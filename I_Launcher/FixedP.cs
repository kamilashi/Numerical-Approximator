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
    public partial class FixedP : Form
    {
        public FixedP()
        {
            InitializeComponent();
            FixedP_text.ReadOnly = true;
            FixedP_text.BorderStyle = 0;
            FixedP_text.BackColor = this.BackColor;
            FixedP_text.TabStop = false;
        }

        private void FixedP_Load(object sender, EventArgs e)
        {

        }
    }
}
