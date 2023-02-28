namespace CPProject.components
{
    partial class FilmCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FilmCard));
            pictureBoxFilmPoster = new PictureBox();
            labelFilmDescription = new System.Windows.Forms.Label();
            labelFilmRaiting = new System.Windows.Forms.Label();
            labelFilmName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFilmPoster).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxFilmPoster
            // 
            pictureBoxFilmPoster.BackColor = Color.White;
            pictureBoxFilmPoster.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBoxFilmPoster.Dock = DockStyle.Top;
            pictureBoxFilmPoster.Image = (Image)resources.GetObject("pictureBoxFilmPoster.Image");
            pictureBoxFilmPoster.Location = new Point(0, 0);
            pictureBoxFilmPoster.Name = "pictureBoxFilmPoster";
            pictureBoxFilmPoster.Size = new Size(258, 247);
            pictureBoxFilmPoster.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxFilmPoster.TabIndex = 0;
            pictureBoxFilmPoster.TabStop = false;
            pictureBoxFilmPoster.Click += pictureBoxFilmPoster_Click;
            // 
            // labelFilmDescription
            // 
            labelFilmDescription.BackColor = Color.White;
            labelFilmDescription.Dock = DockStyle.Bottom;
            labelFilmDescription.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelFilmDescription.Location = new Point(0, 288);
            labelFilmDescription.Name = "labelFilmDescription";
            labelFilmDescription.Padding = new Padding(5, 0, 5, 5);
            labelFilmDescription.Size = new Size(258, 78);
            labelFilmDescription.TabIndex = 1;
            labelFilmDescription.Text = "Description";
            labelFilmDescription.Click += labelFilmDescription_Click;
            // 
            // labelFilmRaiting
            // 
            labelFilmRaiting.BackColor = Color.White;
            labelFilmRaiting.Dock = DockStyle.Right;
            labelFilmRaiting.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelFilmRaiting.Location = new Point(220, 247);
            labelFilmRaiting.Name = "labelFilmRaiting";
            labelFilmRaiting.Size = new Size(38, 41);
            labelFilmRaiting.TabIndex = 2;
            labelFilmRaiting.Text = "5/5";
            labelFilmRaiting.TextAlign = ContentAlignment.MiddleCenter;
            labelFilmRaiting.Click += labelFilmRaiting_Click;
            // 
            // labelFilmName
            // 
            labelFilmName.BackColor = Color.White;
            labelFilmName.Dock = DockStyle.Fill;
            labelFilmName.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelFilmName.Location = new Point(0, 247);
            labelFilmName.Name = "labelFilmName";
            labelFilmName.Padding = new Padding(8, 0, 0, 0);
            labelFilmName.Size = new Size(220, 41);
            labelFilmName.TabIndex = 3;
            labelFilmName.Text = "FilmName";
            labelFilmName.TextAlign = ContentAlignment.MiddleLeft;
            labelFilmName.Click += labelFilmName_Click;
            // 
            // FilmCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(labelFilmName);
            Controls.Add(labelFilmRaiting);
            Controls.Add(labelFilmDescription);
            Controls.Add(pictureBoxFilmPoster);
            Cursor = Cursors.Hand;
            Name = "FilmCard";
            Size = new Size(258, 366);
            MouseClick += FilmCard_MouseClick;
            ((System.ComponentModel.ISupportInitialize)pictureBoxFilmPoster).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBoxFilmPoster;
        private System.Windows.Forms.Label labelFilmDescription;
        private System.Windows.Forms.Label labelFilmRaiting;
        private System.Windows.Forms.Label labelFilmName;
    }
}
