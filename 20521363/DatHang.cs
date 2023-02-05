using _20521363.Model;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Imaging;
using static _20521363.Home;

namespace _20521363
{
    public partial class DatHang : Form
    {
        List<product> products = Home.products;
        List<product> products_buying = Home.products_buying;
        List<quantity_product_in_cart> quantity_buying = Home.quantity_buying;
        List<take_datetime> date_time = Home.date_time;
        take_datetime take;
        public int tamtinh = 15000;
        public int phivanchuyen;
        public int khuyenmai;
        public int thanhtien;
        public string name, phone, email, address, city;
        public DatHang()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            bthome.BackColor = Color.DeepSkyBlue;
            btcharge_shop.BackColor = Color.DeepSkyBlue;
            pnaddress.Visible = true;
        }
        public List<product> products_buy;
        public List<quantity_product_in_cart> quantity_buy;
        public DatHang(List<product> products_buying_in, List<quantity_product_in_cart> quantity_buying_in) : this()
        {
            products_buy = products_buying_in;
            quantity_buy = quantity_buying_in;
            lstShow.View = View.Details;
            load_listview();
            load_lsv();
            load_lsv_thanhtien();
            if (tamtinh >= 40000000)
            {
                phivanchuyen = 0;
                tamtinh -= 15000;
                lsvhoadon.Items[0].SubItems[1].Text = tamtinh.ToString("N0");
                lsvhoadon.Items[2].SubItems[1].Text = phivanchuyen.ToString("N0");
                lsvthanhtien.Items[2].SubItems[1].Text = tamtinh.ToString("N0");
                thanhtien = tamtinh;
            }
        }

