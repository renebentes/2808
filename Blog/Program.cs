using Blog.Data;
using Blog.Models;

using var context = new BlogDataContext();

var user = context.Users.FirstOrDefault();
var post = new Post
{
    Author = user,
    Title = "Novo post",
    Summary = "Novo post sobre ASP.NET",
    Body = "Post sobre ASP.NET",
    Category = new Category { Title = "Backend", Slug = "backend" },
    CreateDate = DateTime.UtcNow,
    Slug = "novo-post"
};

context.Posts.Add(post);
context.SaveChanges();
