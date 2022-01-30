using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deserialize
{
    class Product
    {
        int product_id;
        public int Product_id { get { return product_id; } set { if (product_id < 0) throw new Exception("Значение отрицательная!"); product_id = value; } }
        float price;
        public float Price { get { return price; } set { if (price < 0) throw new Exception("Цена отрицательная!"); price = value; } }
        public string Product_name { get; set; }
    }
}
