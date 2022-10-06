using Blog.Data;
using Microsoft.EntityFrameworkCore;

using var context = new BlogDataContext();

var post = context
    .Posts
    .Include(p => p.Author)
    .Include(p => p.Category)
    .OrderByDescending(p => p.LastUpdateDate)
    .FirstOrDefault();

post.Author.Name = "Teste";

context.Update(post);
context.SaveChanges();
