namespace CPProject.components
{
    partial class CustomInput
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
            textBox = new TextBox();
            panel2 = new Panel();
            panelIndicator = new Panel();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // textBox
            // 
            textBox.BackColor = Color.FromArgb(230, 230, 230);
            textBox.BorderStyle = BorderStyle.None;
            textBox.Dock = DockStyle.Top;
            textBox.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox.Location = new Point(4, 3);
            textBox.Margin = new Padding(0);
            textBox.Name = "textBox";
            textBox.Size = new Size(346, 19);
            textBox.TabIndex = 2;
            textBox.TextChanged += textBox_TextChanged;
            // 
            // panel2
            // 
            panel2.AutoSize = true;
            panel2.Controls.Add(textBox);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(4, 3, 4, 0);
            panel2.Size = new Size(354, 22);
            panel2.TabIndex = 1;
            // 
            // panelIndicator
            // 
            panelIndicator.BackColor = Color.White;
            panelIndicator.Dock = DockStyle.Top;
            panelIndicator.Location = new Point(0, 22);
            panelIndicator.Margin = new Padding(0);
            panelIndicator.Name = "panelIndicator";
            panelIndicator.Size = new Size(354, 2);
            panelIndicator.TabIndex = 3;
            // 
            // CustomInput
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(230, 230, 230);
            Controls.Add(panelIndicator);
            Controls.Add(panel2);
            Margin = new Padding(0);
            MinimumSize = new Size(70, 24);
            Name = "CustomInput";
            Size = new Size(354, 24);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox;
        private Panel panel2;
        private Panel panelIndicator;
    }
}
