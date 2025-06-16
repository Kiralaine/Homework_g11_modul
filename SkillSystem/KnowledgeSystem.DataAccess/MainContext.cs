using Microsoft.EntityFrameworkCore;
using KnowledgeSystem.DataAccess.Configurations;
using KnowledgeSystem.DataAccess.Entities;

namespace KnowledgeSystem.DataAccess;

public class MainContext : DbContext
{
    public DbSet<Employee> Employees { get; set; }
    public DbSet<Knowledge> Knowledge { get; set; }
    public MainContext(DbContextOptions<MainContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfiguration(new KnowledgeConfigurations());
        modelBuilder.ApplyConfiguration(new EmployeeConfigurations());
    }
}
