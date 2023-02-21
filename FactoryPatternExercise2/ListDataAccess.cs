using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    class ListDataAccess : IDataAccess
    {
        public static List<Product> Products = new List<Product>()
        {
            new Product() { Name = "Pearl Jam Ten", Price = "$10" },
                new Product() { Name = "Megaman X Collection", Price = "$10" },
                new Product() { Name = "Keyboard", Price = "$10" },
                new Product() { Name = "Monitor", Price = "$10" },
                new Product() { Name = "Mouse", Price = "$10" },
                new Product() { Name = "Desk", Price = "$10" },
                new Product() { Name = "Power Supply", Price = "$10" }
        };

        public void SaveData()
        {
            Console.WriteLine("Saving your static list. . .");
        }

      
        public List<Product> LoadData()
        {
            Console.WriteLine("Accessing your static list. . .");

            return Products;
        }
    }
}
