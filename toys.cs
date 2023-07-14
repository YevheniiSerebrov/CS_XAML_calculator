using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace COnsole2222
{
    public class Tovar                       // описание класса Товар
    {
        public string Name;
        public Tovar(string name)
        {
            this.Name = name;
        }
        public void PrintName()
        {
            Console.WriteLine(this.Name);
        }
    }

    public class Product : Tovar                // Описание класса Продукт
    {
        public int Price;
        public Product(string name, int price)
            : base(name)
        {
            this.Price = price;
        }
        public void PrintPrice()
        {
            Console.WriteLine(this.Price);
        }
    }

    public class MilkProduct : Product        //описание класса Молочный продукт
    {
        public int Godnost;
        public MilkProduct(string name, int price, int godnost)
            : base(name, price)
        {
            this.Godnost = godnost;
        }
        public void PrintGodnost()
        {
            Console.WriteLine(this.Godnost);
        }
    }

    public class Toys : Tovar            //описание класса Игрушка
    {
        public string strana;
        public Toys(string name, string strana)
            : base(name)
        {
            this.strana = strana;
        }
        public void PrintStrana()
        {
            Console.WriteLine(this.strana);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var Toys = new Toys("Batman", "USA");
            Toys.PrintName();
            Toys.PrintStrana();
            Console.ReadKey();
        }
    }
}
