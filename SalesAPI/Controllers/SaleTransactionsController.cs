using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SalesAPI.Context;
using SalesAPI.Models;

namespace SalesAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SaleTransactionsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public SaleTransactionsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/SaleTransactions
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SaleTransaction>>> GetSalesTransaction()
        {
          if (_context.SalesTransaction == null)
          {
              return NotFound();
          }
            return await _context.SalesTransaction.ToListAsync();
        }

        // GET: api/SaleTransactions/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SaleTransaction>> GetSaleTransaction(int id)
        {
          if (_context.SalesTransaction == null)
          {
              return NotFound();
          }
            var saleTransaction = await _context.SalesTransaction.FindAsync(id);

            if (saleTransaction == null)
            {
                return NotFound();
            }

            return saleTransaction;
        }

        // PUT: api/SaleTransactions/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSaleTransaction(int id, SaleTransaction saleTransaction)
        {
            if (id != saleTransaction.Id)
            {
                return BadRequest();
            }

            _context.Entry(saleTransaction).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SaleTransactionExists(id))
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

        // POST: api/SaleTransactions
        [HttpPost]
        public async Task<ActionResult<SaleTransaction>> PostSaleTransaction(SaleTransaction saleTransaction)
        {
          if (_context.SalesTransaction == null)
          {
              return Problem("Entity set 'AppDbContext.SalesTransaction'  is null.");
          }
            _context.SalesTransaction.Add(saleTransaction);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSaleTransaction", new { id = saleTransaction.Id }, saleTransaction);
        }

        // DELETE: api/SaleTransactions/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSaleTransaction(int id)
        {
            if (_context.SalesTransaction == null)
            {
                return NotFound();
            }
            var saleTransaction = await _context.SalesTransaction.FindAsync(id);
            if (saleTransaction == null)
            {
                return NotFound();
            }

            _context.SalesTransaction.Remove(saleTransaction);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SaleTransactionExists(int id)
        {
            return (_context.SalesTransaction?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
