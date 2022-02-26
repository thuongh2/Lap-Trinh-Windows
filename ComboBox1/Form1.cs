using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboBox1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cbList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string textCBB = cbList1.Text;
            if (textCBB == null)
                return;
            lbList1.Items.Add(textCBB);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int stringRemove = lbList1.SelectedIndex;
            lbList1.Items.RemoveAt(stringRemove);
        }
    }
}
