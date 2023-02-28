namespace CPProject.components
{
    public partial class CustomComboBox : UserControl
    {
        public CustomComboBox()
        {
            InitializeComponent();
            comboBox1.FlatStyle = FlatStyle.Flat;
            comboBox1.Font = new Font("Arial", 12);
        }
        public ComboBox ComboBoxElement
        {
            get { return comboBox1; }
            set { comboBox1 = value; }
        }
    }
}
