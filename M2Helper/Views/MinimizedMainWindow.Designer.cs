namespace M2Helper.Views
{
    partial class MinimizedMainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MinimizedMainWindow));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2DragControl2 = new Guna.UI2.WinForms.Guna2DragControl(components);
            m2HelperLogo = new Guna.UI2.WinForms.Guna2ImageButton();
            label1 = new Label();
            label2 = new Label();
            guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            guna2CustomGradientPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // guna2DragControl2
            // 
            guna2DragControl2.DockIndicatorTransparencyValue = 0.6D;
            guna2DragControl2.TargetControl = guna2CustomGradientPanel1;
            guna2DragControl2.UseTransparentDrag = true;
            // 
            // m2HelperLogo
            // 
            m2HelperLogo.BackColor = Color.Transparent;
            m2HelperLogo.CheckedState.ImageSize = new Size(64, 64);
            m2HelperLogo.HoverState.ImageSize = new Size(64, 64);
            m2HelperLogo.Image = (Image)resources.GetObject("m2HelperLogo.Image");
            m2HelperLogo.ImageOffset = new Point(0, 0);
            m2HelperLogo.ImageRotate = 0F;
            m2HelperLogo.Location = new Point(35, 38);
            m2HelperLogo.Name = "m2HelperLogo";
            m2HelperLogo.PressedState.ImageSize = new Size(64, 64);
            m2HelperLogo.ShadowDecoration.CustomizableEdges = customizableEdges1;
            m2HelperLogo.Size = new Size(71, 61);
            m2HelperLogo.TabIndex = 0;
            m2HelperLogo.Click += m2HelperLogo_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = Color.White;
            label1.Location = new Point(38, 13);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 1;
            label1.Text = "Click Image";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = Color.White;
            label2.Location = new Point(26, 103);
            label2.Name = "label2";
            label2.Size = new Size(103, 15);
            label2.TabIndex = 2;
            label2.Text = "to open m2Helper";
            // 
            // guna2CustomGradientPanel1
            // 
            guna2CustomGradientPanel1.Controls.Add(m2HelperLogo);
            guna2CustomGradientPanel1.Controls.Add(label2);
            guna2CustomGradientPanel1.Controls.Add(label1);
            guna2CustomGradientPanel1.CustomizableEdges = customizableEdges2;
            guna2CustomGradientPanel1.Dock = DockStyle.Fill;
            guna2CustomGradientPanel1.FillColor = Color.Orange;
            guna2CustomGradientPanel1.FillColor2 = Color.FromArgb(255, 128, 0);
            guna2CustomGradientPanel1.FillColor3 = Color.DimGray;
            guna2CustomGradientPanel1.FillColor4 = Color.DarkRed;
            guna2CustomGradientPanel1.Location = new Point(1, 1);
            guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            guna2CustomGradientPanel1.ShadowDecoration.CustomizableEdges = customizableEdges3;
            guna2CustomGradientPanel1.Size = new Size(149, 129);
            guna2CustomGradientPanel1.TabIndex = 3;
            // 
            // MinimizedMainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Orange;
            ClientSize = new Size(151, 131);
            Controls.Add(guna2CustomGradientPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MinimizedMainWindow";
            Opacity = 0.7D;
            Padding = new Padding(1);
            ShowInTaskbar = false;
            Text = "MinimizedMainWindow";
            TopMost = true;
            guna2CustomGradientPanel1.ResumeLayout(false);
            guna2CustomGradientPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl2;
        private Guna.UI2.WinForms.Guna2ImageButton m2HelperLogo;
        private Label label1;
        private Label label2;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
    }
}