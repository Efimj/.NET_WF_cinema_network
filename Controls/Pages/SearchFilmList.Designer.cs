namespace CPProject.Controls
{
    partial class SearchFilmList
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
            panelHeader = new Panel();
            buttonCreateNewFilm = new components.CustomButton();
            label1 = new components.Label();
            customComboBox1 = new components.CustomComboBox();
            panel1 = new Panel();
            customInput1 = new components.CustomInput();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panelHeader.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.White;
            panelHeader.Controls.Add(buttonCreateNewFilm);
            panelHeader.Controls.Add(label1);
            panelHeader.Controls.Add(customComboBox1);
            panelHeader.Controls.Add(panel1);
            panelHeader.Controls.Add(customInput1);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(999, 55);
            panelHeader.TabIndex = 3;
            // 
            // buttonCreateNewFilm
            // 
            buttonCreateNewFilm.AutoSize = true;
            buttonCreateNewFilm.BackColor = Color.White;
            buttonCreateNewFilm.FlatAppearance.BorderSize = 0;
            buttonCreateNewFilm.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCreateNewFilm.ForeColor = Color.Black;
            buttonCreateNewFilm.IsActivated = false;
            buttonCreateNewFilm.Location = new Point(735, 13);
            buttonCreateNewFilm.Name = "buttonCreateNewFilm";
            buttonCreateNewFilm.Size = new Size(121, 29);
            buttonCreateNewFilm.TabIndex = 6;
            buttonCreateNewFilm.Text = "Create film";
            buttonCreateNewFilm.UseVisualStyleBackColor = false;
            buttonCreateNewFilm.Visible = false;
            buttonCreateNewFilm.Click += buttonCreateNewFilm_Click;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Left;
            label1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(212, 54);
            label1.TabIndex = 5;
            label1.Text = "Find favorite movie";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // customComboBox1
            // 
            customComboBox1.BackColor = Color.FromArgb(230, 230, 230);
            customComboBox1.Location = new Point(579, 13);
            customComboBox1.Name = "customComboBox1";
            customComboBox1.Padding = new Padding(3, 2, 3, 2);
            customComboBox1.Size = new Size(150, 29);
            customComboBox1.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDarkDark;
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 54);
            panel1.Name = "panel1";
            panel1.Size = new Size(999, 1);
            panel1.TabIndex = 3;
            // 
            // customInput1
            // 
            customInput1.AutoSize = true;
            customInput1.BackColor = Color.FromArgb(230, 230, 230);
            customInput1.IsInvalid = false;
            customInput1.Location = new Point(228, 13);
            customInput1.Margin = new Padding(0);
            customInput1.MinimumSize = new Size(70, 25);
            customInput1.Name = "customInput1";
            customInput1.Padding = new Padding(3, 2, 3, 2);
            customInput1.Placeholder = "Search a film";
            customInput1.Size = new Size(348, 29);
            customInput1.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 55);
            flowLayoutPanel1.Margin = new Padding(10);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(5, 5, 0, 0);
            flowLayoutPanel1.Size = new Size(999, 540);
            flowLayoutPanel1.TabIndex = 4;
            // 
            // SearchFilmList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panelHeader);
            Name = "SearchFilmList";
            Size = new Size(999, 595);
            Load += SearchFilmList_Load;
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private components.CustomInput customInput1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private components.CustomComboBox customComboBox1;
        private components.Label label1;
        private components.CustomButton buttonCreateNewFilm;
    }
}
