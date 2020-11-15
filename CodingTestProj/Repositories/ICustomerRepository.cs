using CodingTestProj.Dtos;
using CodingTestProj.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodingTestProj.Repositories
{
    public interface ICustomerRepository
    {
      
        Task<IEnumerable<Customer>> GetCustomers();
        Task<Customer> GetCustomer(int Id);
        void UpdateCustomer(Customer customer);
        void Add<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;
        Task<bool> SaveAll();
    }
}
