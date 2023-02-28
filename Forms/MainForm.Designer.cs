namespace CPProject
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            panelNavBar = new Panel();
            panelContainerNavBar = new Panel();
            panel2 = new Panel();
            panel1 = new Panel();
            panelMainFormLayout = new Panel();
            panelNavBar.SuspendLayout();
            SuspendLayout();
            // 
            // panelNavBar
            // 
            panelNavBar.BackColor = SystemColors.ButtonHighlight;
            panelNavBar.Controls.Add(panelContainerNavBar);
            panelNavBar.Controls.Add(panel2);
            panelNavBar.Dock = DockStyle.Left;
            panelNavBar.Location = new Point(0, 0);
            panelNavBar.Name = "panelNavBar";
            panelNavBar.Size = new Size(200, 720);
            panelNavBar.TabIndex = 1;
            // 
            // panelContainerNavBar
            // 
            panelContainerNavBar.Dock = DockStyle.Fill;
            panelContainerNavBar.Location = new Point(0, 0);
            panelContainerNavBar.Name = "panelContainerNavBar";
            panelContainerNavBar.Size = new Size(199, 720);
            panelContainerNavBar.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlDarkDark;
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(199, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1, 720);
            panel2.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDarkDark;
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(200, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1080, 1);
            panel1.TabIndex = 3;
            // 
            // panelMainFormLayout
            // 
            panelMainFormLayout.Dock = DockStyle.Fill;
            panelMainFormLayout.Location = new Point(200, 1);
            panelMainFormLayout.Name = "panelMainFormLayout";
            panelMainFormLayout.Size = new Size(1080, 719);
            panelMainFormLayout.TabIndex = 4;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1280, 720);
            Controls.Add(panelMainFormLayout);
            Controls.Add(panel1);
            Controls.Add(panelNavBar);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CinemaPlanet";
            panelNavBar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelNavBar;
        private Panel panel2;
        private Panel panel1;
        private Panel panelMainFormLayout;
        private Panel panelContainerNavBar;
        private NBAuthorization nbAuthorization1;
    }
}