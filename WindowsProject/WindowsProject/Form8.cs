using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsProject
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                MessageBox.Show("RadioButton1 is selected.");
            else if (radioButton2.Checked)
                MessageBox.Show("RadioButton2 is selected.");
            else if (radioButton3.Checked)
                MessageBox.Show("RadioButton3 is selected.");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                MessageBox.Show("CheckBox1 is selected.");
            if (checkBox2.Checked)
                MessageBox.Show("CheckBox2 is selected.");
            if (checkBox3.Checked)
                MessageBox.Show("CheckBox3 is selected.");

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                MessageBox.Show("Control is selected");
            else
                MessageBox.Show("Control is de-selected");
        }
    }
}
