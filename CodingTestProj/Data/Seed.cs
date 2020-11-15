using System;
using System.Collections.Generic;
using System.Linq;
using CodingTestProj.Data;
using CodingTestProj.Models;
using Microsoft.AspNetCore.Identity;
using Newtonsoft.Json;

namespace CodingTestProj.Data
{
    public class Seed
    {
        public static void SeedUsers(DataContext _context)
        {
            
            if ( !_context.Customers.Any()) 
            {
                var data = System.IO.File.ReadAllText("Data/UserSeedData.json");
                var customers = JsonConvert.DeserializeObject<List<Customer>>(data);

                foreach (var customer in customers)
                {
                    _context.Add(customer);
                }
                _context.SaveChanges();
            }  
        }

         public static void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512()) 
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }
            
        }
    }
}