using CustomerInfo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerInfo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomerController : Controller
    {
        private readonly CustomerDbContext _context;

        public CustomerController(CustomerDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        //Get: api/Customers
        public async Task<ActionResult<IEnumerable<Customers>>> GetCustomer()
        {
            return await _context.customers.ToListAsync();
        }
        [HttpGet("{id}")]
        //Get: api/Customers/5
        public async Task<ActionResult<Customers>> GetCustomers(int id)
        {
            var customer = await _context.customers.FindAsync(id);

            if(customer==null)
            {
                return NotFound();
            }
            return customer;
        }
        [HttpPut("{id}")]
       
        public async Task<IActionResult> PutCustomer(int id,Customers customers)
        {
          if (id != customers.CustomerId)
            {
                return BadRequest();
            }
            _context.Entry(customers).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch(DbUpdateConcurrencyException)
            {
                if(!CustomerExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }    
            }
            return NoContent();


        }
        [HttpPost]
        public async Task<ActionResult<Customers>> PostCustomers(Customers customers)
        {
            _context.customers.Add(customers);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCustomers", new { id = customers.CustomerId }, customers);
        }
        [HttpDelete("{id}")]

        public async Task<IActionResult> DeleteCustomer(int id)
        {
            var customer = await _context.customers.FindAsync(id);

            if(customer == null)
            {
                return NotFound();
            }

            _context.customers.Remove(customer);
            await _context.SaveChangesAsync();

            return NoContent();


        }

        private bool CustomerExists(int id)
        {
            return _context.customers.Any(e => e.CustomerId == id);
        }
    }
}
