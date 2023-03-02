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
        public FilmPage()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }

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
        private void setNewPage(UserControl page)
        {
            this.Hide();
            Panel? parentPanel = (Panel?)this.Parent;
            if (parentPanel != null)
            {
                CreateReview createFilmPage = new CreateReview();
                parentPanel.Controls.Add(page);
            }
        }

        private void customButton3_Click(object sender, EventArgs e)
        {
            CreateReview createReview = new CreateReview();
            setNewPage(createReview);
        }

        private void buttonEditFilm_Click(object sender, EventArgs e)
        {
            CreateFilmPage createFilmPage = new CreateFilmPage();
            setNewPage(createFilmPage);
        }

        private void customButton2_Click(object sender, EventArgs e)
        {
            TicketPurchasePage ticketPurchasePage = new TicketPurchasePage();
            setNewPage(ticketPurchasePage);
        }
    }
}
