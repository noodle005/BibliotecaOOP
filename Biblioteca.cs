public class Biblioteca
{
    private List<Livro> Livros { get; set; } = new List<Livro>();
    private List<Usuario> Usuarios { get; set; } = new List<Usuario>();
    //Lista de livros e de usuários, respectivamente
    public void CadastrarLivro(Livro livro)
    {
        Livros.Add(livro);
        Console.WriteLine($"Livro '{livro.Titulo}' cadastrado com sucesso.");
    }
    //Cadastra o livro

    public void CadastrarUsuario(Usuario usuario)
    {
        Usuarios.Add(usuario);
        Console.WriteLine($"Usuário '{usuario.Nome}' cadastrado com sucesso.");
    }
    //Cadastra o usuário

    public void ListarLivros()
    {
        foreach (var livro in Livros)
        {
            Console.WriteLine($"Código: {livro.Codigo}, Título: {livro.Titulo}, Autor: {livro.Autor}, Gênero: {livro.Genero}, Disponível: {livro.QuantidadeEmEstoque}");
        }
    }
    //Lista os livros

    public void ListarUsuarios()
    {
        foreach (var usuario in Usuarios)
        {
            usuario.ExibirInformacoes();
        }
    }
    //Lista os usuários

    public void EmprestarLivro(string codigoLivro, string numeroUsuario)
    {
        var livro = Livros.FirstOrDefault(l => l.Codigo == codigoLivro);
        var usuario = Usuarios.FirstOrDefault(u => u.NumeroIdentificacao == numeroUsuario);

        if (livro != null && usuario != null)
        {
            livro.Emprestar(usuario);
        }
        else
        {
            Console.WriteLine("Impossível realizar empréstimo, verifique se o usuário ou o livro estão cadastrados.");
        }
    }
    //Empresta o livro, buscando ele e o usuário por seus códigos

    public void DevolverLivro(string codigoLivro)
    {
        var livro = Livros.FirstOrDefault(l => l.Codigo == codigoLivro);

        if (livro != null)
        {
            livro.Devolver();
        }
        else
        {
            Console.WriteLine("O livro não pôde ser encontrado.");
        }
    }
    //Busca livro pelo código e devolve o mesmo
    public void AtualizarUsuario(string numeroIdentificacao, string novoNome, string novoEndereco, string novoContato)
    {
        var usuario = Usuarios.FirstOrDefault(u => u.NumeroIdentificacao == numeroIdentificacao);
        if (usuario != null)
        {
            usuario.AtualizarInformacoes(novoNome, novoEndereco, novoContato);
            Console.WriteLine("Informações do usuário atualizadas com sucesso.");
        }
        else
        {
            Console.WriteLine("Usuário não encontrado.");
        }
    }
    //Atualiza informações do usuário baseado no número de identificação
}
