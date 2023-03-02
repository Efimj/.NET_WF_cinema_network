namespace CPProject.Controls.Pages
{
    partial class FutureSessionPage
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panelHeader = new Panel();
            customButton1 = new components.CustomButton();
            label1 = new components.Label();
            customComboBox1 = new components.CustomComboBox();
            panel1 = new Panel();
            customInput1 = new components.CustomInput();
            customDataGridView1 = new components.ui.CustomDataGridView();
            filmPicture = new DataGridViewImageColumn();
            filmName = new DataGridViewTextBoxColumn();
            sessionTime = new DataGridViewTextBoxColumn();
            address = new DataGridViewTextBoxColumn();
            countTickets = new DataGridViewTextBoxColumn();
            ticketPrice = new DataGridViewTextBoxColumn();
            panel2 = new Panel();
            panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)customDataGridView1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.White;
            panelHeader.Controls.Add(customButton1);
            panelHeader.Controls.Add(label1);
            panelHeader.Controls.Add(customComboBox1);
            panelHeader.Controls.Add(panel1);
            panelHeader.Controls.Add(customInput1);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(931, 55);
            panelHeader.TabIndex = 4;
            // 
            // customButton1
            // 
            customButton1.AutoSize = true;
            customButton1.BackColor = Color.White;
            customButton1.FlatAppearance.BorderSize = 0;
            customButton1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            customButton1.ForeColor = Color.Black;
            customButton1.IsActivated = false;
            customButton1.Location = new Point(735, 13);
            customButton1.Name = "customButton1";
            customButton1.Size = new Size(124, 29);
            customButton1.TabIndex = 6;
            customButton1.Text = "Create session";
            customButton1.UseVisualStyleBackColor = false;
            customButton1.Click += customButton1_Click;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Left;
            label1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(212, 54);
            label1.TabIndex = 5;
            label1.Text = "Find tickets";
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
            panel1.Size = new Size(931, 1);
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
            customInput1.Placeholder = "Search by film";
            customInput1.Size = new Size(348, 29);
            customInput1.TabIndex = 1;
            // 
            // customDataGridView1
            // 
            customDataGridView1.AllowUserToAddRows = false;
            customDataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle1.SelectionBackColor = Color.White;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            customDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            customDataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            customDataGridView1.BackgroundColor = Color.White;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            customDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            customDataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            customDataGridView1.Columns.AddRange(new DataGridViewColumn[] { filmPicture, filmName, sessionTime, address, countTickets, ticketPrice });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            customDataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            customDataGridView1.Dock = DockStyle.Fill;
            customDataGridView1.Location = new Point(15, 5);
            customDataGridView1.Name = "customDataGridView1";
            customDataGridView1.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Control;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            customDataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            customDataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            customDataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle6;
            customDataGridView1.RowTemplate.Height = 30;
            customDataGridView1.Size = new Size(870, 538);
            customDataGridView1.TabIndex = 5;
            // 
            // filmPicture
            // 
            filmPicture.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            filmPicture.HeaderText = "Preview";
            filmPicture.ImageLayout = DataGridViewImageCellLayout.Zoom;
            filmPicture.Name = "filmPicture";
            filmPicture.ReadOnly = true;
            // 
            // filmName
            // 
            filmName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            filmName.DefaultCellStyle = dataGridViewCellStyle3;
            filmName.HeaderText = "Film Name";
            filmName.Name = "filmName";
            filmName.ReadOnly = true;
            // 
            // sessionTime
            // 
            sessionTime.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            sessionTime.HeaderText = "Time";
            sessionTime.Name = "sessionTime";
            sessionTime.ReadOnly = true;
            // 
            // address
            // 
            address.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            address.HeaderText = "Address";
            address.Name = "address";
            address.ReadOnly = true;
            // 
            // countTickets
            // 
            countTickets.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            countTickets.HeaderText = "Count tickets";
            countTickets.Name = "countTickets";
            countTickets.ReadOnly = true;
            // 
            // ticketPrice
            // 
            ticketPrice.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ticketPrice.HeaderText = "Ticket price";
            ticketPrice.Name = "ticketPrice";
            ticketPrice.ReadOnly = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(customDataGridView1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 55);
            panel2.MaximumSize = new Size(900, 0);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(15, 5, 15, 15);
            panel2.Size = new Size(900, 558);
            panel2.TabIndex = 6;
            // 
            // FutureSessionPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(panel2);
            Controls.Add(panelHeader);
            Name = "FutureSessionPage";
            Size = new Size(931, 613);
            Load += FutureSessionPage_Load;
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)customDataGridView1).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private components.Label label1;
        private components.CustomComboBox customComboBox1;
        private Panel panel1;
        private components.CustomInput customInput1;
        private components.ui.CustomDataGridView customDataGridView1;
        private Panel panel2;
        private DataGridViewImageColumn filmPicture;
        private DataGridViewTextBoxColumn filmName;
        private DataGridViewTextBoxColumn sessionTime;
        private DataGridViewTextBoxColumn address;
        private DataGridViewTextBoxColumn countTickets;
        private DataGridViewTextBoxColumn ticketPrice;
        private components.CustomButton customButton1;
    }
}
