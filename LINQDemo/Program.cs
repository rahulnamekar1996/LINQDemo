using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LINQDemo
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Company { get; set; }
        public int Price { get; set; }

        public override string ToString()
        {
            return $"Id ={Id} , Name = {Name}, Company = {Company}, Price = {Price}";
        }

    }
    public class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>()
            {
                new Product{Id=101,Name="Laptop",Company="HP",Price=34500},
                new Product{Id=102,Name="Laptop",Company="Dell",Price=37500},
                new Product{Id=103,Name="Laptop",Company="Lenovo",Price=32500},
                new Product{Id=104,Name="Mouse",Company="Dell",Price=799},
                new Product{Id=105,Name="Mobile",Company="Apple",Price=78500},
                new Product{Id=106,Name="Mobile",Company="MI",Price=12500},
                new Product{Id=107,Name="Keyboard",Company="Microsoft",Price=899},
                 new Product{Id=108,Name="Mouse",Company="Dell",Price=600},
                  new Product{Id=109,Name="Keyboard",Company="Finger",Price=900},
            };
            // display products whose price is >1000

            //var qry = from p in products
            //          where p.Price > 1000
            //          select p;



            // display products of name company dell

            //var qry = from p in products
            //          where p.Company.Contains("Dell")
            //          select p;

            //var qry = from p in products
            //          where p.Company.StartsWith("M")
            //          select p;

            /* var qry = from p in products
                       where p.Price > 1000
                       orderby p.Price
                       select p;*/

            //Lambda Expression 
            //qry no 1
            //var qry=  products.Where (P=>P.Price>1000);N
            // qry no 2

            //var qry = products.Where(p=>p.Name== "Dell").ToList();

            // qry no 3
            //var qry = products.Where(p=>p.Name=="M").ToList();


            // Home Work //

            // qry no 1
            /* var qry = from p in products
                       where p.Price>1500
                       select p;*/
            // qry no 2 
            /*var qry = from p in products
                      where p.Price>10000 && p.Price<40000
                      select p;*/
            // qry no 3 
            /*var qry = from p in products
                       where p.Company.Contains("Dell")
                       select p;*/
            // qry no 4 
            /* var qry = from p in products
                       where p.Name.Contains( "Laptop")
                       select p;*/

            // qry no 5
            /* var qry = from p in products
                      where p.Company.StartsWith("M")
                      select p;*/
            // qry no 6 
            /*var qry = from p in products
                      where p.Name == "Mouse" && p.Price < 1000
                      select p;*/
            // qry no 7 
            /*var qry = from p in products

                      orderby p.Price descending
                      select p;*/



            // qry no 8 
            /* var qry = from p in products

                       orderby p.Name
                       select p;*/

            // qry no 9 
            /* var qry = from p in products
                       where p.Name == "Keyboard"
                       orderby p.Price
                       select p;*/

            // qry no 10 
            /*var qry = from p in products
                      select p;*/

            // Lamda Expression 
            // qry no 1 

            //   var qry = products.OrderByDescending(p => p.Price).ToList();

            // qry no 2

            //var qry = products.Where(p => p.Id == 105).FirstOrDefault();
           // Console.WriteLine(qry);

            // qry no 3 
            // var qry =products.Where(p=>p.Price<5000).ToList();

            // qry no 4 
            //var qry = products.OrderByDescending(p => p.Price).Take(3);

            // qry no 5
            var qry = products.OrderBy(p => p.Price).Take(5);
           foreach (var item in qry)
            {
                Console.WriteLine(item);
            }

        }
    }
}
