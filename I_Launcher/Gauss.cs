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
    public partial class Gauss : Form
    {
        public Gauss()
        {
            InitializeComponent();
            Gauss_text.ReadOnly = true;
            Gauss_text.BorderStyle = 0;
            Gauss_text.BackColor = this.BackColor;
            Gauss_text.TabStop = false;
        }

        private void Gauss_Load(object sender, EventArgs e)
        {

        }
    }
}
