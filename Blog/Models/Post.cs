namespace Blog.Models;

public class Post : ModelBase
{
    public int AuthorId { get; set; }

    public string Body { get; set; } = string.Empty;
    public int CategoryId { get; set; }

    public DateTime CreateDate { get; set; }

    public DateTime LastUpdateDate { get; set; }

    public string Slug { get; set; } = string.Empty;

    public string Summary { get; set; } = string.Empty;

    public string Title { get; set; } = string.Empty;
}
