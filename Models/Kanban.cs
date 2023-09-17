using System.ComponentModel.DataAnnotations;
namespace andromeda.Models;

public class Coluna
{
    [Key]
    public int Id { get; set; }
    public string? Title { get; set; }
    public List<TaskList> TaskList { get; set; } = new List<TaskList>();
}

public class TaskList
{
    [Key]
    public int Id { get; set; }
    public string? Title { get; set; }
    public List<Tasks> Tarefas { get; set; } = new List<Tasks>();
}

public class Tasks
{
    [Key]
    public int Id { get; set; }
    public string? Title { get; set; }
    public string? Description { get; set; }
    public User? User { get; set; }
    public DateTime Data { get; set; }
    public string? Tag { get; set; }
    public Category? Category { get; set; }
    public User? CreatedBy { get; set; }
    public TaskList? TaskList { get; set; }
}