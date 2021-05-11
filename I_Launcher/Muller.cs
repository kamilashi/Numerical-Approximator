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
    public partial class Muller : Form
    {
        public Muller()
        {
            InitializeComponent();
            Muller_text.ReadOnly = true;
            Muller_text.BorderStyle = 0;
            Muller_text.BackColor = this.BackColor;
            Muller_text.TabStop = false;
        }

        private void Muller_Load(object sender, EventArgs e)
        {

        }
    }
}
