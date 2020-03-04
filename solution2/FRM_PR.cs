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
using BEL;

namespace Winforms
{
    public partial class FRM_PR : Form
    {
        public FRM_PR()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            MemoryStream mem = new MemoryStream();

            pictureBox1.Image = Image.FromStream(mem);
            if (comboBox1.Text== "Gestionaire de stock")
            { Pièce_de_rechangeDAO.Inserer(textBox2.Text, textBox3.Text, float.Parse(textBox4.Text), pictureBox1.Text, textBox5.Text, Convert.ToDateTime(dateTimePicker1.Text)); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MemoryStream mem = new MemoryStream();

            pictureBox1.Image = Image.FromStream(mem);
            if (comboBox1.Text == "Gestionaire de stock")
            { Pièce_de_rechangeDAO.Update(textBox2.Text, textBox3.Text, float.Parse(textBox4.Text), pictureBox1.Text, textBox5.Text, Convert.ToDateTime(dateTimePicker1.Text)); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            if (comboBox1.Text == "Gestionaire de stock")
            { Pièce_de_rechangeDAO.supprimer(textBox2.Text); }
        }
    }
}
