namespace CPProject.Forms
{
    partial class RegistrationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrationForm));
            panel1 = new Panel();
            panel5 = new Panel();
            panel4 = new Panel();
            buttonRegistration = new components.CustomButton();
            dateTimePickerAge = new DateTimePicker();
            label2 = new Label();
            inputRepeatePassword = new components.CustomInput();
            inputPassword = new InputLableIndicated();
            inputLogin = new InputLableIndicated();
            label1 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
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
            panel1.Size = new Size(200, 461);
            panel1.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.AutoScroll = true;
            panel5.Controls.Add(panel4);
            panel5.Controls.Add(dateTimePickerAge);
            panel5.Controls.Add(label2);
            panel5.Controls.Add(inputRepeatePassword);
            panel5.Controls.Add(inputPassword);
            panel5.Controls.Add(inputLogin);
            panel5.Dock = DockStyle.Top;
            panel5.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            panel5.Location = new Point(0, 62);
            panel5.Name = "panel5";
            panel5.Padding = new Padding(15, 8, 15, 0);
            panel5.Size = new Size(200, 282);
            panel5.TabIndex = 5;
            // 
            // panel4
            // 
            panel4.AutoSize = true;
            panel4.Controls.Add(buttonRegistration);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(15, 192);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(0, 20, 0, 0);
            panel4.Size = new Size(170, 50);
            panel4.TabIndex = 5;
            // 
            // buttonRegistration
            // 
            buttonRegistration.AutoSize = true;
            buttonRegistration.BackColor = Color.White;
            buttonRegistration.Dock = DockStyle.Top;
            buttonRegistration.Enabled = false;
            buttonRegistration.FlatAppearance.BorderSize = 0;
            buttonRegistration.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonRegistration.ForeColor = Color.Black;
            buttonRegistration.IsActivated = false;
            buttonRegistration.Location = new Point(0, 20);
            buttonRegistration.Name = "buttonRegistration";
            buttonRegistration.Size = new Size(170, 30);
            buttonRegistration.TabIndex = 5;
            buttonRegistration.Text = "Confirm";
            buttonRegistration.UseVisualStyleBackColor = false;
            buttonRegistration.Click += buttonRegistration_Click;
            // 
            // dateTimePickerAge
            // 
            dateTimePickerAge.Cursor = Cursors.Hand;
            dateTimePickerAge.Dock = DockStyle.Top;
            dateTimePickerAge.Format = DateTimePickerFormat.Short;
            dateTimePickerAge.Location = new Point(15, 166);
            dateTimePickerAge.Name = "dateTimePickerAge";
            dateTimePickerAge.Size = new Size(170, 26);
            dateTimePickerAge.TabIndex = 4;
            dateTimePickerAge.ValueChanged += dateTimePickerAge_ValueChanged;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(15, 137);
            label2.Name = "label2";
            label2.Padding = new Padding(0, 9, 0, 3);
            label2.Size = new Size(170, 29);
            label2.TabIndex = 3;
            label2.Text = "Birthday";
            // 
            // inputRepeatePassword
            // 
            inputRepeatePassword.AutoSize = true;
            inputRepeatePassword.BackColor = Color.FromArgb(230, 230, 230);
            inputRepeatePassword.Dock = DockStyle.Top;
            inputRepeatePassword.IsInvalid = false;
            inputRepeatePassword.Location = new Point(15, 111);
            inputRepeatePassword.Margin = new Padding(0);
            inputRepeatePassword.MinimumSize = new Size(90, 25);
            inputRepeatePassword.Name = "inputRepeatePassword";
            inputRepeatePassword.Padding = new Padding(4, 2, 4, 0);
            inputRepeatePassword.Placeholder = "repeat password";
            inputRepeatePassword.Size = new Size(170, 26);
            inputRepeatePassword.TabIndex = 2;
            inputRepeatePassword.CustomInputChanged += inputRepeatePassword_CustomInputChanged;
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
            inputPassword.Padding = new Padding(0, 9, 0, 5);
            inputPassword.Placeholder = "";
            inputPassword.Size = new Size(170, 58);
            inputPassword.TabIndex = 1;
            inputPassword.TextBoxText = "";
            inputPassword.OnChangeTex += input2_OnChangeTex;
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
            inputLogin.Size = new Size(170, 45);
            inputLogin.TabIndex = 0;
            inputLogin.TextBoxText = "";
            inputLogin.OnChangeTex += inputLogin_OnChangeTex;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(200, 62);
            label1.TabIndex = 3;
            label1.Text = "REGISTRATION";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlDarkDark;
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(200, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(584, 1);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ControlDarkDark;
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(200, 1);
            panel3.Name = "panel3";
            panel3.Size = new Size(1, 460);
            panel3.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.ErrorImage = (Image)resources.GetObject("pictureBox1.ErrorImage");
            pictureBox1.Image = Properties.Resources.spase1;
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(201, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(583, 460);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 461);
            Controls.Add(pictureBox1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "RegistrationForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "RegistrationForm";
            panel1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label label1;
        private Panel panel5;
        private InputLableIndicated inputPassword;
        private InputLableIndicated inputLogin;
        private components.CustomInput inputRepeatePassword;
        private DateTimePicker dateTimePickerAge;
        private Label label2;
        private Panel panel4;
        private components.CustomButton buttonRegistration;
        private PictureBox pictureBox1;
    }
}