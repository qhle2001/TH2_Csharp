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
using static _20521363.order_lookup;
using static _20521363.DatHang;
using static System.Net.Mime.MediaTypeNames;

namespace _20521363
{
    public partial class order_lookup_details : Form
    {
        List<product> products_buying = Home.products_buying;
        List<quantity_product_in_cart> quantity_buying = Home.quantity_buying;
        List<take_datetime> date_time = Home.date_time;
        string madh = order_lookup.madh;
        public order_lookup_details()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }
        ImageList imagelist;
        void LoadImageList()
        {
            imagelist = new ImageList() { ImageSize = new Size(100, 100), ColorDepth = ColorDepth.Depth32Bit };
            for (int i = 0; i < products_buying.Count; i++)
            {
                imagelist.Images.Add(products_buying[i].Picture);
            }
        }
        public order_lookup_details(string txt): this()
        {
            LoadImageList();
            lsv_show.View = View.Details;
            lsv_show.SmallImageList = imagelist;
            lsv_show.GridLines = true;
            lsv_show.Columns.Add("", -2, HorizontalAlignment.Center);
            lsv_show.Columns.Add("Thông tin khách hàng", -2, HorizontalAlignment.Center);
            lsv_show.Columns.Add("Địa chỉ", -2, HorizontalAlignment.Center);
            lsv_show.Columns.Add("Tên sản phẩm", -2, HorizontalAlignment.Center);
            lsv_show.Columns.Add("Số tiền", -2, HorizontalAlignment.Center);
            lsv_show.Columns.Add("Thành tiền", -2, HorizontalAlignment.Center);
            lsv_show.Columns.Add("Tình trạng thanh toán", -2, HorizontalAlignment.Center);
            for (int i = 0; i < date_time.Count; i++)
            {
                if (date_time[i].MaDH == txt)
                {
                    ListViewItem item = new ListViewItem();
                    item.ImageIndex = i;
                    item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = date_time[i].Name_customer + "\n" + date_time[i].Phone_number + "\n" + date_time[i].Email });
                    item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = date_time[i].City + "\n" + date_time[i].Address });
                    item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = products_buying[i].Name + "\n x" + date_time[i].SL.ToString() });
                    item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = (products[i].Price * date_time[i].SL).ToString("N0") + "VNĐ" });
                    item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = date_time[i].Thanhtien.ToString("N0") + " VNĐ" });
                    item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = date_time[i].Thanhtoan });
                    lsv_show.Items.Add(item);
                }
            }
            lsv_show.Font = new Font("Times New Roman", 16, FontStyle.Bold);
            lsv_show.ForeColor = Color.Black;
        }

        private void lbback_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
