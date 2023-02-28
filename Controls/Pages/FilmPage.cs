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
            editPanelVisibleSetMode(AuthorizationState.Instance.UsersType);
            AuthorizationState.Instance.subscribeOnChange((EUsersType s) =>
            {
                editPanelVisibleSetMode(s);
            });
            //CustomButton btn = new CustomButton();
            //btn.Text = "By ticket";
            //btn.Dock = DockStyle.Fill;
            //btn.Click += (object sender, EventArgs e) =>
            //{
            //    panelByTicket.Controls.Clear();
            //    components.Label ls = new components.Label();
            //    ls.Text = "no tickets";
            //    ls.Dock = DockStyle.Fill;
            //    ls.Font = new Font("Arial", 12);
            //    ls.TextAlign = ContentAlignment.MiddleCenter;
            //    panelByTicket.Controls.Add(ls);
            //};
            //panelByTicket.Controls.Add(btn);

            //for (int i = 0; i < 30; i++)
            //{
            //    flowLayoutPanelReviews.Controls.Add(new UserReviewItem());
            //}
            //CustomButton btn2 = new CustomButton();
            //btn2.Text = "Make review";
            //btn2.Dock = DockStyle.Fill;
            //panelReviewCreate.Controls.Add(btn2);
        }

        private void editPanelVisibleSetMode(EUsersType s)
        {
            if (s == EUsersType.Administrator)
            {
                panelFilmEdit.Visible = true;
            }
            else
            {
                panelFilmEdit.Visible = false;
            }
        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            goBack?.Invoke();
            this.DestroyHandle();
        }
    }
}
