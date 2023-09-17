using System.ComponentModel.DataAnnotations;
namespace andromeda.Models;

public class BlogPost{
  [Key]
  public int? Id{get; set;}
  public string? Title { get; set; }
  public string? Text { get; set; }
  
  public User? Author { get; set; }
  public string? Description { get; set; }
  public DateTime CreatedDate { get; set; }
  public Category? Category {get; set;} 
}

public class Category
{
  [Key]
  public int Id { get; set; }
  
  public string? Name { get; set; }
  
  
  
}