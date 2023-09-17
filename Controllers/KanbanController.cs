using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using andromeda.Data;
using andromeda.Models;
namespace andromeda.Controllers;

[ApiController]
[Route("andromeda/kanban")]
public class ColunaController : ControllerBase
{
   private AndromedaDbContext? _context;

   public ColunaController(AndromedaDbContext context)
   {
    _context = context;
   }

   [HttpGet]
   [Route("coluna/list")]
   public async Task<ActionResult<IEnumerable<Coluna>>> List()
   {
    if(_context?.Colunas is null)
        return NotFound();
    return await _context.Colunas.ToListAsync();
   }

   [HttpGet()]
   [Route("coluna/find/{id}")]
   public async Task<ActionResult<Coluna>> Find([FromRoute] string id){
    if(_context?.Colunas is null)
        return NotFound();
    var coluna = await _context.Colunas.FindAsync(id);
    if(coluna is null)
        return NotFound();
    return coluna;
   }

   [HttpPost]
   [Route("coluna/create")]
   public IActionResult Create(Coluna coluna){
    _context?.Add(coluna);
    _context?.SaveChanges();
    return Created("", coluna);
   }
}


[ApiController]
[Route("andromeda/kanban")]
public class TaskListController : ControllerBase
{
   private AndromedaDbContext? _context;

   public TaskListController(AndromedaDbContext context)
   {
    _context = context;
   }

   [HttpGet]
   [Route("tasklist/list")]
   public async Task<ActionResult<IEnumerable<TaskList>>> List()
   {
    if(_context?.TaskLists is null)
        return NotFound();
    return await _context.TaskLists.ToListAsync();
   }

   [HttpGet()]
   [Route("tasklist/find/{id}")]
   public async Task<ActionResult<TaskList>> Find([FromRoute] string id){
    if(_context?.TaskLists is null)
        return NotFound();
    var tasklist = await _context.TaskLists.FindAsync(id);
    if(tasklist is null)
        return NotFound();
    return tasklist;
   }

   [HttpPost]
   [Route("tasklist/create")]
   public IActionResult Create(TaskList tasklist){
    _context?.Add(tasklist);
    _context?.SaveChanges();
    return Created("", tasklist);
   }
}


[ApiController]
[Route("andromeda/kanban")]
public class TasksController : ControllerBase
{
   private AndromedaDbContext? _context;

   public TasksController(AndromedaDbContext context)
   {
    _context = context;
   }

   [HttpGet]
   [Route("tasks/list")]
   public async Task<ActionResult<IEnumerable<Tasks>>> List()
   {
    if(_context?.Tasks is null)
        return NotFound();
    return await _context.Tasks.ToListAsync();
   }

   [HttpGet()]
   [Route("tasks/find/{id}")]
   public async Task<ActionResult<Tasks>> Find([FromRoute] string id){
    if(_context?.Tasks is null)
        return NotFound();
    var tasks = await _context.Tasks.FindAsync(id);
    if(tasks is null)
        return NotFound();
    return tasks;
   }

   [HttpPost]
   [Route("tasks/create")]
   public IActionResult Create(Tasks tasks){
    _context?.Add(tasks);
    _context?.SaveChanges();
    return Created("", tasks);
   }
}