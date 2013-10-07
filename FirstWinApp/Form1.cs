using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FirstWinApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.radioButton1.Checked)
            {
                MessageBox.Show("Raspuns corect!");
            }
            else
            {
                MessageBox.Show("Raspuns gresit!");
            }

        }

        private void Form1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ai dat click!");
        }
    }
}
