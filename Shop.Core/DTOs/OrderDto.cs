using Shop.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Core.DTOs
{
    public class OrderDto
    {
        public int Id { get; set; }
        //public int CustId { get; set; }
        public Customer Customer { get; set; }
        public DateTime? DateOrder { get; set; }
        public List<Product>? AllProducts { get; set; }
        public double SumBuying { get; set; }

    }
}
