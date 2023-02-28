namespace CPProject.Controls.Pages
{
    partial class UserSettingsPage
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            panel2 = new Panel();
            customButton1 = new components.CustomButton();
            panel3 = new Panel();
            panel5 = new Panel();
            inputNewPasswordRepeat = new components.CustomInput();
            panel6 = new Panel();
            panel7 = new Panel();
            panel8 = new Panel();
            inputNewPassword = new components.CustomInput();
            panel9 = new Panel();
            label3 = new components.Label();
            panel10 = new Panel();
            panel11 = new Panel();
            inputLogin = new components.CustomInput();
            panel12 = new Panel();
            label4 = new components.Label();
            panel21 = new Panel();
            panel22 = new Panel();
            inputOldPassword = new components.CustomInput();
            panel23 = new Panel();
            label5 = new components.Label();
            label1 = new components.Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            panel9.SuspendLayout();
            panel10.SuspendLayout();
            panel11.SuspendLayout();
            panel12.SuspendLayout();
            panel21.SuspendLayout();
            panel22.SuspendLayout();
            panel23.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(15, 15);
            panel1.Name = "panel1";
            panel1.Size = new Size(651, 317);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(customButton1);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(panel7);
            panel2.Controls.Add(panel10);
            panel2.Controls.Add(panel21);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(400, 317);
            panel2.TabIndex = 0;
            // 
            // customButton1
            // 
            customButton1.AutoSize = true;
            customButton1.BackColor = Color.White;
            customButton1.FlatAppearance.BorderSize = 0;
            customButton1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            customButton1.ForeColor = Color.Black;
            customButton1.IsActivated = false;
            customButton1.Location = new Point(141, 219);
            customButton1.Name = "customButton1";
            customButton1.Size = new Size(121, 29);
            customButton1.TabIndex = 22;
            customButton1.Text = "Confirm";
            customButton1.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(panel6);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 159);
            panel3.Name = "panel3";
            panel3.Size = new Size(400, 40);
            panel3.TabIndex = 20;
            // 
            // panel5
            // 
            panel5.Controls.Add(inputNewPasswordRepeat);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(200, 0);
            panel5.Name = "panel5";
            panel5.Padding = new Padding(5, 0, 0, 0);
            panel5.Size = new Size(200, 40);
            panel5.TabIndex = 3;
            // 
            // inputNewPasswordRepeat
            // 
            inputNewPasswordRepeat.AutoSize = true;
            inputNewPasswordRepeat.BackColor = Color.FromArgb(230, 230, 230);
            inputNewPasswordRepeat.Dock = DockStyle.Top;
            inputNewPasswordRepeat.IsInvalid = true;
            inputNewPasswordRepeat.Location = new Point(5, 0);
            inputNewPasswordRepeat.Margin = new Padding(0);
            inputNewPasswordRepeat.MinimumSize = new Size(90, 25);
            inputNewPasswordRepeat.Name = "inputNewPasswordRepeat";
            inputNewPasswordRepeat.Padding = new Padding(0, 4, 0, 0);
            inputNewPasswordRepeat.Placeholder = "repeat password";
            inputNewPasswordRepeat.Size = new Size(195, 28);
            inputNewPasswordRepeat.TabIndex = 9;
            // 
            // panel6
            // 
            panel6.Dock = DockStyle.Left;
            panel6.Location = new Point(0, 0);
            panel6.Name = "panel6";
            panel6.Padding = new Padding(0, 0, 5, 0);
            panel6.Size = new Size(200, 40);
            panel6.TabIndex = 2;
            // 
            // panel7
            // 
            panel7.Controls.Add(panel8);
            panel7.Controls.Add(panel9);
            panel7.Dock = DockStyle.Top;
            panel7.Location = new Point(0, 119);
            panel7.Name = "panel7";
            panel7.Size = new Size(400, 40);
            panel7.TabIndex = 21;
            // 
            // panel8
            // 
            panel8.Controls.Add(inputNewPassword);
            panel8.Dock = DockStyle.Fill;
            panel8.Location = new Point(200, 0);
            panel8.Name = "panel8";
            panel8.Padding = new Padding(5, 0, 0, 0);
            panel8.Size = new Size(200, 40);
            panel8.TabIndex = 3;
            // 
            // inputNewPassword
            // 
            inputNewPassword.AutoSize = true;
            inputNewPassword.BackColor = Color.FromArgb(230, 230, 230);
            inputNewPassword.Dock = DockStyle.Top;
            inputNewPassword.IsInvalid = true;
            inputNewPassword.Location = new Point(5, 0);
            inputNewPassword.Margin = new Padding(0);
            inputNewPassword.MinimumSize = new Size(70, 24);
            inputNewPassword.Name = "inputNewPassword";
            inputNewPassword.Padding = new Padding(0, 4, 0, 0);
            inputNewPassword.Placeholder = "";
            inputNewPassword.Size = new Size(195, 28);
            inputNewPassword.TabIndex = 0;
            // 
            // panel9
            // 
            panel9.Controls.Add(label3);
            panel9.Dock = DockStyle.Left;
            panel9.Location = new Point(0, 0);
            panel9.Name = "panel9";
            panel9.Padding = new Padding(0, 0, 5, 0);
            panel9.Size = new Size(200, 40);
            panel9.TabIndex = 2;
            // 
            // label3
            // 
            label3.Dock = DockStyle.Top;
            label3.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(195, 35);
            label3.TabIndex = 0;
            label3.Text = "Password";
            label3.TextAlign = ContentAlignment.TopRight;
            // 
            // panel10
            // 
            panel10.Controls.Add(panel11);
            panel10.Controls.Add(panel12);
            panel10.Dock = DockStyle.Top;
            panel10.Location = new Point(0, 79);
            panel10.Name = "panel10";
            panel10.Size = new Size(400, 40);
            panel10.TabIndex = 19;
            // 
            // panel11
            // 
            panel11.Controls.Add(inputLogin);
            panel11.Dock = DockStyle.Fill;
            panel11.Location = new Point(200, 0);
            panel11.Name = "panel11";
            panel11.Padding = new Padding(5, 0, 0, 0);
            panel11.Size = new Size(200, 40);
            panel11.TabIndex = 3;
            // 
            // inputLogin
            // 
            inputLogin.AutoSize = true;
            inputLogin.BackColor = Color.FromArgb(230, 230, 230);
            inputLogin.Dock = DockStyle.Top;
            inputLogin.IsInvalid = true;
            inputLogin.Location = new Point(5, 0);
            inputLogin.Margin = new Padding(0);
            inputLogin.MinimumSize = new Size(70, 24);
            inputLogin.Name = "inputLogin";
            inputLogin.Padding = new Padding(0, 4, 0, 0);
            inputLogin.Placeholder = "";
            inputLogin.Size = new Size(195, 28);
            inputLogin.TabIndex = 0;
            // 
            // panel12
            // 
            panel12.Controls.Add(label4);
            panel12.Dock = DockStyle.Left;
            panel12.Location = new Point(0, 0);
            panel12.Name = "panel12";
            panel12.Padding = new Padding(0, 0, 5, 0);
            panel12.Size = new Size(200, 40);
            panel12.TabIndex = 2;
            // 
            // label4
            // 
            label4.Dock = DockStyle.Top;
            label4.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(195, 35);
            label4.TabIndex = 0;
            label4.Text = "Login";
            label4.TextAlign = ContentAlignment.TopRight;
            // 
            // panel21
            // 
            panel21.Controls.Add(panel22);
            panel21.Controls.Add(panel23);
            panel21.Dock = DockStyle.Top;
            panel21.Location = new Point(0, 39);
            panel21.Name = "panel21";
            panel21.Size = new Size(400, 40);
            panel21.TabIndex = 18;
            // 
            // panel22
            // 
            panel22.Controls.Add(inputOldPassword);
            panel22.Dock = DockStyle.Fill;
            panel22.Location = new Point(200, 0);
            panel22.Name = "panel22";
            panel22.Padding = new Padding(5, 0, 0, 0);
            panel22.Size = new Size(200, 40);
            panel22.TabIndex = 3;
            // 
            // inputOldPassword
            // 
            inputOldPassword.AutoSize = true;
            inputOldPassword.BackColor = Color.FromArgb(230, 230, 230);
            inputOldPassword.Dock = DockStyle.Top;
            inputOldPassword.IsInvalid = true;
            inputOldPassword.Location = new Point(5, 0);
            inputOldPassword.Margin = new Padding(0);
            inputOldPassword.MinimumSize = new Size(90, 25);
            inputOldPassword.Name = "inputOldPassword";
            inputOldPassword.Padding = new Padding(0, 4, 0, 0);
            inputOldPassword.Placeholder = "";
            inputOldPassword.Size = new Size(195, 28);
            inputOldPassword.TabIndex = 9;
            // 
            // panel23
            // 
            panel23.Controls.Add(label5);
            panel23.Dock = DockStyle.Left;
            panel23.Location = new Point(0, 0);
            panel23.Name = "panel23";
            panel23.Padding = new Padding(0, 0, 5, 0);
            panel23.Size = new Size(200, 40);
            panel23.TabIndex = 2;
            // 
            // label5
            // 
            label5.Dock = DockStyle.Top;
            label5.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(0, 0);
            label5.Name = "label5";
            label5.Size = new Size(195, 35);
            label5.TabIndex = 1;
            label5.Text = "Old password";
            label5.TextAlign = ContentAlignment.TopRight;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(400, 39);
            label1.TabIndex = 2;
            label1.Text = "Edit profile";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // UserSettingsPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(panel1);
            Name = "UserSettingsPage";
            Padding = new Padding(15);
            Size = new Size(681, 385);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel7.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel9.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel11.ResumeLayout(false);
            panel11.PerformLayout();
            panel12.ResumeLayout(false);
            panel21.ResumeLayout(false);
            panel22.ResumeLayout(false);
            panel22.PerformLayout();
            panel23.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel5;
        private components.CustomInput inputNewPasswordRepeat;
        private Panel panel6;
        private Panel panel7;
        private Panel panel8;
        private components.CustomInput inputNewPassword;
        private Panel panel9;
        private components.Label label3;
        private Panel panel10;
        private Panel panel11;
        private components.CustomInput inputLogin;
        private Panel panel12;
        private components.Label label4;
        private Panel panel21;
        private Panel panel22;
        private components.CustomInput inputOldPassword;
        private Panel panel23;
        private components.Label label5;
        private components.Label label1;
        private components.CustomButton customButton1;
    }
}
