using CPProject.types;

namespace CPProject.components
{
    public partial class CustomInput : UserControl
    {
        public CustomInput()
        {
            InitializeComponent();
            panelIndicator.BackColor = ColorPalette.InputColor;
        }
        private bool isInvalid = false;
        public bool IsInvalid
        {
            get { return isInvalid; }
            set
            {
                isInvalid = value;
                if (value)
                {
                    panelIndicator.BackColor = ColorPalette.Orange;
                }
                else
                {
                    panelIndicator.BackColor = ColorPalette.InputColor;
                }
            }
        }
        public string Placeholder
        {
            get { return textBox.PlaceholderText; }
            set { textBox.PlaceholderText = value; }
        }
        public new string Text
        {
            get { return textBox.Text; }
            set { textBox.Text = value; }
        }
        public event EventHandler CustomInputChanged;
        private void textBox_TextChanged(object sender, EventArgs e)
        {
            CustomInputChanged?.Invoke(this, e);
        }
    }
}
