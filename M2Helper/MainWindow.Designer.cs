namespace M2Helper
{
    partial class MainWindow
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            draggableTopPanel = new Panel();
            minimizeButton = new Guna.UI2.WinForms.Guna2Button();
            guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            windowTitle = new Label();
            guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            topPanelDragControl = new Guna.UI2.WinForms.Guna2DragControl(components);
            windowTitleDragControl = new Guna.UI2.WinForms.Guna2DragControl(components);
            containerPanel = new Panel();
            razadorDgvLoadingLabel = new Label();
            eventPanel = new Panel();
            currentEventLabel = new Label();
            killedRazadorsDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            panel1 = new Panel();
            allTimeRecordsLabel = new Label();
            todaysRecordsLabel = new Label();
            razadorLatestTimeLabel = new Label();
            razadorCurrentTimeLabel = new Label();
            label1 = new Label();
            guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            stopRazadorSessionButton = new Guna.UI2.WinForms.Guna2Button();
            startRazadorSessionButton = new Guna.UI2.WinForms.Guna2Button();
            applicationStartLoadingScreen = new Panel();
            label2 = new Label();
            loadingLabel = new Label();
            RazadorTimer = new System.Windows.Forms.Timer(components);
            draggableTopPanel.SuspendLayout();
            containerPanel.SuspendLayout();
            eventPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)killedRazadorsDGV).BeginInit();
            panel1.SuspendLayout();
            applicationStartLoadingScreen.SuspendLayout();
            SuspendLayout();
            // 
            // draggableTopPanel
            // 
            draggableTopPanel.BackColor = Color.FromArgb(46, 46, 46);
            draggableTopPanel.Controls.Add(minimizeButton);
            draggableTopPanel.Controls.Add(guna2ControlBox2);
            draggableTopPanel.Controls.Add(windowTitle);
            draggableTopPanel.Controls.Add(guna2ControlBox1);
            draggableTopPanel.Dock = DockStyle.Top;
            draggableTopPanel.Location = new Point(1, 1);
            draggableTopPanel.Margin = new Padding(4, 3, 4, 3);
            draggableTopPanel.Name = "draggableTopPanel";
            draggableTopPanel.Size = new Size(931, 40);
            draggableTopPanel.TabIndex = 1;
            // 
            // minimizeButton
            // 
            minimizeButton.CustomizableEdges = customizableEdges1;
            minimizeButton.DisabledState.BorderColor = Color.DarkGray;
            minimizeButton.DisabledState.CustomBorderColor = Color.DarkGray;
            minimizeButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            minimizeButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            minimizeButton.FillColor = Color.FromArgb(77, 77, 77);
            minimizeButton.Font = new Font("Segoe UI", 9F);
            minimizeButton.ForeColor = Color.White;
            minimizeButton.Location = new Point(720, 5);
            minimizeButton.Name = "minimizeButton";
            minimizeButton.ShadowDecoration.CustomizableEdges = customizableEdges2;
            minimizeButton.Size = new Size(82, 29);
            minimizeButton.TabIndex = 2;
            minimizeButton.Text = "minimize";
            minimizeButton.Click += minimizeButton_Click;
            // 
            // guna2ControlBox2
            // 
            guna2ControlBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            guna2ControlBox2.CustomizableEdges = customizableEdges3;
            guna2ControlBox2.FillColor = Color.FromArgb(139, 152, 166);
            guna2ControlBox2.IconColor = Color.White;
            guna2ControlBox2.Location = new Point(820, 3);
            guna2ControlBox2.Name = "guna2ControlBox2";
            guna2ControlBox2.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2ControlBox2.Size = new Size(52, 33);
            guna2ControlBox2.TabIndex = 3;
            // 
            // windowTitle
            // 
            windowTitle.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            windowTitle.ForeColor = Color.White;
            windowTitle.Location = new Point(2, 7);
            windowTitle.Margin = new Padding(4, 0, 4, 0);
            windowTitle.Name = "windowTitle";
            windowTitle.Size = new Size(733, 27);
            windowTitle.TabIndex = 2;
            windowTitle.Text = "Metin2Helper - Beta";
            // 
            // guna2ControlBox1
            // 
            guna2ControlBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            guna2ControlBox1.CustomizableEdges = customizableEdges5;
            guna2ControlBox1.FillColor = Color.FromArgb(139, 152, 166);
            guna2ControlBox1.IconColor = Color.White;
            guna2ControlBox1.Location = new Point(875, 3);
            guna2ControlBox1.Margin = new Padding(4, 3, 4, 3);
            guna2ControlBox1.Name = "guna2ControlBox1";
            guna2ControlBox1.ShadowDecoration.CustomizableEdges = customizableEdges6;
            guna2ControlBox1.Size = new Size(52, 33);
            guna2ControlBox1.TabIndex = 2;
            // 
            // topPanelDragControl
            // 
            topPanelDragControl.DockIndicatorTransparencyValue = 0.6D;
            topPanelDragControl.TargetControl = draggableTopPanel;
            topPanelDragControl.UseTransparentDrag = true;
            // 
            // windowTitleDragControl
            // 
            windowTitleDragControl.DockIndicatorTransparencyValue = 0.6D;
            windowTitleDragControl.TargetControl = windowTitle;
            windowTitleDragControl.UseTransparentDrag = true;
            // 
            // containerPanel
            // 
            containerPanel.BackColor = Color.FromArgb(77, 77, 77);
            containerPanel.Controls.Add(razadorDgvLoadingLabel);
            containerPanel.Controls.Add(eventPanel);
            containerPanel.Controls.Add(killedRazadorsDGV);
            containerPanel.Controls.Add(panel1);
            containerPanel.Controls.Add(applicationStartLoadingScreen);
            containerPanel.Dock = DockStyle.Fill;
            containerPanel.Location = new Point(1, 41);
            containerPanel.Margin = new Padding(4, 3, 4, 3);
            containerPanel.Name = "containerPanel";
            containerPanel.Size = new Size(931, 420);
            containerPanel.TabIndex = 2;
            // 
            // razadorDgvLoadingLabel
            // 
            razadorDgvLoadingLabel.BackColor = Color.FromArgb(77, 77, 77);
            razadorDgvLoadingLabel.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            razadorDgvLoadingLabel.ForeColor = Color.White;
            razadorDgvLoadingLabel.Location = new Point(122, 266);
            razadorDgvLoadingLabel.Margin = new Padding(4, 0, 4, 0);
            razadorDgvLoadingLabel.Name = "razadorDgvLoadingLabel";
            razadorDgvLoadingLabel.Size = new Size(121, 24);
            razadorDgvLoadingLabel.TabIndex = 1;
            razadorDgvLoadingLabel.Text = "Fetching Data...";
            razadorDgvLoadingLabel.Visible = false;
            // 
            // eventPanel
            // 
            eventPanel.Controls.Add(currentEventLabel);
            eventPanel.Location = new Point(7, 386);
            eventPanel.Name = "eventPanel";
            eventPanel.Size = new Size(374, 29);
            eventPanel.TabIndex = 6;
            // 
            // currentEventLabel
            // 
            currentEventLabel.AutoSize = true;
            currentEventLabel.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            currentEventLabel.ForeColor = Color.White;
            currentEventLabel.Location = new Point(5, 6);
            currentEventLabel.Name = "currentEventLabel";
            currentEventLabel.Size = new Size(99, 17);
            currentEventLabel.TabIndex = 0;
            currentEventLabel.Text = "Current Event :";
            // 
            // killedRazadorsDGV
            // 
            killedRazadorsDGV.AllowUserToAddRows = false;
            killedRazadorsDGV.AllowUserToDeleteRows = false;
            killedRazadorsDGV.AllowUserToResizeColumns = false;
            killedRazadorsDGV.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            killedRazadorsDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            killedRazadorsDGV.BackgroundColor = Color.FromArgb(77, 77, 77);
            killedRazadorsDGV.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            killedRazadorsDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            killedRazadorsDGV.ColumnHeadersHeight = 4;
            killedRazadorsDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            killedRazadorsDGV.DefaultCellStyle = dataGridViewCellStyle3;
            killedRazadorsDGV.GridColor = Color.FromArgb(231, 229, 255);
            killedRazadorsDGV.Location = new Point(7, 170);
            killedRazadorsDGV.Margin = new Padding(4, 3, 4, 3);
            killedRazadorsDGV.MultiSelect = false;
            killedRazadorsDGV.Name = "killedRazadorsDGV";
            killedRazadorsDGV.ReadOnly = true;
            killedRazadorsDGV.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            killedRazadorsDGV.RowHeadersVisible = false;
            killedRazadorsDGV.RowTemplate.Height = 22;
            killedRazadorsDGV.Size = new Size(374, 210);
            killedRazadorsDGV.TabIndex = 5;
            killedRazadorsDGV.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            killedRazadorsDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            killedRazadorsDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            killedRazadorsDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            killedRazadorsDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            killedRazadorsDGV.ThemeStyle.BackColor = Color.FromArgb(77, 77, 77);
            killedRazadorsDGV.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            killedRazadorsDGV.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            killedRazadorsDGV.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            killedRazadorsDGV.ThemeStyle.HeaderStyle.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            killedRazadorsDGV.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            killedRazadorsDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            killedRazadorsDGV.ThemeStyle.HeaderStyle.Height = 4;
            killedRazadorsDGV.ThemeStyle.ReadOnly = true;
            killedRazadorsDGV.ThemeStyle.RowsStyle.BackColor = Color.White;
            killedRazadorsDGV.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            killedRazadorsDGV.ThemeStyle.RowsStyle.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            killedRazadorsDGV.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            killedRazadorsDGV.ThemeStyle.RowsStyle.Height = 22;
            killedRazadorsDGV.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            killedRazadorsDGV.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            killedRazadorsDGV.CellClick += killedRazadorsDGV_CellClick;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(allTimeRecordsLabel);
            panel1.Controls.Add(todaysRecordsLabel);
            panel1.Controls.Add(razadorLatestTimeLabel);
            panel1.Controls.Add(razadorCurrentTimeLabel);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(guna2Button2);
            panel1.Controls.Add(stopRazadorSessionButton);
            panel1.Controls.Add(startRazadorSessionButton);
            panel1.Location = new Point(7, 7);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(374, 157);
            panel1.TabIndex = 4;
            // 
            // allTimeRecordsLabel
            // 
            allTimeRecordsLabel.AutoSize = true;
            allTimeRecordsLabel.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            allTimeRecordsLabel.ForeColor = Color.White;
            allTimeRecordsLabel.Location = new Point(4, 131);
            allTimeRecordsLabel.Margin = new Padding(4, 0, 4, 0);
            allTimeRecordsLabel.Name = "allTimeRecordsLabel";
            allTimeRecordsLabel.Size = new Size(298, 19);
            allTimeRecordsLabel.TabIndex = 7;
            allTimeRecordsLabel.Text = "All Time Records : 0 Entrance, 0 Chests, 0 AVG";
            // 
            // todaysRecordsLabel
            // 
            todaysRecordsLabel.AutoSize = true;
            todaysRecordsLabel.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            todaysRecordsLabel.ForeColor = Color.White;
            todaysRecordsLabel.Location = new Point(4, 108);
            todaysRecordsLabel.Margin = new Padding(4, 0, 4, 0);
            todaysRecordsLabel.Name = "todaysRecordsLabel";
            todaysRecordsLabel.Size = new Size(292, 19);
            todaysRecordsLabel.TabIndex = 6;
            todaysRecordsLabel.Text = "Today's Records : 0 Entrance, 0 Chests, 0 AVG";
            // 
            // razadorLatestTimeLabel
            // 
            razadorLatestTimeLabel.AutoSize = true;
            razadorLatestTimeLabel.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            razadorLatestTimeLabel.ForeColor = Color.White;
            razadorLatestTimeLabel.Location = new Point(4, 86);
            razadorLatestTimeLabel.Margin = new Padding(4, 0, 4, 0);
            razadorLatestTimeLabel.Name = "razadorLatestTimeLabel";
            razadorLatestTimeLabel.Size = new Size(151, 19);
            razadorLatestTimeLabel.TabIndex = 5;
            razadorLatestTimeLabel.Text = "Latest Session Time : 0";
            // 
            // razadorCurrentTimeLabel
            // 
            razadorCurrentTimeLabel.AutoSize = true;
            razadorCurrentTimeLabel.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            razadorCurrentTimeLabel.ForeColor = Color.White;
            razadorCurrentTimeLabel.Location = new Point(4, 66);
            razadorCurrentTimeLabel.Margin = new Padding(4, 0, 4, 0);
            razadorCurrentTimeLabel.Name = "razadorCurrentTimeLabel";
            razadorCurrentTimeLabel.Size = new Size(161, 19);
            razadorCurrentTimeLabel.TabIndex = 4;
            razadorCurrentTimeLabel.Text = "Current Session Time : 0";
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Orange;
            label1.Location = new Point(4, 2);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(201, 24);
            label1.TabIndex = 3;
            label1.Text = "Razador Session Manager";
            // 
            // guna2Button2
            // 
            guna2Button2.CustomizableEdges = customizableEdges7;
            guna2Button2.DisabledState.BorderColor = Color.DarkGray;
            guna2Button2.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button2.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button2.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button2.FillColor = Color.Gray;
            guna2Button2.Font = new Font("Segoe UI", 9F);
            guna2Button2.ForeColor = Color.White;
            guna2Button2.Location = new Point(227, 27);
            guna2Button2.Margin = new Padding(4, 3, 4, 3);
            guna2Button2.Name = "guna2Button2";
            guna2Button2.ShadowDecoration.CustomizableEdges = customizableEdges8;
            guna2Button2.Size = new Size(105, 32);
            guna2Button2.TabIndex = 2;
            guna2Button2.Text = "Terminate";
            // 
            // stopRazadorSessionButton
            // 
            stopRazadorSessionButton.CustomizableEdges = customizableEdges9;
            stopRazadorSessionButton.DisabledState.BorderColor = Color.DarkGray;
            stopRazadorSessionButton.DisabledState.CustomBorderColor = Color.DarkGray;
            stopRazadorSessionButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            stopRazadorSessionButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            stopRazadorSessionButton.FillColor = Color.Red;
            stopRazadorSessionButton.Font = new Font("Segoe UI", 9F);
            stopRazadorSessionButton.ForeColor = Color.White;
            stopRazadorSessionButton.Location = new Point(115, 27);
            stopRazadorSessionButton.Margin = new Padding(4, 3, 4, 3);
            stopRazadorSessionButton.Name = "stopRazadorSessionButton";
            stopRazadorSessionButton.ShadowDecoration.CustomizableEdges = customizableEdges10;
            stopRazadorSessionButton.Size = new Size(105, 32);
            stopRazadorSessionButton.TabIndex = 1;
            stopRazadorSessionButton.Text = "Stop";
            stopRazadorSessionButton.Click += stopRazadorSessionButton_Click;
            // 
            // startRazadorSessionButton
            // 
            startRazadorSessionButton.CustomizableEdges = customizableEdges11;
            startRazadorSessionButton.DisabledState.BorderColor = Color.DarkGray;
            startRazadorSessionButton.DisabledState.CustomBorderColor = Color.DarkGray;
            startRazadorSessionButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            startRazadorSessionButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            startRazadorSessionButton.FillColor = Color.Green;
            startRazadorSessionButton.Font = new Font("Segoe UI", 9F);
            startRazadorSessionButton.ForeColor = Color.White;
            startRazadorSessionButton.Location = new Point(4, 27);
            startRazadorSessionButton.Margin = new Padding(4, 3, 4, 3);
            startRazadorSessionButton.Name = "startRazadorSessionButton";
            startRazadorSessionButton.ShadowDecoration.CustomizableEdges = customizableEdges12;
            startRazadorSessionButton.Size = new Size(105, 32);
            startRazadorSessionButton.TabIndex = 0;
            startRazadorSessionButton.Text = "Start";
            startRazadorSessionButton.Click += startRazadorSessionButton_Click;
            // 
            // applicationStartLoadingScreen
            // 
            applicationStartLoadingScreen.BackColor = Color.Orange;
            applicationStartLoadingScreen.Controls.Add(label2);
            applicationStartLoadingScreen.Controls.Add(loadingLabel);
            applicationStartLoadingScreen.Dock = DockStyle.Fill;
            applicationStartLoadingScreen.Location = new Point(0, 0);
            applicationStartLoadingScreen.Name = "applicationStartLoadingScreen";
            applicationStartLoadingScreen.Size = new Size(931, 420);
            applicationStartLoadingScreen.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("SimSun", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(323, 145);
            label2.Name = "label2";
            label2.Size = new Size(283, 64);
            label2.TabIndex = 1;
            label2.Text = "M2Helper";
            // 
            // loadingLabel
            // 
            loadingLabel.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            loadingLabel.Location = new Point(445, 209);
            loadingLabel.Name = "loadingLabel";
            loadingLabel.Size = new Size(145, 49);
            loadingLabel.TabIndex = 0;
            loadingLabel.Text = "Loading...";
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Orange;
            ClientSize = new Size(933, 462);
            Controls.Add(containerPanel);
            Controls.Add(draggableTopPanel);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "MainWindow";
            Padding = new Padding(1);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Metin2Helper";
            Load += Form1_Load;
            draggableTopPanel.ResumeLayout(false);
            containerPanel.ResumeLayout(false);
            eventPanel.ResumeLayout(false);
            eventPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)killedRazadorsDGV).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            applicationStartLoadingScreen.ResumeLayout(false);
            applicationStartLoadingScreen.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Panel draggableTopPanel;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2DragControl topPanelDragControl;
        private System.Windows.Forms.Label windowTitle;
        private Guna.UI2.WinForms.Guna2DragControl windowTitleDragControl;
        private System.Windows.Forms.Panel containerPanel;
        private System.Windows.Forms.Label razadorDgvLoadingLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button stopRazadorSessionButton;
        private Guna.UI2.WinForms.Guna2Button startRazadorSessionButton;
        private System.Windows.Forms.Timer RazadorTimer;
        private System.Windows.Forms.Label razadorCurrentTimeLabel;
        private System.Windows.Forms.Label razadorLatestTimeLabel;
        private System.Windows.Forms.Label todaysRecordsLabel;
        private Guna.UI2.WinForms.Guna2DataGridView killedRazadorsDGV;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Panel eventPanel;
        private Label currentEventLabel;
        private Panel applicationStartLoadingScreen;
        private Label loadingLabel;
        private Label label2;
        private Guna.UI2.WinForms.Guna2Button minimizeButton;
        private Label allTimeRecordsLabel;
    }
}

