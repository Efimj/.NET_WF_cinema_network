namespace CPProject
{
    public partial class InputLableIndicated : UserControl
    {
        public InputLableIndicated()
        {
            InitializeComponent();
        }

        public string? LableText
        {
            get { return label.Text; }
            set { label.Text = value; }
        }
        public string TextBoxText
        {
            get { return customInput1.Text; }
            set { customInput1.Text = value; }
        }
        public bool IsInvalid
        {
            get { return customInput1.IsInvalid; }
            set { customInput1.IsInvalid = value; }
        }

        public string Placeholder
        {
            get { return customInput1.Placeholder; }
            set { customInput1.Placeholder = value; }
        }

        public event EventHandler OnChangeTex;

        private void customInput1_CustomInputChanged(object sender, EventArgs e)
        {
            OnChangeTex?.Invoke(this, e);
        }
    }
}
