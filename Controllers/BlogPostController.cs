using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using andromeda.Data;
using andromeda.Models;
namespace andromeda.Controllers;

[ApiController]
[Route("andromeda/kanban")]
public class BlogPostController : ControllerBase
{
   private AndromedaDbContext? _context;

   public BlogPostController(AndromedaDbContext context)
   {
    _context = context;
   }

   [HttpGet]
   [Route("blogpost/list")]
   public async Task<ActionResult<IEnumerable<BlogPost>>> List()
   {
    if(_context?.BlogPosts is null)
        return NotFound();
    return await _context.BlogPosts.ToListAsync();
   }

   [HttpGet()]
   [Route("blogpost/find/{id}")]
   public async Task<ActionResult<BlogPost>> Find([FromRoute] string id){
    if(_context?.BlogPosts is null)
        return NotFound();
    var blogPost = await _context.BlogPosts.FindAsync(id);
    if(blogPost is null)
        return NotFound();
    return blogPost;
   }

   [HttpPost]
   [Route("blogpost/create")]
   public IActionResult Create(BlogPost blogPost){
    _context?.Add(blogPost);
    _context?.SaveChanges();
    return Created("", blogPost);
   }
}

[ApiController]
[Route("andromeda/kanban")]
public class CategoryController : ControllerBase
{
   private AndromedaDbContext? _context;

   public CategoryController(AndromedaDbContext context)
   {
    _context = context;
   }

   [HttpGet]
   [Route("category/list")]
   public async Task<ActionResult<IEnumerable<Category>>> List()
   {
    if(_context?.Categories is null)
        return NotFound();
    return await _context.Categories.ToListAsync();
   }

   [HttpGet()]
   [Route("category/find/{id}")]
   public async Task<ActionResult<Category>> Find([FromRoute] string id){
    if(_context?.Categories is null)
        return NotFound();
    var category = await _context.Categories.FindAsync(id);
    if(category is null)
        return NotFound();
    return category;
   }

   [HttpPost]
   [Route("category/create")]
   public IActionResult Create(Category category){
    _context?.Add(category);
    _context?.SaveChanges();
    return Created("", category);
   }
}

