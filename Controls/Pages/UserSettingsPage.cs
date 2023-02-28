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
    public partial class UserSettingsPage : UserControl
    {
        public UserSettingsPage()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
            inputLogin.Text = "User1234";
        }
    }
}
