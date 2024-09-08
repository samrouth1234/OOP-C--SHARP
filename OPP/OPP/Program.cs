using System;

namespace OPP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product();
            int n = 0;
            Console.WriteLine("----------------------------------------");
            Console.Write("Enter Number :");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("----------------------------------------");

            Console.WriteLine("------------ INPUT PRODUCT -------------");
            for (int i = 0; i < n; i++) {
                product.InputProduct();
                Console.WriteLine("----------------------------------------");
            }

            Console.WriteLine("------------ SHOW PRODUCT --------------");
            for (int i = 0; i < n; i++)
            {
                product.ShowProduct();
            }
            Console.WriteLine("---------------------------------------");
            Console.ReadKey();
        }
    }
}
