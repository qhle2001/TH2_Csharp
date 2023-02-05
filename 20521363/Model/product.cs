using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20521363.Model
{
     public class product
    {
        public string Name { set; get; }
        public Image Picture { set; get; }
        public string Color { set; get; }
        public string Type { set; get; }
        public int Price { set; get; }
        public string Technical_data { set; get; }

        public product(string name, Image picture, string color, string type, int price, string technical_data)
        {
            Name = name;
            Picture = picture;
            Color = color;
            Type = type;
            Price = price;
            Technical_data = technical_data;
        }
    }
}
