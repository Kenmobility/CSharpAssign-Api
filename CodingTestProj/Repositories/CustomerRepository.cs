using AutoMapper;
using CodingTestProj.Data;
using CodingTestProj.Dtos;
using CodingTestProj.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodingTestProj.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly DataContext _context;
        public CustomerRepository(DataContext context)
        {
            _context = context;
        }

        public void CreateCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }

        public async Task<Customer> GetCustomer(int Id)
        {
            var customer = await _context.Customers.Include(o => o.Orders).Include(a => a.Addresses)
                .Where(x => x.Id == Id).FirstOrDefaultAsync();

            return customer;
        }

        public async Task<IEnumerable<Customer>> GetCustomers()
        {
            var custormers = await _context.Customers.Include(a => a.Addresses).Include(o => o.Orders).ToListAsync();

            return custormers;
        }

        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity);
        }

        public void Delete<T>(T entity) where T : class
        {
            _context.Remove(entity);
        }

        public async Task<bool> SaveAll()
        {
            return await _context.SaveChangesAsync() > 0;
        }

        public void UpdateCustomer(Customer customer)
        {
            _context.Customers.Update(customer);
        }
    }
}
