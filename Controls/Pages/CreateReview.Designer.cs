namespace CPProject.Controls.Pages
{
    partial class CreateReview
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
            panel3 = new Panel();
            panel6 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            customButton2 = new components.CustomButton();
            panel4 = new Panel();
            textBox1 = new TextBox();
            panel5 = new Panel();
            panel7 = new Panel();
            ratingControl1 = new components.ui.RatingControl();
            label1 = new components.Label();
            panel2 = new Panel();
            customButton1 = new components.CustomButton();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel6.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel7.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(15, 15);
            panel1.Name = "panel1";
            panel1.Size = new Size(897, 434);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(panel6);
            panel3.Controls.Add(panel4);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 49);
            panel3.Name = "panel3";
            panel3.Size = new Size(897, 385);
            panel3.TabIndex = 1;
            // 
            // panel6
            // 
            panel6.Controls.Add(tableLayoutPanel1);
            panel6.Dock = DockStyle.Left;
            panel6.Location = new Point(0, 212);
            panel6.Name = "panel6";
            panel6.Size = new Size(629, 173);
            panel6.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(customButton2, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(629, 33);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // customButton2
            // 
            customButton2.AutoSize = true;
            customButton2.BackColor = Color.White;
            customButton2.Dock = DockStyle.Fill;
            customButton2.FlatAppearance.BorderSize = 0;
            customButton2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            customButton2.ForeColor = Color.Black;
            customButton2.IsActivated = false;
            customButton2.Location = new Point(257, 3);
            customButton2.Name = "customButton2";
            customButton2.Size = new Size(114, 27);
            customButton2.TabIndex = 0;
            customButton2.Text = "save";
            customButton2.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            panel4.AutoSize = true;
            panel4.Controls.Add(textBox1);
            panel4.Controls.Add(panel5);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(897, 212);
            panel4.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Dock = DockStyle.Top;
            textBox1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(0, 39);
            textBox1.MaximumSize = new Size(629, 371);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ScrollBars = ScrollBars.Vertical;
            textBox1.Size = new Size(629, 173);
            textBox1.TabIndex = 2;
            textBox1.Text = "User review description";
            // 
            // panel5
            // 
            panel5.Controls.Add(panel7);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Padding = new Padding(0, 0, 0, 10);
            panel5.Size = new Size(897, 39);
            panel5.TabIndex = 1;
            // 
            // panel7
            // 
            panel7.Controls.Add(ratingControl1);
            panel7.Controls.Add(label1);
            panel7.Dock = DockStyle.Left;
            panel7.Location = new Point(0, 0);
            panel7.Name = "panel7";
            panel7.Size = new Size(629, 29);
            panel7.TabIndex = 1;
            // 
            // ratingControl1
            // 
            ratingControl1.BackColor = Color.White;
            ratingControl1.CurrentReting = null;
            ratingControl1.Dock = DockStyle.Right;
            ratingControl1.Editable = true;
            ratingControl1.Location = new Point(498, 0);
            ratingControl1.Margin = new Padding(0);
            ratingControl1.Name = "ratingControl1";
            ratingControl1.Size = new Size(131, 29);
            ratingControl1.TabIndex = 1;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Left;
            label1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Padding = new Padding(10, 0, 0, 0);
            label1.Size = new Size(257, 29);
            label1.TabIndex = 0;
            label1.Text = "User name";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            panel2.Controls.Add(customButton1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(0, 10, 0, 10);
            panel2.Size = new Size(897, 49);
            panel2.TabIndex = 0;
            // 
            // customButton1
            // 
            customButton1.AutoSize = true;
            customButton1.BackColor = Color.White;
            customButton1.Dock = DockStyle.Left;
            customButton1.FlatAppearance.BorderSize = 0;
            customButton1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            customButton1.ForeColor = Color.Black;
            customButton1.IsActivated = false;
            customButton1.Location = new Point(0, 10);
            customButton1.Name = "customButton1";
            customButton1.Size = new Size(90, 29);
            customButton1.TabIndex = 0;
            customButton1.Text = "back";
            customButton1.UseVisualStyleBackColor = false;
            customButton1.Click += customButton1_Click;
            // 
            // CreateReview
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(panel1);
            Name = "CreateReview";
            Padding = new Padding(15, 15, 0, 0);
            Size = new Size(912, 594);
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel6.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Panel panel2;
        private components.CustomButton customButton1;
        private Panel panel4;
        private TextBox textBox1;
        private Panel panel5;
        private components.Label label1;
        private Panel panel6;
        private TableLayoutPanel tableLayoutPanel1;
        private components.CustomButton customButton2;
        private Panel panel7;
        private components.ui.RatingControl ratingControl1;
    }
}
