public class Usuario
{
    public string Nome { get; private set; }
    public string NumeroIdentificacao { get; private set; }
    public string Endereco { get; private set; }
    public string Contato { get; private set; }
    public List<string> HistoricoEmprestimos { get; private set; }

    //Contém as informações do usuário. HistoricoEmprestimos deixa armazenado o histórico dos empréstimos
    public Usuario(string nome, string numeroIdentificacao, string endereco, string contato)
    {
        Nome = nome;
        NumeroIdentificacao = numeroIdentificacao;
        Endereco = endereco;
        Contato = contato;
        HistoricoEmprestimos = new List<string>();
    }
    //Inicializa as propriedades

    public void AtualizarInformacoes(string nome, string endereco, string contato)
    {
        Nome = nome;
        Endereco = endereco;
        Contato = contato;
    }
    //Atualiza informações do usuário
    
    public void ExibirHistorico()
    {
        Console.WriteLine($"Histórico de Empréstimos de {Nome}:");
        foreach (var emprestimo in HistoricoEmprestimos)
        {
            Console.WriteLine(emprestimo);
        }
    }
    //Mostra histórico de empréstimos do usuário
    public void ExibirInformacoes()
    {
        Console.WriteLine($"Nome: {Nome}, ID: {NumeroIdentificacao}, Endereço: {Endereco}, Contato: {Contato}");
    }
    //Mostra informações do usuário
}