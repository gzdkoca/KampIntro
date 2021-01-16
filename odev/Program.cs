using System;

namespace odev
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.ProductName = "Pen";
            product1.ProductPrice = 5;


            Product product2 = new Product();
            product2.ProductName = "Notebook";
            product2.ProductPrice = 10;

            Product product3 = new Product();
            product3.ProductName = "Book";
            product3.ProductPrice = 20;

            var products = new Product[] { product1, product2, product3 };

            Console.WriteLine("-----For Loop-----");

            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine(products[i].ProductName + ": " + products[i].ProductPrice + "TL");
            }

            Console.WriteLine("\n-----Foreach-----");

            foreach (var product in products)
            {
                Console.WriteLine(product.ProductName + ": " + product.ProductPrice + "TL");
            }

            Console.WriteLine("\n-----While Loop-----");

            int counter = 0;
            while (counter < products.Length)
            {
                Console.WriteLine(products[counter].ProductName + ": " + products[counter].ProductPrice + "TL");
                counter++;
            }
            

        }


    class Product
        {
            public string ProductName { get; set; }
            public string ProductColor { get; set; }
            public int ProductPrice { get; set; }
        }
        
    }
}

