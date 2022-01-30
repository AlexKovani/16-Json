using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;

namespace Deserialize
{
    class Program
    {
        static void Main(string[] args)
        {
            string _json = string.Empty;
            using (StreamReader str = new StreamReader("../../../Products.json"))
            { 
                _json = str.ReadToEnd();
            }
            
            Product[] product1 = JsonSerializer.Deserialize<Product[]>(_json);
            Product maxProduct = product1[0];
            foreach (var i in product1)
            {
                if (i.Price>maxProduct.Price)
                {
                    maxProduct = i;
                } 
            }
            Console.WriteLine($"Самый дорогой продукт: {maxProduct.Product_id} {maxProduct.Product_name} {maxProduct.Price}");
            Console.ReadLine();
        }
    }
}
