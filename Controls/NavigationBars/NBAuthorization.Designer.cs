namespace CPProject
{
    partial class NBAuthorization
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
            label1 = new Label();
            groupBox1 = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            customButtonLogIn = new components.CustomButton();
            customButtonSignIn = new components.CustomButton();
            buttonFilmPage = new components.CustomButton();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            buttonFutureSessions = new components.CustomButton();
            panel4 = new Panel();
            groupBox1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(2, 0);
            label1.Name = "label1";
            label1.Size = new Size(246, 62);
            label1.TabIndex = 1;
            label1.Text = "CinemaPlanet";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            groupBox1.AutoSize = true;
            groupBox1.Controls.Add(tableLayoutPanel1);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Margin = new Padding(10);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(246, 61);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Authorization";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(customButtonLogIn, 0, 0);
            tableLayoutPanel1.Controls.Add(customButtonSignIn, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(3, 18);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(240, 40);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // customButtonLogIn
            // 
            customButtonLogIn.AutoSize = true;
            customButtonLogIn.BackColor = Color.White;
            customButtonLogIn.Dock = DockStyle.Fill;
            customButtonLogIn.FlatAppearance.BorderSize = 0;
            customButtonLogIn.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            customButtonLogIn.ForeColor = Color.Black;
            customButtonLogIn.IsActivated = false;
            customButtonLogIn.Location = new Point(3, 3);
            customButtonLogIn.Name = "customButtonLogIn";
            customButtonLogIn.Size = new Size(114, 34);
            customButtonLogIn.TabIndex = 4;
            customButtonLogIn.Text = "Log in";
            customButtonLogIn.UseVisualStyleBackColor = false;
            customButtonLogIn.Click += customButton1_Click;
            // 
            // customButtonSignIn
            // 
            customButtonSignIn.AutoSize = true;
            customButtonSignIn.BackColor = Color.White;
            customButtonSignIn.Dock = DockStyle.Fill;
            customButtonSignIn.FlatAppearance.BorderSize = 0;
            customButtonSignIn.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            customButtonSignIn.ForeColor = Color.Black;
            customButtonSignIn.IsActivated = false;
            customButtonSignIn.Location = new Point(123, 3);
            customButtonSignIn.Name = "customButtonSignIn";
            customButtonSignIn.Size = new Size(114, 34);
            customButtonSignIn.TabIndex = 5;
            customButtonSignIn.Text = "Sign in";
            customButtonSignIn.UseVisualStyleBackColor = false;
            customButtonSignIn.Click += customButton2_Click;
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
            buttonFilmPage.Location = new Point(0, 20);
            buttonFilmPage.Margin = new Padding(0);
            buttonFilmPage.Name = "buttonFilmPage";
            buttonFilmPage.Padding = new Padding(25, 0, 0, 0);
            buttonFilmPage.Size = new Size(236, 40);
            buttonFilmPage.TabIndex = 5;
            buttonFilmPage.Text = "Films";
            buttonFilmPage.TextAlign = ContentAlignment.MiddleLeft;
            buttonFilmPage.UseVisualStyleBackColor = false;
            buttonFilmPage.Click += buttonFilmPage_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(2, 62);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(5, 0, 5, 10);
            panel1.Size = new Size(246, 109);
            panel1.TabIndex = 6;
            // 
            // panel2
            // 
            panel2.AutoSize = true;
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(buttonFilmPage);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(5, 0);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(0, 20, 0, 0);
            panel2.Size = new Size(236, 107);
            panel2.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.AutoSize = true;
            panel3.Controls.Add(buttonFutureSessions);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 60);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(0, 7, 0, 0);
            panel3.Size = new Size(236, 47);
            panel3.TabIndex = 6;
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
            buttonFutureSessions.Location = new Point(0, 7);
            buttonFutureSessions.Margin = new Padding(0);
            buttonFutureSessions.Name = "buttonFutureSessions";
            buttonFutureSessions.Padding = new Padding(25, 0, 0, 0);
            buttonFutureSessions.Size = new Size(236, 40);
            buttonFutureSessions.TabIndex = 5;
            buttonFutureSessions.Text = "Future sessions";
            buttonFutureSessions.TextAlign = ContentAlignment.MiddleLeft;
            buttonFutureSessions.UseVisualStyleBackColor = false;
            buttonFutureSessions.Click += buttonFutureSessions_Click;
            // 
            // panel4
            // 
            panel4.AutoSize = true;
            panel4.Controls.Add(groupBox1);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(2, 651);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(0, 0, 0, 10);
            panel4.Size = new Size(246, 71);
            panel4.TabIndex = 7;
            // 
            // NBAuthorization
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            Controls.Add(panel4);
            Controls.Add(panel1);
            Controls.Add(label1);
            Margin = new Padding(0);
            Name = "NBAuthorization";
            Padding = new Padding(2, 0, 2, 0);
            Size = new Size(250, 722);
            Load += AppNavBar_Load;
            groupBox1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private components.CustomButton customButtonLogIn;
        private components.CustomButton customButtonSignIn;
        private components.CustomButton buttonFilmPage;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private components.CustomButton buttonFutureSessions;
        private Panel panel4;
    }
}
