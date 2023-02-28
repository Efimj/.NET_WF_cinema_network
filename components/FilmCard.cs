namespace CPProject.components
{
    public partial class FilmCard : UserControl
    {
        public FilmCard()
        {
            InitializeComponent();
        }
        public System.Windows.Forms.Label FilmNameLable
        {
            get
            {
                return labelFilmName;
            }
            set
            {
                labelFilmName = value;
            }
        }
        public System.Windows.Forms.Label FilmDescriptionLable
        {
            get
            {
                return labelFilmDescription;
            }
            set
            {
                labelFilmDescription = value;
            }
        }
        public System.Windows.Forms.Label FilmRatingLable
        {
            get
            {
                return labelFilmRaiting;
            }
            set
            {
                labelFilmRaiting = value;
            }
        }
        public PictureBox FilmPoster
        {
            get
            {
                return pictureBoxFilmPoster;
            }
            set
            {
                pictureBoxFilmPoster = value;
            }
        }

        public delegate void OnFilmClick();
        public event OnFilmClick filmClickEvent;

        private void FilmCard_MouseClick(object sender, MouseEventArgs e)
        {
            filmClickEvent?.Invoke();
        }

        private void pictureBoxFilmPoster_Click(object sender, EventArgs e)
        {
            filmClickEvent?.Invoke();
        }

        private void labelFilmName_Click(object sender, EventArgs e)
        {
            filmClickEvent?.Invoke();
        }

        private void labelFilmRaiting_Click(object sender, EventArgs e)
        {
            filmClickEvent?.Invoke();
        }

        private void labelFilmDescription_Click(object sender, EventArgs e)
        {
            filmClickEvent?.Invoke();
        }
    }
}
