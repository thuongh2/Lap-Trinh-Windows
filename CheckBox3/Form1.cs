using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckBox3
{
    public partial class Form1 : Form
    {
        private double priceCaoVoi = 100000;
        private double priceTayTrang = 1200000;
        private double priceChupHinhRang = 200000;
        private double priceTramRang = 80000;

        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double total = 0;
            if (checkBox1.CheckState == CheckState.Checked)
            {
                total += priceCaoVoi;
            }
            if (checkBox2.CheckState == CheckState.Checked)
            {
                total += priceTayTrang;
            }
            if (checkBox3.CheckState == CheckState.Checked)
            {
                total += priceChupHinhRang;
            }
            total += (double) numericUpDown1.Value * priceTramRang;
            tb1.Text = total.ToString() ;

            string messageTotal = String.Format("Khach hàng {0} cần thanh toán {1}", textBox1.Text, total.ToString());

            MessageBox.Show(messageTotal);
        }

        private void tb1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
