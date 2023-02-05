using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20521363
{
    public partial class order_lookup : Form
    {
        public static string name, phonenumber, madh;

        private void btlookup_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtPhone.Text) || string.IsNullOrEmpty(txtCode.Text))
            {
                MessageBox.Show("Bạn cần điền đầy đủ thông tin!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                madh = txtCode.Text;
                order_lookup_details newform = new order_lookup_details(txtCode.Text);
                newform.ShowDialog();
            }
        }

        public order_lookup()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            ActiveControl = txtName;
        }

    }
}
