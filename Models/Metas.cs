using System.ComponentModel.DataAnnotations;
namespace andromeda.Models;

public class FinancialGoal
{
    [Key]
    public int Id { get; set; }
    public decimal Value { get; set; }
    public string? Name { get; set; }
    public DateTime CreatedOn { get; set; }
    public DateTime ExpectedCompletionDate { get; set; }
    public GoalStatus Status { get; set; }
}

public class Wish
{
    [Key]
    public int Id { get; set; }
    public string? Name { get; set; }
    public WishStatus Status { get; set; }
    public DateTime CreatedOn { get; set; }
}

public enum GoalStatus
{
    InProgress,
    Completed,
    Canceled
}

public enum WishStatus
{
    Pending,
    Fulfilled,
    Canceled
}
