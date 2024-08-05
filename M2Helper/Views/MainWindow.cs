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
using System.Diagnostics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace M2Helper
{
    public partial class MainWindow : Form
    {
        private KilledRazadorService killedRazadorService;
        private SaleService saleService;
        private WeeklyEventService weeklyEventService;
        private CooldownsService razadorCooldownService;
        private DataTable weeklyEvents = null;
        private int latestRazadorTimeSpent = 0;
        private bool isTimerStarted = false;
        private DateTime cetNow;
        private SoundPlayer loginSound = new SoundPlayer(Resources.event_notification);
        private SoundPlayer exitSound = new SoundPlayer(Resources.exit_notification);
        private SoundPlayer razadorCoolDownFinishedSound = new SoundPlayer(Resources.razador_notification);
        private int razadorSessionLabelidentifier = 1;
        private bool isMainWindowHiddenByNotifyIcon = false;
        public static int AvgTimeSpentInRazador;
        public static string currentEvent = string.Empty;
        public static int currentEventId = -1;
        public static string currentNextEvent = string.Empty;
        public static bool isCooldownTimerStarted = false;
        public static double currentRazadorCooldownTimeInSeconds;
        public static int currentRazadorSessionTime = 0;
        public static bool isLatestRazadorSessionSubmitted;
        public static bool isLatestDeleteActionDoneSuccesfully;
        public static string currentLanguage = "EN";
        public static Users loggedInUser = new Users();
        public MainWindow(Users user)
        {
            loggedInUser = user;
            killedRazadorService = new KilledRazadorService();
            saleService = new SaleService();
            weeklyEventService = new WeeklyEventService();
            razadorCooldownService = new CooldownsService();
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Icon = Resources.gficon;
            GetEverything();
            endOfDayCheckerTimer.Tick += EndOfDayCheckerTimer_Tick;
            endOfDayCheckerTimer.Start();
            razadorPicture.DoubleClick += RazadorPicture_DoubleClick;
        }

        private void EndOfDayCheckerTimer_Tick(object? sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            if (now.Hour == 23 && now.Minute == 59 && now.Second == 59)
            {
                EventChangeControlTimer.Tick -= EventChangeControlTimer_Tick;
                EventChangeControlTimer.Stop();
                GetEverything();
            }
        }

        private void RazadorPicture_DoubleClick(object? sender, EventArgs e)
        {
            this.Close();
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
            FetchThings();
        }

        private async void FetchThings()
        {
            DataTable razadorRecords = new DataTable();
            applicationStartLoadingScreen.BringToFront();
            applicationStartLoadingScreen.Visible = true;
            razadorRecords = await killedRazadorService.ReadKilledRazadorRecords();
            FetchWeeklyEventsAndStartEventControlTimer();
            GetRazadorCooldownIfExist();
            GetTodaysRecords(razadorRecords);
            CalculateAvgTimeSpent(razadorRecords);
            razadorRecords.Columns.Remove("isMoonlightEventSession");
            killedRazadorsDGV.DataSource = razadorRecords;
            killedRazadorsDGV.Columns[0].HeaderText = "Id";
            killedRazadorsDGV.Columns[1].HeaderText = "Time Spent";
            killedRazadorsDGV.Columns[2].HeaderText = "When Killed";
            killedRazadorsDGV.Columns[3].HeaderText = "Chest Count";
            killedRazadorsDGV.ColumnHeadersHeight = 20;
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

        private void CalculateAvgTimeSpent(DataTable razadorRecords)
        {
            if (razadorRecords.Rows.Count > 0)
            {
                int count = 0;
                int total = 0;
                foreach (DataRow record in razadorRecords.Rows)
                {
                    if (!(bool)record["isMoonlightEventSession"])
                    {
                        total += (int)record["TimeSpentBySecond"];
                        count += 1;
                    }
                }
                Console.WriteLine($"Avg time spent is : {total / count}");
                AvgTimeSpentInRazador = total / count;
            }

        }

        private async void FetchWeeklyEventsAndStartEventControlTimer()
        {
            currentEventLabel.ForeColor = Color.Orange;
            weeklyEvents = await weeklyEventService.ReadEvents();
            EventChangeControlTimer.Tick += EventChangeControlTimer_Tick;
            EventChangeControlTimer.Start();
        }

        private void EventChangeControlTimer_Tick(object? sender, EventArgs e)
        {
            string identifier = string.Empty;
            DateTime utcNow = DateTime.UtcNow;
            TimeZoneInfo cetTimeZone = TimeZoneInfo.FindSystemTimeZoneById("Central European Standard Time");
            cetNow = TimeZoneInfo.ConvertTimeFromUtc(utcNow, cetTimeZone);
            int today = (int)cetNow.DayOfWeek;
            int currentHour = (int)cetNow.Hour;
            if (weeklyEvents.Rows.Count > 0)
            {
                foreach (DataRow row in weeklyEvents.Rows)
                {
                    if (identifier == "done")
                    {
                        currentNextEvent = row["event_name"].ToString();
                        identifier = string.Empty;
                    }
                    if ((int)row["event_day"] == today)
                    {
                        if (currentHour < (int)row["event_end_time"] && currentHour >= (int)row["event_start_time"])
                        {
                            identifier = "done";
                            TimeSpan difference = new TimeSpan();
                            if ((int)row["event_start_time"] == 20)
                            {
                                DateTime eventEndTime = new DateTime(cetNow.Year, cetNow.Month, cetNow.Day, (int)row["event_end_time"] - 1, 59, 59, 0);
                                difference = eventEndTime - cetNow;
                            }
                            else
                            {
                                DateTime eventEndTime = new DateTime(cetNow.Year, cetNow.Month, cetNow.Day, (int)row["event_end_time"], 0, 0, 0);
                                difference = eventEndTime - cetNow;
                            }
                            string timeLeftToNewEvent = string.Format("{0:D2}:{1:D2}:{2:D2}",
                                                                       difference.Hours,
                                                                       difference.Minutes,
                                                                       difference.Seconds);
                            if (currentEvent != row["event_name"].ToString())
                            {
                                currentEvent = row["event_name"].ToString();
                                currentEventId = (int)row["event_id"];
                                currentEventLabel.Text = $"Current Event : {row["event_name"]}";
                                ShowToastEventNotification("Event Notification", $"Current event is : {row["event_name"]}");
                                Console.WriteLine($"Event set to {row["event_name"]}");
                            }
                            else
                            {
                                currentEventLabel.Text = $"Current Event : {row["event_name"]} ({timeLeftToNewEvent.ToString()} Left to {currentNextEvent})";
                                eventNotifyIcon.Text = $"Current Event : {row["event_name"]} ({timeLeftToNewEvent.ToString()} Left to {currentNextEvent})";
                                Console.WriteLine("Same Event Still exist! " + timeLeftToNewEvent.ToString());
                            }
                        }
                        if (identifier == "done")
                        {
                            if (currentEventId == 28)
                            {
                                foreach (DataRow row2 in weeklyEvents.Rows)
                                {
                                    if ((int)row2["event_id"] == 1)
                                    {
                                        currentNextEvent = row2["event_name"].ToString();
                                    }
                                }
                            }
                        }
                    }

                }
            }
            else
            {
                MessageBox.Show("Events Couldn't Fetch!");
            }
        }

        private void ShowToastEventNotification(string title, string message)
        {
            if (eventNotifyIcon.Icon != Resources.gficon)
            {
                eventNotifyIcon.Icon = Resources.gficon;
            }
            eventNotifyIcon.Icon = Resources.gficon;
            eventNotifyIcon.BalloonTipTitle = title;
            eventNotifyIcon.BalloonTipText = message;
            eventNotifyIcon.BalloonTipIcon = ToolTipIcon.Info;
            eventNotifyIcon.ShowBalloonTip(3000);
        }


        private async void GetRazadorCooldownIfExist()
        {
            razadorCooldownLabel.Text = "Fetching...";
            DataTable cooldown = new DataTable();
            cooldown = await razadorCooldownService.GetCooldownAsDataTableAsync(loggedInUser.UserId);
            if (cooldown.Rows.Count > 0)
            {
                DateTime now = DateTime.Now;
                DateTime nextRazadorTime = (DateTime)cooldown.Rows[0]["NextRazadorTime"];
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
                razadorCooldownLabel.Text = "There is no cooldown record yet!";
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
                todaysRecordsLabel.Text = $"Today's Total : {todaysRecords.Rows.Count} Entrance," +
                $" {totalChestCount} Chests, {formattedAvg} AVG";
            }
            else if (todaysRecords.Rows.Count == 0)
            {
                todaysRecordsLabel.Text = "Today's Total : 0 Entrance, 0 Chests, 0 AVG";
            }

            //All Time Records
            int totalChestCountOfAllTime = 0;
            if (razadorRecords.Rows.Count > 0)
            {
                foreach (DataRow dataRow in razadorRecords.Rows)
                {
                    totalChestCountOfAllTime += (int)dataRow["ChestCount"];
                }
                double avgOfAll = (double)totalChestCountOfAllTime / razadorRecords.Rows.Count;
                string formattedAvgOfAllTime = avgOfAll.ToString("F2");
                allTimeRecordsLabel.Text = $"Total : {razadorRecords.Rows.Count} Entrance, {totalChestCountOfAllTime} Chests, {formattedAvgOfAllTime} AVG";
            }
        }

        private async void RefreshRazadorDGV()
        {
            DataTable razadorRecords = new DataTable();
            razadorRecords = await killedRazadorService.ReadKilledRazadorRecords();
            killedRazadorsDGV.DataSource = razadorRecords;
            CalculateAvgTimeSpent(razadorRecords);
            GetTodaysRecords(razadorRecords);
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
            if (razadorSessionLabelidentifier == 1)
            {
                string oneDotText = "A Razador Session In Progress.";
                razadorCooldownLabel.Text = oneDotText;
                razadorSessionLabelidentifier = 2;
            }
            else if (razadorSessionLabelidentifier == 2)
            {
                string twoDotText = "A Razador Session In Progress..";
                razadorCooldownLabel.Text = twoDotText;
                razadorSessionLabelidentifier = 3;
            }
            else
            {
                string threeDotText = "A Razador Session In Progress...";
                razadorCooldownLabel.Text = threeDotText;
                razadorSessionLabelidentifier = 1;
            }
            startRazadorSessionButton.Enabled = false;
            razadorCooldownLabel.ForeColor = Color.Gray;
            currentRazadorSessionTime += 1;
            int minute = currentRazadorSessionTime / 60;
            int second = currentRazadorSessionTime % 60;
            if (minute >= 10)
            {
                razadorCurrentTimeSecondLabel.Location = new Point(92, 129);
            }
            razadorCurrentTimeMinuteLabel.Text = $"{minute}'";
            razadorCurrentTimeSecondLabel.Text = $"{second}''";
        }

        private void stopRazadorSessionButton_Click(object sender, EventArgs e)
        {
            if (isTimerStarted)
            {
                RazadorTimer.Stop();
                isTimerStarted = false;
                RazadorTimer.Tick -= RazadorTimer_Tick;
                razadorCurrentTimeMinuteLabel.Text = "0'";
                razadorCurrentTimeSecondLabel.Text = "0''";
                razadorCurrentTimeSecondLabel.Location = new Point(57, 129);
                latestRazadorTimeSpent = currentRazadorSessionTime;
                currentRazadorSessionTime = 0;
                startRazadorSessionButton.Enabled = true;
                SubmitSession(latestRazadorTimeSpent);
                razadorCooldownService.AddOrUpdateRazadorCooldown(loggedInUser.UserId);
                GetRazadorCooldownIfExist();
            }
            else
            {
                MessageBox.Show("You didn't start a session yet!", "Error");
            }
        }

        private void SubmitSession(int latestTimeSpentOnRazador)
        {
            ChestCountDialog chestCountDialog = new ChestCountDialog(latestTimeSpentOnRazador, AvgTimeSpentInRazador);
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
            Thread.Sleep(1000);
        }

        private void removeRazadorCooldownButton_Click(object sender, EventArgs e)
        {
            razadorCooldownService.RemoveCooldown(loggedInUser.UserId);
            RazadorCooldownTimer.Stop();
            RazadorCooldownTimer.Tick -= RazadorCooldownTimer_Tick;
            RazadorCooldownTimer.Dispose();
            isCooldownTimerStarted = false;
            GetRazadorCooldownIfExist();
        }

        private async void razadorWeeklyAnalysisButton_Click(object sender, EventArgs e)
        {
            WeeklyAnalysisWindow weeklyRazadorAnalysis = new WeeklyAnalysisWindow(await killedRazadorService.ReadKilledRazadorRecords());
            weeklyRazadorAnalysis.ShowDialog();
        }

        private void corTrackingButton_Click(object sender, EventArgs e)
        {
            CorTrackingWindow corTrackingWindow = new CorTrackingWindow();
            corTrackingWindow.ShowDialog();
        }

        private void cooldownsButton_Click(object sender, EventArgs e)
        {
            if (cooldownsPanel.Visible)
            {
                cooldownsPanel.Visible = false;
            }
            else
            {
                cooldownsPanel.Visible = true;
            }
        }

        private void biologEditButton_Click(object sender, EventArgs e)
        {
            CooldownEditWindow cew = new CooldownEditWindow("biolog");
            cew.ShowDialog();
        }

        private void costumeHelmetEditButton_Click(object sender, EventArgs e)
        {
            CooldownEditWindow cew = new CooldownEditWindow("helmet");
            cew.ShowDialog();
        }

        private void costumeArmorEditButton_Click(object sender, EventArgs e)
        {
            CooldownEditWindow cew = new CooldownEditWindow("armor");
            cew.ShowDialog();
        }

        private void costumeWeaponEditButton_Click(object sender, EventArgs e)
        {
            CooldownEditWindow cew = new CooldownEditWindow("weapon");
            cew.ShowDialog();
        }

        private void collapseExpandButton_Click(object sender, EventArgs e)
        {
            if (this.Size.Width == 500 && this.Size.Height == 462)
            {
                collapseExpandButton.Text = "Collapse";
                this.Size = new Size(933, 462);
                controllersPanel.Location = new Point(719, 2);
            }
            else
            {
                collapseExpandButton.Text = "Expand";
                this.Size = new Size(500, 462);
                controllersPanel.Location = new Point(285, 2);
            }
        }

        private void eventNotifyIcon_Click(object sender, EventArgs e)
        {
            if (isMainWindowHiddenByNotifyIcon)
            {
                isMainWindowHiddenByNotifyIcon = false;
                this.Show();
            }
            else
            {
                isMainWindowHiddenByNotifyIcon = true;
                this.Hide();
            }
        }

        private void languageChangeButton_Click(object sender, EventArgs e)
        {
            if (currentLanguage == "EN")
            {
                currentLanguage = "TR";
                languageChangeButton.Text = "EN";
                razadorSessionManagerTextLabel.Text = "Razador Oturum Yöneticisi";
                corTrackingButton.Text = "Cor Takip";
            }
            else
            {
                currentLanguage = "EN";
                languageChangeButton.Text = "TR";
                razadorSessionManagerTextLabel.Text = "Razador Session Manager";
                corTrackingButton.Text = "Cor Tracking";
            }
        }

        private void bossManageComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (bossManageComboBox.Text == "Razador Session Manager")
            {
                razadorSessionManagerPanel.BringToFront();
            }
            else if (bossManageComboBox.Text == "Nemere Session Manager")
            {
                nemereSessionManagerPanel.BringToFront();
            }
        }
    }
}

