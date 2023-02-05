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
using static _20521363.product_details;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _20521363
{
    public partial class UserCart : UserControl
    {
        List<product> products_cart = Home.products_cart;
        List<quantity_product_in_cart> quantity_of_products_in_cart = Home.quantity_of_products_in_cart;
        Home formout;
        public UserCart(Home formint)
        {
            InitializeComponent();
            formout = formint;
            lbshow.Text = "Giỏ hàng của bạn";
            lstShow.View = View.Details;
            lstShow.Font = new Font("Times New Roman", 16, FontStyle.Bold);
            lstShow.ForeColor = Color.Red;
            load_listview();
        }
        ImageList imagelist;
        void LoadImageList()
        {
            imagelist = new ImageList() { ImageSize = new Size(68, 68), ColorDepth = ColorDepth.Depth32Bit };
            for (int i = 0; i < products_cart.Count; i++)
            {
                imagelist.Images.Add(products_cart[i].Picture);
            }
        }

        private void load_listview()
        {
            LoadImageList();
            lstShow.SmallImageList = imagelist;
            lstShow.CheckBoxes = true;
            lstShow.GridLines = true;
            lstShow.Columns.Add("Hình ảnh", -2, HorizontalAlignment.Center);
            lstShow.Columns.Add("Tên sản phẩm", -2, HorizontalAlignment.Center);
            lstShow.Columns.Add("Số lượng", -2, HorizontalAlignment.Center);
            lstShow.Columns.Add("Giá tiền", -2, HorizontalAlignment.Center);
            lstShow.Columns.Add("Tổng tiền", -2, HorizontalAlignment.Right);
            for (int i = 0; i < products_cart.Count; i++)
            {
                ListViewItem item = new ListViewItem();
                item.ImageIndex = i;
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = products_cart[i].Name });
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = quantity_of_products_in_cart[i].Quantity.ToString() });
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = products_cart[i].Price.ToString("N0") });
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = (products_cart[i].Price * quantity_of_products_in_cart[i].Quantity).ToString("N0") });
                lstShow.Items.Add(item);
            }
            lstShow.Font = new Font("Times New Roman", 16, FontStyle.Bold);
            lstShow.ForeColor = Color.Black;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstShow.Items.Count; i++)
            {
                if (lstShow.Items[i].Checked)
                {
                    lstShow.Items[i].Remove();
                    products_cart.RemoveAt(i);
                    quantity_of_products_in_cart.RemoveAt(i);
                    i--;
                    formout.update_cart();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstShow.Items.Count; i++)
            {
                if (lstShow.Items[i].Checked)
                {
                    lstShow.Items[i].SubItems[2].Text = numericUpDown1.Value.ToString();
                    lstShow.Items[i].SubItems[4].Text = (products_cart[i].Price * (int)numericUpDown1.Value).ToString("N0");
                    quantity_of_products_in_cart[i].Quantity = (int)numericUpDown1.Value;
                    formout.update_cart();
                }
            }
        }

        private void btmua_Click(object sender, EventArgs e)
        {
            List<product> products_buying_ = new List<product>(); 
            List<quantity_product_in_cart> quantity_buying_ = new List<quantity_product_in_cart>();
            for (int i = 0; i < lstShow.Items.Count; i++)
            {
                if (lstShow.Items[i].Checked)
                {
                    products_buying_.Add(products_cart[i]);
                    quantity_buying_.Add(quantity_of_products_in_cart[i]);
                }
            }
            DatHang newform = new DatHang(products_buying_, quantity_buying_);
            newform.ShowDialog();
        }
    }
}
