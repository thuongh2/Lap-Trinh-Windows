using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckedListBox1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string temp = "";
            for (byte i = 0; i < clbList1.Items.Count; i++)
            {
                if(clbList1.GetItemChecked(i) == true)
                {
                    temp += clbList1.Items[i].ToString() + ", ";
                }    

            }    
            if(temp.Length > 0)
                MessageBox.Show(temp);
        }
    }
}
