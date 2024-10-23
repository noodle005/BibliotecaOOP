public interface IPesquisavel
{
    List<Livro> PesquisarPorTitulo(string titulo); //Método que deve ser implementado para permitir a pesquisa de livros por título
    List<Livro> PesquisarPorAutor(string autor); //Método que deve ser implementado para permitir a pesquisa de livros por autor, retornando uma lista de livros que correspondem ao autor pesquisado
    List<Livro> PesquisarPorGenero(string genero); //Método que deve ser implementado para permitir a pesquisa de livros por gênero, retornando uma lista de livros que correspondem ao gênero pesquisado.
}