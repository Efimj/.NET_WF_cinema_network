namespace CPProject.Controls.Pages
{
    partial class CreateFilmPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateFilmPage));
            panel5 = new Panel();
            panel7 = new Panel();
            buttonBack = new components.CustomButton();
            panel2 = new Panel();
            panel23 = new Panel();
            panel24 = new Panel();
            textBox2 = new TextBox();
            label4 = new components.Label();
            panel20 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            customComboBox1 = new components.CustomComboBox();
            panel12 = new Panel();
            label1 = new components.Label();
            panel8 = new Panel();
            panel9 = new Panel();
            panel10 = new Panel();
            customInput2 = new components.CustomInput();
            panel11 = new Panel();
            label2 = new components.Label();
            panel21 = new Panel();
            pictureBox2 = new PictureBox();
            panel22 = new Panel();
            customButton1 = new components.CustomButton();
            panel1 = new Panel();
            panel5.SuspendLayout();
            panel7.SuspendLayout();
            panel2.SuspendLayout();
            panel23.SuspendLayout();
            panel24.SuspendLayout();
            panel20.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel12.SuspendLayout();
            panel8.SuspendLayout();
            panel9.SuspendLayout();
            panel10.SuspendLayout();
            panel11.SuspendLayout();
            panel21.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel22.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel5
            // 
            panel5.Controls.Add(panel7);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Padding = new Padding(0, 0, 0, 10);
            panel5.Size = new Size(666, 39);
            panel5.TabIndex = 1;
            // 
            // panel7
            // 
            panel7.Controls.Add(buttonBack);
            panel7.Dock = DockStyle.Left;
            panel7.Location = new Point(0, 0);
            panel7.Name = "panel7";
            panel7.Size = new Size(200, 29);
            panel7.TabIndex = 0;
            // 
            // buttonBack
            // 
            buttonBack.AutoSize = true;
            buttonBack.BackColor = Color.White;
            buttonBack.Dock = DockStyle.Left;
            buttonBack.FlatAppearance.BorderSize = 0;
            buttonBack.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonBack.ForeColor = Color.Black;
            buttonBack.IsActivated = false;
            buttonBack.Location = new Point(0, 0);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(96, 29);
            buttonBack.TabIndex = 0;
            buttonBack.Text = "back";
            buttonBack.UseVisualStyleBackColor = false;
            buttonBack.Click += buttonBack_Click;
            // 
            // panel2
            // 
            panel2.AutoScroll = true;
            panel2.Controls.Add(panel23);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 39);
            panel2.Name = "panel2";
            panel2.Size = new Size(666, 840);
            panel2.TabIndex = 2;
            // 
            // panel23
            // 
            panel23.Controls.Add(panel24);
            panel23.Controls.Add(panel20);
            panel23.Dock = DockStyle.Top;
            panel23.Location = new Point(0, 0);
            panel23.Name = "panel23";
            panel23.Size = new Size(666, 465);
            panel23.TabIndex = 9;
            // 
            // panel24
            // 
            panel24.Controls.Add(textBox2);
            panel24.Controls.Add(label4);
            panel24.Dock = DockStyle.Fill;
            panel24.Location = new Point(0, 311);
            panel24.Name = "panel24";
            panel24.Size = new Size(666, 154);
            panel24.TabIndex = 9;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(230, 230, 230);
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Dock = DockStyle.Left;
            textBox2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(0, 35);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ScrollBars = ScrollBars.Vertical;
            textBox2.Size = new Size(558, 119);
            textBox2.TabIndex = 2;
            // 
            // label4
            // 
            label4.Dock = DockStyle.Top;
            label4.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Padding = new Padding(0, 0, 5, 0);
            label4.Size = new Size(666, 35);
            label4.TabIndex = 1;
            label4.Text = "Full description";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel20
            // 
            panel20.Controls.Add(panel3);
            panel20.Controls.Add(panel8);
            panel20.Controls.Add(panel21);
            panel20.Dock = DockStyle.Top;
            panel20.Location = new Point(0, 0);
            panel20.Name = "panel20";
            panel20.Size = new Size(666, 311);
            panel20.TabIndex = 8;
            // 
            // panel3
            // 
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(panel12);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(200, 35);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(0, 10, 0, 0);
            panel3.Size = new Size(466, 43);
            panel3.TabIndex = 11;
            // 
            // panel4
            // 
            panel4.Controls.Add(customComboBox1);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(158, 10);
            panel4.Name = "panel4";
            panel4.Size = new Size(308, 33);
            panel4.TabIndex = 1;
            // 
            // customComboBox1
            // 
            customComboBox1.BackColor = Color.FromArgb(230, 230, 230);
            customComboBox1.Dock = DockStyle.Left;
            customComboBox1.Location = new Point(0, 0);
            customComboBox1.Name = "customComboBox1";
            customComboBox1.Padding = new Padding(3, 2, 3, 2);
            customComboBox1.Size = new Size(200, 33);
            customComboBox1.TabIndex = 0;
            // 
            // panel12
            // 
            panel12.Controls.Add(label1);
            panel12.Dock = DockStyle.Left;
            panel12.Location = new Point(0, 10);
            panel12.Name = "panel12";
            panel12.Size = new Size(158, 33);
            panel12.TabIndex = 0;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Padding = new Padding(0, 0, 5, 0);
            label1.Size = new Size(158, 35);
            label1.TabIndex = 0;
            label1.Text = "Film name";
            label1.TextAlign = ContentAlignment.TopRight;
            // 
            // panel8
            // 
            panel8.Controls.Add(panel9);
            panel8.Controls.Add(panel11);
            panel8.Dock = DockStyle.Top;
            panel8.Location = new Point(200, 0);
            panel8.Name = "panel8";
            panel8.Size = new Size(466, 35);
            panel8.TabIndex = 10;
            // 
            // panel9
            // 
            panel9.Controls.Add(panel10);
            panel9.Dock = DockStyle.Fill;
            panel9.Location = new Point(158, 0);
            panel9.Name = "panel9";
            panel9.Size = new Size(308, 35);
            panel9.TabIndex = 1;
            // 
            // panel10
            // 
            panel10.Controls.Add(customInput2);
            panel10.Dock = DockStyle.Top;
            panel10.Location = new Point(0, 0);
            panel10.Name = "panel10";
            panel10.Size = new Size(308, 32);
            panel10.TabIndex = 0;
            // 
            // customInput2
            // 
            customInput2.AutoSize = true;
            customInput2.BackColor = Color.FromArgb(230, 230, 230);
            customInput2.Dock = DockStyle.Left;
            customInput2.IsInvalid = false;
            customInput2.Location = new Point(0, 0);
            customInput2.Margin = new Padding(0);
            customInput2.MinimumSize = new Size(200, 0);
            customInput2.Name = "customInput2";
            customInput2.Padding = new Padding(4, 4, 4, 0);
            customInput2.Placeholder = "";
            customInput2.Size = new Size(200, 32);
            customInput2.TabIndex = 0;
            // 
            // panel11
            // 
            panel11.Controls.Add(label2);
            panel11.Dock = DockStyle.Left;
            panel11.Location = new Point(0, 0);
            panel11.Name = "panel11";
            panel11.Size = new Size(158, 35);
            panel11.TabIndex = 0;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Padding = new Padding(0, 0, 5, 0);
            label2.Size = new Size(158, 35);
            label2.TabIndex = 0;
            label2.Text = "Film name";
            label2.TextAlign = ContentAlignment.TopRight;
            // 
            // panel21
            // 
            panel21.Controls.Add(pictureBox2);
            panel21.Controls.Add(panel22);
            panel21.Dock = DockStyle.Left;
            panel21.Location = new Point(0, 0);
            panel21.Name = "panel21";
            panel21.Size = new Size(200, 311);
            panel21.TabIndex = 9;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Fill;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(200, 270);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // panel22
            // 
            panel22.Controls.Add(customButton1);
            panel22.Dock = DockStyle.Bottom;
            panel22.Location = new Point(0, 270);
            panel22.Name = "panel22";
            panel22.Size = new Size(200, 41);
            panel22.TabIndex = 2;
            // 
            // customButton1
            // 
            customButton1.AutoSize = true;
            customButton1.BackColor = Color.White;
            customButton1.FlatAppearance.BorderSize = 0;
            customButton1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            customButton1.ForeColor = Color.Black;
            customButton1.IsActivated = false;
            customButton1.Location = new Point(40, 6);
            customButton1.Name = "customButton1";
            customButton1.Size = new Size(121, 29);
            customButton1.TabIndex = 0;
            customButton1.Text = "Add picture";
            customButton1.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(panel5);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(15, 15);
            panel1.Name = "panel1";
            panel1.Size = new Size(666, 879);
            panel1.TabIndex = 0;
            // 
            // CreateFilmPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(panel1);
            Name = "CreateFilmPage";
            Padding = new Padding(15);
            Size = new Size(696, 909);
            Load += CreateFilmPage_Load;
            panel5.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel2.ResumeLayout(false);
            panel23.ResumeLayout(false);
            panel24.ResumeLayout(false);
            panel24.PerformLayout();
            panel20.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel12.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panel11.ResumeLayout(false);
            panel21.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel22.ResumeLayout(false);
            panel22.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel5;
        private Panel panel7;
        private components.CustomButton buttonBack;
        private Panel panel2;
        private Panel panel23;
        private Panel panel24;
        private TextBox textBox2;
        private components.Label label4;
        private Panel panel20;
        private Panel panel3;
        private Panel panel4;
        private components.CustomComboBox customComboBox1;
        private Panel panel12;
        private components.Label label1;
        private Panel panel8;
        private Panel panel9;
        private Panel panel10;
        private components.CustomInput customInput2;
        private Panel panel11;
        private components.Label label2;
        private Panel panel21;
        private PictureBox pictureBox2;
        private Panel panel22;
        private components.CustomButton customButton1;
        private Panel panel1;
    }
}
