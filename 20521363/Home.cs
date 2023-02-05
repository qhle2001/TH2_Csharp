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
using System.Xml.Serialization;
using static _20521363.product_details;

namespace _20521363
{
    public partial class Home : Form
    {
        public string button_click;
        public string txt_find;
        public static List<product> products_cart = new List<product>();
        public static List<quantity_product_in_cart> quantity_of_products_in_cart = new List<quantity_product_in_cart>();
        public static List<product> products_buying = new List<product>();
        public static List<quantity_product_in_cart> quantity_buying = new List<quantity_product_in_cart>();
        public static List<take_datetime> date_time = new List<take_datetime>();
        public Home()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            txtB.Text = "Bạn muốn mua gì hôm nay?";
            load_user_home();
        }
        #region sanpham
        public static List<product> products = new List<product>()
        {
            #region ip12
            new product("iPhone 12 64GB Trắng", Resources.ip12_trang, "Trắng", "64GB", 15490000, "Model:\t\t\tiPhone 12 64GB\r\nMàu sắc:\t\t\tTrắng\r\nNhà sản xuất:\t\tiPhone\r\nXuất xứ:\t\t\tTrung Quốc\r\nNăm ra mắt :\t\t2020\r\nThời gian bảo hành:\t12 Tháng\r\nĐịa điểm bảo hành:\t\r\nRAM:\t\t\t4 GB\r\nBộ nhớ trong:\t\t64 GB\r\nHệ điều hành:\t\tiOS 14.1\r\nChipset:\t\t\tApple A14 Bionic\r\nCảm ứng:\t\tCó\r\nLoại màn hình:\t\tSuper Retina XDR\r\nKích thước màn hình:\t6.1 inch \"\r\nĐộ phân giải màn hình:\t2532 x 1170 pixels\r\nCamera trước:\t\t12MP\r\nCamera sau:\t\t12 MP (kép)\r\nĐèn Flash:\t\tCó\r\nVideo:\t\t\t4K\r\nMạng 3G:\t\tCó\r\nMạng 4G:\t\tCó\r\nWIFI:\t\t\tWi-Fi 6 (802.11ax)\r\nBluetooth:\t\tBluetooth 5.0\r\nUSB:\t\t\tType C\r\nMở khóa nhanh:\t\tMở khóa bằng khuôn mặt\r\nThiết kế:\t\t\tNguyên khối, mặt kính cường lực\r\nChống nước:\t\tCó, IP68\r\nKích thước sản phẩm:\t146.7 x 71.5 x 7.4mm mm"),
            new product("iPhone 12 64GB Tím", Resources.ip12_tim, "Tím", "64GB", 15490000,"Model:\t\t\tiPhone 12 64GB\r\nMàu sắc:\t\t\tTím\r\nNhà sản xuất:\t\tiPhone\r\nXuất xứ:\t\t\tTrung Quốc\r\nNăm ra mắt :\t\t2020\r\nThời gian bảo hành:\t12 Tháng\r\nĐịa điểm bảo hành:\t\r\nRAM:\t\t\t4 GB\r\nBộ nhớ trong:\t\t64 GB\r\nHệ điều hành:\t\tiOS 14.1\r\nChipset:\t\t\tApple A14 Bionic\r\nCảm ứng:\t\tCó\r\nLoại màn hình:\t\tSuper Retina XDR\r\nKích thước màn hình:\t6.1 inch \"\r\nĐộ phân giải màn hình:\t2532 x 1170 pixels\r\nCamera trước:\t\t12MP\r\nCamera sau:\t\t12 MP (kép)\r\nĐèn Flash:\t\tCó\r\nVideo:\t\t\t4K\r\nMạng 3G:\t\tCó\r\nMạng 4G:\t\tCó\r\nWIFI:\t\t\tWi-Fi 6 (802.11ax)\r\nBluetooth:\t\tBluetooth 5.0\r\nUSB:\t\t\tType C\r\nMở khóa nhanh:\t\tMở khóa bằng khuôn mặt\r\nThiết kế:\t\t\tNguyên khối, mặt kính cường lực\r\nChống nước:\t\tCó, IP68\r\nKích thước sản phẩm:\t146.7 x 71.5 x 7.4mm mm"),
            new product("iPhone 12 64GB Đen", Resources.ip12_den, "Đen", "64GB", 15490000, "Model:\t\t\tiPhone 12 64GB\r\nMàu sắc:\t\t\tĐen\r\nNhà sản xuất:\t\tiPhone\r\nXuất xứ:\t\t\tTrung Quốc\r\nNăm ra mắt :\t\t2020\r\nThời gian bảo hành:\t12 Tháng\r\nĐịa điểm bảo hành:\t\r\nRAM:\t\t\t4 GB\r\nBộ nhớ trong:\t\t64 GB\r\nHệ điều hành:\t\tiOS 14.1\r\nChipset:\t\t\tApple A14 Bionic\r\nCảm ứng:\t\tCó\r\nLoại màn hình:\t\tSuper Retina XDR\r\nKích thước màn hình:\t6.1 inch \"\r\nĐộ phân giải màn hình:\t2532 x 1170 pixels\r\nCamera trước:\t\t12MP\r\nCamera sau:\t\t12 MP (kép)\r\nĐèn Flash:\t\tCó\r\nVideo:\t\t\t4K\r\nMạng 3G:\t\tCó\r\nMạng 4G:\t\tCó\r\nWIFI:\t\t\tWi-Fi 6 (802.11ax)\r\nBluetooth:\t\tBluetooth 5.0\r\nUSB:\t\t\tType C\r\nMở khóa nhanh:\t\tMở khóa bằng khuôn mặt\r\nThiết kế:\t\t\tNguyên khối, mặt kính cường lực\r\nChống nước:\t\tCó, IP68\r\nKích thước sản phẩm:\t146.7 x 71.5 x 7.4mm mm"),
            new product("iPhone 12 64GB Đỏ", Resources.ip12_do, "Đỏ", "64GB", 15490000, "Model:\t\t\tiPhone 12 64GB\r\nMàu sắc:\t\t\tĐỏ\r\nNhà sản xuất:\t\tiPhone\r\nXuất xứ:\t\t\tTrung Quốc\r\nNăm ra mắt :\t\t2020\r\nThời gian bảo hành:\t12 Tháng\r\nĐịa điểm bảo hành:\t\r\nRAM:\t\t\t4 GB\r\nBộ nhớ trong:\t\t64 GB\r\nHệ điều hành:\t\tiOS 14.1\r\nChipset:\t\t\tApple A14 Bionic\r\nCảm ứng:\t\tCó\r\nLoại màn hình:\t\tSuper Retina XDR\r\nKích thước màn hình:\t6.1 inch \"\r\nĐộ phân giải màn hình:\t2532 x 1170 pixels\r\nCamera trước:\t\t12MP\r\nCamera sau:\t\t12 MP (kép)\r\nĐèn Flash:\t\tCó\r\nVideo:\t\t\t4K\r\nMạng 3G:\t\tCó\r\nMạng 4G:\t\tCó\r\nWIFI:\t\t\tWi-Fi 6 (802.11ax)\r\nBluetooth:\t\tBluetooth 5.0\r\nUSB:\t\t\tType C\r\nMở khóa nhanh:\t\tMở khóa bằng khuôn mặt\r\nThiết kế:\t\t\tNguyên khối, mặt kính cường lực\r\nChống nước:\t\tCó, IP68\r\nKích thước sản phẩm:\t146.7 x 71.5 x 7.4mm mm"),

            new product("iPhone 12 128GB Trắng", Resources.ip12_trang, "Trắng", "128GB", 21990000,"Model:\t\t\tiPhone 12 128GB\r\nMàu sắc:\t\t\tTrắng\r\nNhà sản xuất:\t\tiPhone\r\nXuất xứ:\t\t\tTrung Quốc\r\nNăm ra mắt :\t\t2020\r\nThời gian bảo hành:\t12 Tháng\r\nĐịa điểm bảo hành:\t\r\nRAM:\t\t\t4 GB\r\nBộ nhớ trong:\t\t128 GB\r\nHệ điều hành:\t\tiOS 14.1\r\nChipset:\t\t\tApple A14 Bionic\r\nCảm ứng:\t\tCó\r\nLoại màn hình:\t\tSuper Retina XDR\r\nKích thước màn hình:\t6.1 inch \"\r\nĐộ phân giải màn hình:\t2532 x 1170 pixels\r\nCamera trước:\t\t12MP\r\nCamera sau:\t\t12 MP (kép)\r\nĐèn Flash:\t\tCó\r\nVideo:\t\t\t4K\r\nMạng 3G:\t\tCó\r\nMạng 4G:\t\tCó\r\nWIFI:\t\t\tWi-Fi 6 (802.11ax)\r\nBluetooth:\t\tBluetooth 5.0\r\nUSB:\t\t\tType C\r\nMở khóa nhanh:\t\tMở khóa bằng khuôn mặt\r\nThiết kế:\t\t\tNguyên khối, mặt kính cường lực\r\nChống nước:\t\tCó, IP68\r\nKích thước sản phẩm:\t146.7 x 71.5 x 7.4mm mm"),
            new product("iPhone 12 128GB Tím", Resources.ip12_tim, "Tím", "128GB", 21990000,"Model:\t\t\tiPhone 12 128GB\r\nMàu sắc:\t\t\tTím\r\nNhà sản xuất:\t\tiPhone\r\nXuất xứ:\t\t\tTrung Quốc\r\nNăm ra mắt :\t\t2020\r\nThời gian bảo hành:\t12 Tháng\r\nĐịa điểm bảo hành:\t\r\nRAM:\t\t\t4 GB\r\nBộ nhớ trong:\t\t128 GB\r\nHệ điều hành:\t\tiOS 14.1\r\nChipset:\t\t\tApple A14 Bionic\r\nCảm ứng:\t\tCó\r\nLoại màn hình:\t\tSuper Retina XDR\r\nKích thước màn hình:\t6.1 inch \"\r\nĐộ phân giải màn hình:\t2532 x 1170 pixels\r\nCamera trước:\t\t12MP\r\nCamera sau:\t\t12 MP (kép)\r\nĐèn Flash:\t\tCó\r\nVideo:\t\t\t4K\r\nMạng 3G:\t\tCó\r\nMạng 4G:\t\tCó\r\nWIFI:\t\t\tWi-Fi 6 (802.11ax)\r\nBluetooth:\t\tBluetooth 5.0\r\nUSB:\t\t\tType C\r\nMở khóa nhanh:\t\tMở khóa bằng khuôn mặt\r\nThiết kế:\t\t\tNguyên khối, mặt kính cường lực\r\nChống nước:\t\tCó, IP68\r\nKích thước sản phẩm:\t146.7 x 71.5 x 7.4mm mm"),
            new product("iPhone 12 128GB Đen", Resources.ip12_den, "Đen", "128GB", 21990000,"Model:\t\t\tiPhone 12 128GB\r\nMàu sắc:\t\t\tĐen\r\nNhà sản xuất:\t\tiPhone\r\nXuất xứ:\t\t\tTrung Quốc\r\nNăm ra mắt :\t\t2020\r\nThời gian bảo hành:\t12 Tháng\r\nĐịa điểm bảo hành:\t\r\nRAM:\t\t\t4 GB\r\nBộ nhớ trong:\t\t128 GB\r\nHệ điều hành:\t\tiOS 14.1\r\nChipset:\t\t\tApple A14 Bionic\r\nCảm ứng:\t\tCó\r\nLoại màn hình:\t\tSuper Retina XDR\r\nKích thước màn hình:\t6.1 inch \"\r\nĐộ phân giải màn hình:\t2532 x 1170 pixels\r\nCamera trước:\t\t12MP\r\nCamera sau:\t\t12 MP (kép)\r\nĐèn Flash:\t\tCó\r\nVideo:\t\t\t4K\r\nMạng 3G:\t\tCó\r\nMạng 4G:\t\tCó\r\nWIFI:\t\t\tWi-Fi 6 (802.11ax)\r\nBluetooth:\t\tBluetooth 5.0\r\nUSB:\t\t\tType C\r\nMở khóa nhanh:\t\tMở khóa bằng khuôn mặt\r\nThiết kế:\t\t\tNguyên khối, mặt kính cường lực\r\nChống nước:\t\tCó, IP68\r\nKích thước sản phẩm:\t146.7 x 71.5 x 7.4mm mm"),
            new product("iPhone 12 128GB Đỏ", Resources.ip12_do, "Đỏ", "128GB", 21990000,"Model:\t\t\tiPhone 12 128GB\r\nMàu sắc:\t\t\tĐỏ\r\nNhà sản xuất:\t\tiPhone\r\nXuất xứ:\t\t\tTrung Quốc\r\nNăm ra mắt :\t\t2020\r\nThời gian bảo hành:\t12 Tháng\r\nĐịa điểm bảo hành:\t\r\nRAM:\t\t\t4 GB\r\nBộ nhớ trong:\t\t128 GB\r\nHệ điều hành:\t\tiOS 14.1\r\nChipset:\t\t\tApple A14 Bionic\r\nCảm ứng:\t\tCó\r\nLoại màn hình:\t\tSuper Retina XDR\r\nKích thước màn hình:\t6.1 inch \"\r\nĐộ phân giải màn hình:\t2532 x 1170 pixels\r\nCamera trước:\t\t12MP\r\nCamera sau:\t\t12 MP (kép)\r\nĐèn Flash:\t\tCó\r\nVideo:\t\t\t4K\r\nMạng 3G:\t\tCó\r\nMạng 4G:\t\tCó\r\nWIFI:\t\t\tWi-Fi 6 (802.11ax)\r\nBluetooth:\t\tBluetooth 5.0\r\nUSB:\t\t\tType C\r\nMở khóa nhanh:\t\tMở khóa bằng khuôn mặt\r\nThiết kế:\t\t\tNguyên khối, mặt kính cường lực\r\nChống nước:\t\tCó, IP68\r\nKích thước sản phẩm:\t146.7 x 71.5 x 7.4mm mm"),

            new product("iPhone 12 256GB Trắng", Resources.ip12_trang, "Trắng", "256GB", 28990000,"Model:\t\t\tiPhone 12 256GB\r\nMàu sắc:\t\t\tTrắng\r\nNhà sản xuất:\t\tiPhone\r\nXuất xứ:\t\t\tTrung Quốc\r\nNăm ra mắt :\t\t2020\r\nThời gian bảo hành:\t12 Tháng\r\nĐịa điểm bảo hành:\t\r\nRAM:\t\t\t4 GB\r\nBộ nhớ trong:\t\t256 GB\r\nHệ điều hành:\t\tiOS 14.1\r\nChipset:\t\t\tApple A14 Bionic\r\nCảm ứng:\t\tCó\r\nLoại màn hình:\t\tSuper Retina XDR\r\nKích thước màn hình:\t6.1 inch \"\r\nĐộ phân giải màn hình:\t2532 x 1170 pixels\r\nCamera trước:\t\t12MP\r\nCamera sau:\t\t12 MP (kép)\r\nĐèn Flash:\t\tCó\r\nVideo:\t\t\t4K\r\nMạng 3G:\t\tCó\r\nMạng 4G:\t\tCó\r\nWIFI:\t\t\tWi-Fi 6 (802.11ax)\r\nBluetooth:\t\tBluetooth 5.0\r\nUSB:\t\t\tType C\r\nMở khóa nhanh:\t\tMở khóa bằng khuôn mặt\r\nThiết kế:\t\t\tNguyên khối, mặt kính cường lực\r\nChống nước:\t\tCó, IP68\r\nKích thước sản phẩm:\t146.7 x 71.5 x 7.4mm mm"),
            new product("iPhone 12 256GB Tím", Resources.ip12_tim, "Tím", "256GB", 28990000,"Model:\t\t\tiPhone 12 256GB\r\nMàu sắc:\t\t\tTím\r\nNhà sản xuất:\t\tiPhone\r\nXuất xứ:\t\t\tTrung Quốc\r\nNăm ra mắt :\t\t2020\r\nThời gian bảo hành:\t12 Tháng\r\nĐịa điểm bảo hành:\t\r\nRAM:\t\t\t4 GB\r\nBộ nhớ trong:\t\t256 GB\r\nHệ điều hành:\t\tiOS 14.1\r\nChipset:\t\t\tApple A14 Bionic\r\nCảm ứng:\t\tCó\r\nLoại màn hình:\t\tSuper Retina XDR\r\nKích thước màn hình:\t6.1 inch \"\r\nĐộ phân giải màn hình:\t2532 x 1170 pixels\r\nCamera trước:\t\t12MP\r\nCamera sau:\t\t12 MP (kép)\r\nĐèn Flash:\t\tCó\r\nVideo:\t\t\t4K\r\nMạng 3G:\t\tCó\r\nMạng 4G:\t\tCó\r\nWIFI:\t\t\tWi-Fi 6 (802.11ax)\r\nBluetooth:\t\tBluetooth 5.0\r\nUSB:\t\t\tType C\r\nMở khóa nhanh:\t\tMở khóa bằng khuôn mặt\r\nThiết kế:\t\t\tNguyên khối, mặt kính cường lực\r\nChống nước:\t\tCó, IP68\r\nKích thước sản phẩm:\t146.7 x 71.5 x 7.4mm mm"),
            new product("iPhone 12 256GB Đen", Resources.ip12_den, "Đen", "256GB", 28990000,"Model:\t\t\tiPhone 12 256GB\r\nMàu sắc:\t\t\tĐen\r\nNhà sản xuất:\t\tiPhone\r\nXuất xứ:\t\t\tTrung Quốc\r\nNăm ra mắt :\t\t2020\r\nThời gian bảo hành:\t12 Tháng\r\nĐịa điểm bảo hành:\t\r\nRAM:\t\t\t4 GB\r\nBộ nhớ trong:\t\t256 GB\r\nHệ điều hành:\t\tiOS 14.1\r\nChipset:\t\t\tApple A14 Bionic\r\nCảm ứng:\t\tCó\r\nLoại màn hình:\t\tSuper Retina XDR\r\nKích thước màn hình:\t6.1 inch \"\r\nĐộ phân giải màn hình:\t2532 x 1170 pixels\r\nCamera trước:\t\t12MP\r\nCamera sau:\t\t12 MP (kép)\r\nĐèn Flash:\t\tCó\r\nVideo:\t\t\t4K\r\nMạng 3G:\t\tCó\r\nMạng 4G:\t\tCó\r\nWIFI:\t\t\tWi-Fi 6 (802.11ax)\r\nBluetooth:\t\tBluetooth 5.0\r\nUSB:\t\t\tType C\r\nMở khóa nhanh:\t\tMở khóa bằng khuôn mặt\r\nThiết kế:\t\t\tNguyên khối, mặt kính cường lực\r\nChống nước:\t\tCó, IP68\r\nKích thước sản phẩm:\t146.7 x 71.5 x 7.4mm mm"),
            new product("iPhone 12 256GB Đỏ", Resources.ip12_do, "Đỏ", "256GB", 28990000,"Model:\t\t\tiPhone 12 256GB\r\nMàu sắc:\t\t\tĐỏ\r\nNhà sản xuất:\t\tiPhone\r\nXuất xứ:\t\t\tTrung Quốc\r\nNăm ra mắt :\t\t2020\r\nThời gian bảo hành:\t12 Tháng\r\nĐịa điểm bảo hành:\t\r\nRAM:\t\t\t4 GB\r\nBộ nhớ trong:\t\t256 GB\r\nHệ điều hành:\t\tiOS 14.1\r\nChipset:\t\t\tApple A14 Bionic\r\nCảm ứng:\t\tCó\r\nLoại màn hình:\t\tSuper Retina XDR\r\nKích thước màn hình:\t6.1 inch \"\r\nĐộ phân giải màn hình:\t2532 x 1170 pixels\r\nCamera trước:\t\t12MP\r\nCamera sau:\t\t12 MP (kép)\r\nĐèn Flash:\t\tCó\r\nVideo:\t\t\t4K\r\nMạng 3G:\t\tCó\r\nMạng 4G:\t\tCó\r\nWIFI:\t\t\tWi-Fi 6 (802.11ax)\r\nBluetooth:\t\tBluetooth 5.0\r\nUSB:\t\t\tType C\r\nMở khóa nhanh:\t\tMở khóa bằng khuôn mặt\r\nThiết kế:\t\t\tNguyên khối, mặt kính cường lực\r\nChống nước:\t\tCó, IP68\r\nKích thước sản phẩm:\t146.7 x 71.5 x 7.4mm mm"),

            new product("iPhone 12 Pro 128GB Bạc", Resources.ip12_pro_bac, "Bạc", "128GB", 22490000,"Model:\t\t\tiPhone 12 128GB\r\nMàu sắc:\t\t\tBạc\r\nNhà sản xuất:\t\tiPhone\r\nXuất xứ:\t\t\tTrung Quốc\r\nNăm ra mắt :\t\t2020\r\nThời gian bảo hành:\t12 Tháng\r\nĐịa điểm bảo hành:\t\r\nRAM:\t\t\t4 GB\r\nBộ nhớ trong:\t\t128 GB\r\nHệ điều hành:\t\tiOS 14.1\r\nChipset:\t\t\tApple A14 Bionic\r\nCảm ứng:\t\tCó\r\nLoại màn hình:\t\tSuper Retina XDR\r\nKích thước màn hình:\t6.1 inch \"\r\nĐộ phân giải màn hình:\t2532 x 1170 pixels\r\nCamera trước:\t\t12MP\r\nCamera sau:\t\t12 MP (kép)\r\nĐèn Flash:\t\tCó\r\nVideo:\t\t\t4K\r\nMạng 3G:\t\tCó\r\nMạng 4G:\t\tCó\r\nWIFI:\t\t\tWi-Fi 6 (802.11ax)\r\nBluetooth:\t\tBluetooth 5.0\r\nUSB:\t\t\tType C\r\nMở khóa nhanh:\t\tMở khóa bằng khuôn mặt\r\nThiết kế:\t\t\tNguyên khối, mặt kính cường lực\r\nChống nước:\t\tCó, IP68\r\nKích thước sản phẩm:\t146.7 x 71.5 x 7.4mm mm"),
            new product("iPhone 12 Pro 128GB Vàng", Resources.ip12_pro_vang, "Vàng", "128GB", 22490000,"Model:\t\t\tiPhone 12 128GB\r\nMàu sắc:\t\t\tVàng\r\nNhà sản xuất:\t\tiPhone\r\nXuất xứ:\t\t\tTrung Quốc\r\nNăm ra mắt :\t\t2020\r\nThời gian bảo hành:\t12 Tháng\r\nĐịa điểm bảo hành:\t\r\nRAM:\t\t\t4 GB\r\nBộ nhớ trong:\t\t128 GB\r\nHệ điều hành:\t\tiOS 14.1\r\nChipset:\t\t\tApple A14 Bionic\r\nCảm ứng:\t\tCó\r\nLoại màn hình:\t\tSuper Retina XDR\r\nKích thước màn hình:\t6.1 inch \"\r\nĐộ phân giải màn hình:\t2532 x 1170 pixels\r\nCamera trước:\t\t12MP\r\nCamera sau:\t\t12 MP (kép)\r\nĐèn Flash:\t\tCó\r\nVideo:\t\t\t4K\r\nMạng 3G:\t\tCó\r\nMạng 4G:\t\tCó\r\nWIFI:\t\t\tWi-Fi 6 (802.11ax)\r\nBluetooth:\t\tBluetooth 5.0\r\nUSB:\t\t\tType C\r\nMở khóa nhanh:\t\tMở khóa bằng khuôn mặt\r\nThiết kế:\t\t\tNguyên khối, mặt kính cường lực\r\nChống nước:\t\tCó, IP68\r\nKích thước sản phẩm:\t146.7 x 71.5 x 7.4mm mm"),
            new product("iPhone 12 Pro 128GB Xám", Resources.ip12_pro_xam, "Xám", "128GB", 22490000,"Model:\t\t\tiPhone 12 128GB\r\nMàu sắc:\t\t\tXám\r\nNhà sản xuất:\t\tiPhone\r\nXuất xứ:\t\t\tTrung Quốc\r\nNăm ra mắt :\t\t2020\r\nThời gian bảo hành:\t12 Tháng\r\nĐịa điểm bảo hành:\t\r\nRAM:\t\t\t4 GB\r\nBộ nhớ trong:\t\t128 GB\r\nHệ điều hành:\t\tiOS 14.1\r\nChipset:\t\t\tApple A14 Bionic\r\nCảm ứng:\t\tCó\r\nLoại màn hình:\t\tSuper Retina XDR\r\nKích thước màn hình:\t6.1 inch \"\r\nĐộ phân giải màn hình:\t2532 x 1170 pixels\r\nCamera trước:\t\t12MP\r\nCamera sau:\t\t12 MP (kép)\r\nĐèn Flash:\t\tCó\r\nVideo:\t\t\t4K\r\nMạng 3G:\t\tCó\r\nMạng 4G:\t\tCó\r\nWIFI:\t\t\tWi-Fi 6 (802.11ax)\r\nBluetooth:\t\tBluetooth 5.0\r\nUSB:\t\t\tType C\r\nMở khóa nhanh:\t\tMở khóa bằng khuôn mặt\r\nThiết kế:\t\t\tNguyên khối, mặt kính cường lực\r\nChống nước:\t\tCó, IP68\r\nKích thước sản phẩm:\t146.7 x 71.5 x 7.4mm mm"),
            new product("iPhone 12 Pro 128GB Xanh Dương", Resources.ip12_pro_xanhduong, "Xanh Dương", "128GB", 22490000,"Model:\t\t\tiPhone 12 128GB\r\nMàu sắc:\t\t\tXanh Dương\r\nNhà sản xuất:\t\tiPhone\r\nXuất xứ:\t\t\tTrung Quốc\r\nNăm ra mắt :\t\t2020\r\nThời gian bảo hành:\t12 Tháng\r\nĐịa điểm bảo hành:\t\r\nRAM:\t\t\t4 GB\r\nBộ nhớ trong:\t\t128 GB\r\nHệ điều hành:\t\tiOS 14.1\r\nChipset:\t\t\tApple A14 Bionic\r\nCảm ứng:\t\tCó\r\nLoại màn hình:\t\tSuper Retina XDR\r\nKích thước màn hình:\t6.1 inch \"\r\nĐộ phân giải màn hình:\t2532 x 1170 pixels\r\nCamera trước:\t\t12MP\r\nCamera sau:\t\t12 MP (kép)\r\nĐèn Flash:\t\tCó\r\nVideo:\t\t\t4K\r\nMạng 3G:\t\tCó\r\nMạng 4G:\t\tCó\r\nWIFI:\t\t\tWi-Fi 6 (802.11ax)\r\nBluetooth:\t\tBluetooth 5.0\r\nUSB:\t\t\tType C\r\nMở khóa nhanh:\t\tMở khóa bằng khuôn mặt\r\nThiết kế:\t\t\tNguyên khối, mặt kính cường lực\r\nChống nước:\t\tCó, IP68\r\nKích thước sản phẩm:\t146.7 x 71.5 x 7.4mm mm"),

            new product("iPhone 12 Pro 256GB Bạc", Resources.ip12_pro_bac, "Bạc", "256GB", 23990000,"Model:\t\t\tiPhone 12 256GB\r\nMàu sắc:\t\t\tBạc\r\nNhà sản xuất:\t\tiPhone\r\nXuất xứ:\t\t\tTrung Quốc\r\nNăm ra mắt :\t\t2020\r\nThời gian bảo hành:\t12 Tháng\r\nĐịa điểm bảo hành:\t\r\nRAM:\t\t\t4 GB\r\nBộ nhớ trong:\t\t256 GB\r\nHệ điều hành:\t\tiOS 14.1\r\nChipset:\t\t\tApple A14 Bionic\r\nCảm ứng:\t\tCó\r\nLoại màn hình:\t\tSuper Retina XDR\r\nKích thước màn hình:\t6.1 inch \"\r\nĐộ phân giải màn hình:\t2532 x 1170 pixels\r\nCamera trước:\t\t12MP\r\nCamera sau:\t\t12 MP (kép)\r\nĐèn Flash:\t\tCó\r\nVideo:\t\t\t4K\r\nMạng 3G:\t\tCó\r\nMạng 4G:\t\tCó\r\nWIFI:\t\t\tWi-Fi 6 (802.11ax)\r\nBluetooth:\t\tBluetooth 5.0\r\nUSB:\t\t\tType C\r\nMở khóa nhanh:\t\tMở khóa bằng khuôn mặt\r\nThiết kế:\t\t\tNguyên khối, mặt kính cường lực\r\nChống nước:\t\tCó, IP68\r\nKích thước sản phẩm:\t146.7 x 71.5 x 7.4mm mm"),
            new product("iPhone 12 Pro 256GB Vàng", Resources.ip12_pro_vang, "Vàng", "256GB", 23990000,"Model:\t\t\tiPhone 12 256GB\r\nMàu sắc:\t\t\tVàng\r\nNhà sản xuất:\t\tiPhone\r\nXuất xứ:\t\t\tTrung Quốc\r\nNăm ra mắt :\t\t2020\r\nThời gian bảo hành:\t12 Tháng\r\nĐịa điểm bảo hành:\t\r\nRAM:\t\t\t4 GB\r\nBộ nhớ trong:\t\t256 GB\r\nHệ điều hành:\t\tiOS 14.1\r\nChipset:\t\t\tApple A14 Bionic\r\nCảm ứng:\t\tCó\r\nLoại màn hình:\t\tSuper Retina XDR\r\nKích thước màn hình:\t6.1 inch \"\r\nĐộ phân giải màn hình:\t2532 x 1170 pixels\r\nCamera trước:\t\t12MP\r\nCamera sau:\t\t12 MP (kép)\r\nĐèn Flash:\t\tCó\r\nVideo:\t\t\t4K\r\nMạng 3G:\t\tCó\r\nMạng 4G:\t\tCó\r\nWIFI:\t\t\tWi-Fi 6 (802.11ax)\r\nBluetooth:\t\tBluetooth 5.0\r\nUSB:\t\t\tType C\r\nMở khóa nhanh:\t\tMở khóa bằng khuôn mặt\r\nThiết kế:\t\t\tNguyên khối, mặt kính cường lực\r\nChống nước:\t\tCó, IP68\r\nKích thước sản phẩm:\t146.7 x 71.5 x 7.4mm mm"),
            new product("iPhone 12 Pro 256GB Xám", Resources.ip12_pro_xam, "Xám", "256GB", 23990000,"Model:\t\t\tiPhone 12 256GB\r\nMàu sắc:\t\t\tXám\r\nNhà sản xuất:\t\tiPhone\r\nXuất xứ:\t\t\tTrung Quốc\r\nNăm ra mắt :\t\t2020\r\nThời gian bảo hành:\t12 Tháng\r\nĐịa điểm bảo hành:\t\r\nRAM:\t\t\t4 GB\r\nBộ nhớ trong:\t\t256 GB\r\nHệ điều hành:\t\tiOS 14.1\r\nChipset:\t\t\tApple A14 Bionic\r\nCảm ứng:\t\tCó\r\nLoại màn hình:\t\tSuper Retina XDR\r\nKích thước màn hình:\t6.1 inch \"\r\nĐộ phân giải màn hình:\t2532 x 1170 pixels\r\nCamera trước:\t\t12MP\r\nCamera sau:\t\t12 MP (kép)\r\nĐèn Flash:\t\tCó\r\nVideo:\t\t\t4K\r\nMạng 3G:\t\tCó\r\nMạng 4G:\t\tCó\r\nWIFI:\t\t\tWi-Fi 6 (802.11ax)\r\nBluetooth:\t\tBluetooth 5.0\r\nUSB:\t\t\tType C\r\nMở khóa nhanh:\t\tMở khóa bằng khuôn mặt\r\nThiết kế:\t\t\tNguyên khối, mặt kính cường lực\r\nChống nước:\t\tCó, IP68\r\nKích thước sản phẩm:\t146.7 x 71.5 x 7.4mm mm"),
            new product("iPhone 12 Pro 256GB Xanh Dương", Resources.ip12_pro_xanhduong, "Xanh Dương", "256GB", 23990000,"Model:\t\t\tiPhone 12 256GB\r\nMàu sắc:\t\t\tXanh Dương\r\nNhà sản xuất:\t\tiPhone\r\nXuất xứ:\t\t\tTrung Quốc\r\nNăm ra mắt :\t\t2020\r\nThời gian bảo hành:\t12 Tháng\r\nĐịa điểm bảo hành:\t\r\nRAM:\t\t\t4 GB\r\nBộ nhớ trong:\t\t256 GB\r\nHệ điều hành:\t\tiOS 14.1\r\nChipset:\t\t\tApple A14 Bionic\r\nCảm ứng:\t\tCó\r\nLoại màn hình:\t\tSuper Retina XDR\r\nKích thước màn hình:\t6.1 inch \"\r\nĐộ phân giải màn hình:\t2532 x 1170 pixels\r\nCamera trước:\t\t12MP\r\nCamera sau:\t\t12 MP (kép)\r\nĐèn Flash:\t\tCó\r\nVideo:\t\t\t4K\r\nMạng 3G:\t\tCó\r\nMạng 4G:\t\tCó\r\nWIFI:\t\t\tWi-Fi 6 (802.11ax)\r\nBluetooth:\t\tBluetooth 5.0\r\nUSB:\t\t\tType C\r\nMở khóa nhanh:\t\tMở khóa bằng khuôn mặt\r\nThiết kế:\t\t\tNguyên khối, mặt kính cường lực\r\nChống nước:\t\tCó, IP68\r\nKích thước sản phẩm:\t146.7 x 71.5 x 7.4mm mm"),

            new product("iPhone 12 Pro 512GB Bạc", Resources.ip12_pro_bac, "Bạc", "512GB", 40990000,"Model:\t\t\tiPhone 12 512GB\r\nMàu sắc:\t\t\tBạc\r\nNhà sản xuất:\t\tiPhone\r\nXuất xứ:\t\t\tTrung Quốc\r\nNăm ra mắt :\t\t2020\r\nThời gian bảo hành:\t12 Tháng\r\nĐịa điểm bảo hành:\t\r\nRAM:\t\t\t4 GB\r\nBộ nhớ trong:\t\t512 GB\r\nHệ điều hành:\t\tiOS 14.1\r\nChipset:\t\t\tApple A14 Bionic\r\nCảm ứng:\t\tCó\r\nLoại màn hình:\t\tSuper Retina XDR\r\nKích thước màn hình:\t6.1 inch \"\r\nĐộ phân giải màn hình:\t2532 x 1170 pixels\r\nCamera trước:\t\t12MP\r\nCamera sau:\t\t12 MP (kép)\r\nĐèn Flash:\t\tCó\r\nVideo:\t\t\t4K\r\nMạng 3G:\t\tCó\r\nMạng 4G:\t\tCó\r\nWIFI:\t\t\tWi-Fi 6 (802.11ax)\r\nBluetooth:\t\tBluetooth 5.0\r\nUSB:\t\t\tType C\r\nMở khóa nhanh:\t\tMở khóa bằng khuôn mặt\r\nThiết kế:\t\t\tNguyên khối, mặt kính cường lực\r\nChống nước:\t\tCó, IP68\r\nKích thước sản phẩm:\t146.7 x 71.5 x 7.4mm mm"),
            new product("iPhone 12 Pro 512GB Vàng", Resources.ip12_pro_vang, "Vàng", "512GB", 40990000,"Model:\t\t\tiPhone 12 512GB\r\nMàu sắc:\t\t\tVàng\r\nNhà sản xuất:\t\tiPhone\r\nXuất xứ:\t\t\tTrung Quốc\r\nNăm ra mắt :\t\t2020\r\nThời gian bảo hành:\t12 Tháng\r\nĐịa điểm bảo hành:\t\r\nRAM:\t\t\t4 GB\r\nBộ nhớ trong:\t\t512 GB\r\nHệ điều hành:\t\tiOS 14.1\r\nChipset:\t\t\tApple A14 Bionic\r\nCảm ứng:\t\tCó\r\nLoại màn hình:\t\tSuper Retina XDR\r\nKích thước màn hình:\t6.1 inch \"\r\nĐộ phân giải màn hình:\t2532 x 1170 pixels\r\nCamera trước:\t\t12MP\r\nCamera sau:\t\t12 MP (kép)\r\nĐèn Flash:\t\tCó\r\nVideo:\t\t\t4K\r\nMạng 3G:\t\tCó\r\nMạng 4G:\t\tCó\r\nWIFI:\t\t\tWi-Fi 6 (802.11ax)\r\nBluetooth:\t\tBluetooth 5.0\r\nUSB:\t\t\tType C\r\nMở khóa nhanh:\t\tMở khóa bằng khuôn mặt\r\nThiết kế:\t\t\tNguyên khối, mặt kính cường lực\r\nChống nước:\t\tCó, IP68\r\nKích thước sản phẩm:\t146.7 x 71.5 x 7.4mm mm"),
            new product("iPhone 12 Pro 512GB Xám", Resources.ip12_pro_xam, "Xám", "512GB", 40990000,"Model:\t\t\tiPhone 12 512GB\r\nMàu sắc:\t\t\tXám\r\nNhà sản xuất:\t\tiPhone\r\nXuất xứ:\t\t\tTrung Quốc\r\nNăm ra mắt :\t\t2020\r\nThời gian bảo hành:\t12 Tháng\r\nĐịa điểm bảo hành:\t\r\nRAM:\t\t\t4 GB\r\nBộ nhớ trong:\t\t512 GB\r\nHệ điều hành:\t\tiOS 14.1\r\nChipset:\t\t\tApple A14 Bionic\r\nCảm ứng:\t\tCó\r\nLoại màn hình:\t\tSuper Retina XDR\r\nKích thước màn hình:\t6.1 inch \"\r\nĐộ phân giải màn hình:\t2532 x 1170 pixels\r\nCamera trước:\t\t12MP\r\nCamera sau:\t\t12 MP (kép)\r\nĐèn Flash:\t\tCó\r\nVideo:\t\t\t4K\r\nMạng 3G:\t\tCó\r\nMạng 4G:\t\tCó\r\nWIFI:\t\t\tWi-Fi 6 (802.11ax)\r\nBluetooth:\t\tBluetooth 5.0\r\nUSB:\t\t\tType C\r\nMở khóa nhanh:\t\tMở khóa bằng khuôn mặt\r\nThiết kế:\t\t\tNguyên khối, mặt kính cường lực\r\nChống nước:\t\tCó, IP68\r\nKích thước sản phẩm:\t146.7 x 71.5 x 7.4mm mm"),
            new product("iPhone 12 Pro 512GB Xanh Dương", Resources.ip12_pro_xanhduong, "Xanh Dương", "512GB", 40990000,"Model:\t\t\tiPhone 12 512GB\r\nMàu sắc:\t\t\tXanh Dương\r\nNhà sản xuất:\t\tiPhone\r\nXuất xứ:\t\t\tTrung Quốc\r\nNăm ra mắt :\t\t2020\r\nThời gian bảo hành:\t12 Tháng\r\nĐịa điểm bảo hành:\t\r\nRAM:\t\t\t4 GB\r\nBộ nhớ trong:\t\t512 GB\r\nHệ điều hành:\t\tiOS 14.1\r\nChipset:\t\t\tApple A14 Bionic\r\nCảm ứng:\t\tCó\r\nLoại màn hình:\t\tSuper Retina XDR\r\nKích thước màn hình:\t6.1 inch \"\r\nĐộ phân giải màn hình:\t2532 x 1170 pixels\r\nCamera trước:\t\t12MP\r\nCamera sau:\t\t12 MP (kép)\r\nĐèn Flash:\t\tCó\r\nVideo:\t\t\t4K\r\nMạng 3G:\t\tCó\r\nMạng 4G:\t\tCó\r\nWIFI:\t\t\tWi-Fi 6 (802.11ax)\r\nBluetooth:\t\tBluetooth 5.0\r\nUSB:\t\t\tType C\r\nMở khóa nhanh:\t\tMở khóa bằng khuôn mặt\r\nThiết kế:\t\t\tNguyên khối, mặt kính cường lực\r\nChống nước:\t\tCó, IP68\r\nKích thước sản phẩm:\t146.7 x 71.5 x 7.4mm mm"),

            new product("iPhone 12 Pro Max 128GB Bạc", Resources.ip12_promax_bac, "Bạc", "128GB", 25490000,"Model:\t\t\tiPhone 12 128GB\r\nMàu sắc:\t\t\tBạc\r\nNhà sản xuất:\t\tiPhone\r\nXuất xứ:\t\t\tTrung Quốc\r\nNăm ra mắt :\t\t2020\r\nThời gian bảo hành:\t12 Tháng\r\nĐịa điểm bảo hành:\t\r\nRAM:\t\t\t4 GB\r\nBộ nhớ trong:\t\t128 GB\r\nHệ điều hành:\t\tiOS 14.1\r\nChipset:\t\t\tApple A14 Bionic\r\nCảm ứng:\t\tCó\r\nLoại màn hình:\t\tSuper Retina XDR\r\nKích thước màn hình:\t6.1 inch \"\r\nĐộ phân giải màn hình:\t2532 x 1170 pixels\r\nCamera trước:\t\t12MP\r\nCamera sau:\t\t12 MP (kép)\r\nĐèn Flash:\t\tCó\r\nVideo:\t\t\t4K\r\nMạng 3G:\t\tCó\r\nMạng 4G:\t\tCó\r\nWIFI:\t\t\tWi-Fi 6 (802.11ax)\r\nBluetooth:\t\tBluetooth 5.0\r\nUSB:\t\t\tType C\r\nMở khóa nhanh:\t\tMở khóa bằng khuôn mặt\r\nThiết kế:\t\t\tNguyên khối, mặt kính cường lực\r\nChống nước:\t\tCó, IP68\r\nKích thước sản phẩm:\t146.7 x 71.5 x 7.4mm mm"),
            new product("iPhone 12 Pro Max 128GB Vàng", Resources.ip12_promax_vang, "Vàng", "128GB", 25490000,"Model:\t\t\tiPhone 12 128GB\r\nMàu sắc:\t\t\tVàng\r\nNhà sản xuất:\t\tiPhone\r\nXuất xứ:\t\t\tTrung Quốc\r\nNăm ra mắt :\t\t2020\r\nThời gian bảo hành:\t12 Tháng\r\nĐịa điểm bảo hành:\t\r\nRAM:\t\t\t4 GB\r\nBộ nhớ trong:\t\t128 GB\r\nHệ điều hành:\t\tiOS 14.1\r\nChipset:\t\t\tApple A14 Bionic\r\nCảm ứng:\t\tCó\r\nLoại màn hình:\t\tSuper Retina XDR\r\nKích thước màn hình:\t6.1 inch \"\r\nĐộ phân giải màn hình:\t2532 x 1170 pixels\r\nCamera trước:\t\t12MP\r\nCamera sau:\t\t12 MP (kép)\r\nĐèn Flash:\t\tCó\r\nVideo:\t\t\t4K\r\nMạng 3G:\t\tCó\r\nMạng 4G:\t\tCó\r\nWIFI:\t\t\tWi-Fi 6 (802.11ax)\r\nBluetooth:\t\tBluetooth 5.0\r\nUSB:\t\t\tType C\r\nMở khóa nhanh:\t\tMở khóa bằng khuôn mặt\r\nThiết kế:\t\t\tNguyên khối, mặt kính cường lực\r\nChống nước:\t\tCó, IP68\r\nKích thước sản phẩm:\t146.7 x 71.5 x 7.4mm mm"),
            new product("iPhone 12 Pro Max 128GB Xám", Resources.ip12_promax_xam, "Xám", "128GB", 25490000,"Model:\t\t\tiPhone 12 128GB\r\nMàu sắc:\t\t\tXám\r\nNhà sản xuất:\t\tiPhone\r\nXuất xứ:\t\t\tTrung Quốc\r\nNăm ra mắt :\t\t2020\r\nThời gian bảo hành:\t12 Tháng\r\nĐịa điểm bảo hành:\t\r\nRAM:\t\t\t4 GB\r\nBộ nhớ trong:\t\t128 GB\r\nHệ điều hành:\t\tiOS 14.1\r\nChipset:\t\t\tApple A14 Bionic\r\nCảm ứng:\t\tCó\r\nLoại màn hình:\t\tSuper Retina XDR\r\nKích thước màn hình:\t6.1 inch \"\r\nĐộ phân giải màn hình:\t2532 x 1170 pixels\r\nCamera trước:\t\t12MP\r\nCamera sau:\t\t12 MP (kép)\r\nĐèn Flash:\t\tCó\r\nVideo:\t\t\t4K\r\nMạng 3G:\t\tCó\r\nMạng 4G:\t\tCó\r\nWIFI:\t\t\tWi-Fi 6 (802.11ax)\r\nBluetooth:\t\tBluetooth 5.0\r\nUSB:\t\t\tType C\r\nMở khóa nhanh:\t\tMở khóa bằng khuôn mặt\r\nThiết kế:\t\t\tNguyên khối, mặt kính cường lực\r\nChống nước:\t\tCó, IP68\r\nKích thước sản phẩm:\t146.7 x 71.5 x 7.4mm mm"),
            new product("iPhone 12 Pro Max 128GB Xanh", Resources.ip12_promax_xanh, "Xanh", "128GB", 25490000,"Model:\t\t\tiPhone 12 128GB\r\nMàu sắc:\t\t\tXanh\r\nNhà sản xuất:\t\tiPhone\r\nXuất xứ:\t\t\tTrung Quốc\r\nNăm ra mắt :\t\t2020\r\nThời gian bảo hành:\t12 Tháng\r\nĐịa điểm bảo hành:\t\r\nRAM:\t\t\t4 GB\r\nBộ nhớ trong:\t\t128 GB\r\nHệ điều hành:\t\tiOS 14.1\r\nChipset:\t\t\tApple A14 Bionic\r\nCảm ứng:\t\tCó\r\nLoại màn hình:\t\tSuper Retina XDR\r\nKích thước màn hình:\t6.1 inch \"\r\nĐộ phân giải màn hình:\t2532 x 1170 pixels\r\nCamera trước:\t\t12MP\r\nCamera sau:\t\t12 MP (kép)\r\nĐèn Flash:\t\tCó\r\nVideo:\t\t\t4K\r\nMạng 3G:\t\tCó\r\nMạng 4G:\t\tCó\r\nWIFI:\t\t\tWi-Fi 6 (802.11ax)\r\nBluetooth:\t\tBluetooth 5.0\r\nUSB:\t\t\tType C\r\nMở khóa nhanh:\t\tMở khóa bằng khuôn mặt\r\nThiết kế:\t\t\tNguyên khối, mặt kính cường lực\r\nChống nước:\t\tCó, IP68\r\nKích thước sản phẩm:\t146.7 x 71.5 x 7.4mm mm"),

            new product("iPhone 12 Pro Max 256GB Bạc", Resources.ip12_promax_bac, "Bạc", "256GB", 27490000,"Model:\t\t\tiPhone 12 256GB\r\nMàu sắc:\t\t\tBạc\r\nNhà sản xuất:\t\tiPhone\r\nXuất xứ:\t\t\tTrung Quốc\r\nNăm ra mắt :\t\t2020\r\nThời gian bảo hành:\t12 Tháng\r\nĐịa điểm bảo hành:\t\r\nRAM:\t\t\t4 GB\r\nBộ nhớ trong:\t\t256 GB\r\nHệ điều hành:\t\tiOS 14.1\r\nChipset:\t\t\tApple A14 Bionic\r\nCảm ứng:\t\tCó\r\nLoại màn hình:\t\tSuper Retina XDR\r\nKích thước màn hình:\t6.1 inch \"\r\nĐộ phân giải màn hình:\t2532 x 1170 pixels\r\nCamera trước:\t\t12MP\r\nCamera sau:\t\t12 MP (kép)\r\nĐèn Flash:\t\tCó\r\nVideo:\t\t\t4K\r\nMạng 3G:\t\tCó\r\nMạng 4G:\t\tCó\r\nWIFI:\t\t\tWi-Fi 6 (802.11ax)\r\nBluetooth:\t\tBluetooth 5.0\r\nUSB:\t\t\tType C\r\nMở khóa nhanh:\t\tMở khóa bằng khuôn mặt\r\nThiết kế:\t\t\tNguyên khối, mặt kính cường lực\r\nChống nước:\t\tCó, IP68\r\nKích thước sản phẩm:\t146.7 x 71.5 x 7.4mm mm"),
            new product("iPhone 12 Pro Max 256GB Vàng", Resources.ip12_promax_vang, "Vàng", "256GB", 27490000,"Model:\t\t\tiPhone 12 256GB\r\nMàu sắc:\t\t\tVàng\r\nNhà sản xuất:\t\tiPhone\r\nXuất xứ:\t\t\tTrung Quốc\r\nNăm ra mắt :\t\t2020\r\nThời gian bảo hành:\t12 Tháng\r\nĐịa điểm bảo hành:\t\r\nRAM:\t\t\t4 GB\r\nBộ nhớ trong:\t\t256 GB\r\nHệ điều hành:\t\tiOS 14.1\r\nChipset:\t\t\tApple A14 Bionic\r\nCảm ứng:\t\tCó\r\nLoại màn hình:\t\tSuper Retina XDR\r\nKích thước màn hình:\t6.1 inch \"\r\nĐộ phân giải màn hình:\t2532 x 1170 pixels\r\nCamera trước:\t\t12MP\r\nCamera sau:\t\t12 MP (kép)\r\nĐèn Flash:\t\tCó\r\nVideo:\t\t\t4K\r\nMạng 3G:\t\tCó\r\nMạng 4G:\t\tCó\r\nWIFI:\t\t\tWi-Fi 6 (802.11ax)\r\nBluetooth:\t\tBluetooth 5.0\r\nUSB:\t\t\tType C\r\nMở khóa nhanh:\t\tMở khóa bằng khuôn mặt\r\nThiết kế:\t\t\tNguyên khối, mặt kính cường lực\r\nChống nước:\t\tCó, IP68\r\nKích thước sản phẩm:\t146.7 x 71.5 x 7.4mm mm"),
            new product("iPhone 12 Pro Max 256GB Xám", Resources.ip12_promax_xam, "Xám", "256GB", 27490000,"Model:\t\t\tiPhone 12 256GB\r\nMàu sắc:\t\t\tXám\r\nNhà sản xuất:\t\tiPhone\r\nXuất xứ:\t\t\tTrung Quốc\r\nNăm ra mắt :\t\t2020\r\nThời gian bảo hành:\t12 Tháng\r\nĐịa điểm bảo hành:\t\r\nRAM:\t\t\t4 GB\r\nBộ nhớ trong:\t\t256 GB\r\nHệ điều hành:\t\tiOS 14.1\r\nChipset:\t\t\tApple A14 Bionic\r\nCảm ứng:\t\tCó\r\nLoại màn hình:\t\tSuper Retina XDR\r\nKích thước màn hình:\t6.1 inch \"\r\nĐộ phân giải màn hình:\t2532 x 1170 pixels\r\nCamera trước:\t\t12MP\r\nCamera sau:\t\t12 MP (kép)\r\nĐèn Flash:\t\tCó\r\nVideo:\t\t\t4K\r\nMạng 3G:\t\tCó\r\nMạng 4G:\t\tCó\r\nWIFI:\t\t\tWi-Fi 6 (802.11ax)\r\nBluetooth:\t\tBluetooth 5.0\r\nUSB:\t\t\tType C\r\nMở khóa nhanh:\t\tMở khóa bằng khuôn mặt\r\nThiết kế:\t\t\tNguyên khối, mặt kính cường lực\r\nChống nước:\t\tCó, IP68\r\nKích thước sản phẩm:\t146.7 x 71.5 x 7.4mm mm"),
            new product("iPhone 12 Pro Max 256GB Xanh", Resources.ip12_promax_xanh, "Xanh", "256GB", 27490000,"Model:\t\t\tiPhone 12 256GB\r\nMàu sắc:\t\t\tXanh\r\nNhà sản xuất:\t\tiPhone\r\nXuất xứ:\t\t\tTrung Quốc\r\nNăm ra mắt :\t\t2020\r\nThời gian bảo hành:\t12 Tháng\r\nĐịa điểm bảo hành:\t\r\nRAM:\t\t\t4 GB\r\nBộ nhớ trong:\t\t256 GB\r\nHệ điều hành:\t\tiOS 14.1\r\nChipset:\t\t\tApple A14 Bionic\r\nCảm ứng:\t\tCó\r\nLoại màn hình:\t\tSuper Retina XDR\r\nKích thước màn hình:\t6.1 inch \"\r\nĐộ phân giải màn hình:\t2532 x 1170 pixels\r\nCamera trước:\t\t12MP\r\nCamera sau:\t\t12 MP (kép)\r\nĐèn Flash:\t\tCó\r\nVideo:\t\t\t4K\r\nMạng 3G:\t\tCó\r\nMạng 4G:\t\tCó\r\nWIFI:\t\t\tWi-Fi 6 (802.11ax)\r\nBluetooth:\t\tBluetooth 5.0\r\nUSB:\t\t\tType C\r\nMở khóa nhanh:\t\tMở khóa bằng khuôn mặt\r\nThiết kế:\t\t\tNguyên khối, mặt kính cường lực\r\nChống nước:\t\tCó, IP68\r\nKích thước sản phẩm:\t146.7 x 71.5 x 7.4mm mm"),

            new product("iPhone 12 Pro Max 512GB Bạc", Resources.ip12_promax_bac, "Bạc", "512GB", 43990000,"Model:\t\t\tiPhone 12 512GB\r\nMàu sắc:\t\t\tBạc\r\nNhà sản xuất:\t\tiPhone\r\nXuất xứ:\t\t\tTrung Quốc\r\nNăm ra mắt :\t\t2020\r\nThời gian bảo hành:\t12 Tháng\r\nĐịa điểm bảo hành:\t\r\nRAM:\t\t\t4 GB\r\nBộ nhớ trong:\t\t512 GB\r\nHệ điều hành:\t\tiOS 14.1\r\nChipset:\t\t\tApple A14 Bionic\r\nCảm ứng:\t\tCó\r\nLoại màn hình:\t\tSuper Retina XDR\r\nKích thước màn hình:\t6.1 inch \"\r\nĐộ phân giải màn hình:\t2532 x 1170 pixels\r\nCamera trước:\t\t12MP\r\nCamera sau:\t\t12 MP (kép)\r\nĐèn Flash:\t\tCó\r\nVideo:\t\t\t4K\r\nMạng 3G:\t\tCó\r\nMạng 4G:\t\tCó\r\nWIFI:\t\t\tWi-Fi 6 (802.11ax)\r\nBluetooth:\t\tBluetooth 5.0\r\nUSB:\t\t\tType C\r\nMở khóa nhanh:\t\tMở khóa bằng khuôn mặt\r\nThiết kế:\t\t\tNguyên khối, mặt kính cường lực\r\nChống nước:\t\tCó, IP68\r\nKích thước sản phẩm:\t146.7 x 71.5 x 7.4mm mm"),
            new product("iPhone 12 Pro Max 512GB Vàng", Resources.ip12_promax_vang, "Vàng", "512GB", 43990000,"Model:\t\t\tiPhone 12 512GB\r\nMàu sắc:\t\t\tVàng\r\nNhà sản xuất:\t\tiPhone\r\nXuất xứ:\t\t\tTrung Quốc\r\nNăm ra mắt :\t\t2020\r\nThời gian bảo hành:\t12 Tháng\r\nĐịa điểm bảo hành:\t\r\nRAM:\t\t\t4 GB\r\nBộ nhớ trong:\t\t512 GB\r\nHệ điều hành:\t\tiOS 14.1\r\nChipset:\t\t\tApple A14 Bionic\r\nCảm ứng:\t\tCó\r\nLoại màn hình:\t\tSuper Retina XDR\r\nKích thước màn hình:\t6.1 inch \"\r\nĐộ phân giải màn hình:\t2532 x 1170 pixels\r\nCamera trước:\t\t12MP\r\nCamera sau:\t\t12 MP (kép)\r\nĐèn Flash:\t\tCó\r\nVideo:\t\t\t4K\r\nMạng 3G:\t\tCó\r\nMạng 4G:\t\tCó\r\nWIFI:\t\t\tWi-Fi 6 (802.11ax)\r\nBluetooth:\t\tBluetooth 5.0\r\nUSB:\t\t\tType C\r\nMở khóa nhanh:\t\tMở khóa bằng khuôn mặt\r\nThiết kế:\t\t\tNguyên khối, mặt kính cường lực\r\nChống nước:\t\tCó, IP68\r\nKích thước sản phẩm:\t146.7 x 71.5 x 7.4mm mm"),
            new product("iPhone 12 Pro Max 512GB Xám", Resources.ip12_promax_xam, "Xám", "512GB", 43990000,"Model:\t\t\tiPhone 12 512GB\r\nMàu sắc:\t\t\tXám\r\nNhà sản xuất:\t\tiPhone\r\nXuất xứ:\t\t\tTrung Quốc\r\nNăm ra mắt :\t\t2020\r\nThời gian bảo hành:\t12 Tháng\r\nĐịa điểm bảo hành:\t\r\nRAM:\t\t\t4 GB\r\nBộ nhớ trong:\t\t512 GB\r\nHệ điều hành:\t\tiOS 14.1\r\nChipset:\t\t\tApple A14 Bionic\r\nCảm ứng:\t\tCó\r\nLoại màn hình:\t\tSuper Retina XDR\r\nKích thước màn hình:\t6.1 inch \"\r\nĐộ phân giải màn hình:\t2532 x 1170 pixels\r\nCamera trước:\t\t12MP\r\nCamera sau:\t\t12 MP (kép)\r\nĐèn Flash:\t\tCó\r\nVideo:\t\t\t4K\r\nMạng 3G:\t\tCó\r\nMạng 4G:\t\tCó\r\nWIFI:\t\t\tWi-Fi 6 (802.11ax)\r\nBluetooth:\t\tBluetooth 5.0\r\nUSB:\t\t\tType C\r\nMở khóa nhanh:\t\tMở khóa bằng khuôn mặt\r\nThiết kế:\t\t\tNguyên khối, mặt kính cường lực\r\nChống nước:\t\tCó, IP68\r\nKích thước sản phẩm:\t146.7 x 71.5 x 7.4mm mm"),
            new product("iPhone 12 Pro Max 512GB Xanh", Resources.ip12_promax_xanh, "Xanh", "512GB", 43990000,"Model:\t\t\tiPhone 12 512GB\r\nMàu sắc:\t\t\tXanh\r\nNhà sản xuất:\t\tiPhone\r\nXuất xứ:\t\t\tTrung Quốc\r\nNăm ra mắt :\t\t2020\r\nThời gian bảo hành:\t12 Tháng\r\nĐịa điểm bảo hành:\t\r\nRAM:\t\t\t4 GB\r\nBộ nhớ trong:\t\t512 GB\r\nHệ điều hành:\t\tiOS 14.1\r\nChipset:\t\t\tApple A14 Bionic\r\nCảm ứng:\t\tCó\r\nLoại màn hình:\t\tSuper Retina XDR\r\nKích thước màn hình:\t6.1 inch \"\r\nĐộ phân giải màn hình:\t2532 x 1170 pixels\r\nCamera trước:\t\t12MP\r\nCamera sau:\t\t12 MP (kép)\r\nĐèn Flash:\t\tCó\r\nVideo:\t\t\t4K\r\nMạng 3G:\t\tCó\r\nMạng 4G:\t\tCó\r\nWIFI:\t\t\tWi-Fi 6 (802.11ax)\r\nBluetooth:\t\tBluetooth 5.0\r\nUSB:\t\t\tType C\r\nMở khóa nhanh:\t\tMở khóa bằng khuôn mặt\r\nThiết kế:\t\t\tNguyên khối, mặt kính cường lực\r\nChống nước:\t\tCó, IP68\r\nKích thước sản phẩm:\t146.7 x 71.5 x 7.4mm mm"),

            #endregion
            #region ip13

            new product("iPhone 13 128GB Trắng", Resources.ip13_trang, "Trắng", "128GB", 19190000,"Model:\t\t\tiPhone 13 128GB\r\nMàu sắc:\t\t\tTrắng\r\nNhà sản xuất:\t\tiPhone\r\nXuất xứ:\t\t\tTrung Quốc\r\nNăm ra mắt :\t\t2020\r\nThời gian bảo hành:\t12 Tháng\r\nĐịa điểm bảo hành:\t\r\nRAM:\t\t\t4 GB\r\nBộ nhớ trong:\t\t128 GB\r\nHệ điều hành:\t\tiOS 14.1\r\nChipset:\t\t\tApple A14 Bionic\r\nCảm ứng:\t\tCó\r\nLoại màn hình:\t\tSuper Retina XDR\r\nKích thước màn hình:\t6.1 inch \"\r\nĐộ phân giải màn hình:\t2532 x 1170 pixels\r\nCamera trước:\t\t12MP\r\nCamera sau:\t\t12 MP (kép)\r\nĐèn Flash:\t\tCó\r\nVideo:\t\t\t4K\r\nMạng 3G:\t\tCó\r\nMạng 4G:\t\tCó\r\nWIFI:\t\t\tWi-Fi 6 (802.11ax)\r\nBluetooth:\t\tBluetooth 5.0\r\nUSB:\t\t\tType C\r\nMở khóa nhanh:\t\tMở khóa bằng khuôn mặt\r\nThiết kế:\t\t\tNguyên khối, mặt kính cường lực\r\nChống nước:\t\tCó, IP68\r\nKích thước sản phẩm:\t146.7 x 71.5 x 7.4mm mm"),
            new product("iPhone 13 128GB Hồng", Resources.ip13_hong, "Hồng", "128GB", 19190000,"Model:\t\t\tiPhone 13 128GB\r\nMàu sắc:\t\t\tHồng\r\nNhà sản xuất:\t\tiPhone\r\nXuất xứ:\t\t\tTrung Quốc\r\nNăm ra mắt :\t\t2020\r\nThời gian bảo hành:\t12 Tháng\r\nĐịa điểm bảo hành:\t\r\nRAM:\t\t\t4 GB\r\nBộ nhớ trong:\t\t128 GB\r\nHệ điều hành:\t\tiOS 14.1\r\nChipset:\t\t\tApple A14 Bionic\r\nCảm ứng:\t\tCó\r\nLoại màn hình:\t\tSuper Retina XDR\r\nKích thước màn hình:\t6.1 inch \"\r\nĐộ phân giải màn hình:\t2532 x 1170 pixels\r\nCamera trước:\t\t12MP\r\nCamera sau:\t\t12 MP (kép)\r\nĐèn Flash:\t\tCó\r\nVideo:\t\t\t4K\r\nMạng 3G:\t\tCó\r\nMạng 4G:\t\tCó\r\nWIFI:\t\t\tWi-Fi 6 (802.11ax)\r\nBluetooth:\t\tBluetooth 5.0\r\nUSB:\t\t\tType C\r\nMở khóa nhanh:\t\tMở khóa bằng khuôn mặt\r\nThiết kế:\t\t\tNguyên khối, mặt kính cường lực\r\nChống nước:\t\tCó, IP68\r\nKích thước sản phẩm:\t146.7 x 71.5 x 7.4mm mm"),
            new product("iPhone 13 128GB Đen", Resources.ip13_den, "Đen", "128GB", 19190000,"Model:\t\t\tiPhone 13 128GB\r\nMàu sắc:\t\t\tĐen\r\nNhà sản xuất:\t\tiPhone\r\nXuất xứ:\t\t\tTrung Quốc\r\nNăm ra mắt :\t\t2020\r\nThời gian bảo hành:\t12 Tháng\r\nĐịa điểm bảo hành:\t\r\nRAM:\t\t\t4 GB\r\nBộ nhớ trong:\t\t128 GB\r\nHệ điều hành:\t\tiOS 14.1\r\nChipset:\t\t\tApple A14 Bionic\r\nCảm ứng:\t\tCó\r\nLoại màn hình:\t\tSuper Retina XDR\r\nKích thước màn hình:\t6.1 inch \"\r\nĐộ phân giải màn hình:\t2532 x 1170 pixels\r\nCamera trước:\t\t12MP\r\nCamera sau:\t\t12 MP (kép)\r\nĐèn Flash:\t\tCó\r\nVideo:\t\t\t4K\r\nMạng 3G:\t\tCó\r\nMạng 4G:\t\tCó\r\nWIFI:\t\t\tWi-Fi 6 (802.11ax)\r\nBluetooth:\t\tBluetooth 5.0\r\nUSB:\t\t\tType C\r\nMở khóa nhanh:\t\tMở khóa bằng khuôn mặt\r\nThiết kế:\t\t\tNguyên khối, mặt kính cường lực\r\nChống nước:\t\tCó, IP68\r\nKích thước sản phẩm:\t146.7 x 71.5 x 7.4mm mm"),
            new product("iPhone 13 128GB Đỏ", Resources.ip13_do, "Đỏ", "128GB", 19190000,"Model:\t\t\tiPhone 13 128GB\r\nMàu sắc:\t\t\tĐỏ\r\nNhà sản xuất:\t\tiPhone\r\nXuất xứ:\t\t\tTrung Quốc\r\nNăm ra mắt :\t\t2020\r\nThời gian bảo hành:\t12 Tháng\r\nĐịa điểm bảo hành:\t\r\nRAM:\t\t\t4 GB\r\nBộ nhớ trong:\t\t128 GB\r\nHệ điều hành:\t\tiOS 14.1\r\nChipset:\t\t\tApple A14 Bionic\r\nCảm ứng:\t\tCó\r\nLoại màn hình:\t\tSuper Retina XDR\r\nKích thước màn hình:\t6.1 inch \"\r\nĐộ phân giải màn hình:\t2532 x 1170 pixels\r\nCamera trước:\t\t12MP\r\nCamera sau:\t\t12 MP (kép)\r\nĐèn Flash:\t\tCó\r\nVideo:\t\t\t4K\r\nMạng 3G:\t\tCó\r\nMạng 4G:\t\tCó\r\nWIFI:\t\t\tWi-Fi 6 (802.11ax)\r\nBluetooth:\t\tBluetooth 5.0\r\nUSB:\t\t\tType C\r\nMở khóa nhanh:\t\tMở khóa bằng khuôn mặt\r\nThiết kế:\t\t\tNguyên khối, mặt kính cường lực\r\nChống nước:\t\tCó, IP68\r\nKích thước sản phẩm:\t146.7 x 71.5 x 7.4mm mm"),
            new product("iPhone 13 128GB Xanh", Resources.ip13_xanh, "Xanh", "128GB", 19190000,"Model:\t\t\tiPhone 13 128GB\r\nMàu sắc:\t\t\tXanh\r\nNhà sản xuất:\t\tiPhone\r\nXuất xứ:\t\t\tTrung Quốc\r\nNăm ra mắt :\t\t2020\r\nThời gian bảo hành:\t12 Tháng\r\nĐịa điểm bảo hành:\t\r\nRAM:\t\t\t4 GB\r\nBộ nhớ trong:\t\t128 GB\r\nHệ điều hành:\t\tiOS 14.1\r\nChipset:\t\t\tApple A14 Bionic\r\nCảm ứng:\t\tCó\r\nLoại màn hình:\t\tSuper Retina XDR\r\nKích thước màn hình:\t6.1 inch \"\r\nĐộ phân giải màn hình:\t2532 x 1170 pixels\r\nCamera trước:\t\t12MP\r\nCamera sau:\t\t12 MP (kép)\r\nĐèn Flash:\t\tCó\r\nVideo:\t\t\t4K\r\nMạng 3G:\t\tCó\r\nMạng 4G:\t\tCó\r\nWIFI:\t\t\tWi-Fi 6 (802.11ax)\r\nBluetooth:\t\tBluetooth 5.0\r\nUSB:\t\t\tType C\r\nMở khóa nhanh:\t\tMở khóa bằng khuôn mặt\r\nThiết kế:\t\t\tNguyên khối, mặt kính cường lực\r\nChống nước:\t\tCó, IP68\r\nKích thước sản phẩm:\t146.7 x 71.5 x 7.4mm mm"),

            new product("iPhone 13 256GB Trắng", Resources.ip13_trang, "Trắng", "256GB", 20490000,"Model:\t\t\tiPhone 13 256GB\r\nMàu sắc:\t\t\tTrắng\r\nNhà sản xuất:\t\tiPhone\r\nXuất xứ:\t\t\tTrung Quốc\r\nNăm ra mắt :\t\t2020\r\nThời gian bảo hành:\t12 Tháng\r\nĐịa điểm bảo hành:\t\r\nRAM:\t\t\t4 GB\r\nBộ nhớ trong:\t\t256 GB\r\nHệ điều hành:\t\tiOS 14.1\r\nChipset:\t\t\tApple A14 Bionic\r\nCảm ứng:\t\tCó\r\nLoại màn hình:\t\tSuper Retina XDR\r\nKích thước màn hình:\t6.1 inch \"\r\nĐộ phân giải màn hình:\t2532 x 1170 pixels\r\nCamera trước:\t\t12MP\r\nCamera sau:\t\t12 MP (kép)\r\nĐèn Flash:\t\tCó\r\nVideo:\t\t\t4K\r\nMạng 3G:\t\tCó\r\nMạng 4G:\t\tCó\r\nWIFI:\t\t\tWi-Fi 6 (802.11ax)\r\nBluetooth:\t\tBluetooth 5.0\r\nUSB:\t\t\tType C\r\nMở khóa nhanh:\t\tMở khóa bằng khuôn mặt\r\nThiết kế:\t\t\tNguyên khối, mặt kính cường lực\r\nChống nước:\t\tCó, IP68\r\nKích thước sản phẩm:\t146.7 x 71.5 x 7.4mm mm"),
            new product("iPhone 13 256GB Hồng", Resources.ip13_hong, "Hồng", "256GB", 20490000,"Model:\t\t\tiPhone 13 256GB\r\nMàu sắc:\t\t\tHồng\r\nNhà sản xuất:\t\tiPhone\r\nXuất xứ:\t\t\tTrung Quốc\r\nNăm ra mắt :\t\t2020\r\nThời gian bảo hành:\t12 Tháng\r\nĐịa điểm bảo hành:\t\r\nRAM:\t\t\t4 GB\r\nBộ nhớ trong:\t\t256 GB\r\nHệ điều hành:\t\tiOS 14.1\r\nChipset:\t\t\tApple A14 Bionic\r\nCảm ứng:\t\tCó\r\nLoại màn hình:\t\tSuper Retina XDR\r\nKích thước màn hình:\t6.1 inch \"\r\nĐộ phân giải màn hình:\t2532 x 1170 pixels\r\nCamera trước:\t\t12MP\r\nCamera sau:\t\t12 MP (kép)\r\nĐèn Flash:\t\tCó\r\nVideo:\t\t\t4K\r\nMạng 3G:\t\tCó\r\nMạng 4G:\t\tCó\r\nWIFI:\t\t\tWi-Fi 6 (802.11ax)\r\nBluetooth:\t\tBluetooth 5.0\r\nUSB:\t\t\tType C\r\nMở khóa nhanh:\t\tMở khóa bằng khuôn mặt\r\nThiết kế:\t\t\tNguyên khối, mặt kính cường lực\r\nChống nước:\t\tCó, IP68\r\nKích thước sản phẩm:\t146.7 x 71.5 x 7.4mm mm"),
            new product("iPhone 13 256GB Đen", Resources.ip13_den, "Đen", "256GB", 20490000,"Model:\t\t\tiPhone 13 256GB\r\nMàu sắc:\t\t\tĐen\r\nNhà sản xuất:\t\tiPhone\r\nXuất xứ:\t\t\tTrung Quốc\r\nNăm ra mắt :\t\t2020\r\nThời gian bảo hành:\t12 Tháng\r\nĐịa điểm bảo hành:\t\r\nRAM:\t\t\t4 GB\r\nBộ nhớ trong:\t\t256 GB\r\nHệ điều hành:\t\tiOS 14.1\r\nChipset:\t\t\tApple A14 Bionic\r\nCảm ứng:\t\tCó\r\nLoại màn hình:\t\tSuper Retina XDR\r\nKích thước màn hình:\t6.1 inch \"\r\nĐộ phân giải màn hình:\t2532 x 1170 pixels\r\nCamera trước:\t\t12MP\r\nCamera sau:\t\t12 MP (kép)\r\nĐèn Flash:\t\tCó\r\nVideo:\t\t\t4K\r\nMạng 3G:\t\tCó\r\nMạng 4G:\t\tCó\r\nWIFI:\t\t\tWi-Fi 6 (802.11ax)\r\nBluetooth:\t\tBluetooth 5.0\r\nUSB:\t\t\tType C\r\nMở khóa nhanh:\t\tMở khóa bằng khuôn mặt\r\nThiết kế:\t\t\tNguyên khối, mặt kính cường lực\r\nChống nước:\t\tCó, IP68\r\nKích thước sản phẩm:\t146.7 x 71.5 x 7.4mm mm"),
            new product("iPhone 13 256GB Đỏ", Resources.ip13_do, "Đỏ", "256GB", 20490000,"Model:\t\t\tiPhone 13 256GB\r\nMàu sắc:\t\t\tĐỏ\r\nNhà sản xuất:\t\tiPhone\r\nXuất xứ:\t\t\tTrung Quốc\r\nNăm ra mắt :\t\t2020\r\nThời gian bảo hành:\t12 Tháng\r\nĐịa điểm bảo hành:\t\r\nRAM:\t\t\t4 GB\r\nBộ nhớ trong:\t\t256 GB\r\nHệ điều hành:\t\tiOS 14.1\r\nChipset:\t\t\tApple A14 Bionic\r\nCảm ứng:\t\tCó\r\nLoại màn hình:\t\tSuper Retina XDR\r\nKích thước màn hình:\t6.1 inch \"\r\nĐộ phân giải màn hình:\t2532 x 1170 pixels\r\nCamera trước:\t\t12MP\r\nCamera sau:\t\t12 MP (kép)\r\nĐèn Flash:\t\tCó\r\nVideo:\t\t\t4K\r\nMạng 3G:\t\tCó\r\nMạng 4G:\t\tCó\r\nWIFI:\t\t\tWi-Fi 6 (802.11ax)\r\nBluetooth:\t\tBluetooth 5.0\r\nUSB:\t\t\tType C\r\nMở khóa nhanh:\t\tMở khóa bằng khuôn mặt\r\nThiết kế:\t\t\tNguyên khối, mặt kính cường lực\r\nChống nước:\t\tCó, IP68\r\nKích thước sản phẩm:\t146.7 x 71.5 x 7.4mm mm"),
            new product("iPhone 13 256GB Xanh", Resources.ip13_xanh, "Xanh", "256GB", 20490000,"Model:\t\t\tiPhone 13 256GB\r\nMàu sắc:\t\t\tXanh\r\nNhà sản xuất:\t\tiPhone\r\nXuất xứ:\t\t\tTrung Quốc\r\nNăm ra mắt :\t\t2020\r\nThời gian bảo hành:\t12 Tháng\r\nĐịa điểm bảo hành:\t\r\nRAM:\t\t\t4 GB\r\nBộ nhớ trong:\t\t256 GB\r\nHệ điều hành:\t\tiOS 14.1\r\nChipset:\t\t\tApple A14 Bionic\r\nCảm ứng:\t\tCó\r\nLoại màn hình:\t\tSuper Retina XDR\r\nKích thước màn hình:\t6.1 inch \"\r\nĐộ phân giải màn hình:\t2532 x 1170 pixels\r\nCamera trước:\t\t12MP\r\nCamera sau:\t\t12 MP (kép)\r\nĐèn Flash:\t\tCó\r\nVideo:\t\t\t4K\r\nMạng 3G:\t\tCó\r\nMạng 4G:\t\tCó\r\nWIFI:\t\t\tWi-Fi 6 (802.11ax)\r\nBluetooth:\t\tBluetooth 5.0\r\nUSB:\t\t\tType C\r\nMở khóa nhanh:\t\tMở khóa bằng khuôn mặt\r\nThiết kế:\t\t\tNguyên khối, mặt kính cường lực\r\nChống nước:\t\tCó, IP68\r\nKích thước sản phẩm:\t146.7 x 71.5 x 7.4mm mm"),

            new product("iPhone 13 512GB Trắng", Resources.ip13_trang, "Trắng", "512GB", 24990000,"Model:\t\t\tiPhone 13 512GB\r\nMàu sắc:\t\t\tTrắng\r\nNhà sản xuất:\t\tiPhone\r\nXuất xứ:\t\t\tTrung Quốc\r\nNăm ra mắt :\t\t2020\r\nThời gian bảo hành:\t12 Tháng\r\nĐịa điểm bảo hành:\t\r\nRAM:\t\t\t4 GB\r\nBộ nhớ trong:\t\t512 GB\r\nHệ điều hành:\t\tiOS 14.1\r\nChipset:\t\t\tApple A14 Bionic\r\nCảm ứng:\t\tCó\r\nLoại màn hình:\t\tSuper Retina XDR\r\nKích thước màn hình:\t6.1 inch \"\r\nĐộ phân giải màn hình:\t2532 x 1170 pixels\r\nCamera trước:\t\t12MP\r\nCamera sau:\t\t12 MP (kép)\r\nĐèn Flash:\t\tCó\r\nVideo:\t\t\t4K\r\nMạng 3G:\t\tCó\r\nMạng 4G:\t\tCó\r\nWIFI:\t\t\tWi-Fi 6 (802.11ax)\r\nBluetooth:\t\tBluetooth 5.0\r\nUSB:\t\t\tType C\r\nMở khóa nhanh:\t\tMở khóa bằng khuôn mặt\r\nThiết kế:\t\t\tNguyên khối, mặt kính cường lực\r\nChống nước:\t\tCó, IP68\r\nKích thước sản phẩm:\t146.7 x 71.5 x 7.4mm mm"),
            new product("iPhone 13 512GB Hồng", Resources.ip13_hong, "Hồng", "512GB", 24990000,"Model:\t\t\tiPhone 13 512GB\r\nMàu sắc:\t\t\tHồng\r\nNhà sản xuất:\t\tiPhone\r\nXuất xứ:\t\t\tTrung Quốc\r\nNăm ra mắt :\t\t2020\r\nThời gian bảo hành:\t12 Tháng\r\nĐịa điểm bảo hành:\t\r\nRAM:\t\t\t4 GB\r\nBộ nhớ trong:\t\t512 GB\r\nHệ điều hành:\t\tiOS 14.1\r\nChipset:\t\t\tApple A14 Bionic\r\nCảm ứng:\t\tCó\r\nLoại màn hình:\t\tSuper Retina XDR\r\nKích thước màn hình:\t6.1 inch \"\r\nĐộ phân giải màn hình:\t2532 x 1170 pixels\r\nCamera trước:\t\t12MP\r\nCamera sau:\t\t12 MP (kép)\r\nĐèn Flash:\t\tCó\r\nVideo:\t\t\t4K\r\nMạng 3G:\t\tCó\r\nMạng 4G:\t\tCó\r\nWIFI:\t\t\tWi-Fi 6 (802.11ax)\r\nBluetooth:\t\tBluetooth 5.0\r\nUSB:\t\t\tType C\r\nMở khóa nhanh:\t\tMở khóa bằng khuôn mặt\r\nThiết kế:\t\t\tNguyên khối, mặt kính cường lực\r\nChống nước:\t\tCó, IP68\r\nKích thước sản phẩm:\t146.7 x 71.5 x 7.4mm mm"),
            new product("iPhone 13 512GB Đen", Resources.ip13_den, "Đen", "512GB", 24990000,"Model:\t\t\tiPhone 13 512GB\r\nMàu sắc:\t\t\tĐen\r\nNhà sản xuất:\t\tiPhone\r\nXuất xứ:\t\t\tTrung Quốc\r\nNăm ra mắt :\t\t2020\r\nThời gian bảo hành:\t12 Tháng\r\nĐịa điểm bảo hành:\t\r\nRAM:\t\t\t4 GB\r\nBộ nhớ trong:\t\t512 GB\r\nHệ điều hành:\t\tiOS 14.1\r\nChipset:\t\t\tApple A14 Bionic\r\nCảm ứng:\t\tCó\r\nLoại màn hình:\t\tSuper Retina XDR\r\nKích thước màn hình:\t6.1 inch \"\r\nĐộ phân giải màn hình:\t2532 x 1170 pixels\r\nCamera trước:\t\t12MP\r\nCamera sau:\t\t12 MP (kép)\r\nĐèn Flash:\t\tCó\r\nVideo:\t\t\t4K\r\nMạng 3G:\t\tCó\r\nMạng 4G:\t\tCó\r\nWIFI:\t\t\tWi-Fi 6 (802.11ax)\r\nBluetooth:\t\tBluetooth 5.0\r\nUSB:\t\t\tType C\r\nMở khóa nhanh:\t\tMở khóa bằng khuôn mặt\r\nThiết kế:\t\t\tNguyên khối, mặt kính cường lực\r\nChống nước:\t\tCó, IP68\r\nKích thước sản phẩm:\t146.7 x 71.5 x 7.4mm mm"),
            new product("iPhone 13 512GB Đỏ", Resources.ip13_do, "Đỏ", "512GB", 24990000,"Model:\t\t\tiPhone 13 512GB\r\nMàu sắc:\t\t\tĐỏ\r\nNhà sản xuất:\t\tiPhone\r\nXuất xứ:\t\t\tTrung Quốc\r\nNăm ra mắt :\t\t2020\r\nThời gian bảo hành:\t12 Tháng\r\nĐịa điểm bảo hành:\t\r\nRAM:\t\t\t4 GB\r\nBộ nhớ trong:\t\t512 GB\r\nHệ điều hành:\t\tiOS 14.1\r\nChipset:\t\t\tApple A14 Bionic\r\nCảm ứng:\t\tCó\r\nLoại màn hình:\t\tSuper Retina XDR\r\nKích thước màn hình:\t6.1 inch \"\r\nĐộ phân giải màn hình:\t2532 x 1170 pixels\r\nCamera trước:\t\t12MP\r\nCamera sau:\t\t12 MP (kép)\r\nĐèn Flash:\t\tCó\r\nVideo:\t\t\t4K\r\nMạng 3G:\t\tCó\r\nMạng 4G:\t\tCó\r\nWIFI:\t\t\tWi-Fi 6 (802.11ax)\r\nBluetooth:\t\tBluetooth 5.0\r\nUSB:\t\t\tType C\r\nMở khóa nhanh:\t\tMở khóa bằng khuôn mặt\r\nThiết kế:\t\t\tNguyên khối, mặt kính cường lực\r\nChống nước:\t\tCó, IP68\r\nKích thước sản phẩm:\t146.7 x 71.5 x 7.4mm mm"),
            new product("iPhone 13 512GB Xanh", Resources.ip13_xanh, "Xanh", "512GB", 24990000,"Model:\t\t\tiPhone 13 512GB\r\nMàu sắc:\t\t\tXanh\r\nNhà sản xuất:\t\tiPhone\r\nXuất xứ:\t\t\tTrung Quốc\r\nNăm ra mắt :\t\t2020\r\nThời gian bảo hành:\t12 Tháng\r\nĐịa điểm bảo hành:\t\r\nRAM:\t\t\t4 GB\r\nBộ nhớ trong:\t\t512 GB\r\nHệ điều hành:\t\tiOS 14.1\r\nChipset:\t\t\tApple A14 Bionic\r\nCảm ứng:\t\tCó\r\nLoại màn hình:\t\tSuper Retina XDR\r\nKích thước màn hình:\t6.1 inch \"\r\nĐộ phân giải màn hình:\t2532 x 1170 pixels\r\nCamera trước:\t\t12MP\r\nCamera sau:\t\t12 MP (kép)\r\nĐèn Flash:\t\tCó\r\nVideo:\t\t\t4K\r\nMạng 3G:\t\tCó\r\nMạng 4G:\t\tCó\r\nWIFI:\t\t\tWi-Fi 6 (802.11ax)\r\nBluetooth:\t\tBluetooth 5.0\r\nUSB:\t\t\tType C\r\nMở khóa nhanh:\t\tMở khóa bằng khuôn mặt\r\nThiết kế:\t\t\tNguyên khối, mặt kính cường lực\r\nChống nước:\t\tCó, IP68\r\nKích thước sản phẩm:\t146.7 x 71.5 x 7.4mm mm"),

            new product("iPhone 13 Pro 128GB Bạc", Resources.ip13_pro_bac, "Bạc", "128GB", 25690000,"Model:\t\t\tiPhone 13 Pro 128GB\r\nMàu sắc:\t\t\tBạc\r\nNhà sản xuất:\t\tiPhone\r\nXuất xứ:\t\t\tTrung Quốc\r\nNăm ra mắt :\t\t2020\r\nThời gian bảo hành:\t12 Tháng\r\nĐịa điểm bảo hành:\t\r\nRAM:\t\t\t4 GB\r\nBộ nhớ trong:\t\t128 GB\r\nHệ điều hành:\t\tiOS 14.1\r\nChipset:\t\t\tApple A14 Bionic\r\nCảm ứng:\t\tCó\r\nLoại màn hình:\t\tSuper Retina XDR\r\nKích thước màn hình:\t6.1 inch \"\r\nĐộ phân giải màn hình:\t2532 x 1170 pixels\r\nCamera trước:\t\t12MP\r\nCamera sau:\t\t12 MP (kép)\r\nĐèn Flash:\t\tCó\r\nVideo:\t\t\t4K\r\nMạng 3G:\t\tCó\r\nMạng 4G:\t\tCó\r\nWIFI:\t\t\tWi-Fi 6 (802.11ax)\r\nBluetooth:\t\tBluetooth 5.0\r\nUSB:\t\t\tType C\r\nMở khóa nhanh:\t\tMở khóa bằng khuôn mặt\r\nThiết kế:\t\t\tNguyên khối, mặt kính cường lực\r\nChống nước:\t\tCó, IP68\r\nKích thước sản phẩm:\t146.7 x 71.5 x 7.4mm mm"),
            new product("iPhone 13 Pro 128GB Vàng", Resources.ip13_pro_vang, "Vàng", "128GB", 25690000,"Model:\t\t\tiPhone 13 Pro 128GB\r\nMàu sắc:\t\t\tVàng\r\nNhà sản xuất:\t\tiPhone\r\nXuất xứ:\t\t\tTrung Quốc\r\nNăm ra mắt :\t\t2020\r\nThời gian bảo hành:\t12 Tháng\r\nĐịa điểm bảo hành:\t\r\nRAM:\t\t\t4 GB\r\nBộ nhớ trong:\t\t128 GB\r\nHệ điều hành:\t\tiOS 14.1\r\nChipset:\t\t\tApple A14 Bionic\r\nCảm ứng:\t\tCó\r\nLoại màn hình:\t\tSuper Retina XDR\r\nKích thước màn hình:\t6.1 inch \"\r\nĐộ phân giải màn hình:\t2532 x 1170 pixels\r\nCamera trước:\t\t12MP\r\nCamera sau:\t\t12 MP (kép)\r\nĐèn Flash:\t\tCó\r\nVideo:\t\t\t4K\r\nMạng 3G:\t\tCó\r\nMạng 4G:\t\tCó\r\nWIFI:\t\t\tWi-Fi 6 (802.11ax)\r\nBluetooth:\t\tBluetooth 5.0\r\nUSB:\t\t\tType C\r\nMở khóa nhanh:\t\tMở khóa bằng khuôn mặt\r\nThiết kế:\t\t\tNguyên khối, mặt kính cường lực\r\nChống nước:\t\tCó, IP68\r\nKích thước sản phẩm:\t146.7 x 71.5 x 7.4mm mm"),
            new product("iPhone 13 Pro 128GB Xám", Resources.ip13_pro_xam, "Xám", "128GB", 25690000,"Model:\t\t\tiPhone 13 Pro 128GB\r\nMàu sắc:\t\t\tXám\r\nNhà sản xuất:\t\tiPhone\r\nXuất xứ:\t\t\tTrung Quốc\r\nNăm ra mắt :\t\t2020\r\nThời gian bảo hành:\t12 Tháng\r\nĐịa điểm bảo hành:\t\r\nRAM:\t\t\t4 GB\r\nBộ nhớ trong:\t\t128 GB\r\nHệ điều hành:\t\tiOS 14.1\r\nChipset:\t\t\tApple A14 Bionic\r\nCảm ứng:\t\tCó\r\nLoại màn hình:\t\tSuper Retina XDR\r\nKích thước màn hình:\t6.1 inch \"\r\nĐộ phân giải màn hình:\t2532 x 1170 pixels\r\nCamera trước:\t\t12MP\r\nCamera sau:\t\t12 MP (kép)\r\nĐèn Flash:\t\tCó\r\nVideo:\t\t\t4K\r\nMạng 3G:\t\tCó\r\nMạng 4G:\t\tCó\r\nWIFI:\t\t\tWi-Fi 6 (802.11ax)\r\nBluetooth:\t\tBluetooth 5.0\r\nUSB:\t\t\tType C\r\nMở khóa nhanh:\t\tMở khóa bằng khuôn mặt\r\nThiết kế:\t\t\tNguyên khối, mặt kính cường lực\r\nChống nước:\t\tCó, IP68\r\nKích thước sản phẩm:\t146.7 x 71.5 x 7.4mm mm"),
            new product("iPhone 13 Pro 128GB Xanh", Resources.ip13_pro_xanh, "Xanh", "128GB", 25690000,"Model:\t\t\tiPhone 13 Pro 128GB\r\nMàu sắc:\t\t\tXanh\r\nNhà sản xuất:\t\tiPhone\r\nXuất xứ:\t\t\tTrung Quốc\r\nNăm ra mắt :\t\t2020\r\nThời gian bảo hành:\t12 Tháng\r\nĐịa điểm bảo hành:\t\r\nRAM:\t\t\t4 GB\r\nBộ nhớ trong:\t\t128 GB\r\nHệ điều hành:\t\tiOS 14.1\r\nChipset:\t\t\tApple A14 Bionic\r\nCảm ứng:\t\tCó\r\nLoại màn hình:\t\tSuper Retina XDR\r\nKích thước màn hình:\t6.1 inch \"\r\nĐộ phân giải màn hình:\t2532 x 1170 pixels\r\nCamera trước:\t\t12MP\r\nCamera sau:\t\t12 MP (kép)\r\nĐèn Flash:\t\tCó\r\nVideo:\t\t\t4K\r\nMạng 3G:\t\tCó\r\nMạng 4G:\t\tCó\r\nWIFI:\t\t\tWi-Fi 6 (802.11ax)\r\nBluetooth:\t\tBluetooth 5.0\r\nUSB:\t\t\tType C\r\nMở khóa nhanh:\t\tMở khóa bằng khuôn mặt\r\nThiết kế:\t\t\tNguyên khối, mặt kính cường lực\r\nChống nước:\t\tCó, IP68\r\nKích thước sản phẩm:\t146.7 x 71.5 x 7.4mm mm"),

            new product("iPhone 13 Pro 256GB Bạc", Resources.ip13_pro_bac, "Bạc", "256GB", 27790000,"Model:\t\t\tiPhone 13 Pro 256GB\r\nMàu sắc:\t\t\tBạc\r\nNhà sản xuất:\t\tiPhone\r\nXuất xứ:\t\t\tTrung Quốc\r\nNăm ra mắt :\t\t2020\r\nThời gian bảo hành:\t12 Tháng\r\nĐịa điểm bảo hành:\t\r\nRAM:\t\t\t4 GB\r\nBộ nhớ trong:\t\t256 GB\r\nHệ điều hành:\t\tiOS 14.1\r\nChipset:\t\t\tApple A14 Bionic\r\nCảm ứng:\t\tCó\r\nLoại màn hình:\t\tSuper Retina XDR\r\nKích thước màn hình:\t6.1 inch \"\r\nĐộ phân giải màn hình:\t2532 x 1170 pixels\r\nCamera trước:\t\t12MP\r\nCamera sau:\t\t12 MP (kép)\r\nĐèn Flash:\t\tCó\r\nVideo:\t\t\t4K\r\nMạng 3G:\t\tCó\r\nMạng 4G:\t\tCó\r\nWIFI:\t\t\tWi-Fi 6 (802.11ax)\r\nBluetooth:\t\tBluetooth 5.0\r\nUSB:\t\t\tType C\r\nMở khóa nhanh:\t\tMở khóa bằng khuôn mặt\r\nThiết kế:\t\t\tNguyên khối, mặt kính cường lực\r\nChống nước:\t\tCó, IP68\r\nKích thước sản phẩm:\t146.7 x 71.5 x 7.4mm mm"),
            new product("iPhone 13 Pro 256GB Vàng", Resources.ip13_pro_vang, "Vàng", "256GB", 27790000,"Model:\t\t\tiPhone 13 Pro 256GB\r\nMàu sắc:\t\t\tVàng\r\nNhà sản xuất:\t\tiPhone\r\nXuất xứ:\t\t\tTrung Quốc\r\nNăm ra mắt :\t\t2020\r\nThời gian bảo hành:\t12 Tháng\r\nĐịa điểm bảo hành:\t\r\nRAM:\t\t\t4 GB\r\nBộ nhớ trong:\t\t256 GB\r\nHệ điều hành:\t\tiOS 14.1\r\nChipset:\t\t\tApple A14 Bionic\r\nCảm ứng:\t\tCó\r\nLoại màn hình:\t\tSuper Retina XDR\r\nKích thước màn hình:\t6.1 inch \"\r\nĐộ phân giải màn hình:\t2532 x 1170 pixels\r\nCamera trước:\t\t12MP\r\nCamera sau:\t\t12 MP (kép)\r\nĐèn Flash:\t\tCó\r\nVideo:\t\t\t4K\r\nMạng 3G:\t\tCó\r\nMạng 4G:\t\tCó\r\nWIFI:\t\t\tWi-Fi 6 (802.11ax)\r\nBluetooth:\t\tBluetooth 5.0\r\nUSB:\t\t\tType C\r\nMở khóa nhanh:\t\tMở khóa bằng khuôn mặt\r\nThiết kế:\t\t\tNguyên khối, mặt kính cường lực\r\nChống nước:\t\tCó, IP68\r\nKích thước sản phẩm:\t146.7 x 71.5 x 7.4mm mm"),
            new product("iPhone 13 Pro 256GB Xám", Resources.ip13_pro_xam, "Xám", "256GB", 27790000,"Model:\t\t\tiPhone 13 Pro 256GB\r\nMàu sắc:\t\t\tXám\r\nNhà sản xuất:\t\tiPhone\r\nXuất xứ:\t\t\tTrung Quốc\r\nNăm ra mắt :\t\t2020\r\nThời gian bảo hành:\t12 Tháng\r\nĐịa điểm bảo hành:\t\r\nRAM:\t\t\t4 GB\r\nBộ nhớ trong:\t\t256 GB\r\nHệ điều hành:\t\tiOS 14.1\r\nChipset:\t\t\tApple A14 Bionic\r\nCảm ứng:\t\tCó\r\nLoại màn hình:\t\tSuper Retina XDR\r\nKích thước màn hình:\t6.1 inch \"\r\nĐộ phân giải màn hình:\t2532 x 1170 pixels\r\nCamera trước:\t\t12MP\r\nCamera sau:\t\t12 MP (kép)\r\nĐèn Flash:\t\tCó\r\nVideo:\t\t\t4K\r\nMạng 3G:\t\tCó\r\nMạng 4G:\t\tCó\r\nWIFI:\t\t\tWi-Fi 6 (802.11ax)\r\nBluetooth:\t\tBluetooth 5.0\r\nUSB:\t\t\tType C\r\nMở khóa nhanh:\t\tMở khóa bằng khuôn mặt\r\nThiết kế:\t\t\tNguyên khối, mặt kính cường lực\r\nChống nước:\t\tCó, IP68\r\nKích thước sản phẩm:\t146.7 x 71.5 x 7.4mm mm"),
            new product("iPhone 13 Pro 256GB Xanh", Resources.ip13_pro_xanh, "Xanh", "256GB", 27790000,"Model:\t\t\tiPhone 13 Pro 256GB\r\nMàu sắc:\t\t\tXanh\r\nNhà sản xuất:\t\tiPhone\r\nXuất xứ:\t\t\tTrung Quốc\r\nNăm ra mắt :\t\t2020\r\nThời gian bảo hành:\t12 Tháng\r\nĐịa điểm bảo hành:\t\r\nRAM:\t\t\t4 GB\r\nBộ nhớ trong:\t\t256 GB\r\nHệ điều hành:\t\tiOS 14.1\r\nChipset:\t\t\tApple A14 Bionic\r\nCảm ứng:\t\tCó\r\nLoại màn hình:\t\tSuper Retina XDR\r\nKích thước màn hình:\t6.1 inch \"\r\nĐộ phân giải màn hình:\t2532 x 1170 pixels\r\nCamera trước:\t\t12MP\r\nCamera sau:\t\t12 MP (kép)\r\nĐèn Flash:\t\tCó\r\nVideo:\t\t\t4K\r\nMạng 3G:\t\tCó\r\nMạng 4G:\t\tCó\r\nWIFI:\t\t\tWi-Fi 6 (802.11ax)\r\nBluetooth:\t\tBluetooth 5.0\r\nUSB:\t\t\tType C\r\nMở khóa nhanh:\t\tMở khóa bằng khuôn mặt\r\nThiết kế:\t\t\tNguyên khối, mặt kính cường lực\r\nChống nước:\t\tCó, IP68\r\nKích thước sản phẩm:\t146.7 x 71.5 x 7.4mm mm"),

            new product("iPhone 13 Pro 512GB Bạc", Resources.ip13_pro_bac, "Bạc", "512GB", 28990000,"Model:\t\t\tiPhone 13 Pro 512GB\r\nMàu sắc:\t\t\tBạc\r\nNhà sản xuất:\t\tiPhone\r\nXuất xứ:\t\t\tTrung Quốc\r\nNăm ra mắt :\t\t2020\r\nThời gian bảo hành:\t12 Tháng\r\nĐịa điểm bảo hành:\t\r\nRAM:\t\t\t4 GB\r\nBộ nhớ trong:\t\t512 GB\r\nHệ điều hành:\t\tiOS 14.1\r\nChipset:\t\t\tApple A14 Bionic\r\nCảm ứng:\t\tCó\r\nLoại màn hình:\t\tSuper Retina XDR\r\nKích thước màn hình:\t6.1 inch \"\r\nĐộ phân giải màn hình:\t2532 x 1170 pixels\r\nCamera trước:\t\t12MP\r\nCamera sau:\t\t12 MP (kép)\r\nĐèn Flash:\t\tCó\r\nVideo:\t\t\t4K\r\nMạng 3G:\t\tCó\r\nMạng 4G:\t\tCó\r\nWIFI:\t\t\tWi-Fi 6 (802.11ax)\r\nBluetooth:\t\tBluetooth 5.0\r\nUSB:\t\t\tType C\r\nMở khóa nhanh:\t\tMở khóa bằng khuôn mặt\r\nThiết kế:\t\t\tNguyên khối, mặt kính cường lực\r\nChống nước:\t\tCó, IP68\r\nKích thước sản phẩm:\t146.7 x 71.5 x 7.4mm mm"),
            new product("iPhone 13 Pro 512GB Vàng", Resources.ip13_pro_vang, "Vàng", "512GB", 28990000,"Model:\t\t\tiPhone 13 Pro 512GB\r\nMàu sắc:\t\t\tVàng\r\nNhà sản xuất:\t\tiPhone\r\nXuất xứ:\t\t\tTrung Quốc\r\nNăm ra mắt :\t\t2020\r\nThời gian bảo hành:\t12 Tháng\r\nĐịa điểm bảo hành:\t\r\nRAM:\t\t\t4 GB\r\nBộ nhớ trong:\t\t512 GB\r\nHệ điều hành:\t\tiOS 14.1\r\nChipset:\t\t\tApple A14 Bionic\r\nCảm ứng:\t\tCó\r\nLoại màn hình:\t\tSuper Retina XDR\r\nKích thước màn hình:\t6.1 inch \"\r\nĐộ phân giải màn hình:\t2532 x 1170 pixels\r\nCamera trước:\t\t12MP\r\nCamera sau:\t\t12 MP (kép)\r\nĐèn Flash:\t\tCó\r\nVideo:\t\t\t4K\r\nMạng 3G:\t\tCó\r\nMạng 4G:\t\tCó\r\nWIFI:\t\t\tWi-Fi 6 (802.11ax)\r\nBluetooth:\t\tBluetooth 5.0\r\nUSB:\t\t\tType C\r\nMở khóa nhanh:\t\tMở khóa bằng khuôn mặt\r\nThiết kế:\t\t\tNguyên khối, mặt kính cường lực\r\nChống nước:\t\tCó, IP68\r\nKích thước sản phẩm:\t146.7 x 71.5 x 7.4mm mm"),
            new product("iPhone 13 Pro 512GB Xám", Resources.ip13_pro_xam, "Xám", "512GB", 28990000,"Model:\t\t\tiPhone 13 Pro 512GB\r\nMàu sắc:\t\t\tXám\r\nNhà sản xuất:\t\tiPhone\r\nXuất xứ:\t\t\tTrung Quốc\r\nNăm ra mắt :\t\t2020\r\nThời gian bảo hành:\t12 Tháng\r\nĐịa điểm bảo hành:\t\r\nRAM:\t\t\t4 GB\r\nBộ nhớ trong:\t\t512 GB\r\nHệ điều hành:\t\tiOS 14.1\r\nChipset:\t\t\tApple A14 Bionic\r\nCảm ứng:\t\tCó\r\nLoại màn hình:\t\tSuper Retina XDR\r\nKích thước màn hình:\t6.1 inch \"\r\nĐộ phân giải màn hình:\t2532 x 1170 pixels\r\nCamera trước:\t\t12MP\r\nCamera sau:\t\t12 MP (kép)\r\nĐèn Flash:\t\tCó\r\nVideo:\t\t\t4K\r\nMạng 3G:\t\tCó\r\nMạng 4G:\t\tCó\r\nWIFI:\t\t\tWi-Fi 6 (802.11ax)\r\nBluetooth:\t\tBluetooth 5.0\r\nUSB:\t\t\tType C\r\nMở khóa nhanh:\t\tMở khóa bằng khuôn mặt\r\nThiết kế:\t\t\tNguyên khối, mặt kính cường lực\r\nChống nước:\t\tCó, IP68\r\nKích thước sản phẩm:\t146.7 x 71.5 x 7.4mm mm"),
            new product("iPhone 13 Pro 512GB Xanh", Resources.ip13_pro_xanh, "Xanh", "512GB", 28990000,"Model:\t\t\tiPhone 13 Pro 512GB\r\nMàu sắc:\t\t\tXanh\r\nNhà sản xuất:\t\tiPhone\r\nXuất xứ:\t\t\tTrung Quốc\r\nNăm ra mắt :\t\t2020\r\nThời gian bảo hành:\t12 Tháng\r\nĐịa điểm bảo hành:\t\r\nRAM:\t\t\t4 GB\r\nBộ nhớ trong:\t\t512 GB\r\nHệ điều hành:\t\tiOS 14.1\r\nChipset:\t\t\tApple A14 Bionic\r\nCảm ứng:\t\tCó\r\nLoại màn hình:\t\tSuper Retina XDR\r\nKích thước màn hình:\t6.1 inch \"\r\nĐộ phân giải màn hình:\t2532 x 1170 pixels\r\nCamera trước:\t\t12MP\r\nCamera sau:\t\t12 MP (kép)\r\nĐèn Flash:\t\tCó\r\nVideo:\t\t\t4K\r\nMạng 3G:\t\tCó\r\nMạng 4G:\t\tCó\r\nWIFI:\t\t\tWi-Fi 6 (802.11ax)\r\nBluetooth:\t\tBluetooth 5.0\r\nUSB:\t\t\tType C\r\nMở khóa nhanh:\t\tMở khóa bằng khuôn mặt\r\nThiết kế:\t\t\tNguyên khối, mặt kính cường lực\r\nChống nước:\t\tCó, IP68\r\nKích thước sản phẩm:\t146.7 x 71.5 x 7.4mm mm"),

            new product("iPhone 13 Pro 1TB Bạc", Resources.ip13_pro_bac, "Bạc", "1TB", 46990000,"Model:\t\t\tiPhone 13 Pro 1TB\r\nMàu sắc:\t\t\tBạc\r\nNhà sản xuất:\t\tiPhone\r\nXuất xứ:\t\t\tTrung Quốc\r\nNăm ra mắt :\t\t2020\r\nThời gian bảo hành:\t12 Tháng\r\nĐịa điểm bảo hành:\t\r\nRAM:\t\t\t4 GB\r\nBộ nhớ trong:\t\t1 TB\r\nHệ điều hành:\t\tiOS 14.1\r\nChipset:\t\t\tApple A14 Bionic\r\nCảm ứng:\t\tCó\r\nLoại màn hình:\t\tSuper Retina XDR\r\nKích thước màn hình:\t6.1 inch \"\r\nĐộ phân giải màn hình:\t2532 x 1170 pixels\r\nCamera trước:\t\t12MP\r\nCamera sau:\t\t12 MP (kép)\r\nĐèn Flash:\t\tCó\r\nVideo:\t\t\t4K\r\nMạng 3G:\t\tCó\r\nMạng 4G:\t\tCó\r\nWIFI:\t\t\tWi-Fi 6 (802.11ax)\r\nBluetooth:\t\tBluetooth 5.0\r\nUSB:\t\t\tType C\r\nMở khóa nhanh:\t\tMở khóa bằng khuôn mặt\r\nThiết kế:\t\t\tNguyên khối, mặt kính cường lực\r\nChống nước:\t\tCó, IP68\r\nKích thước sản phẩm:\t146.7 x 71.5 x 7.4mm mm"),
            new product("iPhone 13 Pro 1TB Vàng", Resources.ip13_pro_vang, "Vàng", "1TB", 46990000,"Model:\t\t\tiPhone 13 Pro 1TB\r\nMàu sắc:\t\t\tVàng\r\nNhà sản xuất:\t\tiPhone\r\nXuất xứ:\t\t\tTrung Quốc\r\nNăm ra mắt :\t\t2020\r\nThời gian bảo hành:\t12 Tháng\r\nĐịa điểm bảo hành:\t\r\nRAM:\t\t\t4 GB\r\nBộ nhớ trong:\t\t1 TB\r\nHệ điều hành:\t\tiOS 14.1\r\nChipset:\t\t\tApple A14 Bionic\r\nCảm ứng:\t\tCó\r\nLoại màn hình:\t\tSuper Retina XDR\r\nKích thước màn hình:\t6.1 inch \"\r\nĐộ phân giải màn hình:\t2532 x 1170 pixels\r\nCamera trước:\t\t12MP\r\nCamera sau:\t\t12 MP (kép)\r\nĐèn Flash:\t\tCó\r\nVideo:\t\t\t4K\r\nMạng 3G:\t\tCó\r\nMạng 4G:\t\tCó\r\nWIFI:\t\t\tWi-Fi 6 (802.11ax)\r\nBluetooth:\t\tBluetooth 5.0\r\nUSB:\t\t\tType C\r\nMở khóa nhanh:\t\tMở khóa bằng khuôn mặt\r\nThiết kế:\t\t\tNguyên khối, mặt kính cường lực\r\nChống nước:\t\tCó, IP68\r\nKích thước sản phẩm:\t146.7 x 71.5 x 7.4mm mm"),
            new product("iPhone 13 Pro 1TB Xám", Resources.ip13_pro_xam, "Xám", "1TB", 46990000,"Model:\t\t\tiPhone 13 Pro 1TB\r\nMàu sắc:\t\t\tXám\r\nNhà sản xuất:\t\tiPhone\r\nXuất xứ:\t\t\tTrung Quốc\r\nNăm ra mắt :\t\t2020\r\nThời gian bảo hành:\t12 Tháng\r\nĐịa điểm bảo hành:\t\r\nRAM:\t\t\t4 GB\r\nBộ nhớ trong:\t\t1 TB\r\nHệ điều hành:\t\tiOS 14.1\r\nChipset:\t\t\tApple A14 Bionic\r\nCảm ứng:\t\tCó\r\nLoại màn hình:\t\tSuper Retina XDR\r\nKích thước màn hình:\t6.1 inch \"\r\nĐộ phân giải màn hình:\t2532 x 1170 pixels\r\nCamera trước:\t\t12MP\r\nCamera sau:\t\t12 MP (kép)\r\nĐèn Flash:\t\tCó\r\nVideo:\t\t\t4K\r\nMạng 3G:\t\tCó\r\nMạng 4G:\t\tCó\r\nWIFI:\t\t\tWi-Fi 6 (802.11ax)\r\nBluetooth:\t\tBluetooth 5.0\r\nUSB:\t\t\tType C\r\nMở khóa nhanh:\t\tMở khóa bằng khuôn mặt\r\nThiết kế:\t\t\tNguyên khối, mặt kính cường lực\r\nChống nước:\t\tCó, IP68\r\nKích thước sản phẩm:\t146.7 x 71.5 x 7.4mm mm"),
            new product("iPhone 13 Pro 1TB Xanh", Resources.ip13_pro_xanh, "Xanh", "1TB", 46990000,"Model:\t\t\tiPhone 13 Pro 1TB\r\nMàu sắc:\t\t\tXanh\r\nNhà sản xuất:\t\tiPhone\r\nXuất xứ:\t\t\tTrung Quốc\r\nNăm ra mắt :\t\t2020\r\nThời gian bảo hành:\t12 Tháng\r\nĐịa điểm bảo hành:\t\r\nRAM:\t\t\t4 GB\r\nBộ nhớ trong:\t\t1 TB\r\nHệ điều hành:\t\tiOS 14.1\r\nChipset:\t\t\tApple A14 Bionic\r\nCảm ứng:\t\tCó\r\nLoại màn hình:\t\tSuper Retina XDR\r\nKích thước màn hình:\t6.1 inch \"\r\nĐộ phân giải màn hình:\t2532 x 1170 pixels\r\nCamera trước:\t\t12MP\r\nCamera sau:\t\t12 MP (kép)\r\nĐèn Flash:\t\tCó\r\nVideo:\t\t\t4K\r\nMạng 3G:\t\tCó\r\nMạng 4G:\t\tCó\r\nWIFI:\t\t\tWi-Fi 6 (802.11ax)\r\nBluetooth:\t\tBluetooth 5.0\r\nUSB:\t\t\tType C\r\nMở khóa nhanh:\t\tMở khóa bằng khuôn mặt\r\nThiết kế:\t\t\tNguyên khối, mặt kính cường lực\r\nChống nước:\t\tCó, IP68\r\nKích thước sản phẩm:\t146.7 x 71.5 x 7.4mm mm"),

            new product("iPhone 13 Pro Max 128GB Bạc", Resources.ip13_promax_bac, "Bạc", "128GB", 27990000,"Model:\t\t\tiPhone 13 Pro Max 128GB\r\nMàu sắc:\t\t\tBạc\r\nNhà sản xuất:\t\tiPhone\r\nXuất xứ:\t\t\tTrung Quốc\r\nNăm ra mắt :\t\t2020\r\nThời gian bảo hành:\t12 Tháng\r\nĐịa điểm bảo hành:\t\r\nRAM:\t\t\t4 GB\r\nBộ nhớ trong:\t\t128 GB\r\nHệ điều hành:\t\tiOS 14.1\r\nChipset:\t\t\tApple A14 Bionic\r\nCảm ứng:\t\tCó\r\nLoại màn hình:\t\tSuper Retina XDR\r\nKích thước màn hình:\t6.1 inch \"\r\nĐộ phân giải màn hình:\t2532 x 1170 pixels\r\nCamera trước:\t\t12MP\r\nCamera sau:\t\t12 MP (kép)\r\nĐèn Flash:\t\tCó\r\nVideo:\t\t\t4K\r\nMạng 3G:\t\tCó\r\nMạng 4G:\t\tCó\r\nWIFI:\t\t\tWi-Fi 6 (802.11ax)\r\nBluetooth:\t\tBluetooth 5.0\r\nUSB:\t\t\tType C\r\nMở khóa nhanh:\t\tMở khóa bằng khuôn mặt\r\nThiết kế:\t\t\tNguyên khối, mặt kính cường lực\r\nChống nước:\t\tCó, IP68\r\nKích thước sản phẩm:\t146.7 x 71.5 x 7.4mm mm"),
            new product("iPhone 13 Pro Max 128GB Vàng", Resources.ip13_promax_vang, "Vàng", "128GB", 27990000,"Model:\t\t\tiPhone 13 Pro Max 128GB\r\nMàu sắc:\t\t\tVàng\r\nNhà sản xuất:\t\tiPhone\r\nXuất xứ:\t\t\tTrung Quốc\r\nNăm ra mắt :\t\t2020\r\nThời gian bảo hành:\t12 Tháng\r\nĐịa điểm bảo hành:\t\r\nRAM:\t\t\t4 GB\r\nBộ nhớ trong:\t\t128 GB\r\nHệ điều hành:\t\tiOS 14.1\r\nChipset:\t\t\tApple A14 Bionic\r\nCảm ứng:\t\tCó\r\nLoại màn hình:\t\tSuper Retina XDR\r\nKích thước màn hình:\t6.1 inch \"\r\nĐộ phân giải màn hình:\t2532 x 1170 pixels\r\nCamera trước:\t\t12MP\r\nCamera sau:\t\t12 MP (kép)\r\nĐèn Flash:\t\tCó\r\nVideo:\t\t\t4K\r\nMạng 3G:\t\tCó\r\nMạng 4G:\t\tCó\r\nWIFI:\t\t\tWi-Fi 6 (802.11ax)\r\nBluetooth:\t\tBluetooth 5.0\r\nUSB:\t\t\tType C\r\nMở khóa nhanh:\t\tMở khóa bằng khuôn mặt\r\nThiết kế:\t\t\tNguyên khối, mặt kính cường lực\r\nChống nước:\t\tCó, IP68\r\nKích thước sản phẩm:\t146.7 x 71.5 x 7.4mm mm"),
            new product("iPhone 13 Pro Max 128GB Xám", Resources.ip13_promax_xam, "Xám", "128GB", 27990000,"Model:\t\t\tiPhone 13 Pro Max 128GB\r\nMàu sắc:\t\t\tXám\r\nNhà sản xuất:\t\tiPhone\r\nXuất xứ:\t\t\tTrung Quốc\r\nNăm ra mắt :\t\t2020\r\nThời gian bảo hành:\t12 Tháng\r\nĐịa điểm bảo hành:\t\r\nRAM:\t\t\t4 GB\r\nBộ nhớ trong:\t\t128 GB\r\nHệ điều hành:\t\tiOS 14.1\r\nChipset:\t\t\tApple A14 Bionic\r\nCảm ứng:\t\tCó\r\nLoại màn hình:\t\tSuper Retina XDR\r\nKích thước màn hình:\t6.1 inch \"\r\nĐộ phân giải màn hình:\t2532 x 1170 pixels\r\nCamera trước:\t\t12MP\r\nCamera sau:\t\t12 MP (kép)\r\nĐèn Flash:\t\tCó\r\nVideo:\t\t\t4K\r\nMạng 3G:\t\tCó\r\nMạng 4G:\t\tCó\r\nWIFI:\t\t\tWi-Fi 6 (802.11ax)\r\nBluetooth:\t\tBluetooth 5.0\r\nUSB:\t\t\tType C\r\nMở khóa nhanh:\t\tMở khóa bằng khuôn mặt\r\nThiết kế:\t\t\tNguyên khối, mặt kính cường lực\r\nChống nước:\t\tCó, IP68\r\nKích thước sản phẩm:\t146.7 x 71.5 x 7.4mm mm"),
            new product("iPhone 13 Pro Max 128GB Xanh", Resources.ip13_promax_xanh, "Xanh", "128GB", 27990000,"Model:\t\t\tiPhone 13 Pro Max 128GB\r\nMàu sắc:\t\t\tXanh\r\nNhà sản xuất:\t\tiPhone\r\nXuất xứ:\t\t\tTrung Quốc\r\nNăm ra mắt :\t\t2020\r\nThời gian bảo hành:\t12 Tháng\r\nĐịa điểm bảo hành:\t\r\nRAM:\t\t\t4 GB\r\nBộ nhớ trong:\t\t128 GB\r\nHệ điều hành:\t\tiOS 14.1\r\nChipset:\t\t\tApple A14 Bionic\r\nCảm ứng:\t\tCó\r\nLoại màn hình:\t\tSuper Retina XDR\r\nKích thước màn hình:\t6.1 inch \"\r\nĐộ phân giải màn hình:\t2532 x 1170 pixels\r\nCamera trước:\t\t12MP\r\nCamera sau:\t\t12 MP (kép)\r\nĐèn Flash:\t\tCó\r\nVideo:\t\t\t4K\r\nMạng 3G:\t\tCó\r\nMạng 4G:\t\tCó\r\nWIFI:\t\t\tWi-Fi 6 (802.11ax)\r\nBluetooth:\t\tBluetooth 5.0\r\nUSB:\t\t\tType C\r\nMở khóa nhanh:\t\tMở khóa bằng khuôn mặt\r\nThiết kế:\t\t\tNguyên khối, mặt kính cường lực\r\nChống nước:\t\tCó, IP68\r\nKích thước sản phẩm:\t146.7 x 71.5 x 7.4mm mm"),
            new product("iPhone 13 Pro Max 128GB Xanh Lá", Resources.ip13_promax_xanhla, "Xanh Lá", "128GB", 27990000,"Model:\t\t\tiPhone 13 Pro Max 128GB\r\nMàu sắc:\t\t\tXanh Lá\r\nNhà sản xuất:\t\tiPhone\r\nXuất xứ:\t\t\tTrung Quốc\r\nNăm ra mắt :\t\t2020\r\nThời gian bảo hành:\t12 Tháng\r\nĐịa điểm bảo hành:\t\r\nRAM:\t\t\t4 GB\r\nBộ nhớ trong:\t\t128 GB\r\nHệ điều hành:\t\tiOS 14.1\r\nChipset:\t\t\tApple A14 Bionic\r\nCảm ứng:\t\tCó\r\nLoại màn hình:\t\tSuper Retina XDR\r\nKích thước màn hình:\t6.1 inch \"\r\nĐộ phân giải màn hình:\t2532 x 1170 pixels\r\nCamera trước:\t\t12MP\r\nCamera sau:\t\t12 MP (kép)\r\nĐèn Flash:\t\tCó\r\nVideo:\t\t\t4K\r\nMạng 3G:\t\tCó\r\nMạng 4G:\t\tCó\r\nWIFI:\t\t\tWi-Fi 6 (802.11ax)\r\nBluetooth:\t\tBluetooth 5.0\r\nUSB:\t\t\tType C\r\nMở khóa nhanh:\t\tMở khóa bằng khuôn mặt\r\nThiết kế:\t\t\tNguyên khối, mặt kính cường lực\r\nChống nước:\t\tCó, IP68\r\nKích thước sản phẩm:\t146.7 x 71.5 x 7.4mm mm"),

            new product("iPhone 13 Pro Max 256GB Bạc", Resources.ip13_promax_bac, "Bạc", "256GB", 30290000,"Model:\t\t\tiPhone 13 Pro Max 256GB\r\nMàu sắc:\t\t\tBạc\r\nNhà sản xuất:\t\tiPhone\r\nXuất xứ:\t\t\tTrung Quốc\r\nNăm ra mắt :\t\t2020\r\nThời gian bảo hành:\t12 Tháng\r\nĐịa điểm bảo hành:\t\r\nRAM:\t\t\t4 GB\r\nBộ nhớ trong:\t\t256 GB\r\nHệ điều hành:\t\tiOS 14.1\r\nChipset:\t\t\tApple A14 Bionic\r\nCảm ứng:\t\tCó\r\nLoại màn hình:\t\tSuper Retina XDR\r\nKích thước màn hình:\t6.1 inch \"\r\nĐộ phân giải màn hình:\t2532 x 1170 pixels\r\nCamera trước:\t\t12MP\r\nCamera sau:\t\t12 MP (kép)\r\nĐèn Flash:\t\tCó\r\nVideo:\t\t\t4K\r\nMạng 3G:\t\tCó\r\nMạng 4G:\t\tCó\r\nWIFI:\t\t\tWi-Fi 6 (802.11ax)\r\nBluetooth:\t\tBluetooth 5.0\r\nUSB:\t\t\tType C\r\nMở khóa nhanh:\t\tMở khóa bằng khuôn mặt\r\nThiết kế:\t\t\tNguyên khối, mặt kính cường lực\r\nChống nước:\t\tCó, IP68\r\nKích thước sản phẩm:\t146.7 x 71.5 x 7.4mm mm"),
            new product("iPhone 13 Pro Max 256GB Vàng", Resources.ip13_promax_vang, "Vàng", "256GB", 30290000,"Model:\t\t\tiPhone 13 Pro Max 256GB\r\nMàu sắc:\t\t\tVàng\r\nNhà sản xuất:\t\tiPhone\r\nXuất xứ:\t\t\tTrung Quốc\r\nNăm ra mắt :\t\t2020\r\nThời gian bảo hành:\t12 Tháng\r\nĐịa điểm bảo hành:\t\r\nRAM:\t\t\t4 GB\r\nBộ nhớ trong:\t\t256 GB\r\nHệ điều hành:\t\tiOS 14.1\r\nChipset:\t\t\tApple A14 Bionic\r\nCảm ứng:\t\tCó\r\nLoại màn hình:\t\tSuper Retina XDR\r\nKích thước màn hình:\t6.1 inch \"\r\nĐộ phân giải màn hình:\t2532 x 1170 pixels\r\nCamera trước:\t\t12MP\r\nCamera sau:\t\t12 MP (kép)\r\nĐèn Flash:\t\tCó\r\nVideo:\t\t\t4K\r\nMạng 3G:\t\tCó\r\nMạng 4G:\t\tCó\r\nWIFI:\t\t\tWi-Fi 6 (802.11ax)\r\nBluetooth:\t\tBluetooth 5.0\r\nUSB:\t\t\tType C\r\nMở khóa nhanh:\t\tMở khóa bằng khuôn mặt\r\nThiết kế:\t\t\tNguyên khối, mặt kính cường lực\r\nChống nước:\t\tCó, IP68\r\nKích thước sản phẩm:\t146.7 x 71.5 x 7.4mm mm"),
            new product("iPhone 13 Pro Max 256GB Xám", Resources.ip13_promax_xam, "Xám", "256GB", 30290000,"Model:\t\t\tiPhone 13 Pro Max 256GB\r\nMàu sắc:\t\t\tXám\r\nNhà sản xuất:\t\tiPhone\r\nXuất xứ:\t\t\tTrung Quốc\r\nNăm ra mắt :\t\t2020\r\nThời gian bảo hành:\t12 Tháng\r\nĐịa điểm bảo hành:\t\r\nRAM:\t\t\t4 GB\r\nBộ nhớ trong:\t\t256 GB\r\nHệ điều hành:\t\tiOS 14.1\r\nChipset:\t\t\tApple A14 Bionic\r\nCảm ứng:\t\tCó\r\nLoại màn hình:\t\tSuper Retina XDR\r\nKích thước màn hình:\t6.1 inch \"\r\nĐộ phân giải màn hình:\t2532 x 1170 pixels\r\nCamera trước:\t\t12MP\r\nCamera sau:\t\t12 MP (kép)\r\nĐèn Flash:\t\tCó\r\nVideo:\t\t\t4K\r\nMạng 3G:\t\tCó\r\nMạng 4G:\t\tCó\r\nWIFI:\t\t\tWi-Fi 6 (802.11ax)\r\nBluetooth:\t\tBluetooth 5.0\r\nUSB:\t\t\tType C\r\nMở khóa nhanh:\t\tMở khóa bằng khuôn mặt\r\nThiết kế:\t\t\tNguyên khối, mặt kính cường lực\r\nChống nước:\t\tCó, IP68\r\nKích thước sản phẩm:\t146.7 x 71.5 x 7.4mm mm"),
            new product("iPhone 13 Pro Max 256GB Xanh", Resources.ip13_promax_xanh, "Xanh", "256GB", 30290000,"Model:\t\t\tiPhone 13 Pro Max 256GB\r\nMàu sắc:\t\t\tXanh\r\nNhà sản xuất:\t\tiPhone\r\nXuất xứ:\t\t\tTrung Quốc\r\nNăm ra mắt :\t\t2020\r\nThời gian bảo hành:\t12 Tháng\r\nĐịa điểm bảo hành:\t\r\nRAM:\t\t\t4 GB\r\nBộ nhớ trong:\t\t256 GB\r\nHệ điều hành:\t\tiOS 14.1\r\nChipset:\t\t\tApple A14 Bionic\r\nCảm ứng:\t\tCó\r\nLoại màn hình:\t\tSuper Retina XDR\r\nKích thước màn hình:\t6.1 inch \"\r\nĐộ phân giải màn hình:\t2532 x 1170 pixels\r\nCamera trước:\t\t12MP\r\nCamera sau:\t\t12 MP (kép)\r\nĐèn Flash:\t\tCó\r\nVideo:\t\t\t4K\r\nMạng 3G:\t\tCó\r\nMạng 4G:\t\tCó\r\nWIFI:\t\t\tWi-Fi 6 (802.11ax)\r\nBluetooth:\t\tBluetooth 5.0\r\nUSB:\t\t\tType C\r\nMở khóa nhanh:\t\tMở khóa bằng khuôn mặt\r\nThiết kế:\t\t\tNguyên khối, mặt kính cường lực\r\nChống nước:\t\tCó, IP68\r\nKích thước sản phẩm:\t146.7 x 71.5 x 7.4mm mm"),
            new product("iPhone 13 Pro Max 256GB Xanh Lá", Resources.ip13_promax_xanhla, "Xanh Lá", "256GB", 30290000,"Model:\t\t\tiPhone 13 Pro Max 256GB\r\nMàu sắc:\t\t\tXanh Lá\r\nNhà sản xuất:\t\tiPhone\r\nXuất xứ:\t\t\tTrung Quốc\r\nNăm ra mắt :\t\t2020\r\nThời gian bảo hành:\t12 Tháng\r\nĐịa điểm bảo hành:\t\r\nRAM:\t\t\t4 GB\r\nBộ nhớ trong:\t\t256 GB\r\nHệ điều hành:\t\tiOS 14.1\r\nChipset:\t\t\tApple A14 Bionic\r\nCảm ứng:\t\tCó\r\nLoại màn hình:\t\tSuper Retina XDR\r\nKích thước màn hình:\t6.1 inch \"\r\nĐộ phân giải màn hình:\t2532 x 1170 pixels\r\nCamera trước:\t\t12MP\r\nCamera sau:\t\t12 MP (kép)\r\nĐèn Flash:\t\tCó\r\nVideo:\t\t\t4K\r\nMạng 3G:\t\tCó\r\nMạng 4G:\t\tCó\r\nWIFI:\t\t\tWi-Fi 6 (802.11ax)\r\nBluetooth:\t\tBluetooth 5.0\r\nUSB:\t\t\tType C\r\nMở khóa nhanh:\t\tMở khóa bằng khuôn mặt\r\nThiết kế:\t\t\tNguyên khối, mặt kính cường lực\r\nChống nước:\t\tCó, IP68\r\nKích thước sản phẩm:\t146.7 x 71.5 x 7.4mm mm"),

            new product("iPhone 13 Pro Max 512GB Bạc", Resources.ip13_promax_bac, "Bạc", "512GB", 46990000,"Model:\t\t\tiPhone 13 Pro Max 512GB\r\nMàu sắc:\t\t\tBạc\r\nNhà sản xuất:\t\tiPhone\r\nXuất xứ:\t\t\tTrung Quốc\r\nNăm ra mắt :\t\t2020\r\nThời gian bảo hành:\t12 Tháng\r\nĐịa điểm bảo hành:\t\r\nRAM:\t\t\t4 GB\r\nBộ nhớ trong:\t\t512 GB\r\nHệ điều hành:\t\tiOS 14.1\r\nChipset:\t\t\tApple A14 Bionic\r\nCảm ứng:\t\tCó\r\nLoại màn hình:\t\tSuper Retina XDR\r\nKích thước màn hình:\t6.1 inch \"\r\nĐộ phân giải màn hình:\t2532 x 1170 pixels\r\nCamera trước:\t\t12MP\r\nCamera sau:\t\t12 MP (kép)\r\nĐèn Flash:\t\tCó\r\nVideo:\t\t\t4K\r\nMạng 3G:\t\tCó\r\nMạng 4G:\t\tCó\r\nWIFI:\t\t\tWi-Fi 6 (802.11ax)\r\nBluetooth:\t\tBluetooth 5.0\r\nUSB:\t\t\tType C\r\nMở khóa nhanh:\t\tMở khóa bằng khuôn mặt\r\nThiết kế:\t\t\tNguyên khối, mặt kính cường lực\r\nChống nước:\t\tCó, IP68\r\nKích thước sản phẩm:\t146.7 x 71.5 x 7.4mm mm"),
            new product("iPhone 13 Pro Max 512GB Vàng", Resources.ip13_promax_vang, "Vàng", "512GB", 46990000,"Model:\t\t\tiPhone 13 Pro Max 512GB\r\nMàu sắc:\t\t\tVàng\r\nNhà sản xuất:\t\tiPhone\r\nXuất xứ:\t\t\tTrung Quốc\r\nNăm ra mắt :\t\t2020\r\nThời gian bảo hành:\t12 Tháng\r\nĐịa điểm bảo hành:\t\r\nRAM:\t\t\t4 GB\r\nBộ nhớ trong:\t\t512 GB\r\nHệ điều hành:\t\tiOS 14.1\r\nChipset:\t\t\tApple A14 Bionic\r\nCảm ứng:\t\tCó\r\nLoại màn hình:\t\tSuper Retina XDR\r\nKích thước màn hình:\t6.1 inch \"\r\nĐộ phân giải màn hình:\t2532 x 1170 pixels\r\nCamera trước:\t\t12MP\r\nCamera sau:\t\t12 MP (kép)\r\nĐèn Flash:\t\tCó\r\nVideo:\t\t\t4K\r\nMạng 3G:\t\tCó\r\nMạng 4G:\t\tCó\r\nWIFI:\t\t\tWi-Fi 6 (802.11ax)\r\nBluetooth:\t\tBluetooth 5.0\r\nUSB:\t\t\tType C\r\nMở khóa nhanh:\t\tMở khóa bằng khuôn mặt\r\nThiết kế:\t\t\tNguyên khối, mặt kính cường lực\r\nChống nước:\t\tCó, IP68\r\nKích thước sản phẩm:\t146.7 x 71.5 x 7.4mm mm"),
            new product("iPhone 13 Pro Max 512GB Xám", Resources.ip13_promax_xam, "Xám", "512GB", 46990000,"Model:\t\t\tiPhone 13 Pro Max 512GB\r\nMàu sắc:\t\t\tXám\r\nNhà sản xuất:\t\tiPhone\r\nXuất xứ:\t\t\tTrung Quốc\r\nNăm ra mắt :\t\t2020\r\nThời gian bảo hành:\t12 Tháng\r\nĐịa điểm bảo hành:\t\r\nRAM:\t\t\t4 GB\r\nBộ nhớ trong:\t\t512 GB\r\nHệ điều hành:\t\tiOS 14.1\r\nChipset:\t\t\tApple A14 Bionic\r\nCảm ứng:\t\tCó\r\nLoại màn hình:\t\tSuper Retina XDR\r\nKích thước màn hình:\t6.1 inch \"\r\nĐộ phân giải màn hình:\t2532 x 1170 pixels\r\nCamera trước:\t\t12MP\r\nCamera sau:\t\t12 MP (kép)\r\nĐèn Flash:\t\tCó\r\nVideo:\t\t\t4K\r\nMạng 3G:\t\tCó\r\nMạng 4G:\t\tCó\r\nWIFI:\t\t\tWi-Fi 6 (802.11ax)\r\nBluetooth:\t\tBluetooth 5.0\r\nUSB:\t\t\tType C\r\nMở khóa nhanh:\t\tMở khóa bằng khuôn mặt\r\nThiết kế:\t\t\tNguyên khối, mặt kính cường lực\r\nChống nước:\t\tCó, IP68\r\nKích thước sản phẩm:\t146.7 x 71.5 x 7.4mm mm"),
            new product("iPhone 13 Pro Max 512GB Xanh", Resources.ip13_promax_xanh, "Xanh", "512GB", 46990000,"Model:\t\t\tiPhone 13 Pro Max 512GB\r\nMàu sắc:\t\t\tXanh\r\nNhà sản xuất:\t\tiPhone\r\nXuất xứ:\t\t\tTrung Quốc\r\nNăm ra mắt :\t\t2020\r\nThời gian bảo hành:\t12 Tháng\r\nĐịa điểm bảo hành:\t\r\nRAM:\t\t\t4 GB\r\nBộ nhớ trong:\t\t512 GB\r\nHệ điều hành:\t\tiOS 14.1\r\nChipset:\t\t\tApple A14 Bionic\r\nCảm ứng:\t\tCó\r\nLoại màn hình:\t\tSuper Retina XDR\r\nKích thước màn hình:\t6.1 inch \"\r\nĐộ phân giải màn hình:\t2532 x 1170 pixels\r\nCamera trước:\t\t12MP\r\nCamera sau:\t\t12 MP (kép)\r\nĐèn Flash:\t\tCó\r\nVideo:\t\t\t4K\r\nMạng 3G:\t\tCó\r\nMạng 4G:\t\tCó\r\nWIFI:\t\t\tWi-Fi 6 (802.11ax)\r\nBluetooth:\t\tBluetooth 5.0\r\nUSB:\t\t\tType C\r\nMở khóa nhanh:\t\tMở khóa bằng khuôn mặt\r\nThiết kế:\t\t\tNguyên khối, mặt kính cường lực\r\nChống nước:\t\tCó, IP68\r\nKích thước sản phẩm:\t146.7 x 71.5 x 7.4mm mm"),
            new product("iPhone 13 Pro Max 512GB Xanh Lá", Resources.ip13_promax_xanhla, "Xanh Lá", "512GB", 46990000,"Model:\t\t\tiPhone 13 Pro Max 512GB\r\nMàu sắc:\t\t\tXanh Lá\r\nNhà sản xuất:\t\tiPhone\r\nXuất xứ:\t\t\tTrung Quốc\r\nNăm ra mắt :\t\t2020\r\nThời gian bảo hành:\t12 Tháng\r\nĐịa điểm bảo hành:\t\r\nRAM:\t\t\t4 GB\r\nBộ nhớ trong:\t\t512 GB\r\nHệ điều hành:\t\tiOS 14.1\r\nChipset:\t\t\tApple A14 Bionic\r\nCảm ứng:\t\tCó\r\nLoại màn hình:\t\tSuper Retina XDR\r\nKích thước màn hình:\t6.1 inch \"\r\nĐộ phân giải màn hình:\t2532 x 1170 pixels\r\nCamera trước:\t\t12MP\r\nCamera sau:\t\t12 MP (kép)\r\nĐèn Flash:\t\tCó\r\nVideo:\t\t\t4K\r\nMạng 3G:\t\tCó\r\nMạng 4G:\t\tCó\r\nWIFI:\t\t\tWi-Fi 6 (802.11ax)\r\nBluetooth:\t\tBluetooth 5.0\r\nUSB:\t\t\tType C\r\nMở khóa nhanh:\t\tMở khóa bằng khuôn mặt\r\nThiết kế:\t\t\tNguyên khối, mặt kính cường lực\r\nChống nước:\t\tCó, IP68\r\nKích thước sản phẩm:\t146.7 x 71.5 x 7.4mm mm"),

            new product("iPhone 13 Pro Max 1TB Bạc", Resources.ip13_promax_bac, "Bạc", "1TB", 27990000,"Model:\t\t\tiPhone 13 Pro Max 1TB\r\nMàu sắc:\t\t\tBạc\r\nNhà sản xuất:\t\tiPhone\r\nXuất xứ:\t\t\tTrung Quốc\r\nNăm ra mắt :\t\t2020\r\nThời gian bảo hành:\t12 Tháng\r\nĐịa điểm bảo hành:\t\r\nRAM:\t\t\t4 GB\r\nBộ nhớ trong:\t\t1 TB\r\nHệ điều hành:\t\tiOS 14.1\r\nChipset:\t\t\tApple A14 Bionic\r\nCảm ứng:\t\tCó\r\nLoại màn hình:\t\tSuper Retina XDR\r\nKích thước màn hình:\t6.1 inch \"\r\nĐộ phân giải màn hình:\t2532 x 1170 pixels\r\nCamera trước:\t\t12MP\r\nCamera sau:\t\t12 MP (kép)\r\nĐèn Flash:\t\tCó\r\nVideo:\t\t\t4K\r\nMạng 3G:\t\tCó\r\nMạng 4G:\t\tCó\r\nWIFI:\t\t\tWi-Fi 6 (802.11ax)\r\nBluetooth:\t\tBluetooth 5.0\r\nUSB:\t\t\tType C\r\nMở khóa nhanh:\t\tMở khóa bằng khuôn mặt\r\nThiết kế:\t\t\tNguyên khối, mặt kính cường lực\r\nChống nước:\t\tCó, IP68\r\nKích thước sản phẩm:\t146.7 x 71.5 x 7.4mm mm"),
            new product("iPhone 13 Pro Max 1TB Vàng", Resources.ip13_promax_vang, "Vàng", "1TB", 27990000,"Model:\t\t\tiPhone 13 Pro Max 1TB\r\nMàu sắc:\t\t\tVàng\r\nNhà sản xuất:\t\tiPhone\r\nXuất xứ:\t\t\tTrung Quốc\r\nNăm ra mắt :\t\t2020\r\nThời gian bảo hành:\t12 Tháng\r\nĐịa điểm bảo hành:\t\r\nRAM:\t\t\t4 GB\r\nBộ nhớ trong:\t\t1 TB\r\nHệ điều hành:\t\tiOS 14.1\r\nChipset:\t\t\tApple A14 Bionic\r\nCảm ứng:\t\tCó\r\nLoại màn hình:\t\tSuper Retina XDR\r\nKích thước màn hình:\t6.1 inch \"\r\nĐộ phân giải màn hình:\t2532 x 1170 pixels\r\nCamera trước:\t\t12MP\r\nCamera sau:\t\t12 MP (kép)\r\nĐèn Flash:\t\tCó\r\nVideo:\t\t\t4K\r\nMạng 3G:\t\tCó\r\nMạng 4G:\t\tCó\r\nWIFI:\t\t\tWi-Fi 6 (802.11ax)\r\nBluetooth:\t\tBluetooth 5.0\r\nUSB:\t\t\tType C\r\nMở khóa nhanh:\t\tMở khóa bằng khuôn mặt\r\nThiết kế:\t\t\tNguyên khối, mặt kính cường lực\r\nChống nước:\t\tCó, IP68\r\nKích thước sản phẩm:\t146.7 x 71.5 x 7.4mm mm"),
            new product("iPhone 13 Pro Max 1TB Xám", Resources.ip13_promax_xam, "Xám", "1TB", 27990000,"Model:\t\t\tiPhone 13 Pro Max 1TB\r\nMàu sắc:\t\t\tXám\r\nNhà sản xuất:\t\tiPhone\r\nXuất xứ:\t\t\tTrung Quốc\r\nNăm ra mắt :\t\t2020\r\nThời gian bảo hành:\t12 Tháng\r\nĐịa điểm bảo hành:\t\r\nRAM:\t\t\t4 GB\r\nBộ nhớ trong:\t\t1 TB\r\nHệ điều hành:\t\tiOS 14.1\r\nChipset:\t\t\tApple A14 Bionic\r\nCảm ứng:\t\tCó\r\nLoại màn hình:\t\tSuper Retina XDR\r\nKích thước màn hình:\t6.1 inch \"\r\nĐộ phân giải màn hình:\t2532 x 1170 pixels\r\nCamera trước:\t\t12MP\r\nCamera sau:\t\t12 MP (kép)\r\nĐèn Flash:\t\tCó\r\nVideo:\t\t\t4K\r\nMạng 3G:\t\tCó\r\nMạng 4G:\t\tCó\r\nWIFI:\t\t\tWi-Fi 6 (802.11ax)\r\nBluetooth:\t\tBluetooth 5.0\r\nUSB:\t\t\tType C\r\nMở khóa nhanh:\t\tMở khóa bằng khuôn mặt\r\nThiết kế:\t\t\tNguyên khối, mặt kính cường lực\r\nChống nước:\t\tCó, IP68\r\nKích thước sản phẩm:\t146.7 x 71.5 x 7.4mm mm"),
            new product("iPhone 13 Pro Max 1TB Xanh", Resources.ip13_promax_xanh, "Xanh", "1TB", 27990000,"Model:\t\t\tiPhone 13 Pro Max 1TB\r\nMàu sắc:\t\t\tXanh\r\nNhà sản xuất:\t\tiPhone\r\nXuất xứ:\t\t\tTrung Quốc\r\nNăm ra mắt :\t\t2020\r\nThời gian bảo hành:\t12 Tháng\r\nĐịa điểm bảo hành:\t\r\nRAM:\t\t\t4 GB\r\nBộ nhớ trong:\t\t1 TB\r\nHệ điều hành:\t\tiOS 14.1\r\nChipset:\t\t\tApple A14 Bionic\r\nCảm ứng:\t\tCó\r\nLoại màn hình:\t\tSuper Retina XDR\r\nKích thước màn hình:\t6.1 inch \"\r\nĐộ phân giải màn hình:\t2532 x 1170 pixels\r\nCamera trước:\t\t12MP\r\nCamera sau:\t\t12 MP (kép)\r\nĐèn Flash:\t\tCó\r\nVideo:\t\t\t4K\r\nMạng 3G:\t\tCó\r\nMạng 4G:\t\tCó\r\nWIFI:\t\t\tWi-Fi 6 (802.11ax)\r\nBluetooth:\t\tBluetooth 5.0\r\nUSB:\t\t\tType C\r\nMở khóa nhanh:\t\tMở khóa bằng khuôn mặt\r\nThiết kế:\t\t\tNguyên khối, mặt kính cường lực\r\nChống nước:\t\tCó, IP68\r\nKích thước sản phẩm:\t146.7 x 71.5 x 7.4mm mm"),
            new product("iPhone 13 Pro Max 1TB Xanh Lá", Resources.ip13_promax_xanhla, "Xanh Lá", "1TB", 27990000,"Model:\t\t\tiPhone 13 Pro Max 1TB\r\nMàu sắc:\t\t\tXanh Lá\r\nNhà sản xuất:\t\tiPhone\r\nXuất xứ:\t\t\tTrung Quốc\r\nNăm ra mắt :\t\t2020\r\nThời gian bảo hành:\t12 Tháng\r\nĐịa điểm bảo hành:\t\r\nRAM:\t\t\t4 GB\r\nBộ nhớ trong:\t\t1 TB\r\nHệ điều hành:\t\tiOS 14.1\r\nChipset:\t\t\tApple A14 Bionic\r\nCảm ứng:\t\tCó\r\nLoại màn hình:\t\tSuper Retina XDR\r\nKích thước màn hình:\t6.1 inch \"\r\nĐộ phân giải màn hình:\t2532 x 1170 pixels\r\nCamera trước:\t\t12MP\r\nCamera sau:\t\t12 MP (kép)\r\nĐèn Flash:\t\tCó\r\nVideo:\t\t\t4K\r\nMạng 3G:\t\tCó\r\nMạng 4G:\t\tCó\r\nWIFI:\t\t\tWi-Fi 6 (802.11ax)\r\nBluetooth:\t\tBluetooth 5.0\r\nUSB:\t\t\tType C\r\nMở khóa nhanh:\t\tMở khóa bằng khuôn mặt\r\nThiết kế:\t\t\tNguyên khối, mặt kính cường lực\r\nChống nước:\t\tCó, IP68\r\nKích thước sản phẩm:\t146.7 x 71.5 x 7.4mm mm"),

            #endregion
            #region ip14
            new product("iPhone 14 Plus 128GB Đen", Resources.ip14_plus_den, "Đen", "128GB", 26990000,"Model:\t\t\tiPhone 14 Plus 128GB\r\nMàu sắc:\t\t\tĐen\r\nNhà sản xuất:\t\tiPhone\r\nXuất xứ:\t\t\tTrung Quốc\r\nNăm ra mắt :\t\t2020\r\nThời gian bảo hành:\t12 Tháng\r\nĐịa điểm bảo hành:\t\r\nRAM:\t\t\t4 GB\r\nBộ nhớ trong:\t\t128 GB\r\nHệ điều hành:\t\tiOS 14.1\r\nChipset:\t\t\tApple A14 Bionic\r\nCảm ứng:\t\tCó\r\nLoại màn hình:\t\tSuper Retina XDR\r\nKích thước màn hình:\t6.1 inch \"\r\nĐộ phân giải màn hình:\t2532 x 1170 pixels\r\nCamera trước:\t\t12MP\r\nCamera sau:\t\t12 MP (kép)\r\nĐèn Flash:\t\tCó\r\nVideo:\t\t\t4K\r\nMạng 3G:\t\tCó\r\nMạng 4G:\t\tCó\r\nWIFI:\t\t\tWi-Fi 6 (802.11ax)\r\nBluetooth:\t\tBluetooth 5.0\r\nUSB:\t\t\tType C\r\nMở khóa nhanh:\t\tMở khóa bằng khuôn mặt\r\nThiết kế:\t\t\tNguyên khối, mặt kính cường lực\r\nChống nước:\t\tCó, IP68\r\nKích thước sản phẩm:\t146.7 x 71.5 x 7.4mm mm"),
            new product("iPhone 14 Plus 128GB Đỏ", Resources.ip14_plus_do, "Đỏ", "128GB", 26990000,"Model:\t\t\tiPhone 14 Plus 128GB\r\nMàu sắc:\t\t\tĐỏ\r\nNhà sản xuất:\t\tiPhone\r\nXuất xứ:\t\t\tTrung Quốc\r\nNăm ra mắt :\t\t2020\r\nThời gian bảo hành:\t12 Tháng\r\nĐịa điểm bảo hành:\t\r\nRAM:\t\t\t4 GB\r\nBộ nhớ trong:\t\t128 GB\r\nHệ điều hành:\t\tiOS 14.1\r\nChipset:\t\t\tApple A14 Bionic\r\nCảm ứng:\t\tCó\r\nLoại màn hình:\t\tSuper Retina XDR\r\nKích thước màn hình:\t6.1 inch \"\r\nĐộ phân giải màn hình:\t2532 x 1170 pixels\r\nCamera trước:\t\t12MP\r\nCamera sau:\t\t12 MP (kép)\r\nĐèn Flash:\t\tCó\r\nVideo:\t\t\t4K\r\nMạng 3G:\t\tCó\r\nMạng 4G:\t\tCó\r\nWIFI:\t\t\tWi-Fi 6 (802.11ax)\r\nBluetooth:\t\tBluetooth 5.0\r\nUSB:\t\t\tType C\r\nMở khóa nhanh:\t\tMở khóa bằng khuôn mặt\r\nThiết kế:\t\t\tNguyên khối, mặt kính cường lực\r\nChống nước:\t\tCó, IP68\r\nKích thước sản phẩm:\t146.7 x 71.5 x 7.4mm mm"),
            new product("iPhone 14 Plus 128GB Trắng", Resources.ip14_plus_trang, "Trắng", "128GB", 26990000,"Model:\t\t\tiPhone 14 Plus 128GB\r\nMàu sắc:\t\t\tTrắng\r\nNhà sản xuất:\t\tiPhone\r\nXuất xứ:\t\t\tTrung Quốc\r\nNăm ra mắt :\t\t2020\r\nThời gian bảo hành:\t12 Tháng\r\nĐịa điểm bảo hành:\t\r\nRAM:\t\t\t4 GB\r\nBộ nhớ trong:\t\t128 GB\r\nHệ điều hành:\t\tiOS 14.1\r\nChipset:\t\t\tApple A14 Bionic\r\nCảm ứng:\t\tCó\r\nLoại màn hình:\t\tSuper Retina XDR\r\nKích thước màn hình:\t6.1 inch \"\r\nĐộ phân giải màn hình:\t2532 x 1170 pixels\r\nCamera trước:\t\t12MP\r\nCamera sau:\t\t12 MP (kép)\r\nĐèn Flash:\t\tCó\r\nVideo:\t\t\t4K\r\nMạng 3G:\t\tCó\r\nMạng 4G:\t\tCó\r\nWIFI:\t\t\tWi-Fi 6 (802.11ax)\r\nBluetooth:\t\tBluetooth 5.0\r\nUSB:\t\t\tType C\r\nMở khóa nhanh:\t\tMở khóa bằng khuôn mặt\r\nThiết kế:\t\t\tNguyên khối, mặt kính cường lực\r\nChống nước:\t\tCó, IP68\r\nKích thước sản phẩm:\t146.7 x 71.5 x 7.4mm mm"),
            new product("iPhone 14 Plus 128GB Xanh Dương", Resources.ip14_plus_xanhduong, "Xanh Dương", "128GB", 26990000,"Model:\t\t\tiPhone 14 Plus 128GB\r\nMàu sắc:\t\t\tXanh Dương\r\nNhà sản xuất:\t\tiPhone\r\nXuất xứ:\t\t\tTrung Quốc\r\nNăm ra mắt :\t\t2020\r\nThời gian bảo hành:\t12 Tháng\r\nĐịa điểm bảo hành:\t\r\nRAM:\t\t\t4 GB\r\nBộ nhớ trong:\t\t128 GB\r\nHệ điều hành:\t\tiOS 14.1\r\nChipset:\t\t\tApple A14 Bionic\r\nCảm ứng:\t\tCó\r\nLoại màn hình:\t\tSuper Retina XDR\r\nKích thước màn hình:\t6.1 inch \"\r\nĐộ phân giải màn hình:\t2532 x 1170 pixels\r\nCamera trước:\t\t12MP\r\nCamera sau:\t\t12 MP (kép)\r\nĐèn Flash:\t\tCó\r\nVideo:\t\t\t4K\r\nMạng 3G:\t\tCó\r\nMạng 4G:\t\tCó\r\nWIFI:\t\t\tWi-Fi 6 (802.11ax)\r\nBluetooth:\t\tBluetooth 5.0\r\nUSB:\t\t\tType C\r\nMở khóa nhanh:\t\tMở khóa bằng khuôn mặt\r\nThiết kế:\t\t\tNguyên khối, mặt kính cường lực\r\nChống nước:\t\tCó, IP68\r\nKích thước sản phẩm:\t146.7 x 71.5 x 7.4mm mm"),

            new product("iPhone 14 Plus 256GB Đen", Resources.ip14_plus_den, "Đen", "256GB", 26990000,"Model:\t\t\tiPhone 14 Plus 256GB\r\nMàu sắc:\t\t\tĐen\r\nNhà sản xuất:\t\tiPhone\r\nXuất xứ:\t\t\tTrung Quốc\r\nNăm ra mắt :\t\t2020\r\nThời gian bảo hành:\t12 Tháng\r\nĐịa điểm bảo hành:\t\r\nRAM:\t\t\t4 GB\r\nBộ nhớ trong:\t\t256 GB\r\nHệ điều hành:\t\tiOS 14.1\r\nChipset:\t\t\tApple A14 Bionic\r\nCảm ứng:\t\tCó\r\nLoại màn hình:\t\tSuper Retina XDR\r\nKích thước màn hình:\t6.1 inch \"\r\nĐộ phân giải màn hình:\t2532 x 1170 pixels\r\nCamera trước:\t\t12MP\r\nCamera sau:\t\t12 MP (kép)\r\nĐèn Flash:\t\tCó\r\nVideo:\t\t\t4K\r\nMạng 3G:\t\tCó\r\nMạng 4G:\t\tCó\r\nWIFI:\t\t\tWi-Fi 6 (802.11ax)\r\nBluetooth:\t\tBluetooth 5.0\r\nUSB:\t\t\tType C\r\nMở khóa nhanh:\t\tMở khóa bằng khuôn mặt\r\nThiết kế:\t\t\tNguyên khối, mặt kính cường lực\r\nChống nước:\t\tCó, IP68\r\nKích thước sản phẩm:\t146.7 x 71.5 x 7.4mm mm"),
            new product("iPhone 14 Plus 256GB Đỏ", Resources.ip14_plus_do, "Đỏ", "256GB", 26990000,"Model:\t\t\tiPhone 14 Plus 256GB\r\nMàu sắc:\t\t\tĐỏ\r\nNhà sản xuất:\t\tiPhone\r\nXuất xứ:\t\t\tTrung Quốc\r\nNăm ra mắt :\t\t2020\r\nThời gian bảo hành:\t12 Tháng\r\nĐịa điểm bảo hành:\t\r\nRAM:\t\t\t4 GB\r\nBộ nhớ trong:\t\t256 GB\r\nHệ điều hành:\t\tiOS 14.1\r\nChipset:\t\t\tApple A14 Bionic\r\nCảm ứng:\t\tCó\r\nLoại màn hình:\t\tSuper Retina XDR\r\nKích thước màn hình:\t6.1 inch \"\r\nĐộ phân giải màn hình:\t2532 x 1170 pixels\r\nCamera trước:\t\t12MP\r\nCamera sau:\t\t12 MP (kép)\r\nĐèn Flash:\t\tCó\r\nVideo:\t\t\t4K\r\nMạng 3G:\t\tCó\r\nMạng 4G:\t\tCó\r\nWIFI:\t\t\tWi-Fi 6 (802.11ax)\r\nBluetooth:\t\tBluetooth 5.0\r\nUSB:\t\t\tType C\r\nMở khóa nhanh:\t\tMở khóa bằng khuôn mặt\r\nThiết kế:\t\t\tNguyên khối, mặt kính cường lực\r\nChống nước:\t\tCó, IP68\r\nKích thước sản phẩm:\t146.7 x 71.5 x 7.4mm mm"),
            new product("iPhone 14 Plus 256GB Trắng", Resources.ip14_plus_trang, "Trắng", "256GB", 26990000,"Model:\t\t\tiPhone 14 Plus 256GB\r\nMàu sắc:\t\t\tTrắng\r\nNhà sản xuất:\t\tiPhone\r\nXuất xứ:\t\t\tTrung Quốc\r\nNăm ra mắt :\t\t2020\r\nThời gian bảo hành:\t12 Tháng\r\nĐịa điểm bảo hành:\t\r\nRAM:\t\t\t4 GB\r\nBộ nhớ trong:\t\t256 GB\r\nHệ điều hành:\t\tiOS 14.1\r\nChipset:\t\t\tApple A14 Bionic\r\nCảm ứng:\t\tCó\r\nLoại màn hình:\t\tSuper Retina XDR\r\nKích thước màn hình:\t6.1 inch \"\r\nĐộ phân giải màn hình:\t2532 x 1170 pixels\r\nCamera trước:\t\t12MP\r\nCamera sau:\t\t12 MP (kép)\r\nĐèn Flash:\t\tCó\r\nVideo:\t\t\t4K\r\nMạng 3G:\t\tCó\r\nMạng 4G:\t\tCó\r\nWIFI:\t\t\tWi-Fi 6 (802.11ax)\r\nBluetooth:\t\tBluetooth 5.0\r\nUSB:\t\t\tType C\r\nMở khóa nhanh:\t\tMở khóa bằng khuôn mặt\r\nThiết kế:\t\t\tNguyên khối, mặt kính cường lực\r\nChống nước:\t\tCó, IP68\r\nKích thước sản phẩm:\t146.7 x 71.5 x 7.4mm mm"),
            new product("iPhone 14 Plus 256GB Xanh Dương", Resources.ip14_plus_xanhduong, "Xanh Dương", "256GB", 26990000,"Model:\t\t\tiPhone 14 Plus 256GB\r\nMàu sắc:\t\t\tXanh Dương\r\nNhà sản xuất:\t\tiPhone\r\nXuất xứ:\t\t\tTrung Quốc\r\nNăm ra mắt :\t\t2020\r\nThời gian bảo hành:\t12 Tháng\r\nĐịa điểm bảo hành:\t\r\nRAM:\t\t\t4 GB\r\nBộ nhớ trong:\t\t256 GB\r\nHệ điều hành:\t\tiOS 14.1\r\nChipset:\t\t\tApple A14 Bionic\r\nCảm ứng:\t\tCó\r\nLoại màn hình:\t\tSuper Retina XDR\r\nKích thước màn hình:\t6.1 inch \"\r\nĐộ phân giải màn hình:\t2532 x 1170 pixels\r\nCamera trước:\t\t12MP\r\nCamera sau:\t\t12 MP (kép)\r\nĐèn Flash:\t\tCó\r\nVideo:\t\t\t4K\r\nMạng 3G:\t\tCó\r\nMạng 4G:\t\tCó\r\nWIFI:\t\t\tWi-Fi 6 (802.11ax)\r\nBluetooth:\t\tBluetooth 5.0\r\nUSB:\t\t\tType C\r\nMở khóa nhanh:\t\tMở khóa bằng khuôn mặt\r\nThiết kế:\t\t\tNguyên khối, mặt kính cường lực\r\nChống nước:\t\tCó, IP68\r\nKích thước sản phẩm:\t146.7 x 71.5 x 7.4mm mm"),

            new product("iPhone 14 Plus 512GB Đen", Resources.ip14_plus_den, "Đen", "512GB", 31990000,"Model:\t\t\tiPhone 14 Plus 512GB\r\nMàu sắc:\t\t\tĐen\r\nNhà sản xuất:\t\tiPhone\r\nXuất xứ:\t\t\tTrung Quốc\r\nNăm ra mắt :\t\t2020\r\nThời gian bảo hành:\t12 Tháng\r\nĐịa điểm bảo hành:\t\r\nRAM:\t\t\t4 GB\r\nBộ nhớ trong:\t\t512 GB\r\nHệ điều hành:\t\tiOS 14.1\r\nChipset:\t\t\tApple A14 Bionic\r\nCảm ứng:\t\tCó\r\nLoại màn hình:\t\tSuper Retina XDR\r\nKích thước màn hình:\t6.1 inch \"\r\nĐộ phân giải màn hình:\t2532 x 1170 pixels\r\nCamera trước:\t\t12MP\r\nCamera sau:\t\t12 MP (kép)\r\nĐèn Flash:\t\tCó\r\nVideo:\t\t\t4K\r\nMạng 3G:\t\tCó\r\nMạng 4G:\t\tCó\r\nWIFI:\t\t\tWi-Fi 6 (802.11ax)\r\nBluetooth:\t\tBluetooth 5.0\r\nUSB:\t\t\tType C\r\nMở khóa nhanh:\t\tMở khóa bằng khuôn mặt\r\nThiết kế:\t\t\tNguyên khối, mặt kính cường lực\r\nChống nước:\t\tCó, IP68\r\nKích thước sản phẩm:\t146.7 x 71.5 x 7.4mm mm"),
            new product("iPhone 14 Plus 512GB Đỏ", Resources.ip14_plus_do, "Đỏ", "512GB", 31990000,"Model:\t\t\tiPhone 14 Plus 512GB\r\nMàu sắc:\t\t\tĐỏ\r\nNhà sản xuất:\t\tiPhone\r\nXuất xứ:\t\t\tTrung Quốc\r\nNăm ra mắt :\t\t2020\r\nThời gian bảo hành:\t12 Tháng\r\nĐịa điểm bảo hành:\t\r\nRAM:\t\t\t4 GB\r\nBộ nhớ trong:\t\t512 GB\r\nHệ điều hành:\t\tiOS 14.1\r\nChipset:\t\t\tApple A14 Bionic\r\nCảm ứng:\t\tCó\r\nLoại màn hình:\t\tSuper Retina XDR\r\nKích thước màn hình:\t6.1 inch \"\r\nĐộ phân giải màn hình:\t2532 x 1170 pixels\r\nCamera trước:\t\t12MP\r\nCamera sau:\t\t12 MP (kép)\r\nĐèn Flash:\t\tCó\r\nVideo:\t\t\t4K\r\nMạng 3G:\t\tCó\r\nMạng 4G:\t\tCó\r\nWIFI:\t\t\tWi-Fi 6 (802.11ax)\r\nBluetooth:\t\tBluetooth 5.0\r\nUSB:\t\t\tType C\r\nMở khóa nhanh:\t\tMở khóa bằng khuôn mặt\r\nThiết kế:\t\t\tNguyên khối, mặt kính cường lực\r\nChống nước:\t\tCó, IP68\r\nKích thước sản phẩm:\t146.7 x 71.5 x 7.4mm mm"),
            new product("iPhone 14 Plus 512GB Trắng", Resources.ip14_plus_trang, "Trắng", "512GB", 31990000,"Model:\t\t\tiPhone 14 Plus 512GB\r\nMàu sắc:\t\t\tTrắng\r\nNhà sản xuất:\t\tiPhone\r\nXuất xứ:\t\t\tTrung Quốc\r\nNăm ra mắt :\t\t2020\r\nThời gian bảo hành:\t12 Tháng\r\nĐịa điểm bảo hành:\t\r\nRAM:\t\t\t4 GB\r\nBộ nhớ trong:\t\t512 GB\r\nHệ điều hành:\t\tiOS 14.1\r\nChipset:\t\t\tApple A14 Bionic\r\nCảm ứng:\t\tCó\r\nLoại màn hình:\t\tSuper Retina XDR\r\nKích thước màn hình:\t6.1 inch \"\r\nĐộ phân giải màn hình:\t2532 x 1170 pixels\r\nCamera trước:\t\t12MP\r\nCamera sau:\t\t12 MP (kép)\r\nĐèn Flash:\t\tCó\r\nVideo:\t\t\t4K\r\nMạng 3G:\t\tCó\r\nMạng 4G:\t\tCó\r\nWIFI:\t\t\tWi-Fi 6 (802.11ax)\r\nBluetooth:\t\tBluetooth 5.0\r\nUSB:\t\t\tType C\r\nMở khóa nhanh:\t\tMở khóa bằng khuôn mặt\r\nThiết kế:\t\t\tNguyên khối, mặt kính cường lực\r\nChống nước:\t\tCó, IP68\r\nKích thước sản phẩm:\t146.7 x 71.5 x 7.4mm mm"),
            new product("iPhone 14 Plus 512GB Xanh Dương", Resources.ip14_plus_xanhduong, "Xanh Dương", "512GB", 31990000,"Model:\t\t\tiPhone 14 Plus 512GB\r\nMàu sắc:\t\t\tXanh Dương\r\nNhà sản xuất:\t\tiPhone\r\nXuất xứ:\t\t\tTrung Quốc\r\nNăm ra mắt :\t\t2020\r\nThời gian bảo hành:\t12 Tháng\r\nĐịa điểm bảo hành:\t\r\nRAM:\t\t\t4 GB\r\nBộ nhớ trong:\t\t512 GB\r\nHệ điều hành:\t\tiOS 14.1\r\nChipset:\t\t\tApple A14 Bionic\r\nCảm ứng:\t\tCó\r\nLoại màn hình:\t\tSuper Retina XDR\r\nKích thước màn hình:\t6.1 inch \"\r\nĐộ phân giải màn hình:\t2532 x 1170 pixels\r\nCamera trước:\t\t12MP\r\nCamera sau:\t\t12 MP (kép)\r\nĐèn Flash:\t\tCó\r\nVideo:\t\t\t4K\r\nMạng 3G:\t\tCó\r\nMạng 4G:\t\tCó\r\nWIFI:\t\t\tWi-Fi 6 (802.11ax)\r\nBluetooth:\t\tBluetooth 5.0\r\nUSB:\t\t\tType C\r\nMở khóa nhanh:\t\tMở khóa bằng khuôn mặt\r\nThiết kế:\t\t\tNguyên khối, mặt kính cường lực\r\nChống nước:\t\tCó, IP68\r\nKích thước sản phẩm:\t146.7 x 71.5 x 7.4mm mm"),

            new product("iPhone 14 Pro 128GB Đen", Resources.ip14_pro_den, "Đen", "128GB", 29790000,"Model:\t\t\tiPhone 14 Pro 128GB\r\nMàu sắc:\t\t\tĐen\r\nNhà sản xuất:\t\tiPhone\r\nXuất xứ:\t\t\tTrung Quốc\r\nNăm ra mắt :\t\t2020\r\nThời gian bảo hành:\t12 Tháng\r\nĐịa điểm bảo hành:\t\r\nRAM:\t\t\t4 GB\r\nBộ nhớ trong:\t\t128 GB\r\nHệ điều hành:\t\tiOS 14.1\r\nChipset:\t\t\tApple A14 Bionic\r\nCảm ứng:\t\tCó\r\nLoại màn hình:\t\tSuper Retina XDR\r\nKích thước màn hình:\t6.1 inch \"\r\nĐộ phân giải màn hình:\t2532 x 1170 pixels\r\nCamera trước:\t\t12MP\r\nCamera sau:\t\t12 MP (kép)\r\nĐèn Flash:\t\tCó\r\nVideo:\t\t\t4K\r\nMạng 3G:\t\tCó\r\nMạng 4G:\t\tCó\r\nWIFI:\t\t\tWi-Fi 6 (802.11ax)\r\nBluetooth:\t\tBluetooth 5.0\r\nUSB:\t\t\tType C\r\nMở khóa nhanh:\t\tMở khóa bằng khuôn mặt\r\nThiết kế:\t\t\tNguyên khối, mặt kính cường lực\r\nChống nước:\t\tCó, IP68\r\nKích thước sản phẩm:\t146.7 x 71.5 x 7.4mm mm"),
            new product("iPhone 14 Pro 128GB Vàng", Resources.ip14_pro_vang, "Vàng", "128GB", 29790000,"Model:\t\t\tiPhone 14 Pro 128GB\r\nMàu sắc:\t\t\tVàng\r\nNhà sản xuất:\t\tiPhone\r\nXuất xứ:\t\t\tTrung Quốc\r\nNăm ra mắt :\t\t2020\r\nThời gian bảo hành:\t12 Tháng\r\nĐịa điểm bảo hành:\t\r\nRAM:\t\t\t4 GB\r\nBộ nhớ trong:\t\t128 GB\r\nHệ điều hành:\t\tiOS 14.1\r\nChipset:\t\t\tApple A14 Bionic\r\nCảm ứng:\t\tCó\r\nLoại màn hình:\t\tSuper Retina XDR\r\nKích thước màn hình:\t6.1 inch \"\r\nĐộ phân giải màn hình:\t2532 x 1170 pixels\r\nCamera trước:\t\t12MP\r\nCamera sau:\t\t12 MP (kép)\r\nĐèn Flash:\t\tCó\r\nVideo:\t\t\t4K\r\nMạng 3G:\t\tCó\r\nMạng 4G:\t\tCó\r\nWIFI:\t\t\tWi-Fi 6 (802.11ax)\r\nBluetooth:\t\tBluetooth 5.0\r\nUSB:\t\t\tType C\r\nMở khóa nhanh:\t\tMở khóa bằng khuôn mặt\r\nThiết kế:\t\t\tNguyên khối, mặt kính cường lực\r\nChống nước:\t\tCó, IP68\r\nKích thước sản phẩm:\t146.7 x 71.5 x 7.4mm mm"),
            new product("iPhone 14 Pro 128GB Tím", Resources.ip14_pro_tim, "Tím", "128GB", 29790000,"Model:\t\t\tiPhone 14 Pro 128GB\r\nMàu sắc:\t\t\tTím\r\nNhà sản xuất:\t\tiPhone\r\nXuất xứ:\t\t\tTrung Quốc\r\nNăm ra mắt :\t\t2020\r\nThời gian bảo hành:\t12 Tháng\r\nĐịa điểm bảo hành:\t\r\nRAM:\t\t\t4 GB\r\nBộ nhớ trong:\t\t128 GB\r\nHệ điều hành:\t\tiOS 14.1\r\nChipset:\t\t\tApple A14 Bionic\r\nCảm ứng:\t\tCó\r\nLoại màn hình:\t\tSuper Retina XDR\r\nKích thước màn hình:\t6.1 inch \"\r\nĐộ phân giải màn hình:\t2532 x 1170 pixels\r\nCamera trước:\t\t12MP\r\nCamera sau:\t\t12 MP (kép)\r\nĐèn Flash:\t\tCó\r\nVideo:\t\t\t4K\r\nMạng 3G:\t\tCó\r\nMạng 4G:\t\tCó\r\nWIFI:\t\t\tWi-Fi 6 (802.11ax)\r\nBluetooth:\t\tBluetooth 5.0\r\nUSB:\t\t\tType C\r\nMở khóa nhanh:\t\tMở khóa bằng khuôn mặt\r\nThiết kế:\t\t\tNguyên khối, mặt kính cường lực\r\nChống nước:\t\tCó, IP68\r\nKích thước sản phẩm:\t146.7 x 71.5 x 7.4mm mm"),

            new product("iPhone 14 Pro 256GB Bạc", Resources.ip14_pro_bac, "Bạc", "256GB", 32290000,"Model:\t\t\tiPhone 14 Pro 256GB\r\nMàu sắc:\t\t\tBạc\r\nNhà sản xuất:\t\tiPhone\r\nXuất xứ:\t\t\tTrung Quốc\r\nNăm ra mắt :\t\t2020\r\nThời gian bảo hành:\t12 Tháng\r\nĐịa điểm bảo hành:\t\r\nRAM:\t\t\t4 GB\r\nBộ nhớ trong:\t\t256 GB\r\nHệ điều hành:\t\tiOS 14.1\r\nChipset:\t\t\tApple A14 Bionic\r\nCảm ứng:\t\tCó\r\nLoại màn hình:\t\tSuper Retina XDR\r\nKích thước màn hình:\t6.1 inch \"\r\nĐộ phân giải màn hình:\t2532 x 1170 pixels\r\nCamera trước:\t\t12MP\r\nCamera sau:\t\t12 MP (kép)\r\nĐèn Flash:\t\tCó\r\nVideo:\t\t\t4K\r\nMạng 3G:\t\tCó\r\nMạng 4G:\t\tCó\r\nWIFI:\t\t\tWi-Fi 6 (802.11ax)\r\nBluetooth:\t\tBluetooth 5.0\r\nUSB:\t\t\tType C\r\nMở khóa nhanh:\t\tMở khóa bằng khuôn mặt\r\nThiết kế:\t\t\tNguyên khối, mặt kính cường lực\r\nChống nước:\t\tCó, IP68\r\nKích thước sản phẩm:\t146.7 x 71.5 x 7.4mm mm"),
            new product("iPhone 14 Pro 256GB Đen", Resources.ip14_pro_den, "Đen", "256GB", 32290000,"Model:\t\t\tiPhone 14 Pro 256GB\r\nMàu sắc:\t\t\tĐen\r\nNhà sản xuất:\t\tiPhone\r\nXuất xứ:\t\t\tTrung Quốc\r\nNăm ra mắt :\t\t2020\r\nThời gian bảo hành:\t12 Tháng\r\nĐịa điểm bảo hành:\t\r\nRAM:\t\t\t4 GB\r\nBộ nhớ trong:\t\t256 GB\r\nHệ điều hành:\t\tiOS 14.1\r\nChipset:\t\t\tApple A14 Bionic\r\nCảm ứng:\t\tCó\r\nLoại màn hình:\t\tSuper Retina XDR\r\nKích thước màn hình:\t6.1 inch \"\r\nĐộ phân giải màn hình:\t2532 x 1170 pixels\r\nCamera trước:\t\t12MP\r\nCamera sau:\t\t12 MP (kép)\r\nĐèn Flash:\t\tCó\r\nVideo:\t\t\t4K\r\nMạng 3G:\t\tCó\r\nMạng 4G:\t\tCó\r\nWIFI:\t\t\tWi-Fi 6 (802.11ax)\r\nBluetooth:\t\tBluetooth 5.0\r\nUSB:\t\t\tType C\r\nMở khóa nhanh:\t\tMở khóa bằng khuôn mặt\r\nThiết kế:\t\t\tNguyên khối, mặt kính cường lực\r\nChống nước:\t\tCó, IP68\r\nKích thước sản phẩm:\t146.7 x 71.5 x 7.4mm mm"),
            new product("iPhone 14 Pro 256GB Vàng", Resources.ip14_pro_vang, "Vàng", "256GB", 32290000,"Model:\t\t\tiPhone 14 Pro 256GB\r\nMàu sắc:\t\t\tVàng\r\nNhà sản xuất:\t\tiPhone\r\nXuất xứ:\t\t\tTrung Quốc\r\nNăm ra mắt :\t\t2020\r\nThời gian bảo hành:\t12 Tháng\r\nĐịa điểm bảo hành:\t\r\nRAM:\t\t\t4 GB\r\nBộ nhớ trong:\t\t256 GB\r\nHệ điều hành:\t\tiOS 14.1\r\nChipset:\t\t\tApple A14 Bionic\r\nCảm ứng:\t\tCó\r\nLoại màn hình:\t\tSuper Retina XDR\r\nKích thước màn hình:\t6.1 inch \"\r\nĐộ phân giải màn hình:\t2532 x 1170 pixels\r\nCamera trước:\t\t12MP\r\nCamera sau:\t\t12 MP (kép)\r\nĐèn Flash:\t\tCó\r\nVideo:\t\t\t4K\r\nMạng 3G:\t\tCó\r\nMạng 4G:\t\tCó\r\nWIFI:\t\t\tWi-Fi 6 (802.11ax)\r\nBluetooth:\t\tBluetooth 5.0\r\nUSB:\t\t\tType C\r\nMở khóa nhanh:\t\tMở khóa bằng khuôn mặt\r\nThiết kế:\t\t\tNguyên khối, mặt kính cường lực\r\nChống nước:\t\tCó, IP68\r\nKích thước sản phẩm:\t146.7 x 71.5 x 7.4mm mm"),
            new product("iPhone 14 Pro 256GB Tím", Resources.ip14_pro_tim, "Tím", "256GB", 32290000,"Model:\t\t\tiPhone 14 Pro 256GB\r\nMàu sắc:\t\t\tTím\r\nNhà sản xuất:\t\tiPhone\r\nXuất xứ:\t\t\tTrung Quốc\r\nNăm ra mắt :\t\t2020\r\nThời gian bảo hành:\t12 Tháng\r\nĐịa điểm bảo hành:\t\r\nRAM:\t\t\t4 GB\r\nBộ nhớ trong:\t\t256 GB\r\nHệ điều hành:\t\tiOS 14.1\r\nChipset:\t\t\tApple A14 Bionic\r\nCảm ứng:\t\tCó\r\nLoại màn hình:\t\tSuper Retina XDR\r\nKích thước màn hình:\t6.1 inch \"\r\nĐộ phân giải màn hình:\t2532 x 1170 pixels\r\nCamera trước:\t\t12MP\r\nCamera sau:\t\t12 MP (kép)\r\nĐèn Flash:\t\tCó\r\nVideo:\t\t\t4K\r\nMạng 3G:\t\tCó\r\nMạng 4G:\t\tCó\r\nWIFI:\t\t\tWi-Fi 6 (802.11ax)\r\nBluetooth:\t\tBluetooth 5.0\r\nUSB:\t\t\tType C\r\nMở khóa nhanh:\t\tMở khóa bằng khuôn mặt\r\nThiết kế:\t\t\tNguyên khối, mặt kính cường lực\r\nChống nước:\t\tCó, IP68\r\nKích thước sản phẩm:\t146.7 x 71.5 x 7.4mm mm"),

            new product("iPhone 14 Pro 512GB Bạc", Resources.ip14_pro_bac, "Bạc", "512GB", 36990000,"Model:\t\t\tiPhone 14 Pro 512GB\r\nMàu sắc:\t\t\tBạc\r\nNhà sản xuất:\t\tiPhone\r\nXuất xứ:\t\t\tTrung Quốc\r\nNăm ra mắt :\t\t2020\r\nThời gian bảo hành:\t12 Tháng\r\nĐịa điểm bảo hành:\t\r\nRAM:\t\t\t4 GB\r\nBộ nhớ trong:\t\t512 GB\r\nHệ điều hành:\t\tiOS 14.1\r\nChipset:\t\t\tApple A14 Bionic\r\nCảm ứng:\t\tCó\r\nLoại màn hình:\t\tSuper Retina XDR\r\nKích thước màn hình:\t6.1 inch \"\r\nĐộ phân giải màn hình:\t2532 x 1170 pixels\r\nCamera trước:\t\t12MP\r\nCamera sau:\t\t12 MP (kép)\r\nĐèn Flash:\t\tCó\r\nVideo:\t\t\t4K\r\nMạng 3G:\t\tCó\r\nMạng 4G:\t\tCó\r\nWIFI:\t\t\tWi-Fi 6 (802.11ax)\r\nBluetooth:\t\tBluetooth 5.0\r\nUSB:\t\t\tType C\r\nMở khóa nhanh:\t\tMở khóa bằng khuôn mặt\r\nThiết kế:\t\t\tNguyên khối, mặt kính cường lực\r\nChống nước:\t\tCó, IP68\r\nKích thước sản phẩm:\t146.7 x 71.5 x 7.4mm mm"),
            new product("iPhone 14 Pro 512GB Đen", Resources.ip14_pro_den, "Đen", "512GB", 36990000,"Model:\t\t\tiPhone 14 Pro 512GB\r\nMàu sắc:\t\t\tĐen\r\nNhà sản xuất:\t\tiPhone\r\nXuất xứ:\t\t\tTrung Quốc\r\nNăm ra mắt :\t\t2020\r\nThời gian bảo hành:\t12 Tháng\r\nĐịa điểm bảo hành:\t\r\nRAM:\t\t\t4 GB\r\nBộ nhớ trong:\t\t512 GB\r\nHệ điều hành:\t\tiOS 14.1\r\nChipset:\t\t\tApple A14 Bionic\r\nCảm ứng:\t\tCó\r\nLoại màn hình:\t\tSuper Retina XDR\r\nKích thước màn hình:\t6.1 inch \"\r\nĐộ phân giải màn hình:\t2532 x 1170 pixels\r\nCamera trước:\t\t12MP\r\nCamera sau:\t\t12 MP (kép)\r\nĐèn Flash:\t\tCó\r\nVideo:\t\t\t4K\r\nMạng 3G:\t\tCó\r\nMạng 4G:\t\tCó\r\nWIFI:\t\t\tWi-Fi 6 (802.11ax)\r\nBluetooth:\t\tBluetooth 5.0\r\nUSB:\t\t\tType C\r\nMở khóa nhanh:\t\tMở khóa bằng khuôn mặt\r\nThiết kế:\t\t\tNguyên khối, mặt kính cường lực\r\nChống nước:\t\tCó, IP68\r\nKích thước sản phẩm:\t146.7 x 71.5 x 7.4mm mm"),
            new product("iPhone 14 Pro 512GB Vàng", Resources.ip14_pro_vang, "Vàng", "512GB", 36990000,"Model:\t\t\tiPhone 14 Pro 512GB\r\nMàu sắc:\t\t\tVàng\r\nNhà sản xuất:\t\tiPhone\r\nXuất xứ:\t\t\tTrung Quốc\r\nNăm ra mắt :\t\t2020\r\nThời gian bảo hành:\t12 Tháng\r\nĐịa điểm bảo hành:\t\r\nRAM:\t\t\t4 GB\r\nBộ nhớ trong:\t\t512 GB\r\nHệ điều hành:\t\tiOS 14.1\r\nChipset:\t\t\tApple A14 Bionic\r\nCảm ứng:\t\tCó\r\nLoại màn hình:\t\tSuper Retina XDR\r\nKích thước màn hình:\t6.1 inch \"\r\nĐộ phân giải màn hình:\t2532 x 1170 pixels\r\nCamera trước:\t\t12MP\r\nCamera sau:\t\t12 MP (kép)\r\nĐèn Flash:\t\tCó\r\nVideo:\t\t\t4K\r\nMạng 3G:\t\tCó\r\nMạng 4G:\t\tCó\r\nWIFI:\t\t\tWi-Fi 6 (802.11ax)\r\nBluetooth:\t\tBluetooth 5.0\r\nUSB:\t\t\tType C\r\nMở khóa nhanh:\t\tMở khóa bằng khuôn mặt\r\nThiết kế:\t\t\tNguyên khối, mặt kính cường lực\r\nChống nước:\t\tCó, IP68\r\nKích thước sản phẩm:\t146.7 x 71.5 x 7.4mm mm"),
            new product("iPhone 14 Pro 512GB Tím", Resources.ip14_pro_tim, "Tím", "512GB", 36990000,"Model:\t\t\tiPhone 14 Pro 512GB\r\nMàu sắc:\t\t\tTím\r\nNhà sản xuất:\t\tiPhone\r\nXuất xứ:\t\t\tTrung Quốc\r\nNăm ra mắt :\t\t2020\r\nThời gian bảo hành:\t12 Tháng\r\nĐịa điểm bảo hành:\t\r\nRAM:\t\t\t4 GB\r\nBộ nhớ trong:\t\t512 GB\r\nHệ điều hành:\t\tiOS 14.1\r\nChipset:\t\t\tApple A14 Bionic\r\nCảm ứng:\t\tCó\r\nLoại màn hình:\t\tSuper Retina XDR\r\nKích thước màn hình:\t6.1 inch \"\r\nĐộ phân giải màn hình:\t2532 x 1170 pixels\r\nCamera trước:\t\t12MP\r\nCamera sau:\t\t12 MP (kép)\r\nĐèn Flash:\t\tCó\r\nVideo:\t\t\t4K\r\nMạng 3G:\t\tCó\r\nMạng 4G:\t\tCó\r\nWIFI:\t\t\tWi-Fi 6 (802.11ax)\r\nBluetooth:\t\tBluetooth 5.0\r\nUSB:\t\t\tType C\r\nMở khóa nhanh:\t\tMở khóa bằng khuôn mặt\r\nThiết kế:\t\t\tNguyên khối, mặt kính cường lực\r\nChống nước:\t\tCó, IP68\r\nKích thước sản phẩm:\t146.7 x 71.5 x 7.4mm mm"),

            new product("iPhone 14 Pro 1TB Bạc", Resources.ip14_pro_bac, "Bạc", "1TB", 46990000,"Model:\t\t\tiPhone 14 Pro 1TB\r\nMàu sắc:\t\t\tBạc\r\nNhà sản xuất:\t\tiPhone\r\nXuất xứ:\t\t\tTrung Quốc\r\nNăm ra mắt :\t\t2020\r\nThời gian bảo hành:\t12 Tháng\r\nĐịa điểm bảo hành:\t\r\nRAM:\t\t\t4 GB\r\nBộ nhớ trong:\t\t1 TB\r\nHệ điều hành:\t\tiOS 14.1\r\nChipset:\t\t\tApple A14 Bionic\r\nCảm ứng:\t\tCó\r\nLoại màn hình:\t\tSuper Retina XDR\r\nKích thước màn hình:\t6.1 inch \"\r\nĐộ phân giải màn hình:\t2532 x 1170 pixels\r\nCamera trước:\t\t12MP\r\nCamera sau:\t\t12 MP (kép)\r\nĐèn Flash:\t\tCó\r\nVideo:\t\t\t4K\r\nMạng 3G:\t\tCó\r\nMạng 4G:\t\tCó\r\nWIFI:\t\t\tWi-Fi 6 (802.11ax)\r\nBluetooth:\t\tBluetooth 5.0\r\nUSB:\t\t\tType C\r\nMở khóa nhanh:\t\tMở khóa bằng khuôn mặt\r\nThiết kế:\t\t\tNguyên khối, mặt kính cường lực\r\nChống nước:\t\tCó, IP68\r\nKích thước sản phẩm:\t146.7 x 71.5 x 7.4mm mm"),
            new product("iPhone 14 Pro 1TB Đen", Resources.ip14_pro_den, "Đen", "1TB", 46990000,"Model:\t\t\tiPhone 14 Pro 1TB\r\nMàu sắc:\t\t\tĐen\r\nNhà sản xuất:\t\tiPhone\r\nXuất xứ:\t\t\tTrung Quốc\r\nNăm ra mắt :\t\t2020\r\nThời gian bảo hành:\t12 Tháng\r\nĐịa điểm bảo hành:\t\r\nRAM:\t\t\t4 GB\r\nBộ nhớ trong:\t\t1 TB\r\nHệ điều hành:\t\tiOS 14.1\r\nChipset:\t\t\tApple A14 Bionic\r\nCảm ứng:\t\tCó\r\nLoại màn hình:\t\tSuper Retina XDR\r\nKích thước màn hình:\t6.1 inch \"\r\nĐộ phân giải màn hình:\t2532 x 1170 pixels\r\nCamera trước:\t\t12MP\r\nCamera sau:\t\t12 MP (kép)\r\nĐèn Flash:\t\tCó\r\nVideo:\t\t\t4K\r\nMạng 3G:\t\tCó\r\nMạng 4G:\t\tCó\r\nWIFI:\t\t\tWi-Fi 6 (802.11ax)\r\nBluetooth:\t\tBluetooth 5.0\r\nUSB:\t\t\tType C\r\nMở khóa nhanh:\t\tMở khóa bằng khuôn mặt\r\nThiết kế:\t\t\tNguyên khối, mặt kính cường lực\r\nChống nước:\t\tCó, IP68\r\nKích thước sản phẩm:\t146.7 x 71.5 x 7.4mm mm"),
            new product("iPhone 14 Pro 1TB Vàng", Resources.ip14_pro_vang, "Vàng", "1TB", 46990000,"Model:\t\t\tiPhone 14 Pro 1TB\r\nMàu sắc:\t\t\tVàng\r\nNhà sản xuất:\t\tiPhone\r\nXuất xứ:\t\t\tTrung Quốc\r\nNăm ra mắt :\t\t2020\r\nThời gian bảo hành:\t12 Tháng\r\nĐịa điểm bảo hành:\t\r\nRAM:\t\t\t4 GB\r\nBộ nhớ trong:\t\t1 TB\r\nHệ điều hành:\t\tiOS 14.1\r\nChipset:\t\t\tApple A14 Bionic\r\nCảm ứng:\t\tCó\r\nLoại màn hình:\t\tSuper Retina XDR\r\nKích thước màn hình:\t6.1 inch \"\r\nĐộ phân giải màn hình:\t2532 x 1170 pixels\r\nCamera trước:\t\t12MP\r\nCamera sau:\t\t12 MP (kép)\r\nĐèn Flash:\t\tCó\r\nVideo:\t\t\t4K\r\nMạng 3G:\t\tCó\r\nMạng 4G:\t\tCó\r\nWIFI:\t\t\tWi-Fi 6 (802.11ax)\r\nBluetooth:\t\tBluetooth 5.0\r\nUSB:\t\t\tType C\r\nMở khóa nhanh:\t\tMở khóa bằng khuôn mặt\r\nThiết kế:\t\t\tNguyên khối, mặt kính cường lực\r\nChống nước:\t\tCó, IP68\r\nKích thước sản phẩm:\t146.7 x 71.5 x 7.4mm mm"),
            new product("iPhone 14 Pro 1TB Tím", Resources.ip14_pro_tim, "Tím", "1TB", 46990000,"Model:\t\t\tiPhone 14 Pro 1TB\r\nMàu sắc:\t\t\tTím\r\nNhà sản xuất:\t\tiPhone\r\nXuất xứ:\t\t\tTrung Quốc\r\nNăm ra mắt :\t\t2020\r\nThời gian bảo hành:\t12 Tháng\r\nĐịa điểm bảo hành:\t\r\nRAM:\t\t\t4 GB\r\nBộ nhớ trong:\t\t1 TB\r\nHệ điều hành:\t\tiOS 14.1\r\nChipset:\t\t\tApple A14 Bionic\r\nCảm ứng:\t\tCó\r\nLoại màn hình:\t\tSuper Retina XDR\r\nKích thước màn hình:\t6.1 inch \"\r\nĐộ phân giải màn hình:\t2532 x 1170 pixels\r\nCamera trước:\t\t12MP\r\nCamera sau:\t\t12 MP (kép)\r\nĐèn Flash:\t\tCó\r\nVideo:\t\t\t4K\r\nMạng 3G:\t\tCó\r\nMạng 4G:\t\tCó\r\nWIFI:\t\t\tWi-Fi 6 (802.11ax)\r\nBluetooth:\t\tBluetooth 5.0\r\nUSB:\t\t\tType C\r\nMở khóa nhanh:\t\tMở khóa bằng khuôn mặt\r\nThiết kế:\t\t\tNguyên khối, mặt kính cường lực\r\nChống nước:\t\tCó, IP68\r\nKích thước sản phẩm:\t146.7 x 71.5 x 7.4mm mm"),

            new product("iPhone 14 Pro Max 128GB Bạc", Resources.ip14_promax_bac, "Bạc", "128GB", 32990000,"Model:\t\t\tiPhone 14 Pro Max 128GB\r\nMàu sắc:\t\t\tBạc\r\nNhà sản xuất:\t\tiPhone\r\nXuất xứ:\t\t\tTrung Quốc\r\nNăm ra mắt :\t\t2020\r\nThời gian bảo hành:\t12 Tháng\r\nĐịa điểm bảo hành:\t\r\nRAM:\t\t\t4 GB\r\nBộ nhớ trong:\t\t128 GB\r\nHệ điều hành:\t\tiOS 14.1\r\nChipset:\t\t\tApple A14 Bionic\r\nCảm ứng:\t\tCó\r\nLoại màn hình:\t\tSuper Retina XDR\r\nKích thước màn hình:\t6.1 inch \"\r\nĐộ phân giải màn hình:\t2532 x 1170 pixels\r\nCamera trước:\t\t12MP\r\nCamera sau:\t\t12 MP (kép)\r\nĐèn Flash:\t\tCó\r\nVideo:\t\t\t4K\r\nMạng 3G:\t\tCó\r\nMạng 4G:\t\tCó\r\nWIFI:\t\t\tWi-Fi 6 (802.11ax)\r\nBluetooth:\t\tBluetooth 5.0\r\nUSB:\t\t\tType C\r\nMở khóa nhanh:\t\tMở khóa bằng khuôn mặt\r\nThiết kế:\t\t\tNguyên khối, mặt kính cường lực\r\nChống nước:\t\tCó, IP68\r\nKích thước sản phẩm:\t146.7 x 71.5 x 7.4mm mm"),
            new product("iPhone 14 Pro Max 128GB Đen", Resources.ip14_promax_den, "Đen", "128GB", 32990000,"Model:\t\t\tiPhone 14 Pro Max 128GB\r\nMàu sắc:\t\t\tĐen\r\nNhà sản xuất:\t\tiPhone\r\nXuất xứ:\t\t\tTrung Quốc\r\nNăm ra mắt :\t\t2020\r\nThời gian bảo hành:\t12 Tháng\r\nĐịa điểm bảo hành:\t\r\nRAM:\t\t\t4 GB\r\nBộ nhớ trong:\t\t128 GB\r\nHệ điều hành:\t\tiOS 14.1\r\nChipset:\t\t\tApple A14 Bionic\r\nCảm ứng:\t\tCó\r\nLoại màn hình:\t\tSuper Retina XDR\r\nKích thước màn hình:\t6.1 inch \"\r\nĐộ phân giải màn hình:\t2532 x 1170 pixels\r\nCamera trước:\t\t12MP\r\nCamera sau:\t\t12 MP (kép)\r\nĐèn Flash:\t\tCó\r\nVideo:\t\t\t4K\r\nMạng 3G:\t\tCó\r\nMạng 4G:\t\tCó\r\nWIFI:\t\t\tWi-Fi 6 (802.11ax)\r\nBluetooth:\t\tBluetooth 5.0\r\nUSB:\t\t\tType C\r\nMở khóa nhanh:\t\tMở khóa bằng khuôn mặt\r\nThiết kế:\t\t\tNguyên khối, mặt kính cường lực\r\nChống nước:\t\tCó, IP68\r\nKích thước sản phẩm:\t146.7 x 71.5 x 7.4mm mm"),
            new product("iPhone 14 Pro Max 128GB Vàng", Resources.ip14_promax_vang, "Vàng", "128GB", 32990000,"Model:\t\t\tiPhone 14 Pro Max 128GB\r\nMàu sắc:\t\t\tVàng\r\nNhà sản xuất:\t\tiPhone\r\nXuất xứ:\t\t\tTrung Quốc\r\nNăm ra mắt :\t\t2020\r\nThời gian bảo hành:\t12 Tháng\r\nĐịa điểm bảo hành:\t\r\nRAM:\t\t\t4 GB\r\nBộ nhớ trong:\t\t128 GB\r\nHệ điều hành:\t\tiOS 14.1\r\nChipset:\t\t\tApple A14 Bionic\r\nCảm ứng:\t\tCó\r\nLoại màn hình:\t\tSuper Retina XDR\r\nKích thước màn hình:\t6.1 inch \"\r\nĐộ phân giải màn hình:\t2532 x 1170 pixels\r\nCamera trước:\t\t12MP\r\nCamera sau:\t\t12 MP (kép)\r\nĐèn Flash:\t\tCó\r\nVideo:\t\t\t4K\r\nMạng 3G:\t\tCó\r\nMạng 4G:\t\tCó\r\nWIFI:\t\t\tWi-Fi 6 (802.11ax)\r\nBluetooth:\t\tBluetooth 5.0\r\nUSB:\t\t\tType C\r\nMở khóa nhanh:\t\tMở khóa bằng khuôn mặt\r\nThiết kế:\t\t\tNguyên khối, mặt kính cường lực\r\nChống nước:\t\tCó, IP68\r\nKích thước sản phẩm:\t146.7 x 71.5 x 7.4mm mm"),
            new product("iPhone 14 Pro Max 128GB Tím", Resources.ip14_promax_tim, "Tím", "128GB", 32990000,"Model:\t\t\tiPhone 14 Pro Max 128GB\r\nMàu sắc:\t\t\tTím\r\nNhà sản xuất:\t\tiPhone\r\nXuất xứ:\t\t\tTrung Quốc\r\nNăm ra mắt :\t\t2020\r\nThời gian bảo hành:\t12 Tháng\r\nĐịa điểm bảo hành:\t\r\nRAM:\t\t\t4 GB\r\nBộ nhớ trong:\t\t128 GB\r\nHệ điều hành:\t\tiOS 14.1\r\nChipset:\t\t\tApple A14 Bionic\r\nCảm ứng:\t\tCó\r\nLoại màn hình:\t\tSuper Retina XDR\r\nKích thước màn hình:\t6.1 inch \"\r\nĐộ phân giải màn hình:\t2532 x 1170 pixels\r\nCamera trước:\t\t12MP\r\nCamera sau:\t\t12 MP (kép)\r\nĐèn Flash:\t\tCó\r\nVideo:\t\t\t4K\r\nMạng 3G:\t\tCó\r\nMạng 4G:\t\tCó\r\nWIFI:\t\t\tWi-Fi 6 (802.11ax)\r\nBluetooth:\t\tBluetooth 5.0\r\nUSB:\t\t\tType C\r\nMở khóa nhanh:\t\tMở khóa bằng khuôn mặt\r\nThiết kế:\t\t\tNguyên khối, mặt kính cường lực\r\nChống nước:\t\tCó, IP68\r\nKích thước sản phẩm:\t146.7 x 71.5 x 7.4mm mm"),

            new product("iPhone 14 Pro Max 256GB Bạc", Resources.ip14_promax_bac, "Bạc", "256GB", 35990000,"Model:\t\t\tiPhone 14 Pro Max 256GB\r\nMàu sắc:\t\t\tBạc\r\nNhà sản xuất:\t\tiPhone\r\nXuất xứ:\t\t\tTrung Quốc\r\nNăm ra mắt :\t\t2020\r\nThời gian bảo hành:\t12 Tháng\r\nĐịa điểm bảo hành:\t\r\nRAM:\t\t\t4 GB\r\nBộ nhớ trong:\t\t256 GB\r\nHệ điều hành:\t\tiOS 14.1\r\nChipset:\t\t\tApple A14 Bionic\r\nCảm ứng:\t\tCó\r\nLoại màn hình:\t\tSuper Retina XDR\r\nKích thước màn hình:\t6.1 inch \"\r\nĐộ phân giải màn hình:\t2532 x 1170 pixels\r\nCamera trước:\t\t12MP\r\nCamera sau:\t\t12 MP (kép)\r\nĐèn Flash:\t\tCó\r\nVideo:\t\t\t4K\r\nMạng 3G:\t\tCó\r\nMạng 4G:\t\tCó\r\nWIFI:\t\t\tWi-Fi 6 (802.11ax)\r\nBluetooth:\t\tBluetooth 5.0\r\nUSB:\t\t\tType C\r\nMở khóa nhanh:\t\tMở khóa bằng khuôn mặt\r\nThiết kế:\t\t\tNguyên khối, mặt kính cường lực\r\nChống nước:\t\tCó, IP68\r\nKích thước sản phẩm:\t146.7 x 71.5 x 7.4mm mm"),
            new product("iPhone 14 Pro Max 256GB Đen", Resources.ip14_promax_den, "Đen", "256GB", 35990000,"Model:\t\t\tiPhone 14 Pro Max 256GB\r\nMàu sắc:\t\t\tĐen\r\nNhà sản xuất:\t\tiPhone\r\nXuất xứ:\t\t\tTrung Quốc\r\nNăm ra mắt :\t\t2020\r\nThời gian bảo hành:\t12 Tháng\r\nĐịa điểm bảo hành:\t\r\nRAM:\t\t\t4 GB\r\nBộ nhớ trong:\t\t256 GB\r\nHệ điều hành:\t\tiOS 14.1\r\nChipset:\t\t\tApple A14 Bionic\r\nCảm ứng:\t\tCó\r\nLoại màn hình:\t\tSuper Retina XDR\r\nKích thước màn hình:\t6.1 inch \"\r\nĐộ phân giải màn hình:\t2532 x 1170 pixels\r\nCamera trước:\t\t12MP\r\nCamera sau:\t\t12 MP (kép)\r\nĐèn Flash:\t\tCó\r\nVideo:\t\t\t4K\r\nMạng 3G:\t\tCó\r\nMạng 4G:\t\tCó\r\nWIFI:\t\t\tWi-Fi 6 (802.11ax)\r\nBluetooth:\t\tBluetooth 5.0\r\nUSB:\t\t\tType C\r\nMở khóa nhanh:\t\tMở khóa bằng khuôn mặt\r\nThiết kế:\t\t\tNguyên khối, mặt kính cường lực\r\nChống nước:\t\tCó, IP68\r\nKích thước sản phẩm:\t146.7 x 71.5 x 7.4mm mm"),
            new product("iPhone 14 Pro Max 256GB Vàng", Resources.ip14_promax_vang, "Vàng", "256GB", 35990000,"Model:\t\t\tiPhone 14 Pro Max 256GB\r\nMàu sắc:\t\t\tVàng\r\nNhà sản xuất:\t\tiPhone\r\nXuất xứ:\t\t\tTrung Quốc\r\nNăm ra mắt :\t\t2020\r\nThời gian bảo hành:\t12 Tháng\r\nĐịa điểm bảo hành:\t\r\nRAM:\t\t\t4 GB\r\nBộ nhớ trong:\t\t256 GB\r\nHệ điều hành:\t\tiOS 14.1\r\nChipset:\t\t\tApple A14 Bionic\r\nCảm ứng:\t\tCó\r\nLoại màn hình:\t\tSuper Retina XDR\r\nKích thước màn hình:\t6.1 inch \"\r\nĐộ phân giải màn hình:\t2532 x 1170 pixels\r\nCamera trước:\t\t12MP\r\nCamera sau:\t\t12 MP (kép)\r\nĐèn Flash:\t\tCó\r\nVideo:\t\t\t4K\r\nMạng 3G:\t\tCó\r\nMạng 4G:\t\tCó\r\nWIFI:\t\t\tWi-Fi 6 (802.11ax)\r\nBluetooth:\t\tBluetooth 5.0\r\nUSB:\t\t\tType C\r\nMở khóa nhanh:\t\tMở khóa bằng khuôn mặt\r\nThiết kế:\t\t\tNguyên khối, mặt kính cường lực\r\nChống nước:\t\tCó, IP68\r\nKích thước sản phẩm:\t146.7 x 71.5 x 7.4mm mm"),
            new product("iPhone 14 Pro Max 256GB Tím", Resources.ip14_promax_tim, "Tím", "256GB", 35990000,"Model:\t\t\tiPhone 14 Pro Max 256GB\r\nMàu sắc:\t\t\tTím\r\nNhà sản xuất:\t\tiPhone\r\nXuất xứ:\t\t\tTrung Quốc\r\nNăm ra mắt :\t\t2020\r\nThời gian bảo hành:\t12 Tháng\r\nĐịa điểm bảo hành:\t\r\nRAM:\t\t\t4 GB\r\nBộ nhớ trong:\t\t256 GB\r\nHệ điều hành:\t\tiOS 14.1\r\nChipset:\t\t\tApple A14 Bionic\r\nCảm ứng:\t\tCó\r\nLoại màn hình:\t\tSuper Retina XDR\r\nKích thước màn hình:\t6.1 inch \"\r\nĐộ phân giải màn hình:\t2532 x 1170 pixels\r\nCamera trước:\t\t12MP\r\nCamera sau:\t\t12 MP (kép)\r\nĐèn Flash:\t\tCó\r\nVideo:\t\t\t4K\r\nMạng 3G:\t\tCó\r\nMạng 4G:\t\tCó\r\nWIFI:\t\t\tWi-Fi 6 (802.11ax)\r\nBluetooth:\t\tBluetooth 5.0\r\nUSB:\t\t\tType C\r\nMở khóa nhanh:\t\tMở khóa bằng khuôn mặt\r\nThiết kế:\t\t\tNguyên khối, mặt kính cường lực\r\nChống nước:\t\tCó, IP68\r\nKích thước sản phẩm:\t146.7 x 71.5 x 7.4mm mm"),

            new product("iPhone 14 Pro Max 512GB Bạc", Resources.ip14_promax_bac, "Bạc", "512GB", 42490000,"Model:\t\t\tiPhone 14 Pro Max 512GB\r\nMàu sắc:\t\t\tBạc\r\nNhà sản xuất:\t\tiPhone\r\nXuất xứ:\t\t\tTrung Quốc\r\nNăm ra mắt :\t\t2020\r\nThời gian bảo hành:\t12 Tháng\r\nĐịa điểm bảo hành:\t\r\nRAM:\t\t\t4 GB\r\nBộ nhớ trong:\t\t512 GB\r\nHệ điều hành:\t\tiOS 14.1\r\nChipset:\t\t\tApple A14 Bionic\r\nCảm ứng:\t\tCó\r\nLoại màn hình:\t\tSuper Retina XDR\r\nKích thước màn hình:\t6.1 inch \"\r\nĐộ phân giải màn hình:\t2532 x 1170 pixels\r\nCamera trước:\t\t12MP\r\nCamera sau:\t\t12 MP (kép)\r\nĐèn Flash:\t\tCó\r\nVideo:\t\t\t4K\r\nMạng 3G:\t\tCó\r\nMạng 4G:\t\tCó\r\nWIFI:\t\t\tWi-Fi 6 (802.11ax)\r\nBluetooth:\t\tBluetooth 5.0\r\nUSB:\t\t\tType C\r\nMở khóa nhanh:\t\tMở khóa bằng khuôn mặt\r\nThiết kế:\t\t\tNguyên khối, mặt kính cường lực\r\nChống nước:\t\tCó, IP68\r\nKích thước sản phẩm:\t146.7 x 71.5 x 7.4mm mm"),
            new product("iPhone 14 Pro Max 512GB Đen", Resources.ip14_promax_den, "Đen", "512GB", 42490000,"Model:\t\t\tiPhone 14 Pro Max 512GB\r\nMàu sắc:\t\t\tĐen\r\nNhà sản xuất:\t\tiPhone\r\nXuất xứ:\t\t\tTrung Quốc\r\nNăm ra mắt :\t\t2020\r\nThời gian bảo hành:\t12 Tháng\r\nĐịa điểm bảo hành:\t\r\nRAM:\t\t\t4 GB\r\nBộ nhớ trong:\t\t512 GB\r\nHệ điều hành:\t\tiOS 14.1\r\nChipset:\t\t\tApple A14 Bionic\r\nCảm ứng:\t\tCó\r\nLoại màn hình:\t\tSuper Retina XDR\r\nKích thước màn hình:\t6.1 inch \"\r\nĐộ phân giải màn hình:\t2532 x 1170 pixels\r\nCamera trước:\t\t12MP\r\nCamera sau:\t\t12 MP (kép)\r\nĐèn Flash:\t\tCó\r\nVideo:\t\t\t4K\r\nMạng 3G:\t\tCó\r\nMạng 4G:\t\tCó\r\nWIFI:\t\t\tWi-Fi 6 (802.11ax)\r\nBluetooth:\t\tBluetooth 5.0\r\nUSB:\t\t\tType C\r\nMở khóa nhanh:\t\tMở khóa bằng khuôn mặt\r\nThiết kế:\t\t\tNguyên khối, mặt kính cường lực\r\nChống nước:\t\tCó, IP68\r\nKích thước sản phẩm:\t146.7 x 71.5 x 7.4mm mm"),
            new product("iPhone 14 Pro Max 512GB Vàng", Resources.ip14_promax_vang, "Vàng", "512GB", 42490000,"Model:\t\t\tiPhone 14 Pro Max 512GB\r\nMàu sắc:\t\t\tVàng\r\nNhà sản xuất:\t\tiPhone\r\nXuất xứ:\t\t\tTrung Quốc\r\nNăm ra mắt :\t\t2020\r\nThời gian bảo hành:\t12 Tháng\r\nĐịa điểm bảo hành:\t\r\nRAM:\t\t\t4 GB\r\nBộ nhớ trong:\t\t512 GB\r\nHệ điều hành:\t\tiOS 14.1\r\nChipset:\t\t\tApple A14 Bionic\r\nCảm ứng:\t\tCó\r\nLoại màn hình:\t\tSuper Retina XDR\r\nKích thước màn hình:\t6.1 inch \"\r\nĐộ phân giải màn hình:\t2532 x 1170 pixels\r\nCamera trước:\t\t12MP\r\nCamera sau:\t\t12 MP (kép)\r\nĐèn Flash:\t\tCó\r\nVideo:\t\t\t4K\r\nMạng 3G:\t\tCó\r\nMạng 4G:\t\tCó\r\nWIFI:\t\t\tWi-Fi 6 (802.11ax)\r\nBluetooth:\t\tBluetooth 5.0\r\nUSB:\t\t\tType C\r\nMở khóa nhanh:\t\tMở khóa bằng khuôn mặt\r\nThiết kế:\t\t\tNguyên khối, mặt kính cường lực\r\nChống nước:\t\tCó, IP68\r\nKích thước sản phẩm:\t146.7 x 71.5 x 7.4mm mm"),
            new product("iPhone 14 Pro Max 512GB Tím", Resources.ip14_promax_tim, "Tím", "512GB", 42490000,"Model:\t\t\tiPhone 14 Pro Max 512GB\r\nMàu sắc:\t\t\tTím\r\nNhà sản xuất:\t\tiPhone\r\nXuất xứ:\t\t\tTrung Quốc\r\nNăm ra mắt :\t\t2020\r\nThời gian bảo hành:\t12 Tháng\r\nĐịa điểm bảo hành:\t\r\nRAM:\t\t\t4 GB\r\nBộ nhớ trong:\t\t512 GB\r\nHệ điều hành:\t\tiOS 14.1\r\nChipset:\t\t\tApple A14 Bionic\r\nCảm ứng:\t\tCó\r\nLoại màn hình:\t\tSuper Retina XDR\r\nKích thước màn hình:\t6.1 inch \"\r\nĐộ phân giải màn hình:\t2532 x 1170 pixels\r\nCamera trước:\t\t12MP\r\nCamera sau:\t\t12 MP (kép)\r\nĐèn Flash:\t\tCó\r\nVideo:\t\t\t4K\r\nMạng 3G:\t\tCó\r\nMạng 4G:\t\tCó\r\nWIFI:\t\t\tWi-Fi 6 (802.11ax)\r\nBluetooth:\t\tBluetooth 5.0\r\nUSB:\t\t\tType C\r\nMở khóa nhanh:\t\tMở khóa bằng khuôn mặt\r\nThiết kế:\t\t\tNguyên khối, mặt kính cường lực\r\nChống nước:\t\tCó, IP68\r\nKích thước sản phẩm:\t146.7 x 71.5 x 7.4mm mm"),

            new product("iPhone 14 Pro Max 1TB Bạc", Resources.ip14_promax_bac, "Bạc", "128GB", 47990000,"Model:\t\t\tiPhone 14 Pro Max 128GB\r\nMàu sắc:\t\t\tBạc\r\nNhà sản xuất:\t\tiPhone\r\nXuất xứ:\t\t\tTrung Quốc\r\nNăm ra mắt :\t\t2020\r\nThời gian bảo hành:\t12 Tháng\r\nĐịa điểm bảo hành:\t\r\nRAM:\t\t\t4 GB\r\nBộ nhớ trong:\t\t1 TB\r\nHệ điều hành:\t\tiOS 14.1\r\nChipset:\t\t\tApple A14 Bionic\r\nCảm ứng:\t\tCó\r\nLoại màn hình:\t\tSuper Retina XDR\r\nKích thước màn hình:\t6.1 inch \"\r\nĐộ phân giải màn hình:\t2532 x 1170 pixels\r\nCamera trước:\t\t12MP\r\nCamera sau:\t\t12 MP (kép)\r\nĐèn Flash:\t\tCó\r\nVideo:\t\t\t4K\r\nMạng 3G:\t\tCó\r\nMạng 4G:\t\tCó\r\nWIFI:\t\t\tWi-Fi 6 (802.11ax)\r\nBluetooth:\t\tBluetooth 5.0\r\nUSB:\t\t\tType C\r\nMở khóa nhanh:\t\tMở khóa bằng khuôn mặt\r\nThiết kế:\t\t\tNguyên khối, mặt kính cường lực\r\nChống nước:\t\tCó, IP68\r\nKích thước sản phẩm:\t146.7 x 71.5 x 7.4mm mm"),
            new product("iPhone 14 Pro Max 1TB Đen", Resources.ip14_promax_den, "Đen", "128GB", 47990000,"Model:\t\t\tiPhone 14 Pro Max 128GB\r\nMàu sắc:\t\t\tĐen\r\nNhà sản xuất:\t\tiPhone\r\nXuất xứ:\t\t\tTrung Quốc\r\nNăm ra mắt :\t\t2020\r\nThời gian bảo hành:\t12 Tháng\r\nĐịa điểm bảo hành:\t\r\nRAM:\t\t\t4 GB\r\nBộ nhớ trong:\t\t1 TB\r\nHệ điều hành:\t\tiOS 14.1\r\nChipset:\t\t\tApple A14 Bionic\r\nCảm ứng:\t\tCó\r\nLoại màn hình:\t\tSuper Retina XDR\r\nKích thước màn hình:\t6.1 inch \"\r\nĐộ phân giải màn hình:\t2532 x 1170 pixels\r\nCamera trước:\t\t12MP\r\nCamera sau:\t\t12 MP (kép)\r\nĐèn Flash:\t\tCó\r\nVideo:\t\t\t4K\r\nMạng 3G:\t\tCó\r\nMạng 4G:\t\tCó\r\nWIFI:\t\t\tWi-Fi 6 (802.11ax)\r\nBluetooth:\t\tBluetooth 5.0\r\nUSB:\t\t\tType C\r\nMở khóa nhanh:\t\tMở khóa bằng khuôn mặt\r\nThiết kế:\t\t\tNguyên khối, mặt kính cường lực\r\nChống nước:\t\tCó, IP68\r\nKích thước sản phẩm:\t146.7 x 71.5 x 7.4mm mm"),
            new product("iPhone 14 Pro Max 1TB Vàng", Resources.ip14_promax_vang, "Vàng", "128GB", 47990000,"Model:\t\t\tiPhone 14 Pro Max 128GB\r\nMàu sắc:\t\t\tVàng\r\nNhà sản xuất:\t\tiPhone\r\nXuất xứ:\t\t\tTrung Quốc\r\nNăm ra mắt :\t\t2020\r\nThời gian bảo hành:\t12 Tháng\r\nĐịa điểm bảo hành:\t\r\nRAM:\t\t\t4 GB\r\nBộ nhớ trong:\t\t1 TB\r\nHệ điều hành:\t\tiOS 14.1\r\nChipset:\t\t\tApple A14 Bionic\r\nCảm ứng:\t\tCó\r\nLoại màn hình:\t\tSuper Retina XDR\r\nKích thước màn hình:\t6.1 inch \"\r\nĐộ phân giải màn hình:\t2532 x 1170 pixels\r\nCamera trước:\t\t12MP\r\nCamera sau:\t\t12 MP (kép)\r\nĐèn Flash:\t\tCó\r\nVideo:\t\t\t4K\r\nMạng 3G:\t\tCó\r\nMạng 4G:\t\tCó\r\nWIFI:\t\t\tWi-Fi 6 (802.11ax)\r\nBluetooth:\t\tBluetooth 5.0\r\nUSB:\t\t\tType C\r\nMở khóa nhanh:\t\tMở khóa bằng khuôn mặt\r\nThiết kế:\t\t\tNguyên khối, mặt kính cường lực\r\nChống nước:\t\tCó, IP68\r\nKích thước sản phẩm:\t146.7 x 71.5 x 7.4mm mm"),
            new product("iPhone 14 Pro Max 1TB Tím", Resources.ip14_promax_tim, "Tím", "128GB", 47990000,"Model:\t\t\tiPhone 14 Pro Max 128GB\r\nMàu sắc:\t\t\tTím\r\nNhà sản xuất:\t\tiPhone\r\nXuất xứ:\t\t\tTrung Quốc\r\nNăm ra mắt :\t\t2020\r\nThời gian bảo hành:\t12 Tháng\r\nĐịa điểm bảo hành:\t\r\nRAM:\t\t\t4 GB\r\nBộ nhớ trong:\t\t1 TB\r\nHệ điều hành:\t\tiOS 14.1\r\nChipset:\t\t\tApple A14 Bionic\r\nCảm ứng:\t\tCó\r\nLoại màn hình:\t\tSuper Retina XDR\r\nKích thước màn hình:\t6.1 inch \"\r\nĐộ phân giải màn hình:\t2532 x 1170 pixels\r\nCamera trước:\t\t12MP\r\nCamera sau:\t\t12 MP (kép)\r\nĐèn Flash:\t\tCó\r\nVideo:\t\t\t4K\r\nMạng 3G:\t\tCó\r\nMạng 4G:\t\tCó\r\nWIFI:\t\t\tWi-Fi 6 (802.11ax)\r\nBluetooth:\t\tBluetooth 5.0\r\nUSB:\t\t\tType C\r\nMở khóa nhanh:\t\tMở khóa bằng khuôn mặt\r\nThiết kế:\t\t\tNguyên khối, mặt kính cường lực\r\nChống nước:\t\tCó, IP68\r\nKích thước sản phẩm:\t146.7 x 71.5 x 7.4mm mm"),
            #endregion
            #region samsung
            new product("Samsung Galaxy A03 32GB Đỏ", Resources.samsung_galaxy_a03_32gb_do, "Đỏ", "32GB", 2350000,"Model:\t\t\tA03 (SM-A035F/DS)\r\nMàu sắc:\t\t\tĐỏ\r\nNhà sản xuất:\t\tSamsung\r\nXuất xứ:\t\t\tTrung Quốc\r\nThời gian bảo hành:\t12 Tháng\r\nĐịa điểm bảo hành:\t\r\nRAM:\t\t\t3 GB\r\nBộ nhớ trong:\t\t32 GB\r\nHệ điều hành:\t\tAndroid 11\r\nChipset:\t\t\tUnisoc T606 8 nhân\r\nLoại màn hình:\t\tInfinity-V TFT LCD 20:9\r\nKích thước màn hình:\t6.5 \"\r\nĐộ phân giải màn hình:\tHD+ (720x1600) pixels\r\nCamera trước:\t\t5MP F2.2\r\nCamera sau:\t\t48MP F1.8 (Main), 2MP F2.4 (Depth)\r\nDung lượng Pin:\t\t5000mAh"),
            new product("Samsung Galaxy A03 32GB Đen", Resources.samsung_galaxy_a03_32gb_den, "Đen", "32GB", 2350000,"Model:\t\t\tA03 (SM-A035F/DS)\r\nMàu sắc:\t\t\tĐen\r\nNhà sản xuất:\t\tSamsung\r\nXuất xứ:\t\t\tTrung Quốc\r\nThời gian bảo hành:\t12 Tháng\r\nĐịa điểm bảo hành:\t\r\nRAM:\t\t\t3 GB\r\nBộ nhớ trong:\t\t32 GB\r\nHệ điều hành:\t\tAndroid 11\r\nChipset:\t\t\tUnisoc T606 8 nhân\r\nLoại màn hình:\t\tInfinity-V TFT LCD 20:9\r\nKích thước màn hình:\t6.5 \"\r\nĐộ phân giải màn hình:\tHD+ (720x1600) pixels\r\nCamera trước:\t\t5MP F2.2\r\nCamera sau:\t\t48MP F1.8 (Main), 2MP F2.4 (Depth)\r\nDung lượng Pin:\t\t5000mAh"),
            new product("Samsung Galaxy A03 32GB Xanh", Resources.samsung_galaxy_a03_32gb_xanh, "Xanh", "32GB", 2350000,"Model:\t\t\tA03 (SM-A035F/DS)\r\nMàu sắc:\t\t\tXanh\r\nNhà sản xuất:\t\tSamsung\r\nXuất xứ:\t\t\tTrung Quốc\r\nThời gian bảo hành:\t12 Tháng\r\nĐịa điểm bảo hành:\t\r\nRAM:\t\t\t3 GB\r\nBộ nhớ trong:\t\t32 GB\r\nHệ điều hành:\t\tAndroid 11\r\nChipset:\t\t\tUnisoc T606 8 nhân\r\nLoại màn hình:\t\tInfinity-V TFT LCD 20:9\r\nKích thước màn hình:\t6.5 \"\r\nĐộ phân giải màn hình:\tHD+ (720x1600) pixels\r\nCamera trước:\t\t5MP F2.2\r\nCamera sau:\t\t48MP F1.8 (Main), 2MP F2.4 (Depth)\r\nDung lượng Pin:\t\t5000mAh"),
            new product("Samsung A73 8GB/128GB Xanh", Resources.samsung_a73_8gb_128gb_xanh, "Xanh", "128GB", 11290000,"Model:\t\t\tSM-A736B/DS\r\nMàu sắc:\t\t\tXanh\r\nNhà sản xuất:\t\tSamsung\r\nXuất xứ:\t\t\tViệt Nam\r\nThời gian bảo hành:\t12 Tháng\r\nĐịa điểm bảo hành:\t\r\nRAM:\t\t\t\t8 GB\r\nBộ nhớ trong:\t\t128 GB\r\nHệ điều hành:\t\tAndroid 12\r\nChipset:\t\t\tSnapdragon 778G (8 nhân)\r\nLoại màn hình:\t\tInfinity-O Display\r\nKích thước màn hình:\t6.7” \"\r\nĐộ phân giải màn hình:\tFHD+ (2400x1080) pixels\r\nCamera trước:\t\t32 MP\r\nCamera sau:\t\t\t108 MP + 12 MP+ 5 MP+ 5 MP\r\nLoại SIM:\t\t\tNano SIM\r\nDung lượng Pin:\t\t5,000 mAh\r\nMở khóa nhanh:\t\tOn-Screen Fingerprint\r\nTiện ích khác ĐTDĐ:\tSạc nhanh 25W\r\nChiều cao:\t\t\t7.6 mm\r\nChiều dài:\t\t\t163.7 mm\r\nChiều rộng:\t\t\t76.1 mm"),
            new product("Samsung A73 8GB/128GB Xám", Resources.samsung_a73_8gb_128gb_xam, "Xám", "128GB", 11290000,"Model:\t\t\tSM-A736B/DS\r\nMàu sắc:\t\t\tXám\r\nNhà sản xuất:\t\tSamsung\r\nXuất xứ:\t\t\tViệt Nam\r\nThời gian bảo hành:\t12 Tháng\r\nĐịa điểm bảo hành:\t\r\nRAM:\t\t\t\t8 GB\r\nBộ nhớ trong:\t\t128 GB\r\nHệ điều hành:\t\tAndroid 12\r\nChipset:\t\t\tSnapdragon 778G (8 nhân)\r\nLoại màn hình:\t\tInfinity-O Display\r\nKích thước màn hình:\t6.7” \"\r\nĐộ phân giải màn hình:\tFHD+ (2400x1080) pixels\r\nCamera trước:\t\t32 MP\r\nCamera sau:\t\t\t108 MP + 12 MP+ 5 MP+ 5 MP\r\nLoại SIM:\t\t\tNano SIM\r\nDung lượng Pin:\t\t5,000 mAh\r\nMở khóa nhanh:\t\tOn-Screen Fingerprint\r\nTiện ích khác ĐTDĐ:\tSạc nhanh 25W\r\nChiều cao:\t\t\t7.6 mm\r\nChiều dài:\t\t\t163.7 mm\r\nChiều rộng:\t\t\t76.1 mm"),
            new product("Samsung A73 8GB/128GB Trắng", Resources.samsung_a73_8gb_128gb_trang, "Trắng", "128GB", 11290000,"Model:\t\t\tSM-A736B/DS\r\nMàu sắc:\t\t\tTrắng\r\nNhà sản xuất:\t\tSamsung\r\nXuất xứ:\t\t\tViệt Nam\r\nThời gian bảo hành:\t12 Tháng\r\nĐịa điểm bảo hành:\t\r\nRAM:\t\t\t\t8 GB\r\nBộ nhớ trong:\t\t128 GB\r\nHệ điều hành:\t\tAndroid 12\r\nChipset:\t\t\tSnapdragon 778G (8 nhân)\r\nLoại màn hình:\t\tInfinity-O Display\r\nKích thước màn hình:\t6.7” \"\r\nĐộ phân giải màn hình:\tFHD+ (2400x1080) pixels\r\nCamera trước:\t\t32 MP\r\nCamera sau:\t\t\t108 MP + 12 MP+ 5 MP+ 5 MP\r\nLoại SIM:\t\t\tNano SIM\r\nDung lượng Pin:\t\t5,000 mAh\r\nMở khóa nhanh:\t\tOn-Screen Fingerprint\r\nTiện ích khác ĐTDĐ:\tSạc nhanh 25W\r\nChiều cao:\t\t\t7.6 mm\r\nChiều dài:\t\t\t163.7 mm\r\nChiều rộng:\t\t\t76.1 mm"),
            new product("Samsung S22 8GB/256GB Trắng", Resources.samsung_s22_8gb_256gb_trang, "Trắng", "256GB", 23490000, "Model:\t\t\tG901\r\nMàu sắc:\t\t\tTrắng\r\nNhà sản xuất:\t\tSamsung\r\nXuất xứ:\t\t\tViệt Nam\r\nThời gian bảo hành:\t12 Tháng\r\nĐịa điểm bảo hành:\t\r\nRAM:\t\t\t\t8GB\r\nBộ nhớ trong:\t\t256GB\r\nChipset:\t\t\tQualcomm Snapdragon 8 Gen 1\r\nKích thước màn hình:\t6.1 inch \"\r\nĐộ phân giải màn hình:\t1080 x 2340 pixels\r\nDung lượng Pin:\t\t3.700 mAh"),
            new product("Samsung S22 8GB/256GB Đen", Resources.samsung_s22_8gb_256gb_den, "Đen", "256GB", 23490000, "Model:\t\t\tG901\r\nMàu sắc:\t\t\tĐen\r\nNhà sản xuất:\t\tSamsung\r\nXuất xứ:\t\t\tViệt Nam\r\nThời gian bảo hành:\t12 Tháng\r\nĐịa điểm bảo hành:\t\r\nRAM:\t\t\t\t8GB\r\nBộ nhớ trong:\t\t256GB\r\nChipset:\t\t\tQualcomm Snapdragon 8 Gen 1\r\nKích thước màn hình:\t6.1 inch \"\r\nĐộ phân giải màn hình:\t1080 x 2340 pixels\r\nDung lượng Pin:\t\t3.700 mAh"),
            new product("Samsung S22 8GB/128GB Hồng", Resources.samsung_s22_8gb_128gb_hong, "Hồng", "128GB", 16490000, "Model:\t\t\tG901\r\nMàu sắc:\t\t\tHồng\r\nNhà sản xuất:\t\tSamsung\r\nXuất xứ:\t\t\tViệt Nam\r\nThời gian bảo hành:\t12 Tháng\r\nĐịa điểm bảo hành:\t\r\nRAM:\t\t\t\t8GB\r\nBộ nhớ trong:\t\t128GB\r\nChipset:\t\t\tQualcomm Snapdragon 8 Gen 1\r\nKích thước màn hình:\t6.1 inch \"\r\nĐộ phân giải màn hình:\t1080 x 2340 pixels\r\nDung lượng Pin:\t\t3.700 mAh"),
            new product("Samsung A53 5G 128GB Xanh", Resources.samsung_a53_5g_128gb_xanh, "Xanh", "128GB", 9190000, "Model:\t\t\tSM-A536E/DS\r\nMàu sắc:\t\t\tXanh\r\nNhà sản xuất:\t\tSamsung\r\nXuất xứ:\t\t\tViệt Nam\r\nThời gian bảo hành:\t12 Tháng\r\nĐịa điểm bảo hành:\t\r\nRAM:\t\t\t\t8GB\r\nBộ nhớ trong:\t\t128GB\r\nHỗ trợ thẻ nhớ ngoài:\tHỗ trợ thẻ nhớ lên đến 1TB\r\nChipset:\t\t\tExynos 1280 (8 nhân)\r\nLoại màn hình:\t\tFHD+ Infinity-O Super AMOLED 120Hz\r\nKích thước màn hình:\t6.5 \"\r\nCamera trước:\t\t32.0MP\r\nCamera sau:\t\t\t64MP với chế độ quay chụp OIS sắc nét\r\n\t\t\t\t+ Chụp Góc Siêu Rộng 12MP \r\n\t\t\t\t+ Xoá phông 5MP + Macro 5MP\r\nMạng 4G:\t\t\tKết nối 5G\r\nLoa ngoài:\t\t\tÂm thanh vòm Dolby Atmos\r\nDung lượng Pin:\t\t5,000 mAh Sạc nhanh 25W\r\nMở khóa nhanh:\t\tMở khóa vân tay trên màn hình\r\nChống nước:\t\t\tKháng nước và bụi chuẩn IP67"),
            new product("Samsung A53 5G 128GB Cam", Resources.samsung_a53_5g_128gb_cam, "Cam", "128GB", 9190000, "Model:\t\t\tSM-A536E/DS\r\nMàu sắc:\t\t\tCam\r\nNhà sản xuất:\t\tSamsung\r\nXuất xứ:\t\t\tViệt Nam\r\nThời gian bảo hành:\t12 Tháng\r\nĐịa điểm bảo hành:\t\r\nRAM:\t\t\t\t8GB\r\nBộ nhớ trong:\t\t128GB\r\nHỗ trợ thẻ nhớ ngoài:\tHỗ trợ thẻ nhớ lên đến 1TB\r\nChipset:\t\t\tExynos 1280 (8 nhân)\r\nLoại màn hình:\t\tFHD+ Infinity-O Super AMOLED 120Hz\r\nKích thước màn hình:\t6.5 \"\r\nCamera trước:\t\t32.0MP\r\nCamera sau:\t\t\t64MP với chế độ quay chụp OIS sắc nét\r\n\t\t\t\t+ Chụp Góc Siêu Rộng 12MP \r\n\t\t\t\t+ Xoá phông 5MP + Macro 5MP\r\nMạng 4G:\t\t\tKết nối 5G\r\nLoa ngoài:\t\t\tÂm thanh vòm Dolby Atmos\r\nDung lượng Pin:\t\t5,000 mAh Sạc nhanh 25W\r\nMở khóa nhanh:\t\tMở khóa vân tay trên màn hình\r\nChống nước:\t\t\tKháng nước và bụi chuẩn IP67"),
            new product("Samsung A53 5G 128GB Đen", Resources.samsung_a53_5g_128gb_den, "Đen", "128GB", 9190000, "Model:\t\t\tSM-A536E/DS\r\nMàu sắc:\t\t\tĐen\r\nNhà sản xuất:\t\tSamsung\r\nXuất xứ:\t\t\tViệt Nam\r\nThời gian bảo hành:\t12 Tháng\r\nĐịa điểm bảo hành:\t\r\nRAM:\t\t\t\t8GB\r\nBộ nhớ trong:\t\t128GB\r\nHỗ trợ thẻ nhớ ngoài:\tHỗ trợ thẻ nhớ lên đến 1TB\r\nChipset:\t\t\tExynos 1280 (8 nhân)\r\nLoại màn hình:\t\tFHD+ Infinity-O Super AMOLED 120Hz\r\nKích thước màn hình:\t6.5 \"\r\nCamera trước:\t\t32.0MP\r\nCamera sau:\t\t\t64MP với chế độ quay chụp OIS sắc nét\r\n\t\t\t\t+ Chụp Góc Siêu Rộng 12MP \r\n\t\t\t\t+ Xoá phông 5MP + Macro 5MP\r\nMạng 4G:\t\t\tKết nối 5G\r\nLoa ngoài:\t\t\tÂm thanh vòm Dolby Atmos\r\nDung lượng Pin:\t\t5,000 mAh Sạc nhanh 25W\r\nMở khóa nhanh:\t\tMở khóa vân tay trên màn hình\r\nChống nước:\t\t\tKháng nước và bụi chuẩn IP67"),
            new product("Samsung A53 5G 128GB Trắng", Resources.samsung_a53_5g_128gb_trang, "Trắng", "128GB", 9190000, "Model:\t\t\tSM-A536E/DS\r\nMàu sắc:\t\t\tTrắng\r\nNhà sản xuất:\t\tSamsung\r\nXuất xứ:\t\t\tViệt Nam\r\nThời gian bảo hành:\t12 Tháng\r\nĐịa điểm bảo hành:\t\r\nRAM:\t\t\t\t8GB\r\nBộ nhớ trong:\t\t128GB\r\nHỗ trợ thẻ nhớ ngoài:\tHỗ trợ thẻ nhớ lên đến 1TB\r\nChipset:\t\t\tExynos 1280 (8 nhân)\r\nLoại màn hình:\t\tFHD+ Infinity-O Super AMOLED 120Hz\r\nKích thước màn hình:\t6.5 \"\r\nCamera trước:\t\t32.0MP\r\nCamera sau:\t\t\t64MP với chế độ quay chụp OIS sắc nét\r\n\t\t\t\t+ Chụp Góc Siêu Rộng 12MP \r\n\t\t\t\t+ Xoá phông 5MP + Macro 5MP\r\nMạng 4G:\t\t\tKết nối 5G\r\nLoa ngoài:\t\t\tÂm thanh vòm Dolby Atmos\r\nDung lượng Pin:\t\t5,000 mAh Sạc nhanh 25W\r\nMở khóa nhanh:\t\tMở khóa vân tay trên màn hình\r\nChống nước:\t\t\tKháng nước và bụi chuẩn IP67"),
            new product("Samsung Galaxy A04s 4GB/64GB Xanh", Resources.samsung_galaxy_a04s_4gb_64gb_xanh, "Xanh", "64GB", 3690000, "Model:\t\t\tSM-A047F/DS\r\nMàu sắc:\t\t\tXanh\r\nNhà sản xuất:\t\tSamsung\r\nXuất xứ:\t\t\tViệt Nam\r\nThời gian bảo hành:\t12 Tháng\r\nĐịa điểm bảo hành:\t\r\nRAM:\t\t\t\t4GB\r\nBộ nhớ trong:\t\t64GB\r\nHệ điều hành:\t\tAndroid 12, One UI Core 4\r\nChipset:\t\t\tExynos 850 (8nm)\r\nLoại màn hình:\t\tIPS LCD\r\nKích thước màn hình:\t6.5 \"\r\nĐộ phân giải màn hình:\tHD+ (720 x 1600) pixels\r\nCamera trước:\t\t5MP\r\nCamera sau:\t\t\t50MP - 2MP - 2MP\r\nLoại SIM:\t\t\t2 SIM (Nano-SIM)\r\nDung lượng Pin:\t\t5000mAh\r\nKích thước sản phẩm:\t164.7 x 76.7 x 9.1 mm"),
            new product("Samsung Galaxy A04s 4GB/64GB Đồng", Resources.samsung_galaxy_a04s_4gb_64gb_dong, "Đồng", "64GB", 3690000, "Model:\t\t\tSM-A047F/DS\r\nMàu sắc:\t\t\tĐồng\r\nNhà sản xuất:\t\tSamsung\r\nXuất xứ:\t\t\tViệt Nam\r\nThời gian bảo hành:\t12 Tháng\r\nĐịa điểm bảo hành:\t\r\nRAM:\t\t\t\t4GB\r\nBộ nhớ trong:\t\t64GB\r\nHệ điều hành:\t\tAndroid 12, One UI Core 4\r\nChipset:\t\t\tExynos 850 (8nm)\r\nLoại màn hình:\t\tIPS LCD\r\nKích thước màn hình:\t6.5 \"\r\nĐộ phân giải màn hình:\tHD+ (720 x 1600) pixels\r\nCamera trước:\t\t5MP\r\nCamera sau:\t\t\t50MP - 2MP - 2MP\r\nLoại SIM:\t\t\t2 SIM (Nano-SIM)\r\nDung lượng Pin:\t\t5000mAh\r\nKích thước sản phẩm:\t164.7 x 76.7 x 9.1 mm"),
            new product("Samsung Galaxy A04s 4GB/64GB Đen", Resources.samsung_galaxy_a04s_4gb_64gb_den, "Đen", "64GB", 3690000, "Model:\t\t\tSM-A047F/DS\r\nMàu sắc:\t\t\tĐen\r\nNhà sản xuất:\t\tSamsung\r\nXuất xứ:\t\t\tViệt Nam\r\nThời gian bảo hành:\t12 Tháng\r\nĐịa điểm bảo hành:\t\r\nRAM:\t\t\t\t4GB\r\nBộ nhớ trong:\t\t64GB\r\nHệ điều hành:\t\tAndroid 12, One UI Core 4\r\nChipset:\t\t\tExynos 850 (8nm)\r\nLoại màn hình:\t\tIPS LCD\r\nKích thước màn hình:\t6.5 \"\r\nĐộ phân giải màn hình:\tHD+ (720 x 1600) pixels\r\nCamera trước:\t\t5MP\r\nCamera sau:\t\t\t50MP - 2MP - 2MP\r\nLoại SIM:\t\t\t2 SIM (Nano-SIM)\r\nDung lượng Pin:\t\t5000mAh\r\nKích thước sản phẩm:\t164.7 x 76.7 x 9.1 mm"),
            new product("Samsung Galaxy A03s 64GB Đen", Resources.samsung_galaxy_a03s_64gb_den, "Đen", "64GB", 3190000, "Model:\t\t\tA03s (SM-A037F/DS)\r\nMàu sắc:\t\t\tĐen\r\nNhà sản xuất:\t\tSamsung\r\nXuất xứ:\t\t\tTrung Quốc\r\nThời gian bảo hành:\t12 Tháng\r\nĐịa điểm bảo hành:\t\r\nRAM:\t\t\t\t4GB\r\nBộ nhớ trong:\t\t64GB\r\nHệ điều hành:\t\tAndroid\r\nCPU:\t\t\t\t8 nhân, 2.3GHz, 1.8GHz\r\nChipset:\t\t\tMediaTek MT6765\r\nLoại màn hình:\t\tPLS TFT LCD\r\nKích thước màn hình:\t6.5 \"\r\nĐộ phân giải màn hình:\tHD+ pixels\r\nCamera trước:\t\t5 MP\r\nCamera sau:\t\t\t13 MP + 2 MP + 2 MP\r\nDung lượng Pin:\t\t5000 mAh\r\nMở khóa nhanh:\t\tMở khoá vân tay cạnh viền\r\nKích thước sản phẩm:\t164.2 x 75.9 x 9.1 mm"),
            new product("Samsung Galaxy A03s 64GB Trắng", Resources.samsung_galaxy_a03s_64gb_trang, "Trắng", "64GB", 3190000, "Model:\t\t\tA03s (SM-A037F/DS)\r\nMàu sắc:\t\t\tTrắng\r\nNhà sản xuất:\t\tSamsung\r\nXuất xứ:\t\t\tTrung Quốc\r\nThời gian bảo hành:\t12 Tháng\r\nĐịa điểm bảo hành:\t\r\nRAM:\t\t\t\t4GB\r\nBộ nhớ trong:\t\t64GB\r\nHệ điều hành:\t\tAndroid\r\nCPU:\t\t\t\t8 nhân, 2.3GHz, 1.8GHz\r\nChipset:\t\t\tMediaTek MT6765\r\nLoại màn hình:\t\tPLS TFT LCD\r\nKích thước màn hình:\t6.5 \"\r\nĐộ phân giải màn hình:\tHD+ pixels\r\nCamera trước:\t\t5 MP\r\nCamera sau:\t\t\t13 MP + 2 MP + 2 MP\r\nDung lượng Pin:\t\t5000 mAh\r\nMở khóa nhanh:\t\tMở khoá vân tay cạnh viền\r\nKích thước sản phẩm:\t164.2 x 75.9 x 9.1 mm"),
            new product("Samsung Galaxy A03s 64GB Xanh", Resources.samsung_galaxy_a03s_64gb_xanh, "Xanh", "64GB", 3190000, "Model:\t\t\tA03s (SM-A037F/DS)\r\nMàu sắc:\t\t\tXanh\r\nNhà sản xuất:\t\tSamsung\r\nXuất xứ:\t\t\tTrung Quốc\r\nThời gian bảo hành:\t12 Tháng\r\nĐịa điểm bảo hành:\t\r\nRAM:\t\t\t\t4GB\r\nBộ nhớ trong:\t\t64GB\r\nHệ điều hành:\t\tAndroid\r\nCPU:\t\t\t\t8 nhân, 2.3GHz, 1.8GHz\r\nChipset:\t\t\tMediaTek MT6765\r\nLoại màn hình:\t\tPLS TFT LCD\r\nKích thước màn hình:\t6.5 \"\r\nĐộ phân giải màn hình:\tHD+ pixels\r\nCamera trước:\t\t5 MP\r\nCamera sau:\t\t\t13 MP + 2 MP + 2 MP\r\nDung lượng Pin:\t\t5000 mAh\r\nMở khóa nhanh:\t\tMở khoá vân tay cạnh viền\r\nKích thước sản phẩm:\t164.2 x 75.9 x 9.1 mm"),
            new product("Samsung Galaxy S20 Ultra Xám", Resources.samsung_ultra_xam, "Xám", "128GB", 29990000, "Model:\t\t\tSM-G988B/DS\r\nMàu sắc:\t\t\tXám\r\nNhà sản xuất:\t\tSamsung\r\nXuất xứ:\t\t\tViệt Nam\r\nNăm ra mắt :\t\t2020\r\nThời gian bảo hành:\t12 Tháng\r\nĐịa điểm bảo hành:\t\r\nRAM:\t\t\t\t12 GB\r\nBộ nhớ trong:\t\t128 GB\r\nHệ điều hành:\t\tAndroid 10, One UI 2.1\r\nChipset:\t\t\tExynos 990\r\nCảm ứng:\t\t\tCó\r\nLoại màn hình:\t\tDynamic AMOLED 2X\r\nKích thước màn hình:\t6.9 \"\r\nCamera trước:\t\t40 MP\r\nCamera sau:\t\t\t108 MP + 48 MP + 12 MP\r\nMạng 3G:\t\t\tCó\r\nMạng 4G:\t\t\tCó\r\nLoại SIM:\t\t\t2 Nano SIM\r\nWIFI:\t\t\t\tCó\r\nBluetooth:\t\t\tBluetooth 5.0\r\nNFC:\t\t\t\tCó\r\nGPS:\t\t\t\tBDS, A-GPS, GLONASS\r\nUSB:\t\t\t\tUSB Type-C\r\nDung lượng Pin:\t\t5000 mAh\r\nThiết kế:\t\t\tNguyên khối\r\nGhi âm:\t\t\tCó, microphone chuyên dụng chống ồn\r\nRadio:\t\t\tKhông\r\nMàn hình tràn viền:\tCó"),
            new product("Samsung Galaxy S20 Ultra Đen", Resources.samsung_ultra_den, "Đen", "128GB", 29990000, "Model:\t\t\tSM-G988B/DS\r\nMàu sắc:\t\t\tĐen\r\nNhà sản xuất:\t\tSamsung\r\nXuất xứ:\t\t\tViệt Nam\r\nNăm ra mắt :\t\t2020\r\nThời gian bảo hành:\t12 Tháng\r\nĐịa điểm bảo hành:\t\r\nRAM:\t\t\t\t12 GB\r\nBộ nhớ trong:\t\t128 GB\r\nHệ điều hành:\t\tAndroid 10, One UI 2.1\r\nChipset:\t\t\tExynos 990\r\nCảm ứng:\t\t\tCó\r\nLoại màn hình:\t\tDynamic AMOLED 2X\r\nKích thước màn hình:\t6.9 \"\r\nCamera trước:\t\t40 MP\r\nCamera sau:\t\t\t108 MP + 48 MP + 12 MP\r\nMạng 3G:\t\t\tCó\r\nMạng 4G:\t\t\tCó\r\nLoại SIM:\t\t\t2 Nano SIM\r\nWIFI:\t\t\t\tCó\r\nBluetooth:\t\t\tBluetooth 5.0\r\nNFC:\t\t\t\tCó\r\nGPS:\t\t\t\tBDS, A-GPS, GLONASS\r\nUSB:\t\t\t\tUSB Type-C\r\nDung lượng Pin:\t\t5000 mAh\r\nThiết kế:\t\t\tNguyên khối\r\nGhi âm:\t\t\tCó, microphone chuyên dụng chống ồn\r\nRadio:\t\t\tKhông\r\nMàn hình tràn viền:\tCó"),
            #endregion
            #region xiaomi
            new product("Xiaomi Redmi Note 11S 8GB/128GB Trắng", Resources.xiaomi_redmi_note_11s_8gb_128gb_trang, "Trắng", "128GB", 5790000, "Model:\t\t\tREDMINOTE11S\r\nMàu sắc:\t\t\tTrắng\r\nNhà sản xuất:\t\tXiaomi\r\nXuất xứ:\t\t\tTrung Quốc\r\nThời gian bảo hành:\t18 tháng\r\nĐịa điểm bảo hành:\t\r\nRAM:\t\t\t\t8GB\r\nBộ nhớ trong:\t\t128GB\r\nHệ điều hành:\t\tAndroid 11\r\nChipset:\t\t\tMediatek Helio G96 (12 nm)\r\nLoại màn hình:\t\tAMOLED LCD\r\nKích thước màn hình:\t6.43 \"\r\nCamera trước:\t\t16MP\r\nCamera sau:\t\t\t108MP + 8MP + 2MP + 2MP\r\nDung lượng Pin:\t\t5000 mAh\r\nTiện ích khác ĐTDĐ:\tcó sạc nhanh 33W\r\nChiều cao:\t\t\t8.1 mm\r\nChiều dài:\t\t\t159.9 mm\r\nChiều rộng:\t\t\t73.9 mm"),
            new product("Xiaomi Redmi Note 11S 8GB/128GB Xám", Resources.xiaomi_redmi_note_11s_8gb_128gb_xam, "Xám", "128GB", 5790000, "Model:\t\t\tREDMINOTE11S\r\nMàu sắc:\t\t\tXám\r\nNhà sản xuất:\t\tXiaomi\r\nXuất xứ:\t\t\tTrung Quốc\r\nThời gian bảo hành:\t18 tháng\r\nĐịa điểm bảo hành:\t\r\nRAM:\t\t\t\t8GB\r\nBộ nhớ trong:\t\t128GB\r\nHệ điều hành:\t\tAndroid 11\r\nChipset:\t\t\tMediatek Helio G96 (12 nm)\r\nLoại màn hình:\t\tAMOLED LCD\r\nKích thước màn hình:\t6.43 \"\r\nCamera trước:\t\t16MP\r\nCamera sau:\t\t\t108MP + 8MP + 2MP + 2MP\r\nDung lượng Pin:\t\t5000 mAh\r\nTiện ích khác ĐTDĐ:\tcó sạc nhanh 33W\r\nChiều cao:\t\t\t8.1 mm\r\nChiều dài:\t\t\t159.9 mm\r\nChiều rộng:\t\t\t73.9 mm"),
            new product("Xiaomi Redmi 9C 4GB/128GB Cam", Resources.xiaomi_redmi_note_9c_4gb_128gb_cam, "Cam", "128GB", 2890000, "Model:\t\t\tXIAOMIREDMI9C\r\nMàu sắc:\t\t\tCam\r\nNhà sản xuất:\t\tXiaomi\r\nXuất xứ:\t\t\tTrung Quốc\r\nThời gian bảo hành:\t18 tháng\r\nĐịa điểm bảo hành:\t\r\nRAM:\t\t\t\t4 GB\r\nBộ nhớ trong:\t\t128 GB\r\nHỗ trợ thẻ nhớ ngoài:\tMicroSD, hỗ trợ tối đa 512 GB\r\nCPU:\t\t\t\tCông nghệ tiến trình 12 nm, \r\n\t\t\t\txung nhịp lên đến 2,3GHz, 4x A53, \r\n\t\t\t\tCPU tám nhân\r\nChipset:\t\t\tMediaTek Helio G35\r\nLoại màn hình:\t\tIPS LCD\r\nKích thước màn hình:\t6.53 \"\r\nĐộ phân giải màn hình:\tHD+ (720 x 1600) pixels\r\nCamera trước:\t\t5 MP\r\nCamera sau:\t\t\tChính 13 MP & Phụ 2 MP, 2 MP\r\nLoại SIM:\t\t\t2 nano SIM\r\nWIFI:\t\t\t\tWi-Fi 802.11 a/b/g/n, Wi-Fi Direct, Wi-Fi hotspot\r\nBluetooth:\t\t\tBluetooth 5.0\r\nGPS:\t\t\t\t• GPS • AGPS • GLONASS\r\nUSB:\t\t\t\tCổng sạc Micro USB\r\nJack 3.5mm:\t\t\tCó\r\nDung lượng Pin:\t\t5000mAh, hỗ trợ sạc 10W, pin không tháo rời\r\nMở khóa nhanh:\t\tMở khóa khuôn mặt AI, Cảm biến vân tay mặt sau\r\nChiều cao:\t\t\t164.9 mm\r\nChiều rộng:\t\t\t77.07 mm\r\nChiều sâu:\t\t\t9 mm"),
            new product("Xiaomi Redmi 9C 4GB/128GB Tím", Resources.xiaomi_redmi_note_9c_4gb_128gb_tim, "Tím", "128GB", 2890000, "Model:\t\t\tXIAOMIREDMI9C\r\nMàu sắc:\t\t\tTím\r\nNhà sản xuất:\t\tXiaomi\r\nXuất xứ:\t\t\tTrung Quốc\r\nThời gian bảo hành:\t18 tháng\r\nĐịa điểm bảo hành:\t\r\nRAM:\t\t\t\t4 GB\r\nBộ nhớ trong:\t\t128 GB\r\nHỗ trợ thẻ nhớ ngoài:\tMicroSD, hỗ trợ tối đa 512 GB\r\nCPU:\t\t\t\tCông nghệ tiến trình 12 nm, \r\n\t\t\t\txung nhịp lên đến 2,3GHz, 4x A53, \r\n\t\t\t\tCPU tám nhân\r\nChipset:\t\t\tMediaTek Helio G35\r\nLoại màn hình:\t\tIPS LCD\r\nKích thước màn hình:\t6.53 \"\r\nĐộ phân giải màn hình:\tHD+ (720 x 1600) pixels\r\nCamera trước:\t\t5 MP\r\nCamera sau:\t\t\tChính 13 MP & Phụ 2 MP, 2 MP\r\nLoại SIM:\t\t\t2 nano SIM\r\nWIFI:\t\t\t\tWi-Fi 802.11 a/b/g/n, Wi-Fi Direct, Wi-Fi hotspot\r\nBluetooth:\t\t\tBluetooth 5.0\r\nGPS:\t\t\t\t• GPS • AGPS • GLONASS\r\nUSB:\t\t\t\tCổng sạc Micro USB\r\nJack 3.5mm:\t\t\tCó\r\nDung lượng Pin:\t\t5000mAh, hỗ trợ sạc 10W, pin không tháo rời\r\nMở khóa nhanh:\t\tMở khóa khuôn mặt AI, Cảm biến vân tay mặt sau\r\nChiều cao:\t\t\t164.9 mm\r\nChiều rộng:\t\t\t77.07 mm\r\nChiều sâu:\t\t\t9 mm"),
            new product("Xiaomi Redmi 9C 4GB/128GB Xám", Resources.xiaomi_redmi_note_9c_4gb_128gb_xam, "Xám", "128GB", 2890000, "Model:\t\t\tXIAOMIREDMI9C\r\nMàu sắc:\t\t\tXám\r\nNhà sản xuất:\t\tXiaomi\r\nXuất xứ:\t\t\tTrung Quốc\r\nThời gian bảo hành:\t18 tháng\r\nĐịa điểm bảo hành:\t\r\nRAM:\t\t\t\t4 GB\r\nBộ nhớ trong:\t\t128 GB\r\nHỗ trợ thẻ nhớ ngoài:\tMicroSD, hỗ trợ tối đa 512 GB\r\nCPU:\t\t\t\tCông nghệ tiến trình 12 nm, \r\n\t\t\t\txung nhịp lên đến 2,3GHz, 4x A53, \r\n\t\t\t\tCPU tám nhân\r\nChipset:\t\t\tMediaTek Helio G35\r\nLoại màn hình:\t\tIPS LCD\r\nKích thước màn hình:\t6.53 \"\r\nĐộ phân giải màn hình:\tHD+ (720 x 1600) pixels\r\nCamera trước:\t\t5 MP\r\nCamera sau:\t\t\tChính 13 MP & Phụ 2 MP, 2 MP\r\nLoại SIM:\t\t\t2 nano SIM\r\nWIFI:\t\t\t\tWi-Fi 802.11 a/b/g/n, Wi-Fi Direct, Wi-Fi hotspot\r\nBluetooth:\t\t\tBluetooth 5.0\r\nGPS:\t\t\t\t• GPS • AGPS • GLONASS\r\nUSB:\t\t\t\tCổng sạc Micro USB\r\nJack 3.5mm:\t\t\tCó\r\nDung lượng Pin:\t\t5000mAh, hỗ trợ sạc 10W, pin không tháo rời\r\nMở khóa nhanh:\t\tMở khóa khuôn mặt AI, Cảm biến vân tay mặt sau\r\nChiều cao:\t\t\t164.9 mm\r\nChiều rộng:\t\t\t77.07 mm\r\nChiều sâu:\t\t\t9 mm"),
            new product("Xiaomi Redmi Note 11 Pro 5G 8GB/128GB Xám", Resources.xiaomi_redmi_note11pro_5gb_8gb_128gb_xam, "Xám", "128GB", 7890000, "Model:\t\t\tREDMINOTE11PRO5G\r\nMàu sắc:\t\t\tXám\r\nNhà sản xuất:\t\tXiaomi\r\nXuất xứ:\t\t\tTrung Quốc\r\nThời gian bảo hành:\t18 tháng\r\nĐịa điểm bảo hành:\t\r\nRAM:\t\t\t\t8GB\r\nBộ nhớ trong:\t\t128GB\r\nHỗ trợ thẻ nhớ ngoài:\tMicroSD, hỗ trợ tối đa 1 TB\r\nHệ điều hành:\t\tAndroid 11\r\nChipset:\t\t\tSnapdragon 695 5G 8 nhân\r\nLoại màn hình:\t\tSuper AMOLED\r\nKích thước màn hình:\t6.67 \"\r\nĐộ phân giải màn hình:\tFull HD+ 1080 x 2340 pixels\r\nCamera trước:\t\t16MP\r\nCamera sau:\t\t\t108 MP, 8 MP, 2 MP\r\nĐèn Flash:\t\t\tCó\r\nMạng 4G:\t\t\tHỗ trợ 5G\r\nLoại SIM:\t\t\t2 nano SIM\r\nUSB:\t\t\t\tUSB Type-C\r\nJack 3.5mm:\t\t\tCó\r\nDung lượng Pin:\t\t5000 mAh\r\nMở khóa nhanh:\t\tMở khoá vân tay cạnh viền, Mở khoá khuôn mặt\r\nThiết kế:\t\t\tNguyên khối, Khung nhựa, Mặt lưng kính\r\nTiện ích khác ĐTDĐ:\tsạc nhanh 67W\r\nChiều cao:\t\t\t8.1 mm\r\nChiều dài:\t\t\t164.2 mm\r\nChiều rộng:\t\t\t76.1 mm"),
            new product("Xiaomi Redmi 9A 2GB/32GB Xanh Lá", Resources.xiaomi_redmi_9a_2gb_32gb_xanhla, "Xanh Lá", "32GB", 2090000, "Model:\t\t\tREDMI 9A\r\nMàu sắc:\t\t\tXanh lá\r\nNhà sản xuất:\t\tXiaomi\r\nXuất xứ:\t\t\tTrung Quốc\r\nNăm ra mắt :\t\t2020\r\nThời gian bảo hành:\t18 tháng\r\nĐịa điểm bảo hành:\t\r\nRAM:\t\t\t\t2 GB\r\nBộ nhớ trong:\t\t32 GB\r\nHỗ trợ thẻ nhớ ngoài:\tMicroSD, hỗ trợ tối đa 512 GB\r\nHệ điều hành:\t\tAndroid 10\r\nChipset:\t\t\tMediaTek Helio G25 8 nhân\r\nCảm ứng:\t\t\tCó\r\nLoại màn hình:\t\tIPS LCD\r\nKích thước màn hình:\t6.53 \"\r\nĐộ phân giải màn hình:\tHD+ (700 x 1600) pixels\r\nCamera trước:\t\t5 MP\r\nCamera sau:\t\t\t13 MP\r\nĐèn Flash:\t\t\tCó\r\nVideo:\t\t\tHD 720p@30fps, FullHD 1080p@30fps\r\nMạng 4G:\t\t\tCó\r\nLoại SIM:\t\t\t2 Nano SIM\r\nWIFI:\t\t\t\tWi-Fi hotspot, Wi-Fi 802.11 a/b/g/n, Wi-Fi Direct\r\nBluetooth:\t\t\tLE, A2DP\r\nGPS:\t\t\t\tBDS, A-GPS, GLONASS\r\nUSB:\t\t\t\tMicro USB\r\nJack 3.5mm:\t\t\tCó\r\nDung lượng Pin:\t\t5000 mAh\r\nMở khóa nhanh:\t\tMở khoá khuôn mặt\r\nThiết kế:\t\t\tNguyên khối\r\nGhi âm:\t\t\tCó\r\nRadio:\t\t\tCó\r\nMàn hình tràn viền:\tCó\r\nTiện ích khác ĐTDĐ:\tChạm 2 lần tắt màn hình,\r\n\t\t\t\tChạm 2 lần sáng màn hình,\r\n\t\t\t\tĐèn pin,\r\n\t\t\t\tChặn tin nhắn, \r\n\t\t\t\tChặn cuộc gọi\r\nKích thước sản phẩm:\tDài 164.9 mm - Ngang 77.07 mm - Dày 9 mm"),
            new product("Xiaomi Redmi 9A 2GB/32GB Xanh Dương", Resources.xiaomi_redmi_9a_2gb_32gb_xanhduong, "Xanh Dương", "32GB", 2090000, "Model:\t\t\tREDMI 9A\r\nMàu sắc:\t\t\tXanh Dương\r\nNhà sản xuất:\t\tXiaomi\r\nXuất xứ:\t\t\tTrung Quốc\r\nNăm ra mắt :\t\t2020\r\nThời gian bảo hành:\t18 tháng\r\nĐịa điểm bảo hành:\t\r\nRAM:\t\t\t\t2 GB\r\nBộ nhớ trong:\t\t32 GB\r\nHỗ trợ thẻ nhớ ngoài:\tMicroSD, hỗ trợ tối đa 512 GB\r\nHệ điều hành:\t\tAndroid 10\r\nChipset:\t\t\tMediaTek Helio G25 8 nhân\r\nCảm ứng:\t\t\tCó\r\nLoại màn hình:\t\tIPS LCD\r\nKích thước màn hình:\t6.53 \"\r\nĐộ phân giải màn hình:\tHD+ (700 x 1600) pixels\r\nCamera trước:\t\t5 MP\r\nCamera sau:\t\t\t13 MP\r\nĐèn Flash:\t\t\tCó\r\nVideo:\t\t\tHD 720p@30fps, FullHD 1080p@30fps\r\nMạng 4G:\t\t\tCó\r\nLoại SIM:\t\t\t2 Nano SIM\r\nWIFI:\t\t\t\tWi-Fi hotspot, Wi-Fi 802.11 a/b/g/n, Wi-Fi Direct\r\nBluetooth:\t\t\tLE, A2DP\r\nGPS:\t\t\t\tBDS, A-GPS, GLONASS\r\nUSB:\t\t\t\tMicro USB\r\nJack 3.5mm:\t\t\tCó\r\nDung lượng Pin:\t\t5000 mAh\r\nMở khóa nhanh:\t\tMở khoá khuôn mặt\r\nThiết kế:\t\t\tNguyên khối\r\nGhi âm:\t\t\tCó\r\nRadio:\t\t\tCó\r\nMàn hình tràn viền:\tCó\r\nTiện ích khác ĐTDĐ:\tChạm 2 lần tắt màn hình,\r\n\t\t\t\tChạm 2 lần sáng màn hình,\r\n\t\t\t\tĐèn pin,\r\n\t\t\t\tChặn tin nhắn, \r\n\t\t\t\tChặn cuộc gọi\r\nKích thước sản phẩm:\tDài 164.9 mm - Ngang 77.07 mm - Dày 9 mm"),
            new product("Xiaomi Redmi 10C 4GB/128GB Xanh Dương Đậm", Resources.xiaomi_redmi_note_10c_4gb_128gb_xanhduong, "Xanh Dương Đậm", "128GB", 3350000, "Model:\t\t\tREDMI10C\r\nMàu sắc:\t\t\tXanh dương đậm\r\nNhà sản xuất:\t\tXiaomi\r\nXuất xứ:\t\t\tTrung Quốc\r\nThời gian bảo hành:\t18 tháng\r\nĐịa điểm bảo hành:\t\r\nRAM:\t\t\t\t4 GB\r\nBộ nhớ trong:\t\t128GB\r\nHỗ trợ thẻ nhớ ngoài:\tMicroSD, hỗ trợ tối đa 1 TB\r\nHệ điều hành:\t\tAndroid 11\r\nChipset:\t\t\tSnapdragon 680 8 nhân\r\nCảm ứng:\t\t\tCó\r\nLoại màn hình:\t\tIPS LCD\r\nKích thước màn hình:\t6.71 \"\r\nĐộ phân giải màn hình:\tHD+ 720 x 1650 pixels\r\nCamera trước:\t\t5MP\r\nCamera sau:\t\t\tChính 50 MP, Phụ 2 MP\r\nĐèn Flash:\t\t\tCó\r\nMạng 4G:\t\t\tHỗ trợ 4G\r\nLoại SIM:\t\t\t2 nano SIM\r\nUSB:\t\t\t\tUSB Type-C\r\nJack 3.5mm:\t\t\tCó\r\nDung lượng Pin:\t\t5000 mAh\r\nMở khóa nhanh:\t\tMở khóa bằng vân tay, Mở khóa bằng khuôn mặt\r\nThiết kế:\t\t\tNguyên khối, Khung và Mặt lưng nhựa\r\nTiện ích khác ĐTDĐ:\tsạc nhanh 18W\r\nChiều cao:\t\t\t8.3 mm\r\nChiều dài:\t\t\t169.6 mm\r\nChiều rộng:\t\t\t76.6 mm"),
            new product("Xiaomi Redmi 10C 4GB/128GB Xám", Resources.xiaomi_redmi_note_10c_4gb_128gb_xam, "Xám", "128GB", 3350000, "Model:\t\t\tREDMI10C\r\nMàu sắc:\t\t\tXám\r\nNhà sản xuất:\t\tXiaomi\r\nXuất xứ:\t\t\tTrung Quốc\r\nThời gian bảo hành:\t18 tháng\r\nĐịa điểm bảo hành:\t\r\nRAM:\t\t\t\t4 GB\r\nBộ nhớ trong:\t\t128GB\r\nHỗ trợ thẻ nhớ ngoài:\tMicroSD, hỗ trợ tối đa 1 TB\r\nHệ điều hành:\t\tAndroid 11\r\nChipset:\t\t\tSnapdragon 680 8 nhân\r\nCảm ứng:\t\t\tCó\r\nLoại màn hình:\t\tIPS LCD\r\nKích thước màn hình:\t6.71 \"\r\nĐộ phân giải màn hình:\tHD+ 720 x 1650 pixels\r\nCamera trước:\t\t5MP\r\nCamera sau:\t\t\tChính 50 MP, Phụ 2 MP\r\nĐèn Flash:\t\t\tCó\r\nMạng 4G:\t\t\tHỗ trợ 4G\r\nLoại SIM:\t\t\t2 nano SIM\r\nUSB:\t\t\t\tUSB Type-C\r\nJack 3.5mm:\t\t\tCó\r\nDung lượng Pin:\t\t5000 mAh\r\nMở khóa nhanh:\t\tMở khóa bằng vân tay, Mở khóa bằng khuôn mặt\r\nThiết kế:\t\t\tNguyên khối, Khung và Mặt lưng nhựa\r\nTiện ích khác ĐTDĐ:\tsạc nhanh 18W\r\nChiều cao:\t\t\t8.3 mm\r\nChiều dài:\t\t\t169.6 mm\r\nChiều rộng:\t\t\t76.6 mm"),
            new product("Xiaomi Redmi 10C 4GB/128GB Xanh Lá", Resources.xiaomi_redmi_note_10c_4gb_128gb_xanhla, "Xanh Lá", "128GB", 3350000, "Model:\t\t\tREDMI10C\r\nMàu sắc:\t\t\tXanh Lá\r\nNhà sản xuất:\t\tXiaomi\r\nXuất xứ:\t\t\tTrung Quốc\r\nThời gian bảo hành:\t18 tháng\r\nĐịa điểm bảo hành:\t\r\nRAM:\t\t\t\t4 GB\r\nBộ nhớ trong:\t\t128GB\r\nHỗ trợ thẻ nhớ ngoài:\tMicroSD, hỗ trợ tối đa 1 TB\r\nHệ điều hành:\t\tAndroid 11\r\nChipset:\t\t\tSnapdragon 680 8 nhân\r\nCảm ứng:\t\t\tCó\r\nLoại màn hình:\t\tIPS LCD\r\nKích thước màn hình:\t6.71 \"\r\nĐộ phân giải màn hình:\tHD+ 720 x 1650 pixels\r\nCamera trước:\t\t5MP\r\nCamera sau:\t\t\tChính 50 MP, Phụ 2 MP\r\nĐèn Flash:\t\t\tCó\r\nMạng 4G:\t\t\tHỗ trợ 4G\r\nLoại SIM:\t\t\t2 nano SIM\r\nUSB:\t\t\t\tUSB Type-C\r\nJack 3.5mm:\t\t\tCó\r\nDung lượng Pin:\t\t5000 mAh\r\nMở khóa nhanh:\t\tMở khóa bằng vân tay, Mở khóa bằng khuôn mặt\r\nThiết kế:\t\t\tNguyên khối, Khung và Mặt lưng nhựa\r\nTiện ích khác ĐTDĐ:\tsạc nhanh 18W\r\nChiều cao:\t\t\t8.3 mm\r\nChiều dài:\t\t\t169.6 mm\r\nChiều rộng:\t\t\t76.6 mm"),
            new product("Xiaomi Redmi Note 11 4GB/128GB Xanh Dương Đậm", Resources.xiaomi_redmi_note_11_4gb_128gb_xanhduongdam, "Xanh Dương Đậm", "128GB", 4350000, "Model:\t\t\tRedmi Note 11\r\nMàu sắc:\t\t\tXanh dương đậm\r\nNhà sản xuất:\t\tXiaomi\r\nXuất xứ:\t\t\tTrung Quốc\r\nThời gian bảo hành:\t18 tháng\r\nĐịa điểm bảo hành:\t\r\nRAM:\t\t\t\t4 GB\r\nBộ nhớ trong:\t\t128 GB\r\nHệ điều hành:\t\tAndroid 11\r\nChipset:\t\t\tSnapdragon 680\r\nCảm ứng:\t\t\tCó\r\nLoại màn hình:\t\tAMOLED\r\nKích thước màn hình:\t6.43 \"\r\nĐộ phân giải màn hình:\tFull HD+ 1080 x 2400 pixels\r\nCamera trước:\t\t13 MP\r\nCamera sau:\t\t\tCamera góc rộng: 50 MP, f/1.8, PDAF; \r\n\t\t\t\tCamera góc siêu rộng: 8 MP; \r\n\t\t\t\tCamera macro: 2MP; \r\n\t\t\t\tCamera chân dung: 2MP\r\nMạng 4G:\t\t\tHỗ trợ 4G\r\nLoại SIM:\t\t\t2 Nano SIM\r\nWIFI:\t\t\t\tWi-Fi 802.11 a/b/g/n/ac; Wi-Fi Direct\r\nBluetooth:\t\t\tv5.0\r\nGPS:\t\t\t\tBEIDOU, GPS, GLONASS, GALILEO\r\nUSB:\t\t\t\tType-C\r\nJack 3.5mm:\t\t\tCó\r\nDung lượng Pin:\t\t5000 mAh\r\nMở khóa nhanh:\t\tMở khoá khuôn mặt, Mở khoá vân tay cạnh viền\r\nThiết kế:\t\t\tNguyên khối\r\nKích thước sản phẩm:\tDài 159.8 mm - Ngang 73.87 mm - Dày 8.09 mm"),
            new product("Xiaomi Redmi Note 11 4GB/128GB Xanh Xám", Resources.xiaomi_redmi_note_11_4gb_128gb_xam, "Xanh Xám", "128GB", 4350000, "Model:\t\t\tRedmi Note 11\r\nMàu sắc:\t\t\tXanh Xám\r\nNhà sản xuất:\t\tXiaomi\r\nXuất xứ:\t\t\tTrung Quốc\r\nThời gian bảo hành:\t18 tháng\r\nĐịa điểm bảo hành:\t\r\nRAM:\t\t\t\t4 GB\r\nBộ nhớ trong:\t\t128 GB\r\nHệ điều hành:\t\tAndroid 11\r\nChipset:\t\t\tSnapdragon 680\r\nCảm ứng:\t\t\tCó\r\nLoại màn hình:\t\tAMOLED\r\nKích thước màn hình:\t6.43 \"\r\nĐộ phân giải màn hình:\tFull HD+ 1080 x 2400 pixels\r\nCamera trước:\t\t13 MP\r\nCamera sau:\t\t\tCamera góc rộng: 50 MP, f/1.8, PDAF; \r\n\t\t\t\tCamera góc siêu rộng: 8 MP; \r\n\t\t\t\tCamera macro: 2MP; \r\n\t\t\t\tCamera chân dung: 2MP\r\nMạng 4G:\t\t\tHỗ trợ 4G\r\nLoại SIM:\t\t\t2 Nano SIM\r\nWIFI:\t\t\t\tWi-Fi 802.11 a/b/g/n/ac; Wi-Fi Direct\r\nBluetooth:\t\t\tv5.0\r\nGPS:\t\t\t\tBEIDOU, GPS, GLONASS, GALILEO\r\nUSB:\t\t\t\tType-C\r\nJack 3.5mm:\t\t\tCó\r\nDung lượng Pin:\t\t5000 mAh\r\nMở khóa nhanh:\t\tMở khoá khuôn mặt, Mở khoá vân tay cạnh viền\r\nThiết kế:\t\t\tNguyên khối\r\nKích thước sản phẩm:\tDài 159.8 mm - Ngang 73.87 mm - Dày 8.09 mm"),
            new product("Xiaomi Redmi Note 11 4GB/128GB Xanh Dương Nhạt", Resources.xiaomi_redmi_note_11_4gb_128gb_xanhduongnhat, "Xanh Dương Nhạt", "128GB", 4350000, "Model:\t\t\tRedmi Note 11\r\nMàu sắc:\t\t\tXanh Dương Nhạt\r\nNhà sản xuất:\t\tXiaomi\r\nXuất xứ:\t\t\tTrung Quốc\r\nThời gian bảo hành:\t18 tháng\r\nĐịa điểm bảo hành:\t\r\nRAM:\t\t\t\t4 GB\r\nBộ nhớ trong:\t\t128 GB\r\nHệ điều hành:\t\tAndroid 11\r\nChipset:\t\t\tSnapdragon 680\r\nCảm ứng:\t\t\tCó\r\nLoại màn hình:\t\tAMOLED\r\nKích thước màn hình:\t6.43 \"\r\nĐộ phân giải màn hình:\tFull HD+ 1080 x 2400 pixels\r\nCamera trước:\t\t13 MP\r\nCamera sau:\t\t\tCamera góc rộng: 50 MP, f/1.8, PDAF; \r\n\t\t\t\tCamera góc siêu rộng: 8 MP; \r\n\t\t\t\tCamera macro: 2MP; \r\n\t\t\t\tCamera chân dung: 2MP\r\nMạng 4G:\t\t\tHỗ trợ 4G\r\nLoại SIM:\t\t\t2 Nano SIM\r\nWIFI:\t\t\t\tWi-Fi 802.11 a/b/g/n/ac; Wi-Fi Direct\r\nBluetooth:\t\t\tv5.0\r\nGPS:\t\t\t\tBEIDOU, GPS, GLONASS, GALILEO\r\nUSB:\t\t\t\tType-C\r\nJack 3.5mm:\t\t\tCó\r\nDung lượng Pin:\t\t5000 mAh\r\nMở khóa nhanh:\t\tMở khoá khuôn mặt, Mở khoá vân tay cạnh viền\r\nThiết kế:\t\t\tNguyên khối\r\nKích thước sản phẩm:\tDài 159.8 mm - Ngang 73.87 mm - Dày 8.09 mm"),
            new product("Xiaomi Redmi Note 11 4GB/64GB Xanh Dương Nhạt", Resources.xiaomi_redmi_note_11_4gb_64gb_xanhduongnhat, "Xanh Dương Nhạt", "64GB", 3890000, "Model:\t\t\tRedmi Note 11\r\nMàu sắc:\t\t\tXanh dương nhạt\r\nNhà sản xuất:\t\tXiaomi\r\nXuất xứ:\t\t\tTrung Quốc\r\nThời gian bảo hành:\t18 tháng\r\nĐịa điểm bảo hành:\t\r\nRAM:\t\t\t\t4 GB\r\nBộ nhớ trong:\t\t64 GB\r\nHệ điều hành:\t\tAndroid 11\r\nChipset:\t\t\tSnapdragon 680 8 nhân\r\nCảm ứng:\t\t\tCó\r\nLoại màn hình:\t\tAMOLED\r\nKích thước màn hình:\t6.43 \"\r\nĐộ phân giải màn hình:\tFull HD+ 1080 x 240 pixels\r\nCamera trước:\t\t13 MP\r\nCamera sau:\t\t\tCamera góc rộng: 50 MP, f/1.8, PDAF; \r\n\t\t\t\tCamera góc siêu rộng: 8 MP; \r\n\t\t\t\tCamera Macro: 2MP f/2.4; \r\n\t\t\t\tCamera chân dung: 2MP\r\nĐèn Flash:\t\t\tCó\r\nVideo:\t\t\tFullHD 1080p@30fps\r\nMạng 4G:\t\t\tCó hỗ trợ\r\nLoại SIM:\t\t\t2 nano SIM\r\nWIFI:\t\t\t\tWi-Fi 802.11 a/b/g/n/ac; Wi-Fi Direct\r\nBluetooth:\t\t\tv5.0\r\nGPS:\t\t\t\tBDS, GALILEO, GLONASS, GPS\r\nUSB:\t\t\t\tType-C\r\nJack 3.5mm:\t\t\tCó\r\nDung lượng Pin:\t\t5000 mAh\r\nMở khóa nhanh:\t\tMở khoá khuôn mặt, Mở khoá vân tay cạnh viền\r\nThiết kế:\t\t\tNguyên khối\r\nKích thước sản phẩm:\tDài 159.8 mm - Ngang 73.87 mm - Dày 8.09 mm"),
            new product("Xiaomi Redmi Note 11 4GB/64GB Xám", Resources.xiaomi_redmi_note_11_4gb_64gb_xam, "Xám", "64GB", 3890000, "Model:\t\t\tRedmi Note 11\r\nMàu sắc:\t\t\tXám\r\nNhà sản xuất:\t\tXiaomi\r\nXuất xứ:\t\t\tTrung Quốc\r\nThời gian bảo hành:\t18 tháng\r\nĐịa điểm bảo hành:\t\r\nRAM:\t\t\t\t4 GB\r\nBộ nhớ trong:\t\t64 GB\r\nHệ điều hành:\t\tAndroid 11\r\nChipset:\t\t\tSnapdragon 680 8 nhân\r\nCảm ứng:\t\t\tCó\r\nLoại màn hình:\t\tAMOLED\r\nKích thước màn hình:\t6.43 \"\r\nĐộ phân giải màn hình:\tFull HD+ 1080 x 240 pixels\r\nCamera trước:\t\t13 MP\r\nCamera sau:\t\t\tCamera góc rộng: 50 MP, f/1.8, PDAF; \r\n\t\t\t\tCamera góc siêu rộng: 8 MP; \r\n\t\t\t\tCamera Macro: 2MP f/2.4; \r\n\t\t\t\tCamera chân dung: 2MP\r\nĐèn Flash:\t\t\tCó\r\nVideo:\t\t\tFullHD 1080p@30fps\r\nMạng 4G:\t\t\tCó hỗ trợ\r\nLoại SIM:\t\t\t2 nano SIM\r\nWIFI:\t\t\t\tWi-Fi 802.11 a/b/g/n/ac; Wi-Fi Direct\r\nBluetooth:\t\t\tv5.0\r\nGPS:\t\t\t\tBDS, GALILEO, GLONASS, GPS\r\nUSB:\t\t\t\tType-C\r\nJack 3.5mm:\t\t\tCó\r\nDung lượng Pin:\t\t5000 mAh\r\nMở khóa nhanh:\t\tMở khoá khuôn mặt, Mở khoá vân tay cạnh viền\r\nThiết kế:\t\t\tNguyên khối\r\nKích thước sản phẩm:\tDài 159.8 mm - Ngang 73.87 mm - Dày 8.09 mm"),
            new product("Xiaomi Redmi Note 11 4GB/64GB Xanh Dương Đậm", Resources.xiaomi_redmi_note_11_4gb_64gb_xanhduongdam, "Xanh Dương Đậm", "64GB", 3890000, "Model:\t\t\tRedmi Note 11\r\nMàu sắc:\t\t\tXanh Dương Đậm\r\nNhà sản xuất:\t\tXiaomi\r\nXuất xứ:\t\t\tTrung Quốc\r\nThời gian bảo hành:\t18 tháng\r\nĐịa điểm bảo hành:\t\r\nRAM:\t\t\t\t4 GB\r\nBộ nhớ trong:\t\t64 GB\r\nHệ điều hành:\t\tAndroid 11\r\nChipset:\t\t\tSnapdragon 680 8 nhân\r\nCảm ứng:\t\t\tCó\r\nLoại màn hình:\t\tAMOLED\r\nKích thước màn hình:\t6.43 \"\r\nĐộ phân giải màn hình:\tFull HD+ 1080 x 240 pixels\r\nCamera trước:\t\t13 MP\r\nCamera sau:\t\t\tCamera góc rộng: 50 MP, f/1.8, PDAF; \r\n\t\t\t\tCamera góc siêu rộng: 8 MP; \r\n\t\t\t\tCamera Macro: 2MP f/2.4; \r\n\t\t\t\tCamera chân dung: 2MP\r\nĐèn Flash:\t\t\tCó\r\nVideo:\t\t\tFullHD 1080p@30fps\r\nMạng 4G:\t\t\tCó hỗ trợ\r\nLoại SIM:\t\t\t2 nano SIM\r\nWIFI:\t\t\t\tWi-Fi 802.11 a/b/g/n/ac; Wi-Fi Direct\r\nBluetooth:\t\t\tv5.0\r\nGPS:\t\t\t\tBDS, GALILEO, GLONASS, GPS\r\nUSB:\t\t\t\tType-C\r\nJack 3.5mm:\t\t\tCó\r\nDung lượng Pin:\t\t5000 mAh\r\nMở khóa nhanh:\t\tMở khoá khuôn mặt, Mở khoá vân tay cạnh viền\r\nThiết kế:\t\t\tNguyên khối\r\nKích thước sản phẩm:\tDài 159.8 mm - Ngang 73.87 mm - Dày 8.09 mm"),
            #endregion
        };
        #endregion
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            //panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }
        #region timkiem
        private void txtB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtB.SelectAll();
                txt_find = txtB.Text.ToLower();
                UserDanhmuc uc = new UserDanhmuc(this);
                addUserControl(uc);
            }
        }
        #endregion
        #region danhmucsanpham
        private void load_user_home()
        {
            txtB.Text = "Bạn muốn mua gì hôm nay?";
            txtB.SelectAll();
            button_click = điệnThoạiToolStripMenuItem.Text.ToLower();
            Danhmuc uc = new Danhmuc(this);
            addUserControl(uc);
        }
        private void điệnThoạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtB.Text = "Bạn muốn mua gì hôm nay?";
            txtB.SelectAll();
            button_click = điệnThoạiToolStripMenuItem.Text.ToLower();
            Danhmuc uc = new Danhmuc(this);
            addUserControl(uc);
        }

        private void iPhoneToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            txtB.Text = null;
            button_click = iPhoneToolStripMenuItem.Text.ToLower();
            Danhmuc uc = new Danhmuc(this);
            addUserControl(uc);
        }

        private void samsungToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtB.Text = null;
            button_click = samsungToolStripMenuItem.Text.ToLower();
            Danhmuc uc = new Danhmuc(this);
            addUserControl(uc);
        }

        private void xiaomiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtB.Text = null;
            button_click = xiaomiToolStripMenuItem.Text.ToLower();
            Danhmuc uc = new Danhmuc(this);
            addUserControl(uc);
        }

        private void samsungGalaxyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtB.Text = null;
            button_click = samsungGalaxyToolStripMenuItem.Text.ToLower();
            Danhmuc uc = new Danhmuc(this);
            addUserControl(uc);
        }

        private void samsungA53ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtB.Text = null;
            button_click = samsungA53ToolStripMenuItem.Text.ToLower();
            Danhmuc uc = new Danhmuc(this);
            addUserControl(uc);
        }

        private void samsungS22ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtB.Text = null;
            button_click = samsungS22ToolStripMenuItem.Text.ToLower();
            Danhmuc uc = new Danhmuc(this);
            addUserControl(uc);
        }

        private void samsungA03ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtB.Text = null;
            button_click = samsungA03ToolStripMenuItem.Text.ToLower();
            Danhmuc uc = new Danhmuc(this);
            addUserControl(uc);
        }

        private void iPhone12ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtB.Text = null;
            button_click = iPhone12ToolStripMenuItem.Text.ToLower();
            Danhmuc uc = new Danhmuc(this);
            addUserControl(uc);
        }

        private void iPhone13ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtB.Text = null;
            button_click = iPhone13ToolStripMenuItem.Text.ToLower();
            Danhmuc uc = new Danhmuc(this);
            addUserControl(uc);
        }

        private void iPhone14ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtB.Text = null;
            button_click = iPhone14ToolStripMenuItem.Text.ToLower();
            Danhmuc uc = new Danhmuc(this);
            addUserControl(uc);
        }

        private void samsungS22ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            txtB.Text = null;
            button_click = samsungS22ToolStripMenuItem1.Text.ToLower();
            Danhmuc uc = new Danhmuc(this);
            addUserControl(uc);
        }

        private void sảnPhẩmCaoCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtB.Text = null;
            button_click = sảnPhẩmCaoCấpToolStripMenuItem.Text.ToLower();
            Danhmuc uc = new Danhmuc(this);
            addUserControl(uc);
        }
        #endregion
        private void lbcard_Click(object sender, EventArgs e)
        {
            UserCart uc = new UserCart(this);
            addUserControl(uc);
        }

        //Load label so luong hien thi tren cart
        internal void update_cart()
        {
            lb_quantity.Text = products_cart.Count.ToString();
        }
        #region timkiem
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            txt_find = txtB.Text.ToLower();
            UserDanhmuc uc = new UserDanhmuc(this);
            addUserControl(uc);
        }
        #endregion

        private void ptbcart_Click(object sender, EventArgs e)
        {
            UserCart uc = new UserCart(this);
            addUserControl(uc);
        }

        private void lbH_Click(object sender, EventArgs e)
        {
            int count = 0;
            history uc = new history();
            addUserControl(uc);
            for (int i = 0; i < date_time.Count; i++)
            {
                bool flag = true;
                for (int j = i + 1; j < date_time.Count; j++)
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
            lbhistory.Text = count.ToString();
        }

        private void lbsearch_Click(object sender, EventArgs e)
        {
            order_lookup newform = new order_lookup();
            newform.ShowDialog();
        }
        
        private void ptbH_Click(object sender, EventArgs e)
        {
            int count = 0;
            history uc = new history();
            addUserControl(uc);
            for (int i = 0; i < date_time.Count; i++)
            {
                bool flag = true;
                for (int j = i + 1; j < date_time.Count; j++)
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
            lbhistory.Text = count.ToString();
        }
        #region filter
        public string trademark_color;
        public string memory_color;
        public string color_color;
        public string price_color;
        private void iPhone_Click(object sender, EventArgs e)
        {
            if(iPhone.BackColor == Color.White)
            {
                iPhone.BackColor = Color.DeepSkyBlue;
                samsung.BackColor = Color.White;
                xiaomi.BackColor = Color.White;
                thươngHiệu.BackColor = Color.DeepSkyBlue;
                trademark_color = "DeepSkyBlue";
            }
            else
            {
                iPhone.BackColor = Color.White;
                thươngHiệu.BackColor = Color.White;
                trademark_color = "White";
            }
        }

        private void samsung_Click(object sender, EventArgs e)
        {
            if (samsung.BackColor == Color.White)
            {
                iPhone.BackColor = Color.White;
                samsung.BackColor = Color.DeepSkyBlue;
                xiaomi.BackColor = Color.White;
                thươngHiệu.BackColor = Color.DeepSkyBlue;
                trademark_color = "DeepSkyBlue";
            }
            else
            {
                samsung.BackColor = Color.White;
                thươngHiệu.BackColor = Color.White;
                trademark_color = "White";
            }
        }

        private void xiaomi_Click(object sender, EventArgs e)
        {
            if (xiaomi.BackColor == Color.White)
            {
                iPhone.BackColor = Color.White;
                samsung.BackColor = Color.White;
                xiaomi.BackColor = Color.DeepSkyBlue;
                thươngHiệu.BackColor = Color.DeepSkyBlue;
                trademark_color = "DeepSkyBlue";
            }
            else
            {
                xiaomi.BackColor = Color.White;
                thươngHiệu.BackColor = Color.White;
                trademark_color = "White";
            }
        }

        private void gBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (gBToolStripMenuItem.BackColor == Color.White)
            {
                gBToolStripMenuItem.BackColor = Color.DeepSkyBlue;
                gBToolStripMenuItem1.BackColor = Color.White;
                gBToolStripMenuItem2.BackColor = Color.White;
                gBToolStripMenuItem3.BackColor = Color.White;
                tBToolStripMenuItem.BackColor = Color.White;
                rOM.BackColor = Color.DeepSkyBlue;
                memory_color = "DeepSkyBlue";
            }
            else
            {
                gBToolStripMenuItem.BackColor = Color.White;
                rOM.BackColor = Color.White;
                memory_color = "White";
            }
        }

        private void gBToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (gBToolStripMenuItem1.BackColor == Color.White)
            {
                gBToolStripMenuItem.BackColor = Color.White;
                gBToolStripMenuItem1.BackColor = Color.DeepSkyBlue;
                gBToolStripMenuItem2.BackColor = Color.White;
                gBToolStripMenuItem3.BackColor = Color.White;
                tBToolStripMenuItem.BackColor = Color.White;
                rOM.BackColor = Color.DeepSkyBlue;
                memory_color = "DeepSkyBlue";
            }
            else
            {
                gBToolStripMenuItem1.BackColor = Color.White;
                rOM.BackColor = Color.White;
                memory_color = "White";
            }
        }

        private void gBToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (gBToolStripMenuItem2.BackColor == Color.White)
            {
                gBToolStripMenuItem.BackColor = Color.White;
                gBToolStripMenuItem1.BackColor = Color.White;
                gBToolStripMenuItem2.BackColor = Color.DeepSkyBlue;
                gBToolStripMenuItem3.BackColor = Color.White;
                tBToolStripMenuItem.BackColor = Color.White;
                rOM.BackColor = Color.DeepSkyBlue;
                memory_color = "DeepSkyBlue";
            }
            else
            {
                gBToolStripMenuItem2.BackColor = Color.White;
                rOM.BackColor = Color.White;
                memory_color = "White";
            }
        }

        private void gBToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (gBToolStripMenuItem3.BackColor == Color.White)
            {
                gBToolStripMenuItem.BackColor = Color.White;
                gBToolStripMenuItem1.BackColor = Color.White;
                gBToolStripMenuItem2.BackColor = Color.White;
                gBToolStripMenuItem3.BackColor = Color.DeepSkyBlue;
                tBToolStripMenuItem.BackColor = Color.White;
                rOM.BackColor = Color.DeepSkyBlue;
                memory_color = "DeepSkyBlue";
            }
            else
            {
                gBToolStripMenuItem3.BackColor = Color.White;
                rOM.BackColor = Color.White;
                memory_color = "White";
            }
        }

        private void tBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tBToolStripMenuItem.BackColor == Color.White)
            {
                gBToolStripMenuItem.BackColor = Color.White;
                gBToolStripMenuItem1.BackColor = Color.White;
                gBToolStripMenuItem2.BackColor = Color.White;
                gBToolStripMenuItem3.BackColor = Color.White;
                tBToolStripMenuItem.BackColor = Color.DeepSkyBlue;
                rOM.BackColor = Color.DeepSkyBlue;
                memory_color = "DeepSkyBlue";
            }
            else
            {
                tBToolStripMenuItem.BackColor = Color.White;
                rOM.BackColor = Color.White;
                memory_color = "White";
            }
        }

        private void trắng_Click(object sender, EventArgs e)
        {
            if (trắng.BackColor == Color.White)
            {
                trắng.BackColor = Color.DeepSkyBlue;
                xanh.BackColor = Color.White;
                hồng.BackColor = Color.White;
                cam.BackColor = Color.White;
                tím.BackColor = Color.White;
                đen.BackColor = Color.White;
                đồng.BackColor = Color.White;
                vàng.BackColor = Color.White;
                bạc.BackColor = Color.White;
                màuSắc.BackColor = Color.DeepSkyBlue;
                color_color = "DeepSkyBlue";
            }
            else
            {
                trắng.BackColor = Color.White;
                màuSắc.BackColor = Color.White;
                color_color = "White";
            }
        }

        private void xanh_Click(object sender, EventArgs e)
        {
            if (xanh.BackColor == Color.White)
            {
                trắng.BackColor = Color.White;
                xanh.BackColor = Color.DeepSkyBlue;
                hồng.BackColor = Color.White;
                cam.BackColor = Color.White;
                tím.BackColor = Color.White;
                đen.BackColor = Color.White;
                đồng.BackColor = Color.White;
                vàng.BackColor = Color.White;
                bạc.BackColor = Color.White;
                màuSắc.BackColor = Color.DeepSkyBlue;
                color_color = "DeepSkyBlue";
            }
            else
            {
                xanh.BackColor = Color.White;
                màuSắc.BackColor = Color.White;
                color_color = "White";
            }
        }

        private void hồng_Click(object sender, EventArgs e)
        {
            if (hồng.BackColor == Color.White)
            {
                trắng.BackColor = Color.White;
                xanh.BackColor = Color.White;
                hồng.BackColor = Color.DeepSkyBlue;
                cam.BackColor = Color.White;
                tím.BackColor = Color.White;
                đen.BackColor = Color.White;
                đồng.BackColor = Color.White;
                vàng.BackColor = Color.White;
                bạc.BackColor = Color.White;
                màuSắc.BackColor = Color.DeepSkyBlue;
                color_color = "DeepSkyBlue";
            }
            else
            {
                hồng.BackColor = Color.White;
                màuSắc.BackColor = Color.White;
                color_color = "White";
            }
        }

        private void cam_Click(object sender, EventArgs e)
        {
            if (cam.BackColor == Color.White)
            {
                trắng.BackColor = Color.White;
                xanh.BackColor = Color.White;
                hồng.BackColor = Color.White;
                cam.BackColor = Color.DeepSkyBlue;
                tím.BackColor = Color.White;
                đen.BackColor = Color.White;
                đồng.BackColor = Color.White;
                vàng.BackColor = Color.White;
                bạc.BackColor = Color.White;
                màuSắc.BackColor = Color.DeepSkyBlue;
                color_color = "DeepSkyBlue";
            }
            else
            {
                cam.BackColor = Color.White;
                màuSắc.BackColor = Color.White;
                color_color = "White";
            }
        }

        private void tím_Click(object sender, EventArgs e)
        {
            if (tím.BackColor == Color.White)
            {
                trắng.BackColor = Color.White;
                xanh.BackColor = Color.White;
                hồng.BackColor = Color.White;
                cam.BackColor = Color.White;
                tím.BackColor = Color.DeepSkyBlue;
                đen.BackColor = Color.White;
                đồng.BackColor = Color.White;
                vàng.BackColor = Color.White;
                bạc.BackColor = Color.White;
                màuSắc.BackColor = Color.DeepSkyBlue;
                color_color = "DeepSkyBlue";
            }
            else
            {
                tím.BackColor = Color.White;
                màuSắc.BackColor = Color.White;
                color_color = "White";
            }
        }

        private void đen_Click(object sender, EventArgs e)
        {
            if (đen.BackColor == Color.White)
            {
                trắng.BackColor = Color.White;
                xanh.BackColor = Color.White;
                hồng.BackColor = Color.White;
                cam.BackColor = Color.White;
                tím.BackColor = Color.White;
                đen.BackColor = Color.DeepSkyBlue;
                đồng.BackColor = Color.White;
                vàng.BackColor = Color.White;
                bạc.BackColor = Color.White;
                màuSắc.BackColor = Color.DeepSkyBlue;
                color_color = "DeepSkyBlue";
            }
            else
            {
                đen.BackColor = Color.White;
                màuSắc.BackColor = Color.White;
                color_color = "White";
            }
        }

        private void đồng_Click(object sender, EventArgs e)
        {
            if (đồng.BackColor == Color.White)
            {
                trắng.BackColor = Color.White;
                xanh.BackColor = Color.White;
                hồng.BackColor = Color.White;
                cam.BackColor = Color.White;
                tím.BackColor = Color.White;
                đen.BackColor = Color.White;
                đồng.BackColor = Color.DeepSkyBlue;
                vàng.BackColor = Color.White;
                bạc.BackColor = Color.White;
                màuSắc.BackColor = Color.DeepSkyBlue;
                color_color = "DeepSkyBlue";
            }
            else
            {
                đồng.BackColor = Color.White;
                màuSắc.BackColor = Color.White;
                color_color = "White";
            }
        }

        private void vàng_Click(object sender, EventArgs e)
        {
            if (vàng.BackColor == Color.White)
            {
                trắng.BackColor = Color.White;
                xanh.BackColor = Color.White;
                hồng.BackColor = Color.White;
                cam.BackColor = Color.White;
                tím.BackColor = Color.White;
                đen.BackColor = Color.White;
                đồng.BackColor = Color.White;
                vàng.BackColor = Color.DeepSkyBlue;
                bạc.BackColor = Color.White;
                màuSắc.BackColor = Color.DeepSkyBlue;
                color_color = "DeepSkyBlue";
            }
            else
            {
                vàng.BackColor = Color.White;
                màuSắc.BackColor = Color.White;
                color_color = "White";
            }
        }

        private void bạc_Click(object sender, EventArgs e)
        {
            if (bạc.BackColor == Color.White)
            {
                trắng.BackColor = Color.White;
                xanh.BackColor = Color.White;
                hồng.BackColor = Color.White;
                cam.BackColor = Color.White;
                tím.BackColor = Color.White;
                đen.BackColor = Color.White;
                đồng.BackColor = Color.White;
                vàng.BackColor = Color.White;
                bạc.BackColor = Color.DeepSkyBlue;
                màuSắc.BackColor = Color.DeepSkyBlue;
                color_color = "DeepSkyBlue";
            }
            else
            {
                bạc.BackColor = Color.White;
                màuSắc.BackColor = Color.White;
                color_color = "White";
            }
        }

        private void dưới5Triệu_Click(object sender, EventArgs e)
        {
            if (dưới5Triệu.BackColor == Color.White)
            {
                dưới5Triệu.BackColor = Color.DeepSkyBlue;
                dưới10Triệu.BackColor = Color.White;
                từ1020Triệu.BackColor = Color.White;
                trên20Triệu.BackColor = Color.White;
                trên30Triệu.BackColor = Color.White;
                trên40Triệu.BackColor = Color.White;
                giáTiền.BackColor = Color.DeepSkyBlue;
                price_color = "DeepSkyBlue";
            }
            else
            {
                dưới5Triệu.BackColor = Color.White;
                giáTiền.BackColor = Color.White;
                price_color = "White";
            }
        }

        private void dưới10Triệu_Click(object sender, EventArgs e)
        {
            if (dưới10Triệu.BackColor == Color.White)
            {
                dưới5Triệu.BackColor = Color.White;
                dưới10Triệu.BackColor = Color.DeepSkyBlue;
                từ1020Triệu.BackColor = Color.White;
                trên20Triệu.BackColor = Color.White;
                trên30Triệu.BackColor = Color.White;
                trên40Triệu.BackColor = Color.White;
                giáTiền.BackColor = Color.DeepSkyBlue;
                price_color = "DeepSkyBlue";
            }
            else
            {
                dưới10Triệu.BackColor = Color.White;
                giáTiền.BackColor = Color.White;
                price_color = "White";
            }
        }

        private void từ1020Triệu_Click(object sender, EventArgs e)
        {
            if (từ1020Triệu.BackColor == Color.White)
            {
                dưới5Triệu.BackColor = Color.White;
                dưới10Triệu.BackColor = Color.White;
                từ1020Triệu.BackColor = Color.DeepSkyBlue;
                trên20Triệu.BackColor = Color.White;
                trên30Triệu.BackColor = Color.White;
                trên40Triệu.BackColor = Color.White;
                giáTiền.BackColor = Color.DeepSkyBlue;
                price_color = "DeepSkyBlue";
            }
            else
            {
                từ1020Triệu.BackColor = Color.White;
                giáTiền.BackColor = Color.White;
                price_color = "White";
            }
        }

        private void trên20Triệu_Click(object sender, EventArgs e)
        {
            if (trên20Triệu.BackColor == Color.White)
            {
                dưới5Triệu.BackColor = Color.White;
                dưới10Triệu.BackColor = Color.White;
                từ1020Triệu.BackColor = Color.White;
                trên20Triệu.BackColor = Color.DeepSkyBlue;
                trên30Triệu.BackColor = Color.White;
                trên40Triệu.BackColor = Color.White;
                giáTiền.BackColor = Color.DeepSkyBlue;
                price_color = "DeepSkyBlue";
            }
            else
            {
                trên20Triệu.BackColor = Color.White;
                giáTiền.BackColor = Color.White;
                price_color = "White";
            }
        }

        private void trên30Triệu_Click(object sender, EventArgs e)
        {
            if (trên30Triệu.BackColor == Color.White)
            {
                dưới5Triệu.BackColor = Color.White;
                dưới10Triệu.BackColor = Color.White;
                từ1020Triệu.BackColor = Color.White;
                trên20Triệu.BackColor = Color.White;
                trên30Triệu.BackColor = Color.DeepSkyBlue;
                trên40Triệu.BackColor = Color.White;
                giáTiền.BackColor = Color.DeepSkyBlue;
                price_color = "DeepSkyBlue";
            }
            else
            {
                trên30Triệu.BackColor = Color.White;
                giáTiền.BackColor = Color.White;
                price_color = "White";
            }
        }

        private void trên40Triệu_Click(object sender, EventArgs e)
        {
            if (trên40Triệu.BackColor == Color.White)
            {
                dưới5Triệu.BackColor = Color.White;
                dưới10Triệu.BackColor = Color.White;
                từ1020Triệu.BackColor = Color.White;
                trên20Triệu.BackColor = Color.White;
                trên30Triệu.BackColor = Color.White;
                trên40Triệu.BackColor = Color.DeepSkyBlue;
                giáTiền.BackColor = Color.DeepSkyBlue;
                price_color = "DeepSkyBlue";
            }
            else
            {
                trên40Triệu.BackColor = Color.White;
                giáTiền.BackColor = Color.White;
                price_color = "White";
            }
        }
        public List<string> text_filter;
        private void bộLọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            text_filter = new List<string>();
            for (int i = 0; i<thươngHiệu.DropDownItems.Count; i++)
            {
                if (thươngHiệu.DropDownItems[i].BackColor == Color.DeepSkyBlue)
                {
                    text_filter.Add(thươngHiệu.DropDownItems[i].Text);
                }
            }
            for (int i = 0; i < rOM.DropDownItems.Count; i++)
            {
                if (rOM.DropDownItems[i].BackColor == Color.DeepSkyBlue)
                {
                    text_filter.Add(rOM.DropDownItems[i].Text);
                }
            }
            for (int i = 0; i < màuSắc.DropDownItems.Count; i++)
            {
                if (màuSắc.DropDownItems[i].BackColor == Color.DeepSkyBlue)
                {
                    text_filter.Add(màuSắc.DropDownItems[i].Text);
                }
            }
            for (int i = 0; i<giáTiền.DropDownItems.Count; i++)
            {
                if (giáTiền.DropDownItems[i].BackColor == Color.DeepSkyBlue)
                {
                    text_filter.Add(giáTiền.DropDownItems[i].Text);
                }
            }
            ucfilter uc = new ucfilter(this);
            addUserControl(uc);
        }
        #endregion
    }
}
