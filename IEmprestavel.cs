public interface IEmprestavel
{
    void Emprestar(Usuario usuario); //Método que deve ser implementado pela classe que herdar
    // desta, recebe o objeto Usuario como parâmetro e aí realiza a ação do empréstimo
    void Devolver(); //Método que tem que ser implementado pra permitir devolução do livro
}
