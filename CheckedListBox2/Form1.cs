using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckedListBox2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            for(byte i = 0; i < clbList1.Items.Count; i++)
            {
                if(clbList1.GetItemChecked(i) == true)
                {
                    clbList2.Items.Add(clbList1.Items[i]);
                    clbList1.Items.RemoveAt(i);
                    i--;
                }
            }    
        }

        private void btn_Click(object sender, EventArgs e)
        {
            for(byte i=0; i < clbList2.Items.Count; i++)
            {
                if (clbList2.GetItemChecked(i) == true)
                {
                    clbList1.Items.Add(clbList2.Items[i]);
                    clbList2.Items.RemoveAt(i);
                    i--;
                }
            }
        }
    }
}
