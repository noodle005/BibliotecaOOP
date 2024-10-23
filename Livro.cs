public class Livro : ItemBiblioteca, IPesquisavel
//Livro herda de ItemBiblioteca e pega os métodos de IPesquisavel
{
    public string Autor { get; set; }
    public string ISBN { get; set; }
    public string Genero { get; set; }
    public int QuantidadeEmEstoque { get; set; }
    //Propriedades pra definir restante das informações dos livros

    private List<string> HistoricoEmprestimos { get; set; } = new List<string>();
    //Lista privada, armazena o registro dos livros emprestados
    public Livro(string codigo, string titulo, string autor, string isbn, string genero, int quantidadeEmEstoque)
    {
        Codigo = codigo;
        Titulo = titulo;
        Autor = autor;
        ISBN = isbn;
        Genero = genero;
        QuantidadeEmEstoque = quantidadeEmEstoque;
    }
    //Inicializam as propriedades do livro de acordo com os valores fornecidos
    public override void Emprestar(Usuario usuario)
    {
        if (QuantidadeEmEstoque > 0)
        {
            QuantidadeEmEstoque--;
            string registro = $"Livro: {Titulo}, Emprestado para: {usuario.Nome}, Data: {DateTime.Now}";
            HistoricoEmprestimos.Add(registro); //Adiciona ao histórico do livro
            usuario.HistoricoEmprestimos.Add(registro); //Adiciona ao histórico do usuário
            Console.WriteLine($"Livro {Titulo} emprestado para {usuario.Nome}.");
        }
        else
        {
            Console.WriteLine("Não há exemplares disponíveis.");
        }
    }
    //Realiza o empréstimo, verifica se tem livro disponível no histórico, registra no histórico e diminui a quantidade em estoque.

    public override void Devolver()
    {
        QuantidadeEmEstoque++;
        Console.WriteLine($"Livro '{Titulo}' devolvido com sucesso.");
    }
    //Devolve o livro, aumenta a quantidade no estoque.

    public void ExibirHistorico()
    {
        Console.WriteLine($"Histórico de Empréstimos do livro '{Titulo}':");
        foreach (var emprestimo in HistoricoEmprestimos)
        {
            Console.WriteLine(emprestimo);
        }
    }
    //Serve pra exibir o histórico de empréstimo do livro
    public List<Livro> PesquisarPorTitulo(string titulo)
    {
        return new List<Livro> { this }.Where(l => (l.Titulo ?? "").Contains(titulo, StringComparison.OrdinalIgnoreCase)).ToList();
    }

    public List<Livro> PesquisarPorAutor(string autor)
    {
        return new List<Livro> { this }.Where(l => l.Autor.Contains(autor, StringComparison.OrdinalIgnoreCase)).ToList();
    }

    public List<Livro> PesquisarPorGenero(string genero)
    {
        return new List<Livro> { this }.Where(l => l.Genero.Contains(genero, StringComparison.OrdinalIgnoreCase)).ToList();
    }
    //Métodos de pesquisa dos livros
}