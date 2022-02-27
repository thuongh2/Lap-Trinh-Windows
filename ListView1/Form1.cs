using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListView1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void rdbNu_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            for(byte i = 0; i < lsvDSSV.Items.Count; i++)
            {
                if(lsvDSSV.Items[i].Selected)
                    lsvDSSV.Items.RemoveAt(i) ;
            }    
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.cmbQueQuan.Items.AddRange(new object[]
            {
                "Tp HCM",
                "Hà Nội",
                "Bình Dương",
                "Sóc Trăng",
                "Vĩnh Long",
                "Đồng Nai"
            });
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            string gioiTinh;
            if (rdbNam.Checked == true)
            {
                gioiTinh = "Nam";
            }
            else
                gioiTinh = "Nu";
            string monHoc = "";
            for(byte i=0; i< clbMonHoc.Items.Count; i++)
            {
                monHoc += clbMonHoc.Items[i].ToString() + ", ";
            }    

            ListViewItem listViewItem = new ListViewItem(new string[]
            {
                txtHoTen.Text,
                dtpNgaySinh.Text,
                cmbQueQuan.Text,
                gioiTinh,
                monHoc
            }, -1);
            lsvDSSV.Items.Add(listViewItem);
        }
    }
}
