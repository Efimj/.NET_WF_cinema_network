namespace CPProject.Forms
{
    partial class AuthorizationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthorizationForm));
            panel1 = new Panel();
            panel5 = new Panel();
            panel7 = new Panel();
            customButton2 = new components.CustomButton();
            checkBox1 = new CheckBox();
            inputPassword = new InputLableIndicated();
            inputLogin = new InputLableIndicated();
            label1 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            panel7.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.BackColor = Color.White;
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(217, 461);
            panel1.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.AutoScroll = true;
            panel5.Controls.Add(panel7);
            panel5.Controls.Add(checkBox1);
            panel5.Controls.Add(inputPassword);
            panel5.Controls.Add(inputLogin);
            panel5.Dock = DockStyle.Top;
            panel5.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            panel5.Location = new Point(0, 62);
            panel5.Name = "panel5";
            panel5.Padding = new Padding(15, 8, 15, 0);
            panel5.Size = new Size(217, 199);
            panel5.TabIndex = 4;
            // 
            // panel7
            // 
            panel7.AutoSize = true;
            panel7.Controls.Add(customButton2);
            panel7.Dock = DockStyle.Top;
            panel7.Location = new Point(15, 132);
            panel7.Name = "panel7";
            panel7.Padding = new Padding(2, 20, 2, 0);
            panel7.Size = new Size(187, 52);
            panel7.TabIndex = 7;
            // 
            // customButton2
            // 
            customButton2.AutoSize = true;
            customButton2.BackColor = Color.FromArgb(255, 184, 76);
            customButton2.Dock = DockStyle.Top;
            customButton2.FlatAppearance.BorderSize = 0;
            customButton2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            customButton2.ForeColor = Color.White;
            customButton2.IsActivated = true;
            customButton2.Location = new Point(2, 20);
            customButton2.Margin = new Padding(0);
            customButton2.Name = "customButton2";
            customButton2.Size = new Size(183, 32);
            customButton2.TabIndex = 2;
            customButton2.Text = "Login";
            customButton2.UseVisualStyleBackColor = false;
            customButton2.Click += customButton2_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Dock = DockStyle.Top;
            checkBox1.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox1.Location = new Point(15, 104);
            checkBox1.Name = "checkBox1";
            checkBox1.Padding = new Padding(3, 7, 0, 0);
            checkBox1.Size = new Size(187, 28);
            checkBox1.TabIndex = 5;
            checkBox1.Text = "Remember me";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // inputPassword
            // 
            inputPassword.AutoSize = true;
            inputPassword.BackColor = Color.White;
            inputPassword.Dock = DockStyle.Top;
            inputPassword.IsInvalid = false;
            inputPassword.LableText = "Password";
            inputPassword.Location = new Point(15, 53);
            inputPassword.Margin = new Padding(0);
            inputPassword.MinimumSize = new Size(70, 45);
            inputPassword.Name = "inputPassword";
            inputPassword.Padding = new Padding(0, 7, 0, 0);
            inputPassword.Placeholder = "";
            inputPassword.Size = new Size(187, 51);
            inputPassword.TabIndex = 1;
            inputPassword.TextBoxText = "";
            // 
            // inputLogin
            // 
            inputLogin.AutoSize = true;
            inputLogin.BackColor = Color.White;
            inputLogin.Dock = DockStyle.Top;
            inputLogin.IsInvalid = false;
            inputLogin.LableText = "Login";
            inputLogin.Location = new Point(15, 8);
            inputLogin.Margin = new Padding(0);
            inputLogin.MinimumSize = new Size(70, 45);
            inputLogin.Name = "inputLogin";
            inputLogin.Placeholder = "";
            inputLogin.Size = new Size(187, 45);
            inputLogin.TabIndex = 0;
            inputLogin.TextBoxText = "";
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(217, 62);
            label1.TabIndex = 2;
            label1.Text = "LOGIN";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlDarkDark;
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(217, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1, 461);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(pictureBox1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(218, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(566, 461);
            panel3.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ControlDarkDark;
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(566, 1);
            panel4.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.ErrorImage = (Image)resources.GetObject("pictureBox1.ErrorImage");
            pictureBox1.Image = Properties.Resources.spase1;
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(566, 461);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // AuthorizationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 461);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AuthorizationForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "AuthorizationForm";
            panel1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private PictureBox pictureBox1;
        private Panel panel4;
        private Label label1;
        private Panel panel5;
        private InputLableIndicated inputLogin;
        private InputLableIndicated inputPassword;
        private Panel panel7;
        private components.CustomButton customButton2;
        private CheckBox checkBox1;
    }
}