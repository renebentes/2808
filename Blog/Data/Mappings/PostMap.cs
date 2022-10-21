using Blog.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Blog.Data.Mappings;

public class PostMap : IEntityTypeConfiguration<Post>
{
    public void Configure(EntityTypeBuilder<Post> builder)
    {
        builder.ToTable(nameof(Post));

        builder.HasKey(it => it.Id);

        builder.Property(it => it.Id)
            .ValueGeneratedOnAdd()
            .UseIdentityColumn();

        builder.Property(it => it.Title)
           .IsRequired()
           .HasColumnType("VARCHAR")
           .HasMaxLength(160);

        builder.Property(it => it.Summary)
            .IsRequired()
            .HasColumnType("VARCHAR")
            .HasMaxLength(255);

        builder.Property(it => it.Body)
            .IsRequired()
            .HasColumnType("TEXT");

        builder.Property(it => it.Slug)
            .IsRequired()
            .HasColumnType("VARCHAR")
            .HasMaxLength(80);

        builder.HasIndex(it => it.Slug, "IX_Post_Slug")
            .IsUnique();
    }
}
