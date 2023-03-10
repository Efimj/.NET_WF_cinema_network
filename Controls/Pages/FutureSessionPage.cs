using CPProject.components.ui;
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
    public partial class FutureSessionPage : UserControl
    {
        public FutureSessionPage()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
        }

        private void FutureSessionPage_Load(object sender, EventArgs e)
        {


            customDataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            customDataGridView1.RowTemplate.Height = 50;
            for (int i = 0; i < 5; i++)
            {
                customDataGridView1.Rows.Add(
                Properties.Resources.spase3,
                "Pleasantville",
                DateTime.Now.ToString(),
                "123 Oak Street, Springfield, IL 62704",
                "32",
                "12 usd"
                );
                customDataGridView1.Rows.Add(
                Properties.Resources.spase1,
                "When a young.",
                DateTime.Now.ToString(),
                "456 Elm Avenue, Pleasantville, OH 44134",
                "32",
                "15 usd"
                );
                customDataGridView1.Rows.Add(
                Properties.Resources.spase1,
                "The Lost Key",
                DateTime.Now.ToString(),
                "345 Pineapple Boulevard, Honolulu, HI 96815",
                "32",
                "16 usd"
                );
            }

        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            CreateSessionPage createSessionPage = new CreateSessionPage();
            setNewPage(createSessionPage);
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
    }
}
