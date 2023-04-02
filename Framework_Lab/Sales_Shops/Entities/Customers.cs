namespace Sales_Shops.Entities
{
    public class Customers : Entity
    {
        public string Credit_Card_Number { get; set; }

        public string Email { get; set; }

        public string Customer_name { get; set; }

        public ICollection<Sales> Sales { get; set; } = null!;
    }
}
