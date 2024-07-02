namespace Metin2Helper.Views
{
    partial class ChestCountDialog
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            cancelSubmitButton = new Guna.UI2.WinForms.Guna2Button();
            SubmitSessionButton = new Guna.UI2.WinForms.Guna2Button();
            chestCountComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            questionLabel = new Label();
            chestBoxAnimation = new Guna.UI2.WinForms.Guna2AnimateWindow(components);
            isMoonlightEvent = new CheckBox();
            forgotStartToSession = new CheckBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(46, 46, 46);
            panel1.Controls.Add(forgotStartToSession);
            panel1.Controls.Add(isMoonlightEvent);
            panel1.Controls.Add(cancelSubmitButton);
            panel1.Controls.Add(SubmitSessionButton);
            panel1.Controls.Add(chestCountComboBox);
            panel1.Controls.Add(questionLabel);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(1, 1);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(336, 139);
            panel1.TabIndex = 0;
            // 
            // cancelSubmitButton
            // 
            cancelSubmitButton.CustomizableEdges = customizableEdges7;
            cancelSubmitButton.DisabledState.BorderColor = Color.DarkGray;
            cancelSubmitButton.DisabledState.CustomBorderColor = Color.DarkGray;
            cancelSubmitButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            cancelSubmitButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            cancelSubmitButton.FillColor = Color.Red;
            cancelSubmitButton.Font = new Font("Segoe UI", 9F);
            cancelSubmitButton.ForeColor = Color.White;
            cancelSubmitButton.Location = new Point(177, 96);
            cancelSubmitButton.Margin = new Padding(4, 3, 4, 3);
            cancelSubmitButton.Name = "cancelSubmitButton";
            cancelSubmitButton.ShadowDecoration.CustomizableEdges = customizableEdges8;
            cancelSubmitButton.Size = new Size(132, 39);
            cancelSubmitButton.TabIndex = 3;
            cancelSubmitButton.Text = "Cancel Submit";
            cancelSubmitButton.Click += cancelSubmitButton_Click;
            // 
            // SubmitSessionButton
            // 
            SubmitSessionButton.CustomizableEdges = customizableEdges9;
            SubmitSessionButton.DisabledState.BorderColor = Color.DarkGray;
            SubmitSessionButton.DisabledState.CustomBorderColor = Color.DarkGray;
            SubmitSessionButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            SubmitSessionButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            SubmitSessionButton.FillColor = Color.Green;
            SubmitSessionButton.Font = new Font("Segoe UI", 9F);
            SubmitSessionButton.ForeColor = Color.White;
            SubmitSessionButton.Location = new Point(21, 96);
            SubmitSessionButton.Margin = new Padding(4, 3, 4, 3);
            SubmitSessionButton.Name = "SubmitSessionButton";
            SubmitSessionButton.ShadowDecoration.CustomizableEdges = customizableEdges10;
            SubmitSessionButton.Size = new Size(136, 39);
            SubmitSessionButton.TabIndex = 2;
            SubmitSessionButton.Text = "Submit Session";
            SubmitSessionButton.Click += SubmitSessionButton_Click;
            // 
            // chestCountComboBox
            // 
            chestCountComboBox.BackColor = Color.Transparent;
            chestCountComboBox.CustomizableEdges = customizableEdges11;
            chestCountComboBox.DrawMode = DrawMode.OwnerDrawFixed;
            chestCountComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            chestCountComboBox.FocusedColor = Color.FromArgb(94, 148, 255);
            chestCountComboBox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            chestCountComboBox.Font = new Font("Segoe UI", 10F);
            chestCountComboBox.ForeColor = Color.FromArgb(68, 88, 112);
            chestCountComboBox.ItemHeight = 30;
            chestCountComboBox.Items.AddRange(new object[] { "8", "9", "10" });
            chestCountComboBox.Location = new Point(21, 54);
            chestCountComboBox.Margin = new Padding(4, 3, 4, 3);
            chestCountComboBox.Name = "chestCountComboBox";
            chestCountComboBox.ShadowDecoration.CustomizableEdges = customizableEdges12;
            chestCountComboBox.Size = new Size(136, 36);
            chestCountComboBox.TabIndex = 1;
            // 
            // questionLabel
            // 
            questionLabel.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            questionLabel.ForeColor = Color.White;
            questionLabel.Location = new Point(21, 8);
            questionLabel.Margin = new Padding(4, 0, 4, 0);
            questionLabel.Name = "questionLabel";
            questionLabel.Size = new Size(136, 43);
            questionLabel.TabIndex = 0;
            questionLabel.Text = "How Many Chest Dropped ?";
            questionLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // chestBoxAnimation
            // 
            chestBoxAnimation.AnimationType = Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType.AW_BLEND;
            chestBoxAnimation.TargetForm = this;
            // 
            // isMoonlightEvent
            // 
            isMoonlightEvent.AutoSize = true;
            isMoonlightEvent.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            isMoonlightEvent.ForeColor = Color.White;
            isMoonlightEvent.Location = new Point(177, 18);
            isMoonlightEvent.Name = "isMoonlightEvent";
            isMoonlightEvent.Size = new Size(142, 24);
            isMoonlightEvent.TabIndex = 4;
            isMoonlightEvent.Text = "Moonlight Event";
            isMoonlightEvent.UseVisualStyleBackColor = true;
            // 
            // forgotStartToSession
            // 
            forgotStartToSession.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            forgotStartToSession.ForeColor = Color.White;
            forgotStartToSession.Location = new Point(177, 48);
            forgotStartToSession.Name = "forgotStartToSession";
            forgotStartToSession.Size = new Size(142, 44);
            forgotStartToSession.TabIndex = 5;
            forgotStartToSession.Text = "Forgot Start to Session ?";
            forgotStartToSession.UseVisualStyleBackColor = true;
            // 
            // ChestCountDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Orange;
            ClientSize = new Size(338, 141);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "ChestCountDialog";
            Padding = new Padding(1);
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "ChestCountDialog";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label questionLabel;
        private Guna.UI2.WinForms.Guna2ComboBox chestCountComboBox;
        private Guna.UI2.WinForms.Guna2Button cancelSubmitButton;
        private Guna.UI2.WinForms.Guna2Button SubmitSessionButton;
        private Guna.UI2.WinForms.Guna2AnimateWindow chestBoxAnimation;
        private CheckBox forgotStartToSession;
        private CheckBox isMoonlightEvent;
    }
}