using CPProject.GlobalStates;

namespace CPProject.Forms
{
    public partial class AuthorizationForm : Form
    {
        public AuthorizationForm()
        {
            InitializeComponent();
            this.TopMost = true;
        }

        private void customButton2_Click(object sender, EventArgs e)
        {
            if (AuthorizationState.Instance.logIn(inputLogin.TextBoxText, inputPassword.TextBoxText))
            {
                this.Close();
            }
        }
    }
}
