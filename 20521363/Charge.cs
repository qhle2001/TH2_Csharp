using _20521363.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static _20521363.Home;
using static _20521363.DatHang;

namespace _20521363
{
    public partial class Charge : Form
    {
        List<product> products_buying = Home.products_buying;
        List<quantity_product_in_cart> quantity_buying = Home.quantity_buying;
        List<take_datetime> date_time = Home.date_time;
        DatHang formout;
        public Charge (DatHang formin)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            formout = formin;
            textBox1.Text = formout.thanhtien.ToString("N0");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thanh toán thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            for (int i = 0; i < formout.products_buy.Count; i++)
            {
                products_buying.Add(formout.products_buy[i]);
                quantity_buying.Add(formout.quantity_buy[i]);
                take_datetime take = new take_datetime(formout.name, formout.phone, formout.email, formout.city, formout.address, DateTime.Now, formout.Numrd.ToString(), formout.quantity_buy[i].Quantity, formout.hinhthuc, formout.hinhthucnhan, formout.thanhtien, "Đã thanh toán");
                date_time.Add(take);
            }
            formout.close();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
