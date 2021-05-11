using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Media;

namespace I_Launcher
{
    public partial class Form11 : Form
    {
        SoundPlayer player = new SoundPlayer();
        public Form11()
        {
            InitializeComponent();
            //Console.WriteLine("WELCOME TO NUMERICAL METHODS!");
            //MessageBox.Show("SOUND ON recommended for the full experience!");
            menuStrip1.ForeColor = Color.Cyan;
            this.Icon = Properties.Resources.icon_s;
            //Title.Parent = this;
            //buttonClose.Parent = this;

        }
        private NAudio.Wave.WaveFileReader wave = null;

        private NAudio.Wave.DirectSoundOut output = null;

        
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            if (output != null)
            {
                output.Pause();


                buttonPlay.Visible = true;
                buttonMute.Visible = false;
            }

        }

        private void buttonPlay_Click_1(object sender, EventArgs e)
        {
            if (output != null)
            {
                output.Play();
                buttonMute.Visible = true;
                buttonPlay.Visible = false;
            }

        }
        private void DisposeWave()
        {
            if (output != null)
            {
                if (buttonMute.Visible == true) output.Stop();
                output.Dispose();
                output = null;
            }
            if (wave != null)
            {
                wave.Dispose();
                wave = null;

            }
        }

        private void Form11_Load_1(object sender, EventArgs e)
        {
            //AllocConsole();
            buttonMute.Parent = this;
            buttonPlay.Parent = this;
            wave = new NAudio.Wave.WaveFileReader("lofi.wav");
            output = new NAudio.Wave.DirectSoundOut();
            output.Init(new NAudio.Wave.WaveChannel32(wave));
            output.Play();

            buttonMute.Enabled = true;
            buttonPlay.Visible = false;
            buttonMute.Visible = true;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void codeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void showCodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Determinant show code
            Determinant window = new Determinant();
            window.Show();
        }

        private void runProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Determinant run Prog
            System.Diagnostics.Process.Start("gauss_det_fin.exe");
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
            DisposeWave();

        }

        private void runProgramToolStripMenuItem6_Click(object sender, EventArgs e)
        {

        }

        private void runProgramToolStripMenuItem1_Click(object sender, EventArgs e)
        {   
            System.Diagnostics.Process.Start("matrix_inverse_fin.exe");
        }

        private void runProgramToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Muller_no_complex_fin.exe");
        }

        private void runProgramToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            //System.Diagnostics.Process.Start("bisection_fin.exe");
        }

        private void runProgramToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            //System.Diagnostics.Process.Start("false_position_fin.exe");
        }

        private void runProgramToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("gauss_new_pivot_fin.exe");
        }

        private void runProgramToolStripMenuItem7_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("cosine_fin.exe");
        }

        private void runProgramToolStripMenuItem8_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("gauss_elimination_matrix_naive_fin.exe");
        }

        private void runProgramToolStripMenuItem3_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("bisection_fin.exe");
        }

        private void runProgramToolStripMenuItem4_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("false_position_fin.exe");
        }

        private void runProgramToolStripMenuItem9_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("fixed_point_fin.exe");
        }

        private void runProgramToolStripMenuItem11_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("secant_fin.exe");
        }

        private void showCodeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Inverse window = new Inverse();
            window.Show();
        }
        
        private void showCodeToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Muller window = new Muller();
            window.Show();
        }

        private void showCodeToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Bisection window = new Bisection();
            window.Show();
        }

        private void showCodeToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            FalseP window = new FalseP();
            window.Show();
        }

        private void showCodeToolStripMenuItem9_Click(object sender, EventArgs e)
        {
            FixedP window = new FixedP();
            window.Show();
        }

        private void showCodeToolStripMenuItem10_Click(object sender, EventArgs e)
        {
            Secant window = new Secant();
            window.Show();
        }

        private void showCodeToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            Gauss window = new Gauss();
            window.Show();
        }

        private void showCoseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cos window = new Cos();
            window.Show();
        }

        private void showCodeToolStripMenuItem7_Click(object sender, EventArgs e)
        {
            GaussNaive window = new GaussNaive();
            window.Show();
        }

        private void eQUATION2ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void showCodeToolStripMenuItem8_Click(object sender, EventArgs e)
        {
            ModifiedSecant window = new ModifiedSecant();
            window.Show();
        }

        private void runProgramToolStripMenuItem10_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("modified_secant_fin.exe");
        }
    }
}
