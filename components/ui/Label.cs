using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CPProject.components
{
    public partial class Label : System.Windows.Forms.Label
    {
        public Label()
        {
            InitializeComponent();
            Font = new Font("Arial", 12);
        }
    }
}
