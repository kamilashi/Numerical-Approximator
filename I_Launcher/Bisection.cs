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
    public partial class Bisection : Form
    {
        public Bisection()
        {
            InitializeComponent();
            Bisection_text.ReadOnly = true;
            Bisection_text.BorderStyle = 0;
            Bisection_text.BackColor = this.BackColor;
            Bisection_text.TabStop = false;
        }

        private void Bisection_Load(object sender, EventArgs e)
        {

        }
    }
}
