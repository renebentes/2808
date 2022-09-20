using Blog.Data;

using var context = new BlogDataContext();

var tags = context
    .Tags
    // Filtro antes da execução
    .Where(it => it.Name.Contains(".NET"))
    // Executa a query no banco
    .ToList();

foreach (var tag in tags)
{
    Console.WriteLine(tag.Name);
}
