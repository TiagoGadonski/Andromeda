using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using andromeda.Data;
using andromeda.Models;
namespace andromeda.Controllers;

[ApiController]
[Route("andromeda/texteditor")]
public class TextEditorController : ControllerBase
{
   private AndromedaDbContext? _context;

   public TextEditorController(AndromedaDbContext context)
   {
    _context = context;
   }

   [HttpGet]
   [Route("list/text")]
   public async Task<ActionResult<IEnumerable<TextEditor>>> List()
   {
    if(_context?.TextEditors is null)
        return NotFound();
    return await _context.TextEditors.ToListAsync();
   }

   [HttpGet()]
   [Route("find/text/{id}")]
   public async Task<ActionResult<TextEditor>> Find([FromRoute] string id){
    if(_context?.TextEditors is null)
        return NotFound();
    var texteditor = await _context.TextEditors.FindAsync(id);
    if(texteditor is null)
        return NotFound();
    return texteditor;
   }

   [HttpPost]
   [Route("create/text")]
   public IActionResult Create(TextEditor textEditor){
    _context?.Add(textEditor);
    _context?.SaveChanges();
    return Created("", textEditor);
   }
}

[ApiController]
[Route("andromeda/texteditor")]
public class TagController : ControllerBase
{
   private AndromedaDbContext? _context;

   public TagController(AndromedaDbContext context)
   {
    _context = context;
   }

   [HttpGet]
   [Route("list/tags")]
   public async Task<ActionResult<IEnumerable<Tag>>> List()
   {
    if(_context?.Tags is null)
        return NotFound();
    return await _context.Tags.ToListAsync();
   }

   [HttpGet()]
   [Route("find/tags/{id}")]
   public async Task<ActionResult<Tag>> Find([FromRoute] string id){
    if(_context?.Tags is null)
        return NotFound();
    var tag = await _context.Tags.FindAsync(id);
    if(tag is null)
        return NotFound();
    return tag;
   }

   [HttpPost]
   [Route("create/tags")]
   public IActionResult Create(Tag tag){
    _context?.Add(tag);
    _context?.SaveChanges();
    return Created("", tag);
   }
}
