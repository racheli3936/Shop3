using Microsoft.EntityFrameworkCore;
using Shop.Core.Entities;
using Shop.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Data.Repositories
{
    public class CustomerRepository:ICustomerRepository
    {
        private readonly DataContext _context;
        public CustomerRepository(DataContext context)
        {
            this._context = context;
        }
        public async Task<List<Customer>> GetAllCustomersAsync(int password)
        {
            if (password == _context.managerPassward)
                return await _context.Customers.Include(u=>u.ClubCard).ToListAsync();
            else
            {
                Console.WriteLine("you haven`t permission");
            }
            return null;
        }
        public Customer GetCustomerById(string identity)
        {
            Customer c = _context.Customers.Include(cust=>cust.ClubCard).FirstOrDefault(cust => cust.Identity == identity);
            if (c == null)
            {
                Console.WriteLine("you are not a member");
                return null;
            }
            return c;
        }

        public async void AddNewCustomerAsync(Customer customer,int employeeId)
        {
           // Customer customer = new Customer() {birthday=birthday,identity=identity,name=name,phone=phone,city=city,address=address };
            _context.Employees.ToList().Find(employer => employer.Id == employeeId).NumCustomerEnter++;
            customer.ClubCard=new ClubCard();
            _context.Customers.Add(customer);
            await _context.SaveChangesAsync();
        }
        public async void UpdatePointsAsync(string custIdentity, double sumPay)
        {
            Customer cust = _context.Customers.Include(c=>c.ClubCard).ToList().Find(cust => cust.Identity == custIdentity);
       cust.ClubCard.NumPoint+= (int)(sumPay * 0.1);
            await _context.SaveChangesAsync();
        }
    }
}
