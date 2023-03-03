using CPProject.components;
using CPProject.Controls.Pages;
using CPProject.GlobalStates;

namespace CPProject.Controls
{
    public partial class NBCustomer : UserControl
    {
        public NBCustomer(Panel pagePanel)
        {
            InitializeComponent();
            pagePanel.Controls.Clear();
            pagePanel.Controls.Add(new SearchFilmList());
            this.pagePanel = pagePanel;
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

        private void NBCustomer_Load(object sender, EventArgs e)
        {
            BackColor = Color.White;
            Dock = DockStyle.Fill;
        }

        private void goOnTopMost()
        {
            for (int i = 0; i < Application.OpenForms.Count; i++)
            {
                Application.OpenForms[i].TopMost = true;
            }
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
            "Are you sure you want to log out of your account?",
            "Message",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button1,
            MessageBoxOptions.DefaultDesktopOnly);
            if (result == DialogResult.Yes)
            {
                AuthorizationState.Instance.logOut();
            }
            goOnTopMost();
        }

        private void buttonFilmPage_Click(object sender, EventArgs e)
        {
            setButtonActive(buttonFilmPage);
            pagePanel.Controls.Clear();
            pagePanel.Controls.Add(new SearchFilmList());
        }

        private void buttonFutureSessions_Click(object sender, EventArgs e)
        {
            setButtonActive(buttonFutureSessions);
            pagePanel.Controls.Clear();
        }

        private void buttonReviews_Click(object sender, EventArgs e)
        {
            setButtonActive(buttonReviews);
            pagePanel.Controls.Clear();
        }

        private void buttonAccountSettings_Click(object sender, EventArgs e)
        {
            setButtonActive(buttonAccountSettings);
            pagePanel.Controls.Clear();
            pagePanel.Controls.Add(new UserSettingsPage());
        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            setButtonActive(buttonActiveTickets);
            pagePanel.Controls.Clear();
        }

        private void buttonSessionArchive_Click(object sender, EventArgs e)
        {
            setButtonActive(buttonSessionArchive);
            pagePanel.Controls.Clear();
        }
    }
}
