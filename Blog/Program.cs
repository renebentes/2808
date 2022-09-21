using Blog.Data;
using Microsoft.EntityFrameworkCore;

using var context = new BlogDataContext();

var tags = context
    .Tags
    // Desabilita metadados de traqueamento (referências entre os objetos)
    // Usar somente em modo de leitura, nunca com operações de escrita
    .AsNoTracking()
    .ToList();

foreach (var tag in tags)
{
    Console.WriteLine(tag.Name);
}
