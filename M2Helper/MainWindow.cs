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

namespace M2Helper
{
    public partial class MainWindow : Form
    {
        private KilledRazadorService killedRazadorService;
        private SaleService saleService;
        private WeeklyEventService weeklyEventService;
        private int currentRazadorSessionTime = 0;
        private int latestRazadorTimeSpent = 0;
        private bool isTimerStarted = false;
        private string lastEvent = string.Empty;
        public static bool isLatestRazadorSessionSubmitted;
        public static bool isLatestDeleteActionDoneSuccesfully;
        public MainWindow()
        {
            killedRazadorService = new KilledRazadorService();
            saleService = new SaleService();
            weeklyEventService = new WeeklyEventService();
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Icon = Properties.Resources.gficon;

            GetEverything();

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

            applicationStartLoadingScreen.Visible = false;
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
                textToReturn = $"{second}'";
            }
            else
            {
                textToReturn = $"{minute}'' {second}'";
            }
            return textToReturn;
        }

        private void stopRazadorSessionButton_Click(object sender, EventArgs e)
        {
            RazadorTimer.Stop();
            isTimerStarted = false;
            razadorCurrentTimeLabel.Text = "Current Session Time : 0";
            latestRazadorTimeSpent = currentRazadorSessionTime;
            currentRazadorSessionTime = 0;
            RazadorTimer.Tick -= RazadorTimer_Tick;
            SubmitSession(latestRazadorTimeSpent);
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
    }
}

