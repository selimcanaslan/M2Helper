namespace M2Helper.Views
{
    partial class LoginWindow
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            containerPanel = new Panel();
            guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            loginButton = new Guna.UI2.WinForms.Guna2Button();
            registerButton = new Guna.UI2.WinForms.Guna2Button();
            passwordTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            mailTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            passwordLabel = new Label();
            mailLabel = new Label();
            label1 = new Label();
            containerPanel.SuspendLayout();
            SuspendLayout();
            // 
            // containerPanel
            // 
            containerPanel.BackColor = Color.FromArgb(46, 46, 46);
            containerPanel.Controls.Add(guna2ControlBox1);
            containerPanel.Controls.Add(loginButton);
            containerPanel.Controls.Add(registerButton);
            containerPanel.Controls.Add(passwordTextBox);
            containerPanel.Controls.Add(mailTextBox);
            containerPanel.Controls.Add(passwordLabel);
            containerPanel.Controls.Add(mailLabel);
            containerPanel.Controls.Add(label1);
            containerPanel.Dock = DockStyle.Fill;
            containerPanel.Location = new Point(1, 1);
            containerPanel.Name = "containerPanel";
            containerPanel.Size = new Size(338, 137);
            containerPanel.TabIndex = 0;
            // 
            // guna2ControlBox1
            // 
            guna2ControlBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            guna2ControlBox1.CustomizableEdges = customizableEdges1;
            guna2ControlBox1.FillColor = Color.FromArgb(139, 152, 166);
            guna2ControlBox1.IconColor = Color.White;
            guna2ControlBox1.Location = new Point(319, 0);
            guna2ControlBox1.Name = "guna2ControlBox1";
            guna2ControlBox1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2ControlBox1.Size = new Size(19, 19);
            guna2ControlBox1.TabIndex = 7;
            // 
            // loginButton
            // 
            loginButton.CustomizableEdges = customizableEdges3;
            loginButton.DisabledState.BorderColor = Color.DarkGray;
            loginButton.DisabledState.CustomBorderColor = Color.DarkGray;
            loginButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            loginButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            loginButton.FillColor = Color.Green;
            loginButton.Font = new Font("Segoe UI", 9F);
            loginButton.ForeColor = Color.White;
            loginButton.Location = new Point(233, 92);
            loginButton.Name = "loginButton";
            loginButton.ShadowDecoration.CustomizableEdges = customizableEdges4;
            loginButton.Size = new Size(89, 30);
            loginButton.TabIndex = 6;
            loginButton.Text = "Login";
            loginButton.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            loginButton.Click += loginButton_Click;
            // 
            // registerButton
            // 
            registerButton.CustomizableEdges = customizableEdges5;
            registerButton.DisabledState.BorderColor = Color.DarkGray;
            registerButton.DisabledState.CustomBorderColor = Color.DarkGray;
            registerButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            registerButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            registerButton.Font = new Font("Segoe UI", 9F);
            registerButton.ForeColor = Color.White;
            registerButton.Location = new Point(233, 51);
            registerButton.Name = "registerButton";
            registerButton.ShadowDecoration.CustomizableEdges = customizableEdges6;
            registerButton.Size = new Size(89, 30);
            registerButton.TabIndex = 5;
            registerButton.Text = "Register";
            registerButton.Click += registerButton_Click;
            // 
            // passwordTextBox
            // 
            passwordTextBox.CustomizableEdges = customizableEdges7;
            passwordTextBox.DefaultText = "";
            passwordTextBox.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            passwordTextBox.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            passwordTextBox.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            passwordTextBox.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            passwordTextBox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            passwordTextBox.Font = new Font("Segoe UI", 9F);
            passwordTextBox.ForeColor = Color.Black;
            passwordTextBox.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            passwordTextBox.Location = new Point(78, 92);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PasswordChar = '●';
            passwordTextBox.PlaceholderText = "";
            passwordTextBox.SelectedText = "";
            passwordTextBox.ShadowDecoration.CustomizableEdges = customizableEdges8;
            passwordTextBox.Size = new Size(149, 30);
            passwordTextBox.TabIndex = 4;
            passwordTextBox.UseSystemPasswordChar = true;
            // 
            // mailTextBox
            // 
            mailTextBox.CustomizableEdges = customizableEdges9;
            mailTextBox.DefaultText = "";
            mailTextBox.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            mailTextBox.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            mailTextBox.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            mailTextBox.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            mailTextBox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            mailTextBox.Font = new Font("Segoe UI", 9F);
            mailTextBox.ForeColor = Color.Black;
            mailTextBox.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            mailTextBox.Location = new Point(78, 51);
            mailTextBox.Name = "mailTextBox";
            mailTextBox.PasswordChar = '\0';
            mailTextBox.PlaceholderText = "";
            mailTextBox.SelectedText = "";
            mailTextBox.ShadowDecoration.CustomizableEdges = customizableEdges10;
            mailTextBox.Size = new Size(149, 30);
            mailTextBox.TabIndex = 3;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            passwordLabel.ForeColor = Color.White;
            passwordLabel.Location = new Point(12, 97);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(58, 25);
            passwordLabel.TabIndex = 2;
            passwordLabel.Text = "Pass :";
            // 
            // mailLabel
            // 
            mailLabel.AutoSize = true;
            mailLabel.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            mailLabel.ForeColor = Color.White;
            mailLabel.Location = new Point(12, 56);
            mailLabel.Name = "mailLabel";
            mailLabel.Size = new Size(60, 25);
            mailLabel.TabIndex = 1;
            mailLabel.Text = "Mail :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(116, 11);
            label1.Name = "label1";
            label1.Size = new Size(101, 25);
            label1.TabIndex = 0;
            label1.Text = "M2Helper";
            // 
            // LoginWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Orange;
            ClientSize = new Size(340, 139);
            Controls.Add(containerPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginWindow";
            Padding = new Padding(1);
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginWindow";
            containerPanel.ResumeLayout(false);
            containerPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel containerPanel;
        private Guna.UI2.WinForms.Guna2TextBox passwordTextBox;
        private Guna.UI2.WinForms.Guna2TextBox mailTextBox;
        private Label passwordLabel;
        private Label mailLabel;
        private Label label1;
        private Guna.UI2.WinForms.Guna2Button loginButton;
        private Guna.UI2.WinForms.Guna2Button registerButton;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
    }
}