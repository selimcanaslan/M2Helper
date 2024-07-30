namespace M2Helper.Views
{
    partial class CorTrackingWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            containerPanel = new Panel();
            guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            windowAnimation = new Guna.UI2.WinForms.Guna2AnimateWindow(components);
            accountComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            label1 = new Label();
            characterAlchemyInfoDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            containerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)characterAlchemyInfoDGV).BeginInit();
            SuspendLayout();
            // 
            // containerPanel
            // 
            containerPanel.BackColor = Color.FromArgb(46, 46, 46);
            containerPanel.Controls.Add(characterAlchemyInfoDGV);
            containerPanel.Controls.Add(label1);
            containerPanel.Controls.Add(accountComboBox);
            containerPanel.Controls.Add(guna2ControlBox1);
            containerPanel.Dock = DockStyle.Fill;
            containerPanel.Location = new Point(1, 1);
            containerPanel.Name = "containerPanel";
            containerPanel.Size = new Size(577, 302);
            containerPanel.TabIndex = 0;
            // 
            // guna2ControlBox1
            // 
            guna2ControlBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            guna2ControlBox1.CustomizableEdges = customizableEdges3;
            guna2ControlBox1.FillColor = Color.FromArgb(139, 152, 166);
            guna2ControlBox1.IconColor = Color.White;
            guna2ControlBox1.Location = new Point(544, 3);
            guna2ControlBox1.Name = "guna2ControlBox1";
            guna2ControlBox1.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2ControlBox1.Size = new Size(30, 22);
            guna2ControlBox1.TabIndex = 0;
            // 
            // windowAnimation
            // 
            windowAnimation.AnimationType = Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType.AW_BLEND;
            windowAnimation.Interval = 250;
            windowAnimation.TargetForm = this;
            // 
            // accountComboBox
            // 
            accountComboBox.BackColor = Color.Transparent;
            accountComboBox.CustomizableEdges = customizableEdges1;
            accountComboBox.DrawMode = DrawMode.OwnerDrawFixed;
            accountComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            accountComboBox.FocusedColor = Color.FromArgb(94, 148, 255);
            accountComboBox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            accountComboBox.Font = new Font("Segoe UI", 10F);
            accountComboBox.ForeColor = Color.FromArgb(68, 88, 112);
            accountComboBox.ItemHeight = 30;
            accountComboBox.Location = new Point(3, 24);
            accountComboBox.Name = "accountComboBox";
            accountComboBox.ShadowDecoration.CustomizableEdges = customizableEdges2;
            accountComboBox.Size = new Size(149, 36);
            accountComboBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 6);
            label1.Name = "label1";
            label1.Size = new Size(111, 15);
            label1.TabIndex = 2;
            label1.Text = "Chose You Acoount";
            // 
            // characterAlchemyInfoDGV
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            characterAlchemyInfoDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            characterAlchemyInfoDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            characterAlchemyInfoDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            characterAlchemyInfoDGV.DefaultCellStyle = dataGridViewCellStyle3;
            characterAlchemyInfoDGV.GridColor = Color.FromArgb(231, 229, 255);
            characterAlchemyInfoDGV.Location = new Point(3, 66);
            characterAlchemyInfoDGV.Name = "characterAlchemyInfoDGV";
            characterAlchemyInfoDGV.RowHeadersVisible = false;
            characterAlchemyInfoDGV.Size = new Size(571, 233);
            characterAlchemyInfoDGV.TabIndex = 3;
            characterAlchemyInfoDGV.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            characterAlchemyInfoDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            characterAlchemyInfoDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            characterAlchemyInfoDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            characterAlchemyInfoDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            characterAlchemyInfoDGV.ThemeStyle.BackColor = Color.White;
            characterAlchemyInfoDGV.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            characterAlchemyInfoDGV.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            characterAlchemyInfoDGV.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            characterAlchemyInfoDGV.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            characterAlchemyInfoDGV.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            characterAlchemyInfoDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            characterAlchemyInfoDGV.ThemeStyle.HeaderStyle.Height = 4;
            characterAlchemyInfoDGV.ThemeStyle.ReadOnly = false;
            characterAlchemyInfoDGV.ThemeStyle.RowsStyle.BackColor = Color.White;
            characterAlchemyInfoDGV.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            characterAlchemyInfoDGV.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            characterAlchemyInfoDGV.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            characterAlchemyInfoDGV.ThemeStyle.RowsStyle.Height = 25;
            characterAlchemyInfoDGV.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            characterAlchemyInfoDGV.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // CorTrackingWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Orange;
            ClientSize = new Size(579, 304);
            Controls.Add(containerPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CorTrackingWindow";
            Padding = new Padding(1);
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "CorTrackingWindow";
            containerPanel.ResumeLayout(false);
            containerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)characterAlchemyInfoDGV).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel containerPanel;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2AnimateWindow windowAnimation;
        private Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox accountComboBox;
        private Guna.UI2.WinForms.Guna2DataGridView characterAlchemyInfoDGV;
    }
}