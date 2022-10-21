using Blog.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Blog.Data.Mappings;

public class UserMap : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.ToTable(nameof(User));

        builder.HasKey(u => u.Id);

        builder.Property(u => u.Id)
            .ValueGeneratedOnAdd()
            .UseIdentityColumn();

        builder.Property(u => u.Name)
            .IsRequired()
            .HasColumnType("NVARCHAR")
            .HasMaxLength(80);

        builder.Property(u => u.Email)
            .IsRequired()
            .HasColumnType("VARCHAR")
            .HasMaxLength(200);

        builder.Property(u => u.PasswordHash)
            .IsRequired()
            .HasColumnType("VARCHAR")
            .HasMaxLength(255);

        builder.Property(u => u.Bio)
            .IsRequired()
            .HasColumnType("TEXT");

        builder.Property(u => u.Image)
            .IsRequired()
            .HasColumnType("VARCHAR")
            .HasMaxLength(2000);

        builder.Property(u => u.Slug)
            .IsRequired()
            .HasColumnType("VARCHAR")
            .HasMaxLength(80);

        builder.HasIndex(u => u.Slug, "IX_User_Slug")
            .IsUnique();
    }
}
