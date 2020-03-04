using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;

namespace Winforms
{
    public partial class FRM_PF : Form
    {
        public FRM_PF()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Gestionaire de stock")
            { Produit_finiDAO.supprimer(textBox1.Text); }
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
           

           
            if (comboBox1.Text == "Gestionaire de stock")
            { Produit_finiDAO.Inserer(textBox1.Text, textBox2.Text, float.Parse(textBox3.Text), pictureBox1.Text, float.Parse(textBox4.Text), float.Parse(textBox6.Text), float.Parse(textBox5.Text)); }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           

          
            if (comboBox1.Text == "Gestionaire de stock")
            { Produit_finiDAO.Modifier(textBox1.Text, textBox2.Text, float.Parse(textBox3.Text), pictureBox1.Text, float.Parse(textBox4.Text), float.Parse(textBox6.Text), float.Parse(textBox5.Text)); }
        }
    }
}
