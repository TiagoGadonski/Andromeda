using System.ComponentModel.DataAnnotations;
namespace andromeda.Models;

public class TextEditor{
  [Key]
  public int Id { get; set; }
  public string? Title { get; set; }
  public string? Text { get; set; }
  public User? Author { get; set; }
  public DateTime Date { get; set; }
  public DateTime EditedAt { get; set; }
  public List<Tag>? Tags { get; set; }
}

public class Tag
{
  [Key]
  public int Id { get; set; }
  
  public string? Name { get; set; }
  
}