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
    public partial class CooldownEditWindow : Form
    {
        private string whatToEdit;
        public CooldownEditWindow(string whatToEdit)
        {
            this.whatToEdit = whatToEdit;
            InitializeComponent();
            ShowRelatedPanel(whatToEdit);
        }
        private void ShowRelatedPanel(string whatToEdit)
        {
            if (whatToEdit == "biolog")
            {
                biologEditPanel.BringToFront();
            }
            else if (whatToEdit == "helmet")
            {
                costumeHelmetEditPanel.BringToFront();
            }
            else if (whatToEdit == "weapon")
            {
                costumeWeaponEditPanel.BringToFront();
            }
            else if (whatToEdit == "armor")
            {
                costumeArmorEditPanel.BringToFront();
            }
            else
            {
                MessageBox.Show("Something Went Wrong");
                this.Close();
            }
        }
    }
}
