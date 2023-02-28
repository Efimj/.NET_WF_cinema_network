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
                Image.FromFile(@"D:\Course 2\Semestr 2\ООП КП\CP project\CPProject\images\spase1.jpg"),
                "Pleasantville",
                DateTime.Now.ToString(),
                "123 Oak Street, Springfield, IL 62704",
                "32",
                "12 usd"
                );
                customDataGridView1.Rows.Add(
                Image.FromFile(@"D:\Course 2\Semestr 2\ООП КП\CP project\CPProject\images\spase2.jpg"),
                "When a young.",
                DateTime.Now.ToString(),
                "456 Elm Avenue, Pleasantville, OH 44134",
                "32",
                "15 usd"
                );
                customDataGridView1.Rows.Add(
                Image.FromFile(@"D:\Course 2\Semestr 2\ООП КП\CP project\CPProject\images\spase3.jpg"),
                "The Lost Key",
                DateTime.Now.ToString(),
                "345 Pineapple Boulevard, Honolulu, HI 96815",
                "32",
                "16 usd"
                );
            }

        }
    }
}
