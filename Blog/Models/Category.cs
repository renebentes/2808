namespace Blog.Models;

public class Category : ModelBase
{
    public string Slug { get; set; } = string.Empty;

    public string Title { get; set; } = string.Empty;
}
