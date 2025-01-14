namespace Shop.API.Models.Product
{
    public class ProductPost
    {
        public string Name { get; set; }
        public string? Description { get; set; }
        public double Price { get; set; }
        public int? Amount { get; set; }
    }
}
