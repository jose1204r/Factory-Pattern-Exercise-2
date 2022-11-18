using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    internal class SQLDataAccess : IDataAccess
    {


        public static List<Product> Produtcs = new List<Product>()
        {
            new Product() {Name = "PSP5",Prices = 450 },
            new Product() {Name = "Camera",Prices = 250},
            new Product() {Name = "Oculos", Prices = 299},
            new Product (){Name = "Iphone12", Prices = 450}



        };


        public List<Product> LoadData()
        {
            Console.WriteLine("Im reading data from SQL Data Acess");
            return Produtcs;
        }

        public void SaveData()
        {
            Console.WriteLine("I am Saving... Data  from SQL DATA Acess");

        }
    }
}
