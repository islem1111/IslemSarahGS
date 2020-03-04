using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using DAL;

namespace Winforms
{
    public partial class FRM_MP : Form
    {
        public FRM_MP()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FRM_MP_Load(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
           
            if (comboBox1.Text == "Gestionaire de stock")
            { Matiere_premiereDAO.Insert_MatièrePremière(textBox1.Text, textBox2.Text, float.Parse(textBox3.Text), pictureBox1.Text, textBox4.Text, Convert.ToDateTime(dateTimePicker2.Text), Convert.ToDateTime(dateTimePicker1.Text)); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            if (comboBox1.Text == "Gestionaire de stock")
            { Matiere_premiereDAO.Update_Matière_Première(textBox1.Text, textBox2.Text, float.Parse(textBox3.Text),pictureBox1.Text, textBox4.Text, Convert.ToDateTime(dateTimePicker2.Text), Convert.ToDateTime(dateTimePicker1.Text)); }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (comboBox1.Text == "Gestionaire de stock")
            { Matiere_premiereDAO.supprimer(textBox1.Text); }
        }
    }
}
