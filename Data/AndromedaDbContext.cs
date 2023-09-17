using Microsoft.EntityFrameworkCore;
using andromeda.Models;
namespace andromeda.Data;
public class AndromedaDbContext : DbContext
{
    public DbSet<BlogPost>? BlogPosts { get; set; }
    public DbSet<Category>? Categories { get; set; }
    public DbSet<Transaction>? Transactions { get; set; }
    public DbSet<Coluna>? Colunas { get; set; }
    public DbSet<TaskList>? TaskLists { get; set; }
    public DbSet<Tasks>? Tasks { get; set; }
    public DbSet<FinancialGoal>? FinancialGoals { get; set; }
    public DbSet<Wish>? Wishes { get; set; }
    public DbSet<TextEditor>? TextEditors { get; set; }
    public DbSet<Tag>? Tags { get; set; }
    public DbSet<User>? Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseSqlite("DataSource=andromeda.db;Cache=Shared;");
    }
}