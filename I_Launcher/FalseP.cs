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
    public partial class FalseP : Form
    {
        public FalseP()
        {
            InitializeComponent();
            FalseP_text.ReadOnly = true;
            FalseP_text.BorderStyle = 0;
            FalseP_text.BackColor = this.BackColor;
            FalseP_text.TabStop = false;
        }

        private void FalseP_Load(object sender, EventArgs e)
        {

        }
    }
}
