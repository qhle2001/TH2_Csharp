using _20521363.Model;
using _20521363.Properties;
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
    public partial class UserDanhmuc : UserControl
    {
        List<product> products = Home.products;
        Home formout;
        ImageList imagelist;
        void LoadImageList()
        {
            imagelist = new ImageList() { ImageSize = new Size(255, 255), ColorDepth = ColorDepth.Depth32Bit };
            for (int i = 0; i < products.Count; i++)
            {
                imagelist.Images.Add(products[i].Picture);
            }
        }
        public UserDanhmuc(Home formin)
        {
            InitializeComponent();
            formout = formin;
            lstShow.Clear();
            LoadImageList();
            lstShow.LargeImageList = imagelist;
            string a = formout.txt_find.Trim();
            int count_products = 0;
            string[] split_a = a.Split(' ');
            for (int i = 0; i < products.Count(); i++)
            {
                int count = 0;
                string temp = products[i].Name.ToLower();
                string[] split_temp = temp.Split(' ');
                for (int j = 0; j < split_a.Length; j++)
                {
                    for (int z = 0; z < split_temp.Length; z++)
                    {
                        if (split_a[j] == split_temp[z])
                        {
                            count++;
                        }
                    }
                }
                if (count == split_a.Length)
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = products[i].Name;
                    item.ImageIndex = i;
                    lstShow.Items.Add(item);
                    count_products++;
                }
                if (count_products != 0)
                {
                    lbshow.Text = "Tìm thấy " + count_products.ToString() + " sảm phẩm phù hợp cho từ khóa " + a;
                }
                else
                {
                    lbshow.Text = "Không tìm thấy sản phẩm nào phù hợp";
                }
            }
        }

        private product_details_userdanhmuc product_Details;
        public product index_products;
        private void lstShow_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView lst = sender as ListView;
            if (lstShow.SelectedItems.Count > 0)
            {
                ListViewItem item = lst.SelectedItems[0];
                for (int i = 0; i < products.Count; i++)
                {
                    if (products[i].Name == item.Text)
                    {
                        index_products = products[i];
                        product_Details = new product_details_userdanhmuc(this);
                        product_Details.ShowDialog();
                        break;
                    }
                }
            }
        }
        internal void update()
        {
            formout.update_cart();
        }
    }
}
