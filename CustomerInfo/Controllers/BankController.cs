
using CustomerInfo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CustomerInfo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BankController : Controller
    {
        private readonly CustomerDbContext _context;

        public BankController(CustomerDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        //Get: api/Bank
        public async Task<ActionResult<IEnumerable<Bank>>> GetBank()
        {
            return await _context.Bank.ToListAsync();
        }
        [HttpGet("{id}")]
        //Get: api/Banks/5
        public async Task<ActionResult<Bank>> GetBanks(int id)
        {
            var bank = await _context.Bank.FindAsync(id);

            if (bank == null)
            {
                return NotFound();
            }
            return bank;
        }
        [HttpPut("{id}")]

        public async Task<IActionResult> PutBank(int id, Bank bank)
        {
            if (id != bank.BankId)
            {
                return BadRequest();
            }
            _context.Entry(bank).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BankExists(id))
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
        public async Task<ActionResult<Bank>> PostBanks(Bank bank)
        {
            _context.Bank.Add(bank);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBanks", new { id = bank.BankId }, bank);
        }
        [HttpDelete("{id}")]

        public async Task<IActionResult> DeleteBank(int id)
        {
            var Bank = await _context.Bank.FindAsync(id);

            if (Bank == null)
            {
                return NotFound();
            }

            _context.Bank.Remove(Bank);
            await _context.SaveChangesAsync();

            return NoContent();


        }

        private bool BankExists(int id)
        {
            return _context.Bank.Any(e => e.BankId == id);
        }
    }
}
