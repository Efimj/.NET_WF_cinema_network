namespace CPProject.Forms
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
            this.TopMost = true;
            buttonRegistrationDisable();
            dateTimePickerAge.MaxDate = DateTime.Today.AddYears(-minAge);
        }

        private int minAge = 12;
        private string loginValue = "";
        private string passwordValue = "";
        private string passwordRepeteValue = "";
        private DateTime ageValue;

        private void validateAll()
        {
            if (!loginValidate())
            {
                buttonRegistrationDisable();
                return;
            }
            if (!passwordValidate())
            {
                buttonRegistrationDisable();
                return;
            }
            if (!passwordRepeateValidate())
            {
                buttonRegistrationDisable();
                return;
            }
            if (!ageValidate())
            {
                buttonRegistrationDisable();
                return;
            }
            buttonRegistrationActivate();
        }

        private void buttonRegistrationActivate()
        {
            buttonRegistration.Enabled = true;
            buttonRegistration.IsActivated = true;

        }

        private void buttonRegistrationDisable()
        {
            buttonRegistration.Enabled = false;
            buttonRegistration.IsActivated = false;
        }

        private bool loginValidate()
        {
            if (loginValue.Length < 1)
            {
                inputLogin.IsInvalid = true;
                return false;
            }
            inputLogin.IsInvalid = false;
            return true;
        }
        private bool passwordValidate()
        {
            if (passwordValue.Length < 1)
            {
                inputPassword.IsInvalid = true;
                return false;
            }
            inputPassword.IsInvalid = false;
            return true;
        }
        private bool passwordRepeateValidate()
        {
            if (passwordRepeteValue != passwordValue)
            {
                inputRepeatePassword.IsInvalid = true;
                return false;
            }
            inputRepeatePassword.IsInvalid = false;
            return true;
        }
        private bool ageValidate()
        {
            if (ageValue > (DateTime.Today.AddYears(-minAge)))
            {
                return false;
            }
            return true;
        }

        private void inputLogin_OnChangeTex(object sender, EventArgs e)
        {
            loginValue = inputLogin.TextBoxText;
            validateAll();
        }

        private void input2_OnChangeTex(object sender, EventArgs e)
        {
            passwordValue = inputPassword.TextBoxText;
            validateAll();
        }

        private void inputRepeatePassword_CustomInputChanged(object sender, EventArgs e)
        {
            passwordRepeteValue = inputRepeatePassword.Text;
            validateAll();
        }

        private void dateTimePickerAge_ValueChanged(object sender, EventArgs e)
        {
            ageValue = dateTimePickerAge.Value;
            validateAll();
        }

        private void buttonRegistration_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
