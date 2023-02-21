using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    class MySQLDataAccess : IDataAccess
    {
        public void SaveData()
        {
            Console.WriteLine("Saving data to your MySQL Database. . .");
        }

       
        public List<Product> LoadData()
        {
            Console.WriteLine("Accessing your SQL Database. . .");

            return new List<Product>()
            {
                new Product() { Name = "Pearl Jam Ten", Price = "$10" },
                new Product() { Name = "Megaman X Collection", Price = "$10" },
                new Product() { Name = "Keyboard", Price = "$10" },
                new Product() { Name = "Monitor", Price = "$10" },
                new Product() { Name = "Mouse", Price = "$10" },
                new Product() { Name = "Desk", Price = "$10" },
                new Product() { Name = "Power Supply", Price = "$10" }
            };
        }
    }
}
