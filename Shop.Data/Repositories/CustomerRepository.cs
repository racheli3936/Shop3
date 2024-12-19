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
        public List<Customer> GetAllCustomers(int password)
        {
            if (password == _context.managerPassward)
                return _context.Customers.ToList();
            else
            {
                Console.WriteLine("you haven`t permission");
            }
            return null;
        }
        public Customer GetCustomerById(string identity)
        {
            Customer c = _context.Customers.FirstOrDefault(cust => cust.identity == identity);
            if (c == null)
            {
                Console.WriteLine("you are not a member");
                return null;
            }
            return c;
        }

        public void AddNewCustomer(Customer customer,int employeeId)
        {
           // Customer customer = new Customer() {birthday=birthday,identity=identity,name=name,phone=phone,city=city,address=address };
            _context.Employees.ToList().Find(employer => employer.Id == employeeId).NumCustomerEnter++;
            _context.Customers.Add(customer);
            _context.SaveChanges();
        }
        public void UpdatePoints(string custIdentity, double sumPay)
        {
            _context.Customers.ToList().Find(cust => cust.identity == custIdentity).ClubCard.NumPoint += (int)(sumPay * 0.1);
            _context.SaveChanges();
        }
    }
}
