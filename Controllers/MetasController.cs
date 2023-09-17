using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using andromeda.Data;
using andromeda.Models;
namespace andromeda.Controllers;

[ApiController]
[Route("andromeda/metas")]
public class FinancialGoalController : ControllerBase
{
   private AndromedaDbContext? _context;

   public FinancialGoalController(AndromedaDbContext context)
   {
    _context = context;
   }

   [HttpGet]
   [Route("list/financialgoal")]
   public async Task<ActionResult<IEnumerable<FinancialGoal>>> List()
   {
    if(_context?.FinancialGoals is null)
        return NotFound();
    return await _context.FinancialGoals.ToListAsync();
   }

   [HttpGet()]
   [Route("find/financialgoal/{id}")]
   public async Task<ActionResult<FinancialGoal>> Find([FromRoute] string id){
    if(_context?.FinancialGoals is null)
        return NotFound();
    var financialGoal = await _context.FinancialGoals.FindAsync(id);
    if(financialGoal is null)
        return NotFound();
    return financialGoal;
   }

   [HttpPost]
   [Route("create/financialgoal")]
   public IActionResult Create(FinancialGoal financialGoal){
    _context?.Add(financialGoal);
    _context?.SaveChanges();
    return Created("", financialGoal);
   }
}


[ApiController]
[Route("andromeda/metas")]
public class WishController : ControllerBase
{
   private AndromedaDbContext? _context;

   public WishController(AndromedaDbContext context)
   {
    _context = context;
   }

   [HttpGet]
   [Route("list/wish")]
   public async Task<ActionResult<IEnumerable<Wish>>> List()
   {
    if(_context?.Wishes is null)
        return NotFound();
    return await _context.Wishes.ToListAsync();
   }

   [HttpGet()]
   [Route("find/wish/{id}")]
   public async Task<ActionResult<Wish>> Find([FromRoute] string id){
    if(_context?.Wishes is null)
        return NotFound();
    var wish = await _context.Wishes.FindAsync(id);
    if(wish is null)
        return NotFound();
    return wish;
   }

   [HttpPost]
   [Route("create/wish")]
   public IActionResult Create(Wish wish){
    _context?.Add(wish);
    _context?.SaveChanges();
    return Created("", wish);
   }
}