using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Core.Entities
{
    public class Customer
    {
        //private static int num_customer;
        [Key]
        public int Id { get; set; }
        public string Identity { get; set; }
        public string Name { get; set; }
        public string ? Phone { get; set; }
        public string ? City { get; set; }
        public string? Address { get; set; }
        public DateTime ? Birthday { get; set; }
        public int ?ClubCardNumCard { get; set; }
        public ClubCard ?ClubCard { get; set; }


        //public int EmployerId { get; set; }
        //static Customer()
        //{
        //    num_customer = 1;
        //}

        //public Customer(DateTime birthday, string identity = "-", string name = "-", string phone = "-", string city = "", string address = "")
        //{
        //    this.ClubCard = new ClubCard();
        //    this.identity = identity;
        //    this.name = name;
        //    this.phone = phone;
        //    this.city = city;
        //    this.address = address;
        //    this.birthday = birthday;
        //    this.Id = num_customer++;
        //    //  this.EmployerId = employerId;
        //}
    }
}
