using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace I_Launcher
{
    public partial class GaussNaive : Form
    {
        public GaussNaive()
        {
            InitializeComponent();
            GaussNaive_text.ReadOnly = true;
            GaussNaive_text.BorderStyle = 0;
            GaussNaive_text.BackColor = this.BackColor;
            GaussNaive_text.TabStop = false;
        }

        private void GaussNaive_Load(object sender, EventArgs e)
        {

        }
    }
}
