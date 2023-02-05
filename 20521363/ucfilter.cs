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
    public partial class ucfilter : UserControl
    {
        //List<product> products = Home.products;
        Home ucout;
        ImageList imagelist;
        void LoadImageList()
        {
            imagelist = new ImageList() { ImageSize = new Size(255, 255), ColorDepth = ColorDepth.Depth32Bit };
            for (int i = 0; i < products.Count; i++)
            {
                imagelist.Images.Add(products[i].Picture);
            }
        }
        List<string> filter;
        public ucfilter(Home formin)
        {
            InitializeComponent();
            ucout = formin;
            lstShow.Clear();
            LoadImageList();
            lstShow.LargeImageList = imagelist;
            filter = ucout.text_filter;
            int count_products = 0;
            for (int i = 0; i < products.Count(); i++)
            {
                int count = 0;
                string[] split_temp = products[i].Name.Split(' ');
                for (int j = 0; j < filter.Count; j++)
                {
                    for (int z = 0; z < split_temp.Length; z++)
                    {
                        if (filter[j] == split_temp[z])
                        {
                            count++;
                        }
                    }
                    if (filter[j] == "Dưới 5 triệu")
                    {
                        if (products[i].Price < 5000000)
                        {
                            count++;
                        }
                    }
                    if (filter[j] == "Dưới 10 triệu")
                    {
                        if (products[i].Price < 10000000)
                        {
                            count++;
                        }
                    }
                    if (filter[j] == "Từ 10 - 20 triệu")
                    {
                        if (products[i].Price >= 1000000 && products[i].Price <= 20000000)
                        {
                            count++;
                        }
                    }
                    if (filter[j] == "Trên 20 triệu")
                    {
                        if (products[i].Price > 20000000)
                        {
                            count++;
                        }
                    }
                    if (filter[j] == "Trên 30 triệu")
                    {
                        if (products[i].Price > 3000000)
                        {
                            count++;
                        }
                    }
                    if (filter[j] == "Trên 40 triệu")
                    {
                        if (products[i].Price > 40000000)
                        {
                            count++;
                        }
                    }
                    if (filter[j] == products[i].Type)
                    {
                        count++;
                    }
                }
                if (count == filter.Count)
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = products[i].Name;
                    item.ImageIndex = i;
                    lstShow.Items.Add(item);
                    count_products++;
                }
            }
            if (count_products == 0)
            {
                lbshow.Text = "Không tìm thấy sản phẩm nào phù hợp";
            }
            else
            {
                if (filter.Count > 0)
                {
                    lbshow.Text = "Tìm thấy " + count_products.ToString() + " sảm phẩm phù hợp";
                }
                else
                {
                    lbshow.Text = "Có " + count_products.ToString() + " sảm phẩm trong danh mục";
                }
            }
        }
        private filter_detail product_Details;
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
                        product_Details = new filter_detail(this);
                        product_Details.ShowDialog();
                        break;
                    }
                }
            }
        }
        internal void update()
        {
            ucout.update_cart();
        }
    }
}
