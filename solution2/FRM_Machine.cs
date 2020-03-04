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
    public partial class FRM_Machine : Form
    {
        public FRM_Machine()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
           
            if (comboBox1.Text == "Gestionaire de stock")
            { MachineDAO.Insert_Machine(textBox4.Text, textBox5.Text, float.Parse(textBox3.Text), pictureBox1.Text, textBox2.Text); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            if (comboBox1.Text == "Gestionaire de stock")
            { MachineDAO.Update_Machine(textBox4.Text, textBox5.Text, float.Parse(textBox3.Text), pictureBox1.Text, textBox2.Text); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Gestionaire de stock")
            { MachineDAO.supprimer(textBox4.Text); }
        }
    }
}
