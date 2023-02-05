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

namespace _20521363
{
    public partial class product_details_userdanhmuc : Form
    {
        List<product> products_cart = Home.products_cart;
        List<quantity_product_in_cart> quantity_of_products_in_cart = Home.quantity_of_products_in_cart;
        UserDanhmuc ucout;
        public product_details_userdanhmuc(UserDanhmuc ucin)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            ucout = ucin;
            ptB.Image = ucout.index_products.Picture;
            lbname.Text = ucout.index_products.Name;
            lbprice.Text = ucout.index_products.Price.ToString("N0") + "đ";
        }
        private void btcart_Click(object sender, EventArgs e)
        {
            quantity_product_in_cart product_detail_quantity = new quantity_product_in_cart((int)numericUpDown1.Value);
            bool flagg = false;
            for (int i = 0; i< products_cart.Count; i++)
            {
                if (ucout.index_products.Name == products_cart[i].Name)
                {
                    quantity_of_products_in_cart[i].Quantity += product_detail_quantity.Quantity;
                    flagg = true;
                    break;
                }
            }
            if (flagg == false)
            {
                products_cart.Add(ucout.index_products);
                quantity_of_products_in_cart.Add(product_detail_quantity);
            }
            ucout.update();
            this.Close();
        }

        
        private void btmua_Click(object sender, EventArgs e)
        {
            List<product> products_buying_ = new List<product>();
            List<quantity_product_in_cart> quantity_buying_ = new List<quantity_product_in_cart>();
            products_buying_.Add(ucout.index_products);
            quantity_product_in_cart product_quantity_ = new quantity_product_in_cart((int)numericUpDown1.Value);
            quantity_buying_.Add(product_quantity_);
            this.Close();
            DatHang newform = new DatHang(products_buying_, quantity_buying_);
            newform.ShowDialog();
        }

        private void btexit_Click(object sender, EventArgs e)
        {
            DialogResult Result = MessageBox.Show("Bạn muốn thoát?", "Thoát!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (Result == DialogResult.Yes) { this.Close(); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ucout.index_products.Technical_data, "Thông số kỹ thuật");
        }
    }
}
