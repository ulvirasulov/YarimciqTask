using BlogApp.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class AssignmentConfiguration : IEntityTypeConfiguration<Assignment>
{
    public void Configure(EntityTypeBuilder<Assignment> builder)
    {
        builder.Property(a => a.Name)
               .IsRequired()
               .HasMaxLength(200);

        builder.Property(a => a.FinishTime)
               .IsRequired();

        builder.HasOne(a => a.Topic)
               .WithMany(t => t.Assignments)
               .HasForeignKey(a => a.TopicId);

        builder.HasOne(a => a.Tag)
               .WithMany(t => t.Assignments)
               .HasForeignKey(a => a.TagId);

        builder.HasOne(a => a.Employee)
               .WithMany(e => e.Assignments)
               .HasForeignKey(a => a.EmployeeId);
    }
}
