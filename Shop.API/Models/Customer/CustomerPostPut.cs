namespace Shop.API.Models.Customer
{
    public class CustomerPostPut
    {
        public string Identity { get; set; }
        public string Name { get; set; }
        public string? Phone { get; set; }
        public string? City { get; set; }
        public string? Address { get; set; }
        public DateTime? Birthday { get; set; }
    }
}
