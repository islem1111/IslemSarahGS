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
    public partial class FRM_Outillage : Form
    {
        public FRM_Outillage()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FRM_Outillage_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
           

          
            if (comboBox1.Text == "Gestionaire de stock")
            { outillageDAO.Insert_outillage(textBox1.Text, textBox2.Text, float.Parse(textBox3.Text), pictureBox1.Text, textBox4.Text, Convert.ToDateTime(dateTimePicker1.Text)); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
         

          
            if (comboBox1.Text == "Gestionaire de stock")
            { outillageDAO.Update_outillage(textBox1.Text, textBox2.Text, float.Parse(textBox3.Text), pictureBox1.Text, textBox4.Text, Convert.ToDateTime(dateTimePicker1.Text)); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Gestionaire de stock")
            { outillageDAO.supprimer(textBox1.Text); }
        }
    }
}
