using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleProject.Models
{
    class Product
    {
        public static int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public bool IsBlock { get; set; }
        static Product()
        {
            Id++;
        }

        public Product(string name,double price)
        {
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return $"{Id},{Name},{Price}";
        }
    }


}
