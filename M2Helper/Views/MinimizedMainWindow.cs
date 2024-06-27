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
        public MinimizedMainWindow()
        {
            InitializeComponent();
        }

        private void m2HelperLogo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
