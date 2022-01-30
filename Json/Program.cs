using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;
using System.Text.Encodings.Web;
using System.Text.Unicode;

namespace Json
{
    class Program
    {
        //    1.    Необходимо разработать программу для записи информации о товаре в текстовый файл в формате json.

        //Разработать класс для моделирования объекта «Товар».
        //Предусмотреть члены класса «Код товара» (целое число), «Название товара» (строка), «Цена товара» (вещественное число).
        //Создать массив из 5-ти товаров, значения должны вводиться пользователем с клавиатуры.
        //Сериализовать массив в json-строку, сохранить ее программно в файл «Products.json».

        //    2.    Необходимо разработать программу для получения информации о товаре из json-файла.
        //Десериализовать файл «Products.json» из задачи 1. Определить название самого дорогого товара.
        static void Main(string[] args)
        {
            const int num = 5;
            Console.WriteLine("Введите данные(числовой код товара,название и цену в руб) для 5 товаров.");
            Product[] product = new Product[num];
            {
                Console.WriteLine();
                for (int i = 0; i < num; i++)
                {
                    product[i] = new Product();
                    Console.WriteLine("{0}-й товар:", i + 1);
                    Console.WriteLine("Введите код товара:");
                    product[i].Product_id = int.Parse(Console.ReadLine());
                    Console.WriteLine("Введите название товара:");
                    product[i].Product_name = Console.ReadLine();
                    Console.WriteLine("Введите цену:");
                    product[i].Price = Convert.ToSingle(Console.ReadLine());
                    Console.WriteLine();
                }
            }
            JsonSerializerOptions options = new JsonSerializerOptions
            {
                Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Cyrillic),
                WriteIndented = true

            };
            string product_Json = JsonSerializer.Serialize(product, options);

            Console.WriteLine(product_Json);


            StreamWriter file = File.CreateText("../../../Products.json");
            file.WriteLine(product_Json);
            file.Close();

            Console.ReadKey();
        }
    }
}
