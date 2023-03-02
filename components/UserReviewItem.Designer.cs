namespace CPProject.components
{
    partial class UserReviewItem
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
            panel1 = new Panel();
            label3 = new Label();
            textBox2 = new TextBox();
            ratingControl1 = new ui.RatingControl();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Dock = DockStyle.Left;
            label1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Padding = new Padding(12, 0, 0, 0);
            label1.Size = new Size(513, 37);
            label1.TabIndex = 0;
            label1.Text = "Username";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.Controls.Add(ratingControl1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(5, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(649, 37);
            panel1.TabIndex = 1;
            // 
            // label3
            // 
            label3.Dock = DockStyle.Bottom;
            label3.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(5, 114);
            label3.Name = "label3";
            label3.Padding = new Padding(0, 0, 15, 0);
            label3.Size = new Size(649, 34);
            label3.TabIndex = 13;
            label3.Text = "26.02.2023";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.White;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Dock = DockStyle.Fill;
            textBox2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(5, 39);
            textBox2.Margin = new Padding(3, 5, 3, 3);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.ScrollBars = ScrollBars.Vertical;
            textBox2.Size = new Size(649, 75);
            textBox2.TabIndex = 14;
            textBox2.Text = "Review description";
            // 
            // ratingControl1
            // 
            ratingControl1.BackColor = Color.White;
            ratingControl1.CurrentReting = null;
            ratingControl1.Dock = DockStyle.Fill;
            ratingControl1.Editable = false;
            ratingControl1.Location = new Point(513, 0);
            ratingControl1.Margin = new Padding(0);
            ratingControl1.Name = "ratingControl1";
            ratingControl1.Size = new Size(136, 37);
            ratingControl1.TabIndex = 1;
            // 
            // UserReviewItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(panel1);
            Name = "UserReviewItem";
            Padding = new Padding(5, 2, 2, 2);
            Size = new Size(656, 150);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Label label3;
        private TextBox textBox2;
        private ui.RatingControl ratingControl1;
    }
}
