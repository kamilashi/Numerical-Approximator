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
    public partial class Cos : Form
    {
        public Cos()
        {
            InitializeComponent();
            Cos_text.ReadOnly = true;
            Cos_text.BorderStyle = 0;
            Cos_text.BackColor = this.BackColor;
            Cos_text.TabStop = false;
        }

        private void Cos_Load(object sender, EventArgs e)
        {

        }
    }
}
