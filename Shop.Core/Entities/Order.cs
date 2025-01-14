using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Shop.Core.Entities
{
    public class Order
    {
        //static int orderId;
        [Key]
        public int Id { get; set; }
        //public int CustId { get; set; }
        public Customer Customer { get; set; }
        public DateTime? DateOrder { get; set; }
        public List<Product>? AllProducts { get; set; }
        public double SumBuying { get; set; }
        //public int EmployeeId { get; set; }
        //static Order()
        //{
        //    orderId = 1;
        //}
        //public Order(int custId)
        //{
        //    Id = orderId++;
        //    CustId = custId;
        //    DateOrder = DateTime.Now;
        //    AllProducts = new List<Product>();
        //    SumBuying = 0;
        //}
        //public override string ToString()
        //{
        //    //  Class.ClubCards.Find(item=>item.Customer.Id == Id);
        //    // string name = Class.ClubCards.ForEach(card => { if (card.Customer.Id == Id) { } });
        //    string products = "";
        //    AllProducts.ForEach(p => products += p.ToString() + "\n");
        //    return $"id: {Id}\nhello to {CustId}\ndate: {DateOrder}\n{products}\nsum: {SumBuying} ";
        //}
    }
}
