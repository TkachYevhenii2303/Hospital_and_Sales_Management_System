using Bogus;
using Sales_Management_DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Sales_Management_DAL.Bogus_Generator
{
    public class BogusGenerator
    {
        public static List<Customers> Customers { get; set; } = new();
        public static List<Products> Products { get; set; } = new();
        public static List<Stores> Stores { get; set; } = new();
        public static List<Sales> Sales { get; set; } = new();

        private const int CUSTOMERS = 50;
        private const int PRODUCTS = 75;
        private const int STORES = 50;
        private const int SALES = 25;

        public static void Generate_all_Data()
        {
            Customers = new Faker<Customers>()
                .RuleFor(x => x.Customers_title, f => f.Person.FullName)
                .RuleFor(x => x.Customers_email, (f, o) => f.Internet.Email(o.Customers_title))
                .RuleFor(x => x.ID, _ => Guid.NewGuid()).Generate(CUSTOMERS);

            Products = new Faker<Products>()
                .RuleFor(x => x.Products_title, f => f.Commerce.Product())
                .RuleFor(x => x.Products_count, f => f.Random.Int())
                .RuleFor(x => x.ID, _ => Guid.NewGuid()).Generate(PRODUCTS);

            Stores = new Faker<Stores>()
                .RuleFor(x => x.Stores_title, f => f.Commerce.Department())
                .RuleFor(x => x.ID, _ => Guid.NewGuid()).Generate(STORES);

            Sales = new Faker<Sales>()
                .RuleFor(x => x.Customers_ID, f => f.PickRandom(Customers).ID)
                .RuleFor(x => x.Products_ID, f => f.PickRandom(Products).ID)
                .RuleFor(x => x.Stores_ID, f => f.PickRandom(Stores).ID)
                .RuleFor(x => x.ID, _ => Guid.NewGuid()).Generate(SALES);
        }
    }
}
