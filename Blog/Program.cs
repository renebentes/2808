using Blog.Data;
using Microsoft.EntityFrameworkCore;

using var context = new BlogDataContext();

var posts = context
    .Posts
    .AsNoTracking()
    // Efetua o JOIN
    .Include(p => p.Author)
    .Include(p => p.Category)
    .OrderByDescending(p => p.LastUpdateDate)
    .ToList();

foreach (var post in posts)
{
    Console.WriteLine($"{post.Title} escrito por {post.Author?.Name}");
}