        ImageList imagelist;
        void LoadImageList()
        {
            imagelist = new ImageList() { ImageSize = new Size(68, 68), ColorDepth = ColorDepth.Depth32Bit };
            for (int i = 0; i < products_buy.Count; i++)
            {
                imagelist.Images.Add(products_buy[i].Picture);
            }
        }
        #region load_listview
        private void load_lsv()
        {
            lsvhoadon.View = View.Details;
            lsvhoadon.BackColor = Color.Gainsboro;
            lsvhoadon.Columns.Add("", -2, HorizontalAlignment.Left);
            lsvhoadon.Columns.Add("Thành tiền (VNĐ)", -2, HorizontalAlignment.Right);
            lsvhoadon.Font = new Font("Times New Roman", 18, FontStyle.Bold);
            lsvhoadon.ForeColor = Color.Black;
            ListViewItem item1 = new ListViewItem();
            item1.Text = "Tạm tính:";
            item1.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = tamtinh.ToString("N0") });
            lsvhoadon.Items.Add(item1);
            ListViewItem item2 = new ListViewItem();
            item2.Text = "Khuyến mãi:";
            item2.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = "0" });
            lsvhoadon.Items.Add(item2);
            ListViewItem item3 = new ListViewItem();
            item3.Text = "Phí vận chuyển:";
            item3.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = "15,000" });
            lsvhoadon.Items.Add(item3);
            lsvhoadon.Items[1].ForeColor = Color.Red;
        }
        
        private void load_listview()
        {
            LoadImageList();
            lstShow.SmallImageList = imagelist;
            lstShow.GridLines = true;
            lstShow.Columns.Add("Hình ảnh", -2, HorizontalAlignment.Center);
            lstShow.Columns.Add("Tên sản phẩm", -2, HorizontalAlignment.Center);
            lstShow.Columns.Add("Số lượng", -2, HorizontalAlignment.Center);
            lstShow.Columns.Add("Tổng tiền", -2, HorizontalAlignment.Right);
            for (int i = 0; i < products_buy.Count; i++)
            {
                ListViewItem item = new ListViewItem();
                item.ImageIndex = i;
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = products_buy[i].Name });
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = quantity_buy[i].Quantity.ToString() });
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = (products_buy[i].Price * quantity_buy[i].Quantity).ToString("N0") });
                lstShow.Items.Add(item);
                tamtinh += (products_buy[i].Price * quantity_buy[i].Quantity);
            }
            lstShow.Font = new Font("Times New Roman", 18, FontStyle.Bold);
            lstShow.ForeColor = Color.Black;
        }
        private void load_lsv_thanhtien()
        {
            khuyenmai = 0;
            phivanchuyen = 0;
            lsvthanhtien.View = View.Details;
            lsvthanhtien.BackColor = Color.Gainsboro;
            lsvthanhtien.Columns.Add("", -2, HorizontalAlignment.Left);
            lsvthanhtien.Columns.Add("Thành tiền (VNĐ)", -2, HorizontalAlignment.Right);
            lsvthanhtien.Font = new Font("Times New Roman", 18, FontStyle.Bold);
            lsvthanhtien.ForeColor = Color.Black;
            ListViewItem item_1 = new ListViewItem();
            item_1.Text = "Khuyến mãi:";
            item_1.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = "-" + khuyenmai.ToString("N0") });
            lsvthanhtien.Items.Add(item_1);
            ListViewItem item_2 = new ListViewItem();
            item_2.Text = "Phí vận chuyển:";
            item_2.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = "-" + phivanchuyen.ToString("N0") });
            lsvthanhtien.Items.Add(item_2);
            ListViewItem item_3 = new ListViewItem();
            item_3.Text = "Tổng tiền:";
            item_3.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = tamtinh.ToString("N0") });
            lsvthanhtien.Items.Add(item_3);
            lsvthanhtien.Items[0].ForeColor = Color.Red;
            lsvthanhtien.Items[2].ForeColor = Color.Red;
            thanhtien = tamtinh;
        }
        #endregion
        #region event_panel_information
        private void bthome_Click(object sender, EventArgs e)
        {
            Control ctrl = ((Control)sender);
            switch (ctrl.BackColor.Name)
            {
                case "White":
                    ctrl.BackColor = Color.DeepSkyBlue;
                    btshop.BackColor = Color.White;
                    if (tamtinh >= 40000000)
                    {
                        phivanchuyen = 0;
                    }
                    else
                    {
                        phivanchuyen = 15000;
                    }
                    tamtinh += phivanchuyen;
                    lsvhoadon.Items[0].SubItems[1].Text = tamtinh.ToString("N0");
                    lsvhoadon.Items[2].SubItems[1].Text = phivanchuyen.ToString("N0");
                    lsvthanhtien.Items[2].SubItems[1].Text = tamtinh.ToString("N0");
                    thanhtien = tamtinh;
                    pnaddress.Visible = true;
                    break;
            }
        }

        private void btshop_Click(object sender, EventArgs e)
        {
            Control ctrl = ((Control)sender);
            switch (ctrl.BackColor.Name)
            {
                case "White":
                    ctrl.BackColor = Color.DeepSkyBlue;
                    bthome.BackColor = Color.White;
                    if (tamtinh < 40000000)
                    {
                        tamtinh -= 15000;
                    }
                    phivanchuyen = 0;
                    lsvhoadon.Items[0].SubItems[1].Text = tamtinh.ToString("N0");
                    lsvhoadon.Items[2].SubItems[1].Text = phivanchuyen.ToString("N0");
                    lsvthanhtien.Items[2].SubItems[1].Text = tamtinh.ToString("N0");
                    lsvthanhtien.Items[1].SubItems[1].Text = "-" + phivanchuyen.ToString("N0");
                    thanhtien = tamtinh;
                    txtbaddress.Text = txtcity.Text = null;
                    pnaddress.Visible = false;
                    break;
            }
        }

        private void btcharge_shop_Click(object sender, EventArgs e)
        {
            Control ctrl = ((Control)sender);
            switch (ctrl.BackColor.Name)
            {
                case "White":
                    ctrl.BackColor = Color.DeepSkyBlue;
                    btibk.BackColor = Color.White;
                    break;
            }
        }

        private void btibk_Click(object sender, EventArgs e)
        {
            Control ctrl = ((Control)sender);
            switch (ctrl.BackColor.Name)
            {
                case "White":
                    ctrl.BackColor = Color.DeepSkyBlue;
                    btcharge_shop.BackColor = Color.White;
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a = txtcity.Text.ToLower();
            a = a.Trim();
            if (bthome.BackColor == Color.DeepSkyBlue)
            {
                if (a == "thành phố hồ chí minh" || a == "hồ chí minh")
                {
                    if (tamtinh < 40000000)
                    {
                        phivanchuyen = 15000;
                        lsvthanhtien.Items[1].SubItems[1].Text = "-" + phivanchuyen.ToString("N0");
                        lsvthanhtien.Items[2].SubItems[1].Text = (tamtinh - khuyenmai - phivanchuyen).ToString("N0");
                    }
                }
                if (a != "thành phố hồ chí minh" && a != "hồ chí minh")
                {
                     phivanchuyen = 0;
                     lsvthanhtien.Items[1].SubItems[1].Text = "-" + phivanchuyen.ToString("N0");
                     lsvthanhtien.Items[2].SubItems[1].Text = (tamtinh - khuyenmai - phivanchuyen).ToString("N0");
                }
            }
        }
        #endregion

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       
        private void lbback_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region dathang
        private void btapdung_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtbcode.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã giảm giá!\nVui lòng nhập mã giảm giá nếu có!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (txtbcode.Text == "Mjz3K")
            {
                if (tamtinh < 50000000)
                {
                    MessageBox.Show("Mã chỉ áp dụng cho đơn hàng từ 50 triệu!","Thông báo!",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    txtbcode.Text = null;
                }
                else
                {
                    khuyenmai = 1000000;
                    lsvthanhtien.Items[0].SubItems[1].Text = "-" + khuyenmai.ToString("N0");
                    lsvthanhtien.Items[2].SubItems[1].Text = (tamtinh - khuyenmai).ToString("N0");
                    thanhtien = tamtinh - khuyenmai;
                }
            }
            if (txtbcode.Text == "2NjkS")
            {
                if (tamtinh < 100000000)
                {
                    MessageBox.Show("Mã chỉ áp dụng cho đơn hàng từ 100 triệu!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtbcode.Text = null;
                }
                else
                {
                    khuyenmai = 3000000;
                    lsvthanhtien.Items[0].SubItems[1].Text = "-" + khuyenmai.ToString("N0");
                    lsvthanhtien.Items[2].SubItems[1].Text = (tamtinh - khuyenmai).ToString("N0");
                    thanhtien = tamtinh - khuyenmai;
                }
            }
            if (!string.IsNullOrEmpty(txtbcode.Text) && txtbcode.Text != "Mjz3K" && txtbcode.Text != "2NjkS")
            {
                MessageBox.Show("Mã không tồn tại!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtbcode.Text = null;
            }
        }
        public int Numrd;
        public string hinhthuc,hinhthucnhan;
        private void btđDatHang_Click(object sender, EventArgs e)
        {
            if (btibk.BackColor == Color.DeepSkyBlue)
            {
                hinhthuc = btibk.Text;
            }
            else
            {
                hinhthuc = btcharge_shop.Text;
            }
            Random rd = new Random();
            while (true)
            {
                bool flagg = false;
                Numrd = rd.Next(10000000, 99999999);
                for (int i = 0; i < date_time.Count; i++)
                {
                    if (Numrd.ToString() == date_time[i].MaDH)
                    {
                        flagg = true;
                        break;
                    }
                }
                if (flagg == false)
                {
                    break;
                }
            }
            if (products_buy.Count == 0)
            {
                MessageBox.Show("Danh sách sảm phẩm rỗng!\nHãy chọn sản phẩm để mua!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            else
            {
                string a = txtcity.Text.ToLower();
                a = a.Trim();
                if (bthome.BackColor == Color.DeepSkyBlue)
                {
                    hinhthucnhan = bthome.Text;
                    if (a == "thành phố hồ chí minh" || a == "hồ chí minh")
                    {
                        if (tamtinh < 40000000)
                        {
                            phivanchuyen = 15000;
                            lsvthanhtien.Items[1].SubItems[1].Text = "-" + phivanchuyen.ToString("N0");
                            lsvthanhtien.Items[2].SubItems[1].Text = (tamtinh - khuyenmai - phivanchuyen).ToString("N0");
                            thanhtien = tamtinh - khuyenmai - phivanchuyen;
                        }
                    }
                    if (a != "thành phố hồ chí minh" && a != "hồ chí minh")
                    {
                        phivanchuyen = 0;
                        lsvthanhtien.Items[1].SubItems[1].Text = "-" + phivanchuyen.ToString("N0");
                        lsvthanhtien.Items[2].SubItems[1].Text = (tamtinh - khuyenmai - phivanchuyen).ToString("N0");
                        thanhtien = tamtinh - khuyenmai - phivanchuyen;
                    }
                    if (string.IsNullOrEmpty(txtbname.Text) || string.IsNullOrEmpty(txtbphone.Text) || string.IsNullOrEmpty(txtbemail.Text) || string.IsNullOrEmpty(txtcity.Text) || string.IsNullOrEmpty(txtbaddress.Text))
                    {
                        MessageBox.Show("Bạn cần điền đầy đủ thông tin!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (btcharge_shop.BackColor == Color.DeepSkyBlue)
                        {
                            MessageBox.Show("Đặt hàng thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            for (int i = 0; i < products_buy.Count; i++)
                            {
                                products_buying.Add(products_buy[i]);
                                quantity_buying.Add(quantity_buy[i]);
                                take = new take_datetime(txtbname.Text, txtbphone.Text, txtbemail.Text, txtcity.Text, txtbaddress.Text, DateTime.Now, Numrd.ToString(), quantity_buy[i].Quantity, hinhthuc, bthome.Text, thanhtien, "Chưa thanh toán");
                                date_time.Add(take);
                            }
                            this.Close();
                        }
                        if (btibk.BackColor == Color.DeepSkyBlue)
                        {
                            name = txtbname.Text; phone = txtbphone.Text; email = txtbemail.Text; city = txtcity.Text; address = txtbaddress.Text;
                            Charge newform = new Charge(this);
                            newform.ShowDialog();
                        }
                        
                    }
                }
                else
                {
                    hinhthucnhan = btshop.Text;
                    if (string.IsNullOrEmpty(txtbname.Text) || string.IsNullOrEmpty(txtbphone.Text) || string.IsNullOrEmpty(txtbemail.Text))
                    {
                        MessageBox.Show("Bạn cần điền đầy đủ thông tin!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (btcharge_shop.BackColor == Color.DeepSkyBlue)
                        {
                            MessageBox.Show("Đặt hàng thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            for (int i = 0; i < products_buy.Count; i++)
                            {
                                products_buying.Add(products_buy[i]);
                                quantity_buying.Add(quantity_buy[i]);
                                take = new take_datetime(txtbname.Text, txtbphone.Text, txtbemail.Text, txtcity.Text, txtbaddress.Text, DateTime.Now, Numrd.ToString(), quantity_buy[i].Quantity, hinhthuc, bthome.Text, thanhtien, "Chưa thanh toán");
                                date_time.Add(take);
                            }
                            this.Close();
                        }
                        if (btibk.BackColor == Color.DeepSkyBlue)
                        {
                            name = txtbname.Text; phone = txtbphone.Text; email = txtbemail.Text; city = txtcity.Text; address = txtbaddress.Text;
                            Charge newform = new Charge(this);
                            newform.ShowDialog();
                        }
                    }
                }
            }
        }
        #endregion
        private void DatHang_Load(object sender, EventArgs e)
        {
            ActiveControl = bthome;
        }
        internal void close()
        {
            this.Close();
        }
    }
}
