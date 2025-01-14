using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Core.Entities
{
    public class Employee
    {
        //static int employerId;
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string ?Phone { get; set; }
        public int NumCustomerEnter { get; set; } = 0;
        public double ? Salary { get; set; }

        //static Employee()
        //{
        //    employerId = 1;
        //}
        //public Employee()
        //{
        //    NumCustomerEnter = 0;
        //}
        //public Employee(string name = "-", string phone = "-") : this()
        //{
        //    Id = employerId++;
        //    Name = name;
        //    Phone = phone;
        //}
    }
}

   
