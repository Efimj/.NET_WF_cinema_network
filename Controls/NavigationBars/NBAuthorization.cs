using CPProject.components;
using CPProject.Controls;
using CPProject.Controls.Pages;
using CPProject.Forms;

namespace CPProject
{
    public partial class NBAuthorization : UserControl
    {
        public NBAuthorization(Panel pagePanel)
        {
            InitializeComponent();
            this.pagePanel = pagePanel;
            pagePanel.Controls.Clear();
            pagePanel.Controls.Add(new SearchFilmList());
            setButtonActive(buttonFilmPage);
        }
        private Panel pagePanel;
        private CustomButton? lastButtonActivated;
        private void setButtonActive(CustomButton nextButton)
        {
            if (lastButtonActivated != null)
            {
                lastButtonActivated.IsActivated = false;
            }
            nextButton.IsActivated = true;
            lastButtonActivated = nextButton;
        }

        private void AppNavBar_Load(object sender, EventArgs e)
        {
            BackColor = Color.White;
            Dock = DockStyle.Fill;
        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            new AuthorizationForm().ShowDialog(this);
        }

        private void customButton2_Click(object sender, EventArgs e)
        {
            new RegistrationForm().ShowDialog(this);
        }

        private void buttonFutureSessions_Click(object sender, EventArgs e)
        {
            setButtonActive(buttonFutureSessions);
            pagePanel.Controls.Clear();
            pagePanel.Controls.Add(new FutureSessionPage());
        }

        private void buttonFilmPage_Click(object sender, EventArgs e)
        {
            setButtonActive(buttonFilmPage);
            pagePanel.Controls.Clear();
            pagePanel.Controls.Add(new SearchFilmList());
        }
    }
}
