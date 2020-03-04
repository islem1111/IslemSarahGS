using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using BEL;

namespace Winforms
{
    public partial class FRM_Menu : Form
    {
        public FRM_Menu()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnutilisateur_Click(object sender, EventArgs e)
        {
            palbtn.Top = btnUT.Top;
            inscription fr = new inscription();
            fr.ShowDialog();
            this.Close();

        }

        private void btnMP_Click(object sender, EventArgs e)
        {
            palbtn.Top = btnMP.Top;
           FRM_MP fr = new FRM_MP ();
            fr.ShowDialog();
            this.Close();

        }

        private void btnOU_Click(object sender, EventArgs e)
        {
            palbtn.Top = btnOU.Top;
          FRM_Outillage fr = new FRM_Outillage();
           fr.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            palbtn.Top = btnMA.Top;
            FRM_Machine fr = new FRM_Machine();
            fr.ShowDialog();
            this.Close();
        }

        private void btnPF_Click(object sender, EventArgs e)
        {
            palbtn.Top = btnPF.Top;
            FRM_PF fr = new FRM_PF();
            fr.ShowDialog();
            this.Close();
        }

        private void btnPR_Click(object sender, EventArgs e)
        {
            palbtn.Top = btnPR.Top;
            FRM_PR fr = new FRM_PR();
            fr.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            palbtn.Top = btnLI.Top;
            FRM_Ligne fr = new FRM_Ligne();
            fr.ShowDialog();
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }
    }
}
