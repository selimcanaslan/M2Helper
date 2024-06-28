using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using M2Helper.Service;
using M2Helper.Models;
using M2Helper.Repository;
using Metin2Helper.Service;
using Metin2Helper.Views;
using static Guna.UI2.WinForms.Suite.Descriptions;
using M2Helper.Views;
using System.Runtime.Intrinsics.X86;
using System.Text.RegularExpressions;
using System.Media;
using M2Helper.Properties;

namespace M2Helper
{
    public partial class MainWindow : Form
    {
        private KilledRazadorService killedRazadorService;
        private SaleService saleService;
        private WeeklyEventService weeklyEventService;
        private RazadorCooldownService razadorCooldownService;
        private int latestRazadorTimeSpent = 0;
        private bool isTimerStarted = false;
        private string lastEvent = string.Empty;
        private SoundPlayer loginSound = new SoundPlayer(Resources.event_notification);
        private SoundPlayer exitSound = new SoundPlayer(Resources.exit_notification);
        private SoundPlayer razadorCoolDownFinishedSound = new SoundPlayer(Resources.razador_notification);

        public static bool isCooldownTimerStarted = false;
        public static double currentRazadorCooldownTimeInSeconds;
        public static int currentRazadorSessionTime = 0;
        public static bool isLatestRazadorSessionSubmitted;
        public static bool isLatestDeleteActionDoneSuccesfully;
        public MainWindow()
        {
            killedRazadorService = new KilledRazadorService();
            saleService = new SaleService();
            weeklyEventService = new WeeklyEventService();
            razadorCooldownService = new RazadorCooldownService();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Icon = Properties.Resources.gficon;

            GetEverything();

        }

        private void PlayLoginSound()
        {
            loginSound.Play();
        }
        private void PlayExitSound()
        {
            exitSound.Play();
        }
        private void PlayRazadorSound()
        {
            razadorCoolDownFinishedSound.Play();
        }

        private void GetEverything()
        {
            FillRazadorDGVAndGetCurrentEvent();
        }

