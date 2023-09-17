using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using andromeda.Data;
using andromeda.Models;
namespace andromeda.Controllers;

[ApiController]
[Route("andromeda/kanban")]
public class FinancialControlController : ControllerBase
{
   private AndromedaDbContext? _context;

   public FinancialControlController(AndromedaDbContext context)
   {
    _context = context;
   }

   [HttpGet]
   [Route("financialcontrol/list")]
   public async Task<ActionResult<IEnumerable<Transaction>>> List()
   {
    if(_context?.Transactions is null)
        return NotFound();
    return await _context.Transactions.ToListAsync();
   }

   [HttpGet()]
   [Route("transaction/find/{id}")]
   public async Task<ActionResult<Transaction>> Find([FromRoute] string id){
    if(_context?.Transactions is null)
        return NotFound();
    var transaction = await _context.Transactions.FindAsync(id);
    if(transaction is null)
        return NotFound();
    return transaction;
   }

   [HttpPost]
   [Route("transaction/create")]
   public IActionResult Create(Transaction transaction){
    _context?.Add(transaction);
    _context?.SaveChanges();
    return Created("", transaction);
   }
}
