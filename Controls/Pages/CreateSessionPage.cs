using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPProject.Controls.Pages
{
    public partial class CreateSessionPage : UserControl
    {
        public CreateSessionPage()
        {
            InitializeComponent();
        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            goBack();
        }

        private void goBack()
        {
            this.Hide();
            Panel? parentPanel = (Panel?)this.Parent;
            if (parentPanel != null)
            {
                parentPanel.Controls.RemoveAt(parentPanel.Controls.Count - 1);
                parentPanel.Controls[parentPanel.Controls.Count - 1].Show();
            }
            this.DestroyHandle();
        }
    }
}
