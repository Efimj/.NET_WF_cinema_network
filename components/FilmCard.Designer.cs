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
            labelFilmName = new System.Windows.Forms.Label();
            labelFilmDescription = new System.Windows.Forms.Label();
            pictureBoxFilmPoster = new PictureBox();
            panel1 = new Panel();
            panel2 = new Panel();
            ratingControl1 = new ui.RatingControl();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFilmPoster).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // labelFilmName
            // 
            labelFilmName.BackColor = Color.White;
            labelFilmName.Dock = DockStyle.Top;
            labelFilmName.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelFilmName.Location = new Point(0, 0);
            labelFilmName.Name = "labelFilmName";
            labelFilmName.Padding = new Padding(8, 0, 0, 0);
            labelFilmName.Size = new Size(258, 30);
            labelFilmName.TabIndex = 3;
            labelFilmName.Text = "FilmName";
            labelFilmName.TextAlign = ContentAlignment.BottomLeft;
            labelFilmName.Click += labelFilmName_Click;
            // 
            // labelFilmDescription
            // 
            labelFilmDescription.BackColor = Color.White;
            labelFilmDescription.Dock = DockStyle.Bottom;
            labelFilmDescription.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelFilmDescription.Location = new Point(0, 286);
            labelFilmDescription.Name = "labelFilmDescription";
            labelFilmDescription.Padding = new Padding(5);
            labelFilmDescription.Size = new Size(258, 80);
            labelFilmDescription.TabIndex = 1;
            labelFilmDescription.Text = "Description";
            labelFilmDescription.Click += labelFilmDescription_Click;
            // 
            // pictureBoxFilmPoster
            // 
            pictureBoxFilmPoster.BackColor = Color.White;
            pictureBoxFilmPoster.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBoxFilmPoster.Dock = DockStyle.Top;
            pictureBoxFilmPoster.Image = (Image)resources.GetObject("pictureBoxFilmPoster.Image");
            pictureBoxFilmPoster.Location = new Point(0, 0);
            pictureBoxFilmPoster.Name = "pictureBoxFilmPoster";
            pictureBoxFilmPoster.Size = new Size(258, 225);
            pictureBoxFilmPoster.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxFilmPoster.TabIndex = 0;
            pictureBoxFilmPoster.TabStop = false;
            pictureBoxFilmPoster.Click += pictureBoxFilmPoster_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(labelFilmName);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 225);
            panel1.Name = "panel1";
            panel1.Size = new Size(258, 61);
            panel1.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(ratingControl1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 30);
            panel2.Name = "panel2";
            panel2.Size = new Size(258, 31);
            panel2.TabIndex = 4;
            // 
            // ratingControl1
            // 
            ratingControl1.BackColor = Color.White;
            ratingControl1.CurrentReting = 4;
            ratingControl1.Dock = DockStyle.Right;
            ratingControl1.Editable = false;
            ratingControl1.Location = new Point(120, 0);
            ratingControl1.Margin = new Padding(0);
            ratingControl1.Name = "ratingControl1";
            ratingControl1.Padding = new Padding(0, 0, 10, 0);
            ratingControl1.Size = new Size(138, 31);
            ratingControl1.TabIndex = 0;
            // 
            // FilmCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(panel1);
            Controls.Add(labelFilmDescription);
            Controls.Add(pictureBoxFilmPoster);
            Cursor = Cursors.Hand;
            Name = "FilmCard";
            Size = new Size(258, 366);
            MouseClick += FilmCard_MouseClick;
            ((System.ComponentModel.ISupportInitialize)pictureBoxFilmPoster).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label labelFilmName;
        private System.Windows.Forms.Label labelFilmDescription;
        private PictureBox pictureBoxFilmPoster;
        private Panel panel1;
        private Panel panel2;
        private ui.RatingControl ratingControl1;
    }
}
