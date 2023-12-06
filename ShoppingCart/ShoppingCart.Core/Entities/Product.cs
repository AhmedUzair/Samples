namespace ShopingCart.Core.Entities
{
    public class Product : Audit
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public int StockQuantity { get; set; }
        public string CategoryId { get; set; }

    }
}
