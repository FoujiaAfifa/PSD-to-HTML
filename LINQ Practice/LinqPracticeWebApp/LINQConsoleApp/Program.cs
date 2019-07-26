using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {


            var Products = new List<Product>()
            {
                new Product(){ ID = 1, Name = "Nokia3100", Category = "Electronics", Price = 2200,Brand="Nokia"},
                new Product(){ ID = 2, Name = "Samsung4520", Category = "Electronics", Price = 17000,Brand="Samsung"},
                new Product(){ ID = 4, Name = "HP-Probook", Category = "Electronics", Price = 72200,Brand="HP"},
                new Product(){ ID = 6, Name = "iPad", Category = "Electronics", Price = 20000,Brand="Apple"}
            };

            //Select All Columns after filtering

            var retrieveProducts = from p in Products
                                   where p.Price > 2000 && p.Price < 30000
                                   orderby p.Name
                                   select p;


            foreach (var s in retrieveProducts)
            {
                Console.WriteLine(s.ID+" "+ s.Name + " " + s.Category + " " + s.Price +" "+ s.Brand + "\t\t");
                
            }

            Console.WriteLine("\t\t");

            //Select only 3columns 

            var retrieveProducts2 = from p in Products
                                   where p.Price > 2000 && p.Price < 30000
                                   orderby p.Name descending
                                   select new
                                   {
                                       Name = p.Name,
                                       Category = p.Category,
                                       Price = p.Price
                                   };


            foreach (var s in retrieveProducts2)
            {
                Console.WriteLine(s.Name + " " + s.Category + " " + s.Price);

            }

            Console.WriteLine("\t\t");

            //LINQ Using Lamda Expression //select all columns

            var retrieveProducts3 = Products.Where(r => r.Price > 2000 && r.Price < 30000);


            foreach (var s in retrieveProducts3)
            {
                
                Console.WriteLine(s.ID + " " + s.Name + " " + s.Category + " " + s.Price + " " + s.Brand + "\t\t");

            }

            Console.WriteLine("\t\t");

            //LINQ Using Lamda Expression //select all columns


            var retrieveProducts4 = Products.Where(p => p.Price > 8000 && p.Price < 30000)
                                            .OrderByDescending(p => p.Name)
                                            .Select(p => new
                                            {
                                                Name = p.Name,
                                                Price= p.Price,
                                                Category=p.Category
                                            });

            foreach (var s in retrieveProducts4)
            {
                Console.WriteLine(s.Name + " " + s.Category + " " + s.Price);

            }


            Console.WriteLine("\t\t\t\t\t");


            // Find min value of an even number in an Array

            int[] array = {75,12, 32, 24, 54, 23,10, 65, 28, 30 };

            int? result = null;

            foreach (int i in array)
            {
                if(i%2==0)
                {
                    if (!result.HasValue || i < result)
                    {
                        result = i;
                    }

                }

                
            }

            Console.WriteLine("Min Value of Even Number is: " + result);
            Console.WriteLine("\t\t\t\t\t");


            // Find min value in an Array Using Lamda Expression Aggregate Functions

            int[] numbers = { 75, 12, 32, 24, 54,3, 10, 65, 28, 30 };

            int minimumValue = numbers.Min();

            Console.WriteLine("Min Value is:" + minimumValue);
            Console.WriteLine("\t\t\t\t\t");


            // Find min valueof an Even number in an Array Using Lamda Expression Aggregate Functions

            int[] values = { 75, 12, 32, 24, 54, 21, 10, 65, 28, 30 };

            int minimumEvenValue = values.Where(x => x % 2 == 0).Min();

            Console.WriteLine("Min Value of Even Number is:" + minimumEvenValue);
            Console.WriteLine("\t\t\t\t\t");


            //Concate values of an array by Comma 

            string[] countries = { "Bangladesh", "UK", "USA", "India","Germany" };

            string showContries = string.Empty;

            foreach (string s in countries)
            {
                showContries = showContries + s + " ,";
            }

            int lastIndex = showContries.LastIndexOf(",");
            showContries = showContries.Remove(lastIndex);

            Console.WriteLine("Countries are: " + showContries);
            Console.WriteLine("\t\t\t\t\t");


            //Concate values of an array by Comma Using Lamda Expression


            string showcountriesLinq = countries.Aggregate((a, b) => a + "," + b);


            Console.WriteLine("Countries are Using Linq:" + " " + showcountriesLinq);
            Console.WriteLine("\t\t\t\t\t");


            //Compute the products af all numbers using a seed value

            int[] products = { 12, 5, 7 };

            int computeResult = products.Aggregate(10,(a, b) => a * b);

            Console.WriteLine("Compute result of products: " + computeResult);
            Console.WriteLine("\t\t\t\t\t");

            //Take Operator

            var resultCountires = countries.Take(2);

            foreach(var r in resultCountires)
            {
                Console.WriteLine(r);
            }
            Console.WriteLine("\t\t\t\t\t");

            //Skip Operator

            var resultCountires1 = countries.Skip(2);

            foreach (var r in resultCountires1)
            {
                Console.WriteLine(r);
            }
            Console.WriteLine("\t\t\t\t\t");



            Console.ReadKey();
        }
    }
}
