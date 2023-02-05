using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _20521363.Model
{
    public class take_datetime
    {
        public string Name_customer { get; set; }
        public string Phone_number { get; set; }
        public string Email { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public DateTime aDateTime { get; set; }
        public string MaDH { get; set; }
        public int SL { get; set; }
        public string Hinhthucthanhtoan { get; set; }
        public string Hinhthucnhan { get; set; }
        public int Thanhtien { get; set; }
        public string Thanhtoan  { get; set; }
        public take_datetime(string name_customer, string phone_number, string email, string city, string address, DateTime aDateTime, string maDH, int sL, string hinhthucthanhtoan, string hinhthucnhan,int thanhtien, string thanhtoan)
        {
            Name_customer = name_customer;
            Phone_number = phone_number;
            Email = email;
            City = city;
            Address = address;
            this.aDateTime = aDateTime;
            MaDH = maDH;
            SL = sL;
            Hinhthucthanhtoan = hinhthucthanhtoan;
            Hinhthucnhan = hinhthucnhan;
            Thanhtien = thanhtien;
            Thanhtoan = thanhtoan;
        }
    }
}
