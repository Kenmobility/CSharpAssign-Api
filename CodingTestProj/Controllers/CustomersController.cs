using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using CodingTestProj.Models;
using CodingTestProj.Dtos;
using AutoMapper;
using CodingTestProj.Repositories;

namespace CodingTestProj.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly ICustomerRepository _repo;


        public CustomersController(IMapper mapper, ICustomerRepository repo)
        {
            _mapper = mapper;
            _repo = repo;
        }

        // GET: api/Customers
        [HttpGet]
        public async Task<ActionResult> GetCustomers()
        {

            var customers = await _repo.GetCustomers();

            var customersToReturn = _mapper.Map<IEnumerable<CustomersForReturnDto>>(customers);

            return Ok(customersToReturn);

        }

        // GET: api/Customers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Customer>> GetCustomer(int id)
        {
            var customer = await _repo.GetCustomer(id);

            if (customer == null)
            {
                return NotFound();
            }
            var customerToReturn = _mapper.Map<CustomersForReturnDto>(customer);

            return Ok(customerToReturn);
        }

        // PUT: api/Customers/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCustomer(int id, [FromBody]CustomerForUpdateDto customer)
        {
            try
            {
                if (customer == null)
                {
                    return BadRequest("customer object is null");
                }
                if (!ModelState.IsValid)
                {
                    return BadRequest("Invalid model object");
                }
                var customerEntity = await _repo.GetCustomer(id);
                if (customer == null)
                {
                    return NotFound();
                }

               var customerToUpdate = _mapper.Map<Customer>(customer);

                _repo.UpdateCustomer(customerToUpdate);

                await _repo.SaveAll();

                return Ok("Successfully updated");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal server error");
            }
        }

        // POST: api/Customers
        [HttpPost]
        public async Task<ActionResult<Customer>> PostCustomer([FromBody]CustomerForCreationDto customerForCreate)
        {
            try
            {
                if (customerForCreate == null)
                {
                    return BadRequest("Customer object is null");
                }
                if (!ModelState.IsValid)
                {
                    return BadRequest("Invalid model object");
                }
                var customerEntity = _mapper.Map<Customer>(customerForCreate);

                _repo.Add(customerEntity);

                await  _repo.SaveAll();

                return Ok(customerEntity);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal server error");
            }
        }

        // DELETE: api/Customers/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Customer>> DeleteCustomer(int id)
        {
            try
            {
                var customer = await _repo.GetCustomer(id);

                if (customer == null)
                {
                    return NotFound();
                }

                _repo.Delete(customer);

                if (await _repo.SaveAll())
                {
                    return Ok("Customer succesfully removed");
                }
                return BadRequest("Failed to delete Customer");

            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal server error");
            }
        }
    }
}
