namespace CPProject.components
{
    partial class CustomComboBox
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
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.FromArgb(230, 230, 230);
            comboBox1.Cursor = Cursors.Hand;
            comboBox1.Dock = DockStyle.Fill;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(3, 2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(144, 26);
            comboBox1.TabIndex = 0;
            // 
            // CustomComboBox
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 230, 230);
            Controls.Add(comboBox1);
            Name = "CustomComboBox";
            Padding = new Padding(3, 2, 3, 2);
            Size = new Size(150, 29);
            ResumeLayout(false);
        }

        #endregion

        private ComboBox comboBox1;
    }
}
