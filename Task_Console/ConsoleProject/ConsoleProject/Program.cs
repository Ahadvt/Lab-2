using ConsoleProject.Extentions;
using ConsoleProject.Models;
using ConsoleProject.Services;
using System;

namespace ConsoleProject
{
    class Program
    {
        static void Main(string[] args)
        {

            ServiceManager<Product> serviceManager = new ServiceManager<Product>();
            do
            {
                Console.WriteLine("1.Add queue");
                Console.WriteLine("2.Add queueAsync");
                Console.WriteLine("3.removeFromQueue");
                Console.WriteLine("4.IsQueEmpty");
                Console.WriteLine("0. Out");

                string choose = Console.ReadLine();
                int chooseNum;
                while (!int.TryParse(choose, out chooseNum) || chooseNum > 9 || chooseNum < 0)

                {
                    Console.WriteLine("Please chose number");
                    choose = Console.ReadLine();
                }
                Console.Clear();

                switch (chooseNum)
                {
                    case 1:
                        Console.Clear();
                        AddQueue(ref serviceManager);
                        break;
                    case 2:
                        Console.Clear();
                        AddQueUeAsync(ref serviceManager);
                        break;
                    case 3:
                        Console.Clear();
                        RemoveFromQueue(ref serviceManager);
                        break;
                    case 4:
                        Console.Clear();
                        IsqueEmpty(ref serviceManager);
                        break;

                    case 0:
                        return;
                }
            } while (true);
        }

        static void AddQueue(ref ServiceManager<Product> serviceManager)
        {
            Console.WriteLine("Please add product name");
            string name = Console.ReadLine();
            Console.WriteLine("Please add product Price");
            double.TryParse(Console.ReadLine(), out double price);

            Product product = new Product(name, price);
            serviceManager.done=serviceManager.done.Unlock();
            serviceManager.addInQueue(product);
            serviceManager.done = serviceManager.done.Lock();

            Console.WriteLine("Created");
        }

        static void AddQueUeAsync(ref ServiceManager<Product> serviceManager)
        {
            Console.WriteLine("Please add product name");
            string name = Console.ReadLine();
            Console.WriteLine("Please add product Price");
            double.TryParse(Console.ReadLine(), out double price);

            Console.WriteLine("Please add product name");
            string name2 = Console.ReadLine();
            Console.WriteLine("Please add product Price");
            double.TryParse(Console.ReadLine(), out double price2);

            Product product = new Product(name, price);
            Product product2 = new Product(name2, price2);
            serviceManager.done = serviceManager.done.Unlock();
             serviceManager.addInQueueAsync(product, product2);
            serviceManager.done = serviceManager.done.Lock();

            Console.WriteLine("Created");

        }

        static void RemoveFromQueue(ref ServiceManager<Product> serviceManager)
        {
            serviceManager.done = serviceManager.done.Unlock();
            Console.WriteLine(serviceManager.removeFromQueue()+" "+"Removed");
            serviceManager.done = serviceManager.done.Lock();

        }

        static void IsqueEmpty(ref ServiceManager<Product> serviceManager)
        {
            serviceManager.done = serviceManager.done.Unlock();
             string result= serviceManager.IsQueueEmpty()?"Yes":"No";
            Console.WriteLine(result);
            serviceManager.done = serviceManager.done.Lock();

        }
    }

}
