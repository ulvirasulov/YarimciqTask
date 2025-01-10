using BlogApp.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class TagConfiguration : IEntityTypeConfiguration<Tag>
{
    public void Configure(EntityTypeBuilder<Tag> builder)
    {
        builder.Property(t => t.Name)
               .IsRequired()
               .HasMaxLength(50);

        builder.HasMany(t => t.Assignments)
               .WithOne(a => a.Tag)
               .HasForeignKey(a => a.TagId);
    }
}
