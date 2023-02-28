namespace CPProject
{
    partial class InputLableIndicated
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
            label = new Label();
            customInput1 = new components.CustomInput();
            SuspendLayout();
            // 
            // label
            // 
            label.Dock = DockStyle.Top;
            label.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label.Location = new Point(0, 0);
            label.Name = "label";
            label.Size = new Size(140, 18);
            label.TabIndex = 0;
            label.Text = "label1";
            // 
            // customInput1
            // 
            customInput1.AutoSize = true;
            customInput1.Dock = DockStyle.Top;
            customInput1.IsInvalid = false;
            customInput1.Location = new Point(0, 18);
            customInput1.Margin = new Padding(0);
            customInput1.MinimumSize = new Size(70, 25);
            customInput1.Name = "customInput1";
            customInput1.Padding = new Padding(3, 2, 3, 0);
            customInput1.Placeholder = "";
            customInput1.Size = new Size(140, 28);
            customInput1.TabIndex = 3;
            customInput1.CustomInputChanged += customInput1_CustomInputChanged;
            // 
            // InputLableIndicated
            // 
            AutoSize = true;
            BackColor = Color.White;
            Controls.Add(customInput1);
            Controls.Add(label);
            Margin = new Padding(0);
            MinimumSize = new Size(70, 48);
            Name = "InputLableIndicated";
            Size = new Size(140, 48);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label;
        private components.CustomInput customInput1;
    }
}
