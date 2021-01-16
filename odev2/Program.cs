using System;

namespace ODEV
{
    class Program
    {
        static void Main(string[] args)
        {
            Product list1 = new Product();
            list1.id = 1;
            list1.ProductName = "Phone";
            list1.Price = 500;


            Product list2 = new Product();
            list2.id = 2;
            list2.ProductName = "Headphone";
            list2.Price = 200;

            Product list3 = new Product();
            list3.id = 3;
            list3.ProductName = "Phonecase";
            list3.Price = 50;

            Product list4 = new Product();
            list4.id = 4;
            list4.ProductName = "Smartwatch";
            list4.Price = 300;

            Product[] products = new Product[] { list1, list2, list3, list4 };

            foreach (Product list in products)
            {
                Console.WriteLine(list.id + "-" + list.ProductName + "\n" + "Price: " + list.Price + "\n");
            }
            Console.WriteLine("\n End Of Foreach Loop \n");

            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine(products[i].id + "-" + products[i].ProductName + "\n" + "Price: " + products[i].Price + "\n");
            }
            Console.WriteLine("\n End of For Loop \n");

            int counter = 0;
            while (counter < products.Length)
            {
                Console.WriteLine(products[counter].id + "-" + products[counter].ProductName + "\n" + "Price: " + products[counter].Price + "\n");
                counter++;
            }
            Console.WriteLine("\n End of While Loop \n");
        }
    }

    class Product
    {
        public int id { get; set; }

        public string ProductName { get; set; }

        public int Price { get; set; }

    }

}