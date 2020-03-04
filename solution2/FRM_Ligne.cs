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
    public partial class FRM_Ligne : Form
    {
        public FRM_Ligne()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Gestionaire de stock")
            { ligneDAO.Insert_ligne(textBox1.Text, textBox2.Text, int.Parse(textBox3.Text), textBox4.Text); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Gestionaire de stock")
            { ligneDAO.Update_ligne(textBox1.Text, textBox2.Text, int.Parse(textBox3.Text), textBox4.Text); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Gestionaire de stock")
            { ligneDAO.supprimer(textBox1.Text); }
        }
    }
}
