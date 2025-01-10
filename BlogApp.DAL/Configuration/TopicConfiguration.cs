using BlogApp.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class TopicConfiguration : IEntityTypeConfiguration<Topic>
{
    public void Configure(EntityTypeBuilder<Topic> builder)
    {
        builder.Property(t => t.Name)
               .IsRequired()
               .HasMaxLength(50);

        builder.HasMany(t => t.Assignments)
               .WithOne(a => a.Topic)
               .HasForeignKey(a => a.TopicId);
    }
}
