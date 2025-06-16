using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using KnowledgeSystem.DataAccess.Entities;

namespace KnowledgeSystem.DataAccess.Configurations;

public class EmployeeConfigurations : IEntityTypeConfiguration<Employee>
{
    public void Configure(EntityTypeBuilder<Employee> builder)
    {
        builder.ToTable("Employee");
        builder.HasKey(u => u.EmployeeId);

        builder.Property(u => u.FirstName).IsRequired().HasMaxLength(50);
        builder.Property(u => u.LastName).IsRequired(false).HasMaxLength(50);

        builder.HasMany(u => u.Knowledge)
            .WithOne(s => s.Employee)
            .HasForeignKey(s => s.EmployeeId);
    }
}
