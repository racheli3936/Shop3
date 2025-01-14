using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Shop.Core.Entities
{
    public class Product
    {
        //private static int num_Product;
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public double Price { get; set; }
        public int ? Amount { get; set; }
        public bool ? IsExist { get; set; }
        [JsonIgnore]
        public List<Order>? Orders { get; set; }
        //static Product()
        //{
        //    num_Product = 1;
        //}
        //public Product()
        //{
        //    Description = "no special information";
        //}
        //public Product(string name, double price, int amount = 0, string description = "no special information")
        //{
        //    Id = num_Product++;
        //    Name = name;
        //    Description = description;
        //    Amount = amount;
        //    Price = price;
        //    IsExist = false;
        //    if (amount > 0)
        //    {
        //        IsExist = true;
        //    }
        //}
        //public override string ToString()
        //{
        //    return Name + " " + Price + " " + Description;
        //}
    }
}
