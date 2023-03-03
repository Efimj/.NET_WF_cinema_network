using CPProject.components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPProject.Controls.NavigationBars
{
    public partial class NBAdmin : UserControl
    {
        public NBAdmin(Panel pagePanel)
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

        private void NBAdmin_Load(object sender, EventArgs e)
        {
            BackColor = Color.White;
            Dock = DockStyle.Fill;
        }
    }
}
