using livraria.Models;
using Microsoft.EntityFrameworkCore;

namespace livraria.Data
{
    public class BibliotecaContext:DbContext
    {
        public BibliotecaContext(DbContextOptions<BibliotecaContext> options) : base(options) { }

        public DbSet<Autor> Autores { get; set; }
        public DbSet<Livro> Livros { get; set; }
    }
}
