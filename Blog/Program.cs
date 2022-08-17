using Blog.Data;
using Blog.Models;

using var context = new BlogDataContext();

var tag = context.Tags.FirstOrDefault(tag => tag.Id == 2);

context.Remove(tag);
context.SaveChanges();
