public class Program
{
    public static void Main() //Inicia a aplicação
    {
        Biblioteca biblioteca = new Biblioteca(); //Cria nova biblioteca

        //Cadastro de livros
        var livro1 = new Livro("728", "Vingadores: Guerra Civil", "Stuart Moore", "8542804126", "Aventura", 1);
        var livro2 = new Livro("729", "Venom: Protetor Letal", "James R. Tuck", "6555612622", "Aventura", 6);
        biblioteca.CadastrarLivro(livro1);
        biblioteca.CadastrarLivro(livro2);

        //Cadastro de usuários
        var usuario1 = new Usuario("Daiane", "D023", "Rua Batuíra, 343", "(51)99699-5000");
        var usuario2 = new Usuario("Joel", "J020", "Avenida Paraguassú, 4843", "(51)99699-3000");
        biblioteca.CadastrarUsuario(usuario1);
        biblioteca.CadastrarUsuario(usuario2);

        //Listar livros e usuários
        biblioteca.ListarLivros();
        biblioteca.ListarUsuarios();

        //Empréstimo e devolução do livro do Venom para Daiane
        biblioteca.EmprestarLivro("729", "D023");
        biblioteca.DevolverLivro("729");

        //Exibir histórico de empréstimos do usuário1
        usuario1.ExibirHistorico(); 

        //Atualizar informações do usuário Daiane
        biblioteca.AtualizarUsuario("D023", "Daiane Ribeiro", "Rua Ipê, 1648", "(51)99641-3003");
        
        //Listar usuários após atualização
        biblioteca.ListarUsuarios();
        
        //Exibir histórico de empréstimos do livro Venom
        livro2.ExibirHistorico(); 
    }
}