namespace Blog.Models;

public class Tag : ModelBase
{
    public string Name { get; set; } = string.Empty;

    public string Slug { get; set; } = string.Empty;
}
