using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace programa2_structur
{
    struct Price
    {
        public string tovar;
        public string magazin;
        public int rubli;
        public Price(string tovar, string magazin, int rubli)
        {
            this.tovar = tovar;
            this.magazin = magazin;
            this.rubli = rubli;
        }
        class Program
        {
            static void Main(string[] args)
            {
                Price[] price = new Price[8];
              string[] arrTovar = new string[8] { "Яблоко", "Груша", "Суп", "Кракен", "Кальмар", "Овощ", "Фрукт", "Дрель" };
              string[] arrMarket = new string[8] { "Магнит", "Окей", "Перекресток", "Рынок", "У Омара", "У меня", "Привет", "Карабанда" };
                for (int i = 0;i < 8; i++)
                {
                    Console.WriteLine($"Имя товара: { price[i].tovar = arrTovar[i]}");
                    Console.WriteLine($"Магазин товара: {price[i].magazin = arrMarket[i]}");
                    Console.WriteLine($"Цена товара: {price[i].rubli = (i+1) * 10}");
                    Console.WriteLine("----------------------");
                }

                Console.WriteLine("Введите имя товара для поиска");
                bool flag = false;
                string name = Console.ReadLine();
                for (int i = 0; i < 8; i++)
                {
                    if (name == price[i].tovar)
                    {
                        Console.WriteLine($"Данный товар есть в {price[i].magazin}, его стоимость {price[i].rubli}");
                        flag = true;
                    }
                }
                if (!flag)
                    Console.WriteLine("Товара нет");
                Console.ReadKey();
            }
        }
    }
}
