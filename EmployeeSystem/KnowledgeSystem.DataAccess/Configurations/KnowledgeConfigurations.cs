using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using KnowledgeSystem.DataAccess.Entities;

namespace KnowledgeSystem.DataAccess.Configurations;

public class KnowledgeConfigurations : IEntityTypeConfiguration<Knowledge>
{
    public void Configure(EntityTypeBuilder<Knowledge> builder)
    {
        builder.ToTable("Knowledge");
        builder.HasKey(u => u.KnowledgeId);

        builder.Property(u => u.Type).IsRequired().HasMaxLength(50);
        builder.Property(u => u.Name).IsRequired().HasMaxLength(50);
        builder.Property(u => u.Description).IsRequired(false).HasMaxLength(250);
    }
}
