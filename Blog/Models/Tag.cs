using System.ComponentModel.DataAnnotations.Schema;

namespace Blog.Models;

[Table("Tag")]
public class Tag : ModelBase
{
    public string Name { get; set; } = string.Empty;

    public string Slug { get; set; } = string.Empty;
}
