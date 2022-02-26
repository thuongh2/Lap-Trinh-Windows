using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckBox1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SetAllDisplay(CheckBox a, Label b)
        {
            if (a.CheckState == CheckState.Checked)
            {
                b.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                b.BackColor = System.Drawing.SystemColors.ActiveCaption;
            }
            else
            {
                b.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                b.BackColor = System.Drawing.SystemColors.Control;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            SetAllDisplay(checkBox1, label1);
        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            SetAllDisplay(checkBox2, label2);
        }
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            SetAllDisplay(checkBox3, label3);
        }
        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            SetAllDisplay(checkBox4, label4);
        }
        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            SetAllDisplay(checkBox5, label5);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            SetAllDisplay(checkBox6, label6);
        }
    }
}
