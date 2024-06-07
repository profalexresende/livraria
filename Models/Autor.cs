namespace livraria.Models
{
    public class Autor
    {
        public int AutorId { get; set; }
        public string Nome { get; set; }
        public string Nacionalidade { get; set; }
        public ICollection<Livro> Livros { get; set; }
    }
}
