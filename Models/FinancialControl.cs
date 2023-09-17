using System.ComponentModel.DataAnnotations;
namespace andromeda.Models;

public class Transaction
{
    [Key]
    public int Id { get; set; }
    public decimal Amount { get; set; }
    public TransactionType Type { get; set; }
    public string? Name { get; set; }
    public DateTime Date { get; set; }
}

public enum TransactionType
{
    Income,
    Expense
}