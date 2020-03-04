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

namespace Winforms
{
    public partial class authentification : Form
    {
        public authentification()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (utilisateurDAO.verif(textBox1.Text, textBox2.Text) == true)
            {
                //FRM_Menu fr = new FRM_Menu();
                //fr.ShowDialog();
                this.Close();
            }
            else
                MessageBox.Show("vérifier SVP");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
