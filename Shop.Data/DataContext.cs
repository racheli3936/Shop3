using Microsoft.EntityFrameworkCore;
using Shop.Core.Entities;
using Shop.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Data
{
    public class DataContext:DbContext
    {
        public DbSet<ClubCard> ClubCards { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public int managerPassward { get; set; } = 1234;
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=racheli_shop");
            optionsBuilder.LogTo(message=>Debug.WriteLine($"{message}"));

        }
        //public DataContext()
        //{
        //    ClubCards = new List<ClubCard>();
        //    Products = new List<Product>();
        //    Orders = new List<Order>();
        //    Employees= new List<Employee>();
        //    Employees.Add(new Employee("moshe", "050"));
        //    Employees.Add(new Employee("yosef", "052"));
        //    Employees.Add(new Employee("yaron", "058"));
        //    Customers=new List<Customer>();
        //    managerPassward = 123;
        //}
    }
}
