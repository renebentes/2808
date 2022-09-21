using Blog.Data;
using Blog.Models;

using var context = new BlogDataContext();

var user = new User
{
    Name = "André Baltieri",
    Slug = "andrebaltieri",
    Email = "andre@balta.io",
    Bio = "9x Microsoft MVP",
    Image = "https://balta.io",
    PasswordHash = "123098457"
};

var category = new Category { Title = "Backend", Slug = "backend" };

var post = new Post
{
    Author = user,
    Category = category,
    Body = "<p>Hello world</p>",
    Slug = "comecando-com-ef-core",
    Summary = "Neste artigo vamos aprender EF core",
    Title = "Começando com EF Core",
    CreateDate = DateTime.Now,
    LastUpdateDate = DateTime.Now,
};

context.Posts.Add(post);
context.SaveChanges();

