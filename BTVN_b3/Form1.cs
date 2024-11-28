using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTVN_b3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void QLNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvQLNV.SelectedItems.Count > 0)
            {
                ListViewItem lv = lvQLNV.SelectedItems[0];
                String lname= lv.SubItems[0].Text;
                String fname = lv.SubItems[1].Text;
                String phone = lv.SubItems[2].Text;

                txtfirstname.Text = fname;
                txtlastname.Text = lname;
                txtphone.Text = phone;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListViewItem Lv1 = new ListViewItem(txtlastname.Text);
            Lv1.SubItems.Add(txtfirstname.Text);
            Lv1.SubItems.Add(txtphone.Text);
            lvQLNV.Items.Add(Lv1);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            while (lvQLNV.SelectedItems.Count > 0)
            {
                lvQLNV.Items.RemoveAt(lvQLNV.SelectedItems[0].Index);
            }
        }
    }
}
