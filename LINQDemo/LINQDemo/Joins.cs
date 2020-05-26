using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQDemo
{
    class Product
    {
        public string Name { get; set; }
        public int CategoryID { get; set; }
    }

    class Category
    {
        public string Name { get; set; }
        public int ID { get; set; }
    }

    class Joins
    {
        public static void JoinsTester()
        {
            ////Joins
            List<Category> categories = new List<Category>()
                    {
                 new Category(){Name="Beverages", ID=001},
                 new Category(){ Name="Condiments", ID=002},
                 new Category(){ Name="Vegetables", ID=003},
                 new Category() {  Name="Grains", ID=004},
                 new Category() {  Name="Fruit", ID=005}
             };

            List<Product> products = new List<Product>()
            {
               new Product{Name="Cola",  CategoryID=001},
               new Product{Name="Tea",  CategoryID=001},
               new Product{Name="Mustard", CategoryID=002},
               new Product{Name="Pickles", CategoryID=002},
               new Product{Name="Carrots", CategoryID=003},
               new Product{Name="Bok Choy", CategoryID=003},
               new Product{Name="Peaches", CategoryID=005},
               new Product{Name="Melons", CategoryID=005},
             };

           var innerJoinQuery =
           from category in categories
           join prod in products on category.ID equals prod.CategoryID
           select new { Category = category.ID, Product = prod.Name };

            Console.WriteLine("InnerJoin:");
            // Execute the query. Access results 
            // with a simple foreach statement.
            foreach (var item in innerJoinQuery)
            {
                Console.WriteLine("{0,-10}{1}", item.Product, item.Category);
            }

            Console.WriteLine(System.Environment.NewLine);


            Console.ReadLine();
        }
    }
}
