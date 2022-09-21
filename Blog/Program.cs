using Blog.Data;
using Microsoft.EntityFrameworkCore;

using var context = new BlogDataContext();

var tag = context
    .Tags
    .AsNoTracking()
    // First() - Retorna primeiro elemento ou exception quando condição não
    // satisfeita
    // FirstOrDefault() - Retorna primeiro elemento ou null quando condição
    // não satisfeita
    // Single() - Retorna único elemento ou exceção quando condição não
    // satisfeita ou mais de um
    // SingleOrDefault() - Retorna único elemento ou null quando condição
    // não satisfeita ou exception quando mais elements satisfazem a condição
    .SingleOrDefault(it => it.Id == 3);

Console.WriteLine(tag?.Name);
