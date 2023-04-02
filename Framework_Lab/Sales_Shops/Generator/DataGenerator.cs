using Bogus;
using Sales_Shops.Entities;

namespace Sales_Shops.Generator
{
    public static class DataGenerator
    {
        public static List<Customers> Customers = new List<Customers>();
        public static List<Stores> Stores = new List<Stores>();
        public static List<Products> Products = new List<Products>();
        public static List<Sales> Sales = new List<Sales>();

        private const int CUSTOMERS = 100;
        private const int STORES = 250;
        private const int PRODUCTS = 400;
        private const int SALES = 175;

        public static void Generate_all_Data()
        {
            Customers = new Faker<Customers>()
                .RuleFor(c => c.Customer_name, f => f.Name.FullName())
                .RuleFor(c => c.Credit_Card_Number, f => f.Finance.CreditCardNumber())
                .RuleFor(c => c.Email, (f, c) => f.Internet.Email(c.Customer_name))
                .RuleFor(c => c.Id, _ => Guid.NewGuid()).Generate(CUSTOMERS);

            Stores = new Faker<Stores>()
                .RuleFor(u => u.Stores_title, f => f.Commerce.ProductDescription())
                .RuleFor(u => u.Id, _ => Guid.NewGuid()).Generate(STORES);

            Products = new Faker<Products>()
                .RuleFor(u => u.Products_title, f => f.Commerce.Product())
                .RuleFor(u => u.Products_price, f => f.Random.Decimal(100, 1500))
                .RuleFor(u => u.Products_amount, f => f.Random.Int(50, 250))
                .RuleFor(u => u.Id, _ => Guid.NewGuid()).Generate(PRODUCTS);

            Sales = new Faker<Sales>()
                .RuleFor(u => u.Products_ID, f => f.PickRandom(Products).Id)
                .RuleFor(u => u.Customer_ID, f => f.PickRandom(Customers).Id)
                .RuleFor(u => u.Stores_ID, f => f.PickRandom(Stores).Id)
                .RuleFor(u => u.Id, _ => Guid.NewGuid()).Generate(SALES);
        }
    }
}
