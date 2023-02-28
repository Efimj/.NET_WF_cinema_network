using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPProject.components.ui
{
    public partial class CustomDataGridView : DataGridView
    {
        public CustomDataGridView()
        {
            InitializeComponent();
            BackgroundColor = Color.White;
            RowHeadersVisible = false;
            RowTemplate.Height = 30;
        }
    }
}
