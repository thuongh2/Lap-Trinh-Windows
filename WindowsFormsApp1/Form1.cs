using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello WinForm");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        private void button1_Click_1(object sender, EventArgs e)
        {
            double numberA = Convert.ToDouble(textBox1.Text);
            double numberB = Convert.ToDouble(textBox2.Text);

            if(numberA == 0)
            {
                if(numberB != 0)
                {
                    textBox3.Text = "Phuong trinh vo nghiem";
                }
                else
                {
                    textBox3.Text = "Phuong trinh vo so nghiem";
                }
            }
            else
            {
                double kq = -numberB / numberA;
                textBox3.Text = kq.ToString();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
