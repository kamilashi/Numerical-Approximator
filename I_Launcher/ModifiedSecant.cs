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
    public partial class ModifiedSecant : Form
    {
        public ModifiedSecant()
        {
            InitializeComponent();
            ModifiedSecant_text.ReadOnly = true;
            ModifiedSecant_text.BorderStyle = 0;
            ModifiedSecant_text.BackColor = this.BackColor;
            ModifiedSecant_text.TabStop = false;
        }

        private void ModifiedSecant_Load(object sender, EventArgs e)
        {

        }
    }
}
