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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (sender is Button)
                MessageBox.Show("Button is clicked by the user.");
            else if (sender is TextBox) 
                MessageBox.Show("TextBox is clicked by the user.");
            else
                MessageBox.Show("Form6 is clicked by the user.");

        }
    }
}
