using CPProject.GlobalStates;
using CPProject.types;
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
    public partial class CreateFilmPage : UserControl
    {
        public CreateFilmPage(Action goBack)
        {
            InitializeComponent();
            this.goBack = goBack;
            Dock = DockStyle.Fill;
        }
        private Action goBack;
        private void buttonBack_Click(object sender, EventArgs e)
        {
            goBack?.Invoke();
        }

        private void CreateFilmPage_Load(object sender, EventArgs e)
        {
        }
    }
}
