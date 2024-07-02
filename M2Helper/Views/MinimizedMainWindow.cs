using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M2Helper.Views
{
    public partial class MinimizedMainWindow : Form
    {
        private double currentRazadorCooldownTime;
        public MinimizedMainWindow()
        {
            InitializeComponent();
            currentRazadorCooldownTime = MainWindow.currentRazadorCooldownTimeInSeconds;
            ShowCooldownIfExist();
            ShowCurrentEvent();
        }

        private void ShowCooldownIfExist()
        {
            if (MainWindow.isCooldownTimerStarted)
            {
                RazadorCooldownTimer.Interval = 1000;
                RazadorCooldownTimer.Tick += RazadorCooldownTimer_Tick;
                RazadorCooldownTimer.Start();
            }
        }
        private void RazadorCooldownTimer_Tick(object sender, EventArgs e)
        {
            currentRazadorCooldownTime -= 1;
            if (currentRazadorCooldownTime <= 0)
            {
                RazadorCooldownTimer.Stop();
                RazadorCooldownTimer.Tick -= RazadorCooldownTimer_Tick;
                cooldownLabel.Text = "No Razador CD!";
            }
            if (currentRazadorCooldownTime > 0)
            {
                cooldownLabel.Text = $"{(int)currentRazadorCooldownTime / 60}' {(int)currentRazadorCooldownTime % 60}'' To Razador!";
            }
        }
        private void ShowCurrentEvent()
        {
            CurrentEventCheckerTimer.Tick += CurrentEventCheckerTimer_Tick;
            CurrentEventCheckerTimer.Start();
        }

        private void CurrentEventCheckerTimer_Tick(object sender, EventArgs e)
        {
            currentEventLabel.Text = $"Event : {MainWindow.currentEvent}";
        }

        private void m2HelperLogo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
