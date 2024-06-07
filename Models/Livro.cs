namespace livraria.Models
{
    public class Livro
    {
        public int LivroId { get; set; }
        public string Titulo { get; set; }
        public int AnoPublicacao { get; set; }
        public int AutorId { get; set; }
        public Autor Autor { get; set; }
    }
}
