using System.ComponentModel.DataAnnotations.Schema;

namespace Blog.Models;

[Table(nameof(Category))]
public class Category : ModelBase
{
    public string Slug { get; set; }

    public string Title { get; set; }
}
