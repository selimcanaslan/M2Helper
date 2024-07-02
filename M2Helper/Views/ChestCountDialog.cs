using M2Helper;
using M2Helper.Models;
using M2Helper.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metin2Helper.Views
{
    public partial class ChestCountDialog : Form
    {
        KilledRazadorService killedRazadorService;
        private int avgTimeSpent;
        private int timeSpent;
        public ChestCountDialog(int timeSpent, int avgTimeSpent)
        {
            this.timeSpent = timeSpent;
            this.avgTimeSpent = avgTimeSpent;
            killedRazadorService = new KilledRazadorService();
            InitializeComponent();
        }

        private void SubmitSession()
        {
            KilledRazador killedRazador = new KilledRazador();
            killedRazador.When_killed = DateTime.Now;
            killedRazador.Chest_Count = Convert.ToInt16(chestCountComboBox.Text);
            if (forgotStartToSession.Checked)
            {
                killedRazador.Time_spent_by_second = avgTimeSpent;
            }
            else
            {
                killedRazador.Time_spent_by_second = this.timeSpent;
            }
            if (isMoonlightEvent.Checked)
            {
                killedRazador.isMoonlightEventSession = true;
            }
            else
            {
                killedRazador.isMoonlightEventSession = false;
            }

            killedRazadorService.AddKilledRazadorRecord(killedRazador);
            MainWindow.isLatestRazadorSessionSubmitted = true;
        }

        private void cancelSubmitButton_Click(object sender, EventArgs e)
        {
            MainWindow.isLatestRazadorSessionSubmitted = false;
            this.Close();
        }

        private void SubmitSessionButton_Click(object sender, EventArgs e)
        {
            SubmitSession();
            this.Close();
        }
    }
}
