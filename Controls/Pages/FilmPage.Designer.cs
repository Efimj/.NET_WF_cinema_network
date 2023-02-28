namespace CPProject.Controls.Pages
{
    partial class FilmPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FilmPage));
            panel3 = new Panel();
            panel7 = new Panel();
            textBox2 = new TextBox();
            panel8 = new Panel();
            label3 = new components.Label();
            customButton2 = new components.CustomButton();
            panel9 = new Panel();
            panel11 = new Panel();
            label4 = new components.Label();
            pictureBox1 = new PictureBox();
            panelByTicket = new Panel();
            panel1 = new Panel();
            flowLayoutPanelReviews = new FlowLayoutPanel();
            panelReviewCreate = new Panel();
            label1 = new components.Label();
            panel2 = new Panel();
            panel3.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            panel9.SuspendLayout();
            panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.Controls.Add(panel7);
            panel3.Controls.Add(panel8);
            panel3.Controls.Add(panel9);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.MaximumSize = new Size(720, 250);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(15, 15, 0, 5);
            panel3.Size = new Size(720, 205);
            panel3.TabIndex = 8;
            // 
            // panel7
            // 
            panel7.Controls.Add(textBox2);
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(15, 45);
            panel7.Name = "panel7";
            panel7.Padding = new Padding(0, 8, 0, 0);
            panel7.Size = new Size(505, 155);
            panel7.TabIndex = 9;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.White;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Dock = DockStyle.Fill;
            textBox2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(0, 8);
            textBox2.Margin = new Padding(3, 5, 3, 3);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.ScrollBars = ScrollBars.Vertical;
            textBox2.Size = new Size(505, 147);
            textBox2.TabIndex = 11;
            textBox2.Text = "Film full description";
            // 
            // panel8
            // 
            panel8.AutoSize = true;
            panel8.Controls.Add(label3);
            panel8.Controls.Add(customButton2);
            panel8.Dock = DockStyle.Top;
            panel8.Location = new Point(15, 15);
            panel8.Name = "panel8";
            panel8.Size = new Size(505, 30);
            panel8.TabIndex = 8;
            // 
            // label3
            // 
            label3.Dock = DockStyle.Top;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(90, 0);
            label3.Name = "label3";
            label3.Padding = new Padding(15, 5, 15, 0);
            label3.Size = new Size(415, 30);
            label3.TabIndex = 6;
            label3.Text = "FilmName";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // customButton2
            // 
            customButton2.AutoSize = true;
            customButton2.BackColor = Color.White;
            customButton2.Dock = DockStyle.Left;
            customButton2.FlatAppearance.BorderSize = 0;
            customButton2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            customButton2.ForeColor = Color.Black;
            customButton2.IsActivated = false;
            customButton2.Location = new Point(0, 0);
            customButton2.MaximumSize = new Size(90, 30);
            customButton2.Name = "customButton2";
            customButton2.Size = new Size(90, 30);
            customButton2.TabIndex = 0;
            customButton2.Text = "back";
            customButton2.UseVisualStyleBackColor = false;
            customButton2.Click += customButton2_Click;
            // 
            // panel9
            // 
            panel9.Controls.Add(panel11);
            panel9.Controls.Add(panelByTicket);
            panel9.Dock = DockStyle.Right;
            panel9.Location = new Point(520, 15);
            panel9.Name = "panel9";
            panel9.Size = new Size(200, 185);
            panel9.TabIndex = 0;
            // 
            // panel11
            // 
            panel11.Controls.Add(label4);
            panel11.Controls.Add(pictureBox1);
            panel11.Dock = DockStyle.Fill;
            panel11.Location = new Point(0, 0);
            panel11.Name = "panel11";
            panel11.Size = new Size(200, 156);
            panel11.TabIndex = 1;
            // 
            // label4
            // 
            label4.Dock = DockStyle.Fill;
            label4.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(0, 131);
            label4.Name = "label4";
            label4.Size = new Size(200, 25);
            label4.TabIndex = 3;
            label4.Text = "User score 4.5/5";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(200, 131);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // panelByTicket
            // 
            panelByTicket.Dock = DockStyle.Bottom;
            panelByTicket.Location = new Point(0, 156);
            panelByTicket.Name = "panelByTicket";
            panelByTicket.Padding = new Padding(30, 0, 30, 0);
            panelByTicket.Size = new Size(200, 29);
            panelByTicket.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(flowLayoutPanelReviews);
            panel1.Controls.Add(panelReviewCreate);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 205);
            panel1.Name = "panel1";
            panel1.Size = new Size(722, 273);
            panel1.TabIndex = 9;
            // 
            // flowLayoutPanelReviews
            // 
            flowLayoutPanelReviews.AutoScroll = true;
            flowLayoutPanelReviews.AutoSize = true;
            flowLayoutPanelReviews.Dock = DockStyle.Fill;
            flowLayoutPanelReviews.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanelReviews.Location = new Point(0, 79);
            flowLayoutPanelReviews.MaximumSize = new Size(720, 4000);
            flowLayoutPanelReviews.Name = "flowLayoutPanelReviews";
            flowLayoutPanelReviews.Padding = new Padding(15, 0, 0, 0);
            flowLayoutPanelReviews.Size = new Size(720, 194);
            flowLayoutPanelReviews.TabIndex = 10;
            flowLayoutPanelReviews.WrapContents = false;
            // 
            // panelReviewCreate
            // 
            panelReviewCreate.Dock = DockStyle.Top;
            panelReviewCreate.Location = new Point(0, 44);
            panelReviewCreate.MaximumSize = new Size(150, 35);
            panelReviewCreate.Name = "panelReviewCreate";
            panelReviewCreate.Padding = new Padding(16, 0, 0, 6);
            panelReviewCreate.Size = new Size(150, 35);
            panelReviewCreate.TabIndex = 9;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(0, 1);
            label1.MaximumSize = new Size(720, 250);
            label1.Name = "label1";
            label1.Padding = new Padding(15, 0, 0, 0);
            label1.Size = new Size(720, 43);
            label1.TabIndex = 8;
            label1.Text = "Reviews";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlDarkDark;
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(15, 3, 3, 3);
            panel2.MaximumSize = new Size(720, 1);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(15, 0, 0, 0);
            panel2.Size = new Size(720, 1);
            panel2.TabIndex = 2;
            // 
            // FilmPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(panel1);
            Controls.Add(panel3);
            Name = "FilmPage";
            Size = new Size(722, 478);
            Load += FilmPage_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel9.ResumeLayout(false);
            panel11.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private Panel panel7;
        private TextBox textBox2;
        private Panel panel8;
        private components.Label label3;
        private components.CustomButton customButton2;
        private Panel panel9;
        private Panel panel11;
        private components.Label label4;
        private PictureBox pictureBox1;
        private Panel panelByTicket;
        private Panel panel1;
        private Panel panel2;
        private FlowLayoutPanel flowLayoutPanelReviews;
        private Panel panelReviewCreate;
        private components.Label label1;
    }
}
