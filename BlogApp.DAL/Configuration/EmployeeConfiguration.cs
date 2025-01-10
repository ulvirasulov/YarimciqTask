using BlogApp.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
{
    public void Configure(EntityTypeBuilder<Employee> builder)
    {
        builder.Property(e => e.Fullname)
               .IsRequired()
               .HasMaxLength(200);

        builder.HasMany(e => e.Assignments)
               .WithOne(a => a.Employee)
               .HasForeignKey(a => a.EmployeeId);
    }
}
