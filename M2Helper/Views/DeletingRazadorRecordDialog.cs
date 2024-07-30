using M2Helper;
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
    public partial class DeletingRazadorRecordDialog : Form
    {
        private int _recordId;
        private KilledRazadorService killedRazadorService;
        public DeletingRazadorRecordDialog(int recordId)
        {
            killedRazadorService = new KilledRazadorService();
            this._recordId = recordId;
            InitializeComponent();
            razadorChestCountComboBox.SelectedIndex = 0;
        }

        private void yesButton_Click(object sender, EventArgs e)
        {
            killedRazadorService.DeleteKilledRazadorRecord(this._recordId);
            MainWindow.isLatestDeleteActionDoneSuccesfully = true;
            this.Close();
        }

        private void noButton_Click(object sender, EventArgs e)
        {
            MainWindow.isLatestDeleteActionDoneSuccesfully = false;
            this.Close();
        }

        private void editChestCountButton_Click(object sender, EventArgs e)
        {
            var selectedValue = razadorChestCountComboBox.SelectedItem?.ToString();
            if (selectedValue != null)
            {
                int selectedChestCount = Int32.Parse(selectedValue);
            }
        }
    }
}
