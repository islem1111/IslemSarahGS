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
    public partial class inscription : System.Windows.Forms.Form
    {
        public inscription()
        {
            InitializeComponent();
        }

        private void inscription_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (utilisateurDAO.verif(textBox1.Text, "0"))

            {
                if (utilisateurDAO.Ajout(int.Parse(textBox1.Text), textBox2.Text, textBox3.Text, textBox4.Text, textBox8.Text, textBox7.Text, textBox6.Text, textBox5.Text, int.Parse(textBox9.Text)))
                {
                    MessageBox.Show("inscription réussite");
                }

                else
                { MessageBox.Show("Erreur"); }
            }
            else
                MessageBox.Show("changer l'ID SVP");
        }
    }
}
