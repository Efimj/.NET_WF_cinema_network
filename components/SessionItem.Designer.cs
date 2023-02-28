namespace CPProject.components
{
    partial class SessionItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SessionItem));
            panel6 = new Panel();
            panel7 = new Panel();
            panel8 = new Panel();
            textBox2 = new TextBox();
            label1 = new Label();
            panel12 = new Panel();
            panel9 = new Panel();
            label5 = new Label();
            label6 = new Label();
            panel11 = new Panel();
            panel10 = new Panel();
            pictureBox2 = new PictureBox();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            panel9.SuspendLayout();
            panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(panel7);
            panel6.Controls.Add(panel10);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(0, 0);
            panel6.MinimumSize = new Size(600, 80);
            panel6.Name = "panel6";
            panel6.Size = new Size(720, 82);
            panel6.TabIndex = 2;
            // 
            // panel7
            // 
            panel7.Controls.Add(panel8);
            panel7.Controls.Add(panel9);
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(150, 0);
            panel7.Name = "panel7";
            panel7.Size = new Size(568, 80);
            panel7.TabIndex = 2;
            // 
            // panel8
            // 
            panel8.Controls.Add(textBox2);
            panel8.Controls.Add(label1);
            panel8.Controls.Add(panel12);
            panel8.Dock = DockStyle.Fill;
            panel8.Location = new Point(199, 0);
            panel8.Name = "panel8";
            panel8.Size = new Size(369, 80);
            panel8.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.White;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Dock = DockStyle.Fill;
            textBox2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(1, 29);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.ScrollBars = ScrollBars.Vertical;
            textBox2.Size = new Size(368, 51);
            textBox2.TabIndex = 13;
            textBox2.Text = "Address";
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(1, 0);
            label1.Name = "label1";
            label1.Size = new Size(368, 29);
            label1.TabIndex = 12;
            label1.Text = "Date time";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel12
            // 
            panel12.BackColor = SystemColors.ControlDarkDark;
            panel12.Dock = DockStyle.Left;
            panel12.Location = new Point(0, 0);
            panel12.Name = "panel12";
            panel12.Size = new Size(1, 80);
            panel12.TabIndex = 1;
            // 
            // panel9
            // 
            panel9.Controls.Add(label5);
            panel9.Controls.Add(label6);
            panel9.Controls.Add(panel11);
            panel9.Dock = DockStyle.Left;
            panel9.Location = new Point(0, 0);
            panel9.Name = "panel9";
            panel9.Size = new Size(199, 80);
            panel9.TabIndex = 0;
            // 
            // label5
            // 
            label5.Dock = DockStyle.Fill;
            label5.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(1, 29);
            label5.Name = "label5";
            label5.Size = new Size(198, 51);
            label5.TabIndex = 12;
            label5.Text = "Film description";
            // 
            // label6
            // 
            label6.Dock = DockStyle.Top;
            label6.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(1, 0);
            label6.Name = "label6";
            label6.Size = new Size(198, 29);
            label6.TabIndex = 11;
            label6.Text = "FilmName";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel11
            // 
            panel11.BackColor = SystemColors.ControlDarkDark;
            panel11.Dock = DockStyle.Left;
            panel11.Location = new Point(0, 0);
            panel11.Name = "panel11";
            panel11.Size = new Size(1, 80);
            panel11.TabIndex = 0;
            // 
            // panel10
            // 
            panel10.BackColor = Color.White;
            panel10.Controls.Add(pictureBox2);
            panel10.Dock = DockStyle.Left;
            panel10.Location = new Point(0, 0);
            panel10.Name = "panel10";
            panel10.Size = new Size(150, 80);
            panel10.TabIndex = 1;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Fill;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(150, 80);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // SessionItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            Controls.Add(panel6);
            MinimumSize = new Size(600, 80);
            Name = "SessionItem";
            Size = new Size(720, 130);
            panel6.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel9.ResumeLayout(false);
            panel10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel6;
        private Panel panel7;
        private Panel panel8;
        private TextBox textBox2;
        private Label label1;
        private Panel panel12;
        private Panel panel9;
        private Label label5;
        private Label label6;
        private Panel panel11;
        private Panel panel10;
        private PictureBox pictureBox2;
    }
}
