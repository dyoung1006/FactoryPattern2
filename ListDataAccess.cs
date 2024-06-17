﻿
namespace Factory_Pattern2
{
    public class ListDataAccess : IDataAccess
    {
        public static List<Product> Products = new List<Product>()
        {
            new Product(){ Name = "Xbox", Price = 350 },
                new Product(){ Name = "PS5", Price = 500 }
        };

        public List<Product> LoadData()
        {
            Console.WriteLine("I am reading data from List Data Access.");
            return Products;
        }

        public void SaveData()
        {
            Console.WriteLine("I am saving data from a SQL Data Access.");
        }
    }
}
