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
    public partial class Inverse : Form
    {
        public Inverse()
        {
            InitializeComponent();
            Inverse_text.ReadOnly = true;
            Inverse_text.BorderStyle = 0;
            Inverse_text.BackColor = this.BackColor;
            Inverse_text.TabStop = false;
        }

        private void Inverse_Load(object sender, EventArgs e)
        {

        }
    }
}
