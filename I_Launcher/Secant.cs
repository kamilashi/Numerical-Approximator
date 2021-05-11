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
    public partial class Secant : Form
    {
        public Secant()
        {
            InitializeComponent();
            Secant_text.ReadOnly = true;
            Secant_text.BorderStyle = 0;
            Secant_text.BackColor = this.BackColor;
            Secant_text.TabStop = false;
        }

        private void Secant_Load(object sender, EventArgs e)
        {

        }
    }
}
