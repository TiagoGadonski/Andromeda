using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using andromeda.Data;
using andromeda.Models;
namespace andromeda.Controllers;

[ApiController]
[Route("andromeda/user")]
public class UserController : ControllerBase
{
   private AndromedaDbContext? _context;

   public UserController(AndromedaDbContext context)
   {
    _context = context;
   }

   [HttpGet]
   [Route("list")]
   public async Task<ActionResult<IEnumerable<User>>> List()
   {
    if(_context?.Users is null)
        return NotFound();
    return await _context.Users.ToListAsync();
   }

   [HttpGet()]
   [Route("find/{id}")]
   public async Task<ActionResult<User>> Find([FromRoute] string id){
    if(_context?.Users is null)
        return NotFound();
    var user = await _context.Users.FindAsync(id);
    if(user is null)
        return NotFound();
    return user;
   }

   [HttpPost]
   [Route("create")]
   public IActionResult Create(User user){
    _context?.Add(user);
    _context?.SaveChanges();
    return Created("", user);
   }
}
