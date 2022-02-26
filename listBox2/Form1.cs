using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace listBox2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if(listBox2.Items.Count > 0)
                {
                    string selectItem = listBox2.SelectedItem.ToString();
                    listBox2.Items.Remove(selectItem);
                }
                else
                {
                    MessageBox.Show("ListBox2 Empty");
                    return;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            string itemSelected = listBox1.SelectedItem.ToString();
            MessageBox.Show(itemSelected);

            for (byte i = 0; i < listBox2.Items.Count; i++)
            {
                if (listBox2.Items[i].ToString() == itemSelected)
                {
                    MessageBox.Show("Item exists");
                    return;
                }
            }

            listBox2.Items.Add(itemSelected);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            for(byte i=0; i < listBox1.Items.Count; i++)
            {
                listBox2.Items.Add(listBox1.Items[i]);
            }
        }


    }
}