        private async void GetCurrentEvent()
        {
            int hourDifference = 1;
            DataTable events = new DataTable();
            events = await weeklyEventService.ReadEvents();
            int today = (int)DateTime.Now.DayOfWeek;
            int currentHour = (int)DateTime.Now.Hour;
            if (events.Rows.Count > 0)
            {
                foreach (DataRow row in events.Rows)
                {
                    if ((int)row["event_day"] == today)
                    {
                        if (currentHour < (int)row["event_end_time"] && currentHour >= (int)row["event_start_time"])
                        {
                            currentEventLabel.Text = $"Current Event : {row["event_name"]}";
                            lastEvent = row["event_name"].ToString();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Events Couldn't Fetch!");
            }
        }
        private async void FillRazadorDGVAndGetCurrentEvent()
        {
            DataTable razadorRecords = new DataTable();
            applicationStartLoadingScreen.BringToFront();
            applicationStartLoadingScreen.Visible = true;
            razadorRecords = await killedRazadorService.ReadKilledRazadorRecords();
            GetCurrentEvent();
            GetRazadorCooldownIfExist();
            GetTodaysRecords(razadorRecords);
            killedRazadorsDGV.DataSource = razadorRecords;
            killedRazadorsDGV.Columns[0].HeaderText = "Id";
            killedRazadorsDGV.Columns[1].HeaderText = "Time Spent";
            killedRazadorsDGV.Columns[2].HeaderText = "When Killed";
            killedRazadorsDGV.Columns[3].HeaderText = "Chest Count";
            killedRazadorsDGV.AutoResizeColumnHeadersHeight();
            killedRazadorsDGV.AutoGenerateColumns = false;

            DataGridViewCellStyle cellStyle = new DataGridViewCellStyle();
            cellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


            foreach (DataGridViewColumn column in killedRazadorsDGV.Columns)
            {
                column.DefaultCellStyle = cellStyle;
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            foreach (DataGridViewColumn column in killedRazadorsDGV.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            killedRazadorsDGV.Columns[killedRazadorsDGV.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            killedRazadorsDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            PlayLoginSound();
            applicationStartLoadingScreen.Visible = false;
        }

        private async void GetRazadorCooldownIfExist()
        {
            DataTable cooldown = new DataTable();
            cooldown = await razadorCooldownService.GetNextRazadorDate();
            if (cooldown.Rows.Count > 0)
            {
                DateTime now = DateTime.Now;
                DateTime nextRazadorTime = (DateTime)cooldown.Rows[0]["next_razador_time"];
                TimeSpan difference = nextRazadorTime - now;
                double differenceInSeconds = difference.TotalSeconds;
                if (differenceInSeconds > 0)
                {
                    currentRazadorCooldownTimeInSeconds = differenceInSeconds;
                    Console.WriteLine($"{(int)differenceInSeconds / 60}' {(int)differenceInSeconds % 60}''");
                    if (isCooldownTimerStarted)
                    {
                        RazadorCooldownTimer.Stop();
                        isCooldownTimerStarted = false;
                        RazadorCooldownTimer.Tick -= RazadorCooldownTimer_Tick;

                        isCooldownTimerStarted = true;
                        RazadorCooldownTimer.Interval = 1000;
                        RazadorCooldownTimer.Tick += RazadorCooldownTimer_Tick;
                        RazadorCooldownTimer.Start();
                    }
                    else
                    {
                        isCooldownTimerStarted = true;
                        RazadorCooldownTimer.Interval = 1000;
                        RazadorCooldownTimer.Tick += RazadorCooldownTimer_Tick;
                        RazadorCooldownTimer.Start();
                    }
                }
                else
                {
                    razadorCooldownLabel.Text = "You are good to go for new session !";
                    razadorCooldownLabel.ForeColor = Color.Green;
                }
            }
            else
            {
                Console.WriteLine("There is no cooldown record yet!");
            }
        }
        private void RazadorCooldownTimer_Tick(object sender, EventArgs e)
        {
            Console.WriteLine(currentRazadorCooldownTimeInSeconds);
            currentRazadorCooldownTimeInSeconds -= 1;
            if (currentRazadorCooldownTimeInSeconds <= 0)
            {
                RazadorCooldownTimer.Stop();
                isCooldownTimerStarted = false;
                RazadorCooldownTimer.Tick -= RazadorCooldownTimer_Tick;
                razadorCooldownLabel.Text = "You are good to go for new session !";
                razadorCooldownLabel.ForeColor = Color.Green;
                PlayRazadorSound();
            }
            if (currentRazadorCooldownTimeInSeconds > 0)
            {
                if (currentRazadorCooldownTimeInSeconds > 1200)
                {
                    razadorCooldownLabel.Text = $"{(int)currentRazadorCooldownTimeInSeconds / 60}' {(int)currentRazadorCooldownTimeInSeconds % 60}'' cooldown left!";
                    razadorCooldownLabel.ForeColor = Color.Green;
                }
                else if (currentRazadorCooldownTimeInSeconds > 600 && currentRazadorCooldownTimeInSeconds < 1200)
                {
                    razadorCooldownLabel.Text = $"{(int)currentRazadorCooldownTimeInSeconds / 60}' {(int)currentRazadorCooldownTimeInSeconds % 60}'' cooldown left!";
                    razadorCooldownLabel.ForeColor = Color.Orange;
                }
                else
                {
                    razadorCooldownLabel.Text = $"{(int)currentRazadorCooldownTimeInSeconds / 60}' {(int)currentRazadorCooldownTimeInSeconds % 60}'' cooldown left!";
                    razadorCooldownLabel.ForeColor = Color.Red;
                }
            }
        }

        private void GetTodaysRecords(DataTable razadorRecords)
        {

            //Today's Records
            int totalChestCount = 0;
            DataTable todaysRecords = new DataTable();

            todaysRecords.Columns.Add("Id", typeof(int));
            todaysRecords.Columns.Add("TimeSpentBySecond", typeof(int));
            todaysRecords.Columns.Add("WhenKilled", typeof(DateTime));
            todaysRecords.Columns.Add("ChestCount", typeof(int));
            DateTime today = DateTime.Now;
            foreach (DataRow record in razadorRecords.Rows)
            {
                if (today.Day == ((DateTime)record["WhenKilled"]).Day &&
                    today.Month == ((DateTime)record["WhenKilled"]).Month &&
                    today.Year == ((DateTime)record["WhenKilled"]).Year)
                {
                    todaysRecords.Rows.Add(record["Id"], record["TimeSpentBySecond"], record["WhenKilled"], record["ChestCount"]);
                }
            }
            if (todaysRecords.Rows.Count > 0)
            {
                foreach (DataRow recordsOfToday in todaysRecords.Rows)
                {
                    totalChestCount += (int)recordsOfToday["ChestCount"];
                }
                double avg = (double)totalChestCount / todaysRecords.Rows.Count;
                string formattedAvg = avg.ToString("F2");
                todaysRecordsLabel.Text = $"Today's Records : {todaysRecords.Rows.Count} Entrance," +
                $" {totalChestCount} Chests, {formattedAvg} AVG";
            }
            else if (todaysRecords.Rows.Count == 0)
            {
                todaysRecordsLabel.Text = "Today's Records : 0 Entrance, 0 Chests, 0 AVG";
            }

            //All Time Records
            int totalChestCountOfAllTime = 0;
            if (razadorRecords.Rows.Count > 0)
            {
                foreach (DataRow dataRow in razadorRecords.Rows)
                {
                    totalChestCountOfAllTime += (int)dataRow["ChestCount"];
                }
                Console.WriteLine(totalChestCount.ToString());
                double avgOfAll = (double)totalChestCountOfAllTime / razadorRecords.Rows.Count;
                string formattedAvgOfAllTime = avgOfAll.ToString("F2");
                allTimeRecordsLabel.Text = $"All Time Records : {razadorRecords.Rows.Count} Entrance, {totalChestCountOfAllTime} Chests, {formattedAvgOfAllTime} AVG";
            }
        }

        private async void RefreshRazadorDGV()
        {
            DataTable dataTable = new DataTable();
            razadorDgvLoadingLabel.Visible = true;
            dataTable = await killedRazadorService.ReadKilledRazadorRecords();
            killedRazadorsDGV.DataSource = dataTable;
            GetTodaysRecords(dataTable);
            razadorDgvLoadingLabel.Visible = false;
        }

        private void startRazadorSessionButton_Click(object sender, EventArgs e)
        {
            if (isTimerStarted)
            {
                MessageBox.Show("You have already started a session!", "Error", MessageBoxButtons.OK);
            }
            else
            {
                isTimerStarted = true;
                RazadorTimer.Interval = 1000;
                RazadorTimer.Tick += RazadorTimer_Tick;
                RazadorTimer.Start();
            }
        }

        private void RazadorTimer_Tick(object sender, EventArgs e)
        {
            currentRazadorSessionTime += 1;
            razadorCurrentTimeLabel.Text = $"Current Session Time : {ConvertTime(currentRazadorSessionTime)}";
        }

        private string ConvertTime(int time)
        {
            string textToReturn;
            int minute = time / 60;
            int second = time % 60;
            if (minute < 1)
            {
                textToReturn = $"{second}''";
            }
            else
            {
                textToReturn = $"{minute}' {second}''";
            }
            return textToReturn;
        }

        private void stopRazadorSessionButton_Click(object sender, EventArgs e)
        {
            RazadorTimer.Stop();
            isTimerStarted = false;
            RazadorTimer.Tick -= RazadorTimer_Tick;
            razadorCurrentTimeLabel.Text = "Current Session Time : 0";
            latestRazadorTimeSpent = currentRazadorSessionTime;
            currentRazadorSessionTime = 0;
            SubmitSession(latestRazadorTimeSpent);
            razadorCooldownService.UpdateNextRazadorTimeAsync(1);
            GetRazadorCooldownIfExist();
        }

        private void SubmitSession(int latestTimeSpentOnRazador)
        {
            ChestCountDialog chestCountDialog = new ChestCountDialog(latestTimeSpentOnRazador);
            chestCountDialog.ShowDialog();
            if (isLatestRazadorSessionSubmitted)
            {
                RefreshRazadorDGV();
                razadorLatestTimeLabel.Text = $"Latest Session Time : {ConvertTime(latestTimeSpentOnRazador)} (Submitted)";
            }
            else
            {
                razadorLatestTimeLabel.Text = $"Latest Session Time : {ConvertTime(latestTimeSpentOnRazador)} (Not Submitted)";

            }

        }

        private void killedRazadorsDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int specificColumnIndex = killedRazadorsDGV.Columns["Id"].Index;
                int selectedId = Convert.ToInt16(killedRazadorsDGV.Rows[e.RowIndex].Cells[specificColumnIndex].Value);
                DeletingRazadorRecordDialog deleteDialog = new DeletingRazadorRecordDialog(selectedId);
                deleteDialog.ShowDialog();

            }
            if (isLatestDeleteActionDoneSuccesfully)
            {
                RefreshRazadorDGV();
            }
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            MinimizedMainWindow minimizedMainWindow = new MinimizedMainWindow();
            this.Hide();
            minimizedMainWindow.Closed += (s, args) => this.Show();
            minimizedMainWindow.Show();
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            PlayExitSound();
            System.Threading.Thread.Sleep(1000);
        }
    }
}

