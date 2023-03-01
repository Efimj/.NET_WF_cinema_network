using CPProject.components;
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
    public partial class FilmPage : UserControl
    {
        public FilmPage(Action goBack)
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            this.goBack = goBack;
        }

        private Action goBack;

        private void FilmPage_Load(object sender, EventArgs e)
        {
            panelNoReviews.Visible = false;
            editPanelVisibleSetMode(AuthorizationState.Instance.UsersType);
            AuthorizationState.Instance.subscribeOnChange((EUsersType s) =>
            {
                editPanelVisibleSetMode(s);
            });
            for (int i = 0; i < 30; i++)
            {
                flowLayoutPanelReviews.Controls.Add(new UserReviewItem());
            }
        }

        private void editPanelVisibleSetMode(EUsersType s)
        {
            if (s == EUsersType.Administrator)
            {
                buttonEditFilm.Visible = true;
            }
            else
            {
                buttonEditFilm.Visible = false;
            }
        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            goBack?.Invoke();
            this.DestroyHandle();
        }
    }
}
