using System;
using System.Globalization;
using System.Collections.Generic;
using ProductsImported.Entities;
namespace ProductsImported
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Product> List = new List<Product>();
            Console.Write("Enter the number of products: ");
            int contador = int.Parse(Console.ReadLine());

            for (int i = 0; i < contador; i++)
            {
                Console.WriteLine("Product # " + i + " data: ");
                Console.Write("Common, used or imported (c/u/i)? ");
                char ch = char.Parse(Console.ReadLine());
                    switch (ch) 
                {
                    case 'i':
                        Console.Write("Name: ");
                        string Importedname = Console.ReadLine();
                        Console.Write("Price: ");
                        double Importedprice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        Console.Write("Customs fee: ");
                        double Importedfee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        List.Add(new ImportedProduct (Importedname, Importedprice, Importedfee));
                        break;

                    case 'c':
                        Console.Write("Name: ");
                        string Commonname = Console.ReadLine();
                        Console.Write("Price: ");
                        double CommonPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        List.Add(new Product(Commonname, CommonPrice));
                        break;


                    case 'u':
                        Console.Write("Name: ");
                        string UsedProduct = Console.ReadLine();
                        Console.Write("Price: ");
                        double UsedPrice = double.Parse(Console.ReadLine());
                        Console.Write("Manufacture date (DD/MM/YYYY): ");
                        DateTime date = DateTime.Parse(Console.ReadLine());
                        List.Add(new UsedProduct(UsedProduct, UsedPrice, date));

                        break;
                    default:    
                        Console.WriteLine("Digito invalido!");
                        break;
                }
                
            }
            Console.WriteLine();
            Console.WriteLine("PRICE TAGS:");
            foreach (Product prod in List)
            {
                Console.WriteLine(prod.PriceTag());
            }



        }
    }
}
