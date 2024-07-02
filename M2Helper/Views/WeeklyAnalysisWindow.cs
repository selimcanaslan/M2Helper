using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M2Helper.Views
{
    public partial class WeeklyAnalysisWindow : Form
    {
        private DataTable razadorRecords;
        public WeeklyAnalysisWindow(DataTable razadorRecords)
        {
            this.razadorRecords = razadorRecords;
            InitializeComponent();
            CalculateAnalysis();
        }

        private void CalculateAnalysis()
        {
            DateTime today = DateTime.Today;
            DateTime yesterday = new DateTime();
            DateTime twoDaysAgo = new DateTime();
            DateTime threeDaysAgo = new DateTime();
            DateTime fourDaysAgo = new DateTime();
            DateTime fiveDaysAgo = new DateTime();
            DateTime sixDaysAgo = new DateTime();
            DateTime sevenDaysAgo = new DateTime();
            for (int i = 1; i < 8; i++)
            {
                if (i == 1)
                {
                    yesterday = today.AddDays(-i);
                    day1DateLabel.Text = yesterday.ToString("dd MMM");
                }
                if (i == 2)
                {
                    twoDaysAgo = today.AddDays(-i);
                    day2DateLabel.Text = twoDaysAgo.ToString("dd MMM");
                }
                if (i == 3)
                {
                    threeDaysAgo = today.AddDays(-i);
                    day3DateLabel.Text = threeDaysAgo.ToString("dd MMM");
                }
                if (i == 4)
                {
                    fourDaysAgo = today.AddDays(-i);
                    day4DateLabel.Text = fourDaysAgo.ToString("dd MMM");
                }
                if (i == 5)
                {
                    fiveDaysAgo = today.AddDays(-i);
                    day5DateLabel.Text = fiveDaysAgo.ToString("dd MMM");
                }
                if (i == 6)
                {
                    sixDaysAgo = today.AddDays(-i);
                    day6DateLabel.Text = sixDaysAgo.ToString("dd MMM");
                }
                if (i == 7)
                {
                    sevenDaysAgo = today.AddDays(-i);
                    day7DateLabel.Text = sevenDaysAgo.ToString("dd MMM");
                }
            }
            Phase2(yesterday, twoDaysAgo, threeDaysAgo, fourDaysAgo, fiveDaysAgo, sixDaysAgo, sevenDaysAgo);
        }
        private void Phase2(DateTime day1, DateTime day2, DateTime day3, DateTime day4, DateTime day5, DateTime day6, DateTime day7)
        {
            int[] days = new int[7];
            int[] chestCounts = new int[7];
            for (int i = 0; i < days.Length; i++)
            {
                days[i] = 0;
                chestCounts[i] = 0;
            }
            foreach (DataRow records in razadorRecords.Rows)
            {
                if (day1.Day == ((DateTime)records["WhenKilled"]).Day &&
                    day1.Month == ((DateTime)records["WhenKilled"]).Month &&
                    day1.Year == ((DateTime)records["WhenKilled"]).Year)
                {
                    days[0]++;
                    chestCounts[0] += (int)records["ChestCount"];
                }
                if (day2.Day == ((DateTime)records["WhenKilled"]).Day &&
                    day2.Month == ((DateTime)records["WhenKilled"]).Month &&
                    day2.Year == ((DateTime)records["WhenKilled"]).Year)
                {
                    days[1]++;
                    chestCounts[1] += (int)records["ChestCount"];
                }
                if (day3.Day == ((DateTime)records["WhenKilled"]).Day &&
                    day3.Month == ((DateTime)records["WhenKilled"]).Month &&
                    day3.Year == ((DateTime)records["WhenKilled"]).Year)
                {
                    days[2]++;
                    chestCounts[2] += (int)records["ChestCount"];
                }
                if (day4.Day == ((DateTime)records["WhenKilled"]).Day &&
                    day4.Month == ((DateTime)records["WhenKilled"]).Month &&
                    day4.Year == ((DateTime)records["WhenKilled"]).Year)
                {
                    days[3]++;
                    chestCounts[3] += (int)records["ChestCount"];
                }
                if (day5.Day == ((DateTime)records["WhenKilled"]).Day &&
                    day5.Month == ((DateTime)records["WhenKilled"]).Month &&
                    day5.Year == ((DateTime)records["WhenKilled"]).Year)
                {
                    days[4]++;
                    chestCounts[4] += (int)records["ChestCount"];
                }
                if (day6.Day == ((DateTime)records["WhenKilled"]).Day &&
                    day6.Month == ((DateTime)records["WhenKilled"]).Month &&
                    day6.Year == ((DateTime)records["WhenKilled"]).Year)
                {
                    days[5]++;
                    chestCounts[5] += (int)records["ChestCount"];
                }
                if (day7.Day == ((DateTime)records["WhenKilled"]).Day &&
                    day7.Month == ((DateTime)records["WhenKilled"]).Month &&
                    day7.Year == ((DateTime)records["WhenKilled"]).Year)
                {
                    days[6]++;
                    chestCounts[6] += (int)records["ChestCount"];
                }

            }
            day1SessionCountLabel.Text = days[0].ToString() + " Session";
            day2SessionCountLabel.Text = days[1].ToString() + " Session";
            day3SessionCountLabel.Text = days[2].ToString() + " Session";
            day4SessionCountLabel.Text = days[3].ToString() + " Session";
            day5SessionCountLabel.Text = days[4].ToString() + " Session";
            day6SessionCountLabel.Text = days[5].ToString() + " Session";
            day7SessionCountLabel.Text = days[6].ToString() + " Session";
            Phase3(days, chestCounts);
        }
        private void Phase3(int[] days, int[] chestCounts)
        {
            int totalChestCount = 0;
            int totalSessionCount = 0;
            for (int i = 0; i < days.Length; i++)
            {
                totalChestCount += chestCounts[i];
                totalSessionCount += days[i];
            }
            totalSessionCountLabel.Text = totalSessionCount.ToString() + " Session";
            totalChestCountAndAvgLabel.Text = totalChestCount.ToString() + " TOTAL / " + ((double)(totalChestCount / (double)totalSessionCount)).ToString("F2") + " AVG";

            if (chestCounts[0] > 0)
            {
                day1TotalAvgChestLabel.Text = chestCounts[0].ToString() + " TOTAL / " + ((double)chestCounts[0] / (double)days[0]).ToString("F2") + " AVG";
            }
            else
            {
                day7TotalAvgChestLabel.Text = "No Records";
            }
            if (chestCounts[1] > 0)
            {
                day2TotalAvgChestLabel.Text = chestCounts[1].ToString() + " TOTAL / " + ((double)chestCounts[1] / (double)days[1]).ToString("F2") + " AVG";
            }
            else
            {
                day7TotalAvgChestLabel.Text = "No Records";
            }
            if (chestCounts[2] > 0)
            {
                day3TotalAvgChestLabel.Text = chestCounts[2].ToString() + " TOTAL / " + ((double)chestCounts[2] / (double)days[2]).ToString("F2") + " AVG";
            }
            else
            {
                day7TotalAvgChestLabel.Text = "No Records";
            }
            if (chestCounts[3] > 0)
            {
                day4TotalAvgChestLabel.Text = chestCounts[3].ToString() + " TOTAL / " + ((double)chestCounts[3] / (double)days[3]).ToString("F2") + " AVG";
            }
            else
            {
                day7TotalAvgChestLabel.Text = "No Records";
            }
            if (chestCounts[4] > 0)
            {
                day5TotalAvgChestLabel.Text = chestCounts[4].ToString() + " TOTAL / " + ((double)chestCounts[4] / (double)days[4]).ToString("F2") + " AVG";
            }
            else
            {
                day7TotalAvgChestLabel.Text = "No Records";
            }
            if (chestCounts[5] > 0)
            {
                day6TotalAvgChestLabel.Text = chestCounts[5].ToString() + " TOTAL / " + ((double)chestCounts[5] / (double)days[5]).ToString("F2") + " AVG";
            }
            else
            {
                day7TotalAvgChestLabel.Text = "No Records";
            }
            if (chestCounts[6] > 0)
            {
                day7TotalAvgChestLabel.Text = chestCounts[6].ToString() + " TOTAL / " + ((double)chestCounts[6] / (double)days[6]).ToString("F2") + " AVG";
            }
            else
            {
                day7TotalAvgChestLabel.Text = "No Records";
            }

        }
    }
}
