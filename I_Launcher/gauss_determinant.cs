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
    public partial class Determinant : Form
    {
        public Determinant()
        {
            InitializeComponent();
            
            Determinant_text.ReadOnly = true;
            Determinant_text.BorderStyle = 0;
            Determinant_text.BackColor = this.BackColor;
            Determinant_text.TabStop = false;
        }

        private void Determinant_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Determinant_text_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
