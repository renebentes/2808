using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blog.Models;

[Table(nameof(Category))]
public class Category : ModelBase
{
    [Required]
    [MinLength(3)]
    [MaxLength(80)]
    [Column(nameof(Slug), TypeName = "VARCHAR")]
    public string Slug { get; set; }

    [Required]
    [MinLength(3)]
    [MaxLength(80)]
    [Column(nameof(Title), TypeName = "NVARCHAR")]
    public string Title { get; set; }
}
