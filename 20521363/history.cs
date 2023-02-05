using _20521363.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;
using static _20521363.Home;

namespace _20521363
{
    public partial class history : UserControl
    {
        List<product> products_buying = Home.products_buying;
        List<quantity_product_in_cart> quantity_buying = Home.quantity_buying;
        List<take_datetime> date_time = Home.date_time;
        int count = 0;
        public history()
        {
            InitializeComponent();
            load_lsv();
            lsvhistory.View = View.Details;
            for (int i = 0; i < date_time.Count; i++)
            {
                bool flag = true;
                for (int j = i+1; j < date_time.Count; j++)
                {
                    if (date_time[i].MaDH == date_time[j].MaDH)
                    {
                        flag = false; break;
                    }
                }
                if (flag == true)
                {
                    count++;
                }
            }
            lbhistory.Text = "Bạn đã mua bên chúng tôi " + count.ToString() + " đơn hàng";
        }
        ImageList imagelist;
        void LoadImageList()
        {
            imagelist = new ImageList() { ImageSize = new Size(68, 68), ColorDepth = ColorDepth.Depth32Bit };
            for (int i = 0; i < products_buying.Count; i++)
            {
                imagelist.Images.Add(products_buying[i].Picture);
            }
        }
        private void load_lsv()
        {
            LoadImageList();
            lsvhistory.SmallImageList = imagelist;
            lsvhistory.GridLines = true;
            lsvhistory.Columns.Add("Mã đơn hàng", -2, HorizontalAlignment.Center);
            lsvhistory.Columns.Add("Số lượng", -2, HorizontalAlignment.Center);
            lsvhistory.Columns.Add("Thời gian", -2, HorizontalAlignment.Center);
            lsvhistory.Columns.Add("Thành tiền", -2, HorizontalAlignment.Center);
            lsvhistory.Columns.Add("Hình thức thanh toán", -2, HorizontalAlignment.Center);
            lsvhistory.Columns.Add("Hình thức nhận hàng", -2, HorizontalAlignment.Center);
            for (int i = 0; i < date_time.Count; i++)
            {
                bool flag = true;
                for (int j = 0; j < i; j++)
                {
                    if (date_time[j].MaDH == date_time[i].MaDH)
                    {
                        flag = false;
                        break;
                    }
                }
                if (flag)
                {
                    int slsp = 0;
                    for (int j = i; j < date_time.Count; j++)
                    {
                        if (date_time[j].MaDH == date_time[i].MaDH)
                        {
                            slsp += date_time[j].SL;
                        }
                    }
                    ListViewItem item = new ListViewItem();
                    item.Text = date_time[i].MaDH.ToString();
                    item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = slsp.ToString() });
                    item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = date_time[i].aDateTime.ToString() });
                    item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = date_time[i].Thanhtien.ToString("N0") });
                    item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = date_time[i].Hinhthucthanhtoan });
                    item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = date_time[i].Hinhthucnhan });
                    lsvhistory.Items.Add(item);
                }
                
            }
            lsvhistory.Font = new Font("Times New Roman", 16, FontStyle.Bold);
            lsvhistory.ForeColor = Color.Black;
        }
        private order_lookup_details detail;
        private void lsvhistory_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView lst = sender as ListView;
            if (lsvhistory.SelectedItems.Count > 0)
            {
                ListViewItem item = lst.SelectedItems[0];
                detail = new order_lookup_details(item.Text);
                detail.ShowDialog();
            }
        }
    }
}
