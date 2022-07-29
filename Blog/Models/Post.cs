namespace Blog.Models;

public class Post : ModelBase
{
    public int AuthorId { get; set; }

    public string Body { get; set; }

    public int CategoryId { get; set; }

    public DateTime CreateDate { get; set; }

    public DateTime LastUpdateDate { get; set; }

    public string Slug { get; set; }

    public string Summary { get; set; }

    public string Title { get; set; }
}