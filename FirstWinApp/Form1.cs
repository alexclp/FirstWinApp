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
        private bool changedColor = false;

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
            if (!this.changedColor)
            {
                this.changedColor = true;
                this.BackColor = Color.IndianRed;
            }
            else
            {
                this.changedColor = false;
                this.BackColor = Color.LemonChiffon;
            }
            MessageBox.Show("Changed color!");
        }
    }
}
