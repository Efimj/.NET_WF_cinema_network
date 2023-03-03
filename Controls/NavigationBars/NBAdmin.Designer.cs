﻿namespace CPProject.Controls.NavigationBars
{
    partial class NBAdmin
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
            panel4 = new Panel();
            buttonLogOut = new components.CustomButton();
            panel2 = new Panel();
            panel3 = new Panel();
            panel9 = new Panel();
            buttonAccountSettings = new components.CustomButton();
            panel8 = new Panel();
            buttonReviews = new components.CustomButton();
            panel6 = new Panel();
            buttonSessionArchive = new components.CustomButton();
            panel5 = new Panel();
            buttonFutureSessions = new components.CustomButton();
            panel7 = new Panel();
            buttonActiveTickets = new components.CustomButton();
            panel10 = new Panel();
            buttonFilmPage = new components.CustomButton();
            panel11 = new Panel();
            label2 = new components.Label();
            label1 = new Label();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel9.SuspendLayout();
            panel8.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel7.SuspendLayout();
            panel10.SuspendLayout();
            panel11.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.Controls.Add(panel4);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 678);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 44);
            panel1.TabIndex = 8;
            // 
            // panel4
            // 
            panel4.AutoSize = true;
            panel4.Controls.Add(buttonLogOut);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(5, 0, 5, 10);
            panel4.Size = new Size(250, 44);
            panel4.TabIndex = 7;
            // 
            // buttonLogOut
            // 
            buttonLogOut.AutoSize = true;
            buttonLogOut.BackColor = Color.White;
            buttonLogOut.Dock = DockStyle.Bottom;
            buttonLogOut.FlatAppearance.BorderSize = 0;
            buttonLogOut.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonLogOut.ForeColor = Color.Black;
            buttonLogOut.IsActivated = false;
            buttonLogOut.Location = new Point(5, 0);
            buttonLogOut.Margin = new Padding(0);
            buttonLogOut.Name = "buttonLogOut";
            buttonLogOut.Size = new Size(240, 34);
            buttonLogOut.TabIndex = 5;
            buttonLogOut.Text = "Log out";
            buttonLogOut.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(panel11);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 562);
            panel2.TabIndex = 9;
            // 
            // panel3
            // 
            panel3.Controls.Add(panel9);
            panel3.Controls.Add(panel8);
            panel3.Controls.Add(panel6);
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(panel7);
            panel3.Controls.Add(panel10);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 100);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(5, 20, 5, 0);
            panel3.Size = new Size(250, 331);
            panel3.TabIndex = 9;
            // 
            // panel9
            // 
            panel9.AutoSize = true;
            panel9.Controls.Add(buttonAccountSettings);
            panel9.Dock = DockStyle.Top;
            panel9.Location = new Point(5, 245);
            panel9.Name = "panel9";
            panel9.Padding = new Padding(0, 5, 0, 0);
            panel9.Size = new Size(240, 45);
            panel9.TabIndex = 17;
            // 
            // buttonAccountSettings
            // 
            buttonAccountSettings.AutoSize = true;
            buttonAccountSettings.BackColor = Color.White;
            buttonAccountSettings.Dock = DockStyle.Top;
            buttonAccountSettings.FlatAppearance.BorderSize = 0;
            buttonAccountSettings.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAccountSettings.ForeColor = Color.Black;
            buttonAccountSettings.IsActivated = false;
            buttonAccountSettings.Location = new Point(0, 5);
            buttonAccountSettings.Margin = new Padding(0);
            buttonAccountSettings.Name = "buttonAccountSettings";
            buttonAccountSettings.Padding = new Padding(25, 0, 0, 0);
            buttonAccountSettings.Size = new Size(240, 40);
            buttonAccountSettings.TabIndex = 8;
            buttonAccountSettings.Text = "Settings";
            buttonAccountSettings.TextAlign = ContentAlignment.MiddleLeft;
            buttonAccountSettings.UseVisualStyleBackColor = false;
            // 
            // panel8
            // 
            panel8.AutoSize = true;
            panel8.Controls.Add(buttonReviews);
            panel8.Dock = DockStyle.Top;
            panel8.Location = new Point(5, 200);
            panel8.Name = "panel8";
            panel8.Padding = new Padding(0, 5, 0, 0);
            panel8.Size = new Size(240, 45);
            panel8.TabIndex = 18;
            // 
            // buttonReviews
            // 
            buttonReviews.AutoSize = true;
            buttonReviews.BackColor = Color.White;
            buttonReviews.Dock = DockStyle.Top;
            buttonReviews.FlatAppearance.BorderSize = 0;
            buttonReviews.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonReviews.ForeColor = Color.Black;
            buttonReviews.IsActivated = false;
            buttonReviews.Location = new Point(0, 5);
            buttonReviews.Margin = new Padding(0);
            buttonReviews.Name = "buttonReviews";
            buttonReviews.Padding = new Padding(25, 0, 0, 0);
            buttonReviews.Size = new Size(240, 40);
            buttonReviews.TabIndex = 9;
            buttonReviews.Text = "Reviews";
            buttonReviews.TextAlign = ContentAlignment.MiddleLeft;
            buttonReviews.UseVisualStyleBackColor = false;
            // 
            // panel6
            // 
            panel6.AutoSize = true;
            panel6.Controls.Add(buttonSessionArchive);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(5, 155);
            panel6.Name = "panel6";
            panel6.Padding = new Padding(0, 5, 0, 0);
            panel6.Size = new Size(240, 45);
            panel6.TabIndex = 18;
            // 
            // buttonSessionArchive
            // 
            buttonSessionArchive.AutoSize = true;
            buttonSessionArchive.BackColor = Color.White;
            buttonSessionArchive.Dock = DockStyle.Top;
            buttonSessionArchive.FlatAppearance.BorderSize = 0;
            buttonSessionArchive.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSessionArchive.ForeColor = Color.Black;
            buttonSessionArchive.IsActivated = false;
            buttonSessionArchive.Location = new Point(0, 5);
            buttonSessionArchive.Margin = new Padding(0);
            buttonSessionArchive.Name = "buttonSessionArchive";
            buttonSessionArchive.Padding = new Padding(25, 0, 0, 0);
            buttonSessionArchive.Size = new Size(240, 40);
            buttonSessionArchive.TabIndex = 10;
            buttonSessionArchive.Text = "SessionArchive";
            buttonSessionArchive.TextAlign = ContentAlignment.MiddleLeft;
            buttonSessionArchive.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            panel5.AutoSize = true;
            panel5.Controls.Add(buttonFutureSessions);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(5, 110);
            panel5.Name = "panel5";
            panel5.Padding = new Padding(0, 5, 0, 0);
            panel5.Size = new Size(240, 45);
            panel5.TabIndex = 17;
            // 
            // buttonFutureSessions
            // 
            buttonFutureSessions.AutoSize = true;
            buttonFutureSessions.BackColor = Color.White;
            buttonFutureSessions.Dock = DockStyle.Top;
            buttonFutureSessions.FlatAppearance.BorderSize = 0;
            buttonFutureSessions.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonFutureSessions.ForeColor = Color.Black;
            buttonFutureSessions.IsActivated = false;
            buttonFutureSessions.Location = new Point(0, 5);
            buttonFutureSessions.Margin = new Padding(0);
            buttonFutureSessions.Name = "buttonFutureSessions";
            buttonFutureSessions.Padding = new Padding(25, 0, 0, 0);
            buttonFutureSessions.Size = new Size(240, 40);
            buttonFutureSessions.TabIndex = 11;
            buttonFutureSessions.Text = "Future sessions";
            buttonFutureSessions.TextAlign = ContentAlignment.MiddleLeft;
            buttonFutureSessions.UseVisualStyleBackColor = false;
            // 
            // panel7
            // 
            panel7.AutoSize = true;
            panel7.Controls.Add(buttonActiveTickets);
            panel7.Dock = DockStyle.Top;
            panel7.Location = new Point(5, 65);
            panel7.Name = "panel7";
            panel7.Padding = new Padding(0, 5, 0, 0);
            panel7.Size = new Size(240, 45);
            panel7.TabIndex = 16;
            // 
            // buttonActiveTickets
            // 
            buttonActiveTickets.AutoSize = true;
            buttonActiveTickets.BackColor = Color.White;
            buttonActiveTickets.Dock = DockStyle.Top;
            buttonActiveTickets.FlatAppearance.BorderSize = 0;
            buttonActiveTickets.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonActiveTickets.ForeColor = Color.Black;
            buttonActiveTickets.IsActivated = false;
            buttonActiveTickets.Location = new Point(0, 5);
            buttonActiveTickets.Margin = new Padding(0);
            buttonActiveTickets.Name = "buttonActiveTickets";
            buttonActiveTickets.Padding = new Padding(25, 0, 0, 0);
            buttonActiveTickets.Size = new Size(240, 40);
            buttonActiveTickets.TabIndex = 10;
            buttonActiveTickets.Text = "My active tickets";
            buttonActiveTickets.TextAlign = ContentAlignment.MiddleLeft;
            buttonActiveTickets.UseVisualStyleBackColor = false;
            // 
            // panel10
            // 
            panel10.AutoSize = true;
            panel10.Controls.Add(buttonFilmPage);
            panel10.Dock = DockStyle.Top;
            panel10.Location = new Point(5, 20);
            panel10.Name = "panel10";
            panel10.Padding = new Padding(0, 5, 0, 0);
            panel10.Size = new Size(240, 45);
            panel10.TabIndex = 13;
            // 
            // buttonFilmPage
            // 
            buttonFilmPage.AutoSize = true;
            buttonFilmPage.BackColor = Color.White;
            buttonFilmPage.Dock = DockStyle.Top;
            buttonFilmPage.FlatAppearance.BorderSize = 0;
            buttonFilmPage.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonFilmPage.ForeColor = Color.Black;
            buttonFilmPage.IsActivated = false;
            buttonFilmPage.Location = new Point(0, 5);
            buttonFilmPage.Margin = new Padding(0);
            buttonFilmPage.Name = "buttonFilmPage";
            buttonFilmPage.Padding = new Padding(25, 0, 0, 0);
            buttonFilmPage.Size = new Size(240, 40);
            buttonFilmPage.TabIndex = 12;
            buttonFilmPage.Text = "Films";
            buttonFilmPage.TextAlign = ContentAlignment.MiddleLeft;
            buttonFilmPage.UseVisualStyleBackColor = false;
            // 
            // panel11
            // 
            panel11.Controls.Add(label2);
            panel11.Controls.Add(label1);
            panel11.Dock = DockStyle.Top;
            panel11.Location = new Point(0, 0);
            panel11.Name = "panel11";
            panel11.Size = new Size(250, 100);
            panel11.TabIndex = 8;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(0, 72);
            label2.Name = "label2";
            label2.Padding = new Padding(0, 0, 10, 0);
            label2.Size = new Size(250, 28);
            label2.TabIndex = 4;
            label2.Text = "Admin";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(250, 72);
            label1.TabIndex = 3;
            label1.Text = "Hello USERNAME";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // NBAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "NBAdmin";
            Size = new Size(250, 722);
            Load += NBAdmin_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panel11.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel4;
        private components.CustomButton buttonLogOut;
        private Panel panel2;
        private Panel panel3;
        private Panel panel9;
        private components.CustomButton buttonAccountSettings;
        private Panel panel8;
        private components.CustomButton buttonReviews;
        private Panel panel6;
        private components.CustomButton buttonSessionArchive;
        private Panel panel5;
        private components.CustomButton buttonFutureSessions;
        private Panel panel7;
        private components.CustomButton buttonActiveTickets;
        private Panel panel10;
        private components.CustomButton buttonFilmPage;
        private Panel panel11;
        private components.Label label2;
        private Label label1;
    }
}
