public abstract class ItemBiblioteca : IEmprestavel //ItemBiblioteca é abstrata então não vai ser instanciada diretamente
//Herda de IEmprestavel, porque assim vai ser possível realizar os métodos de empréstimo
{
    public string? Titulo { get; set; } //Serve pra armazenar o título do livro
    public string? Codigo { get; set; } //Serve pra armazenar o código do livro

    public abstract void Emprestar(Usuario usuario); //Método pra realizar o empréstimo
    public abstract void Devolver(); // Método pra ser feito a devolução
}