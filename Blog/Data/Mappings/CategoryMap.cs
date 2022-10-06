using Blog.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Blog.Data.Mappings;

public class CategoryMap : IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> builder)
    {
        builder.ToTable(nameof(Category));

        // Define a chave primária
        builder.HasKey(c => c.Id);

        // Define que será usado IDENTITY(1, 1) para geração
        // automática da chave
        builder.Property(c => c.Id)
            .ValueGeneratedOnAdd()
            .UseIdentityColumn();
    }
}
