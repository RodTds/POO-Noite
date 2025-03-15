using EncapsulamentoEstudante;
internal class Program
{
    private static void Main(string[] args)
    {
        Estudante aluno1 = new Estudante();
        aluno1.Nome = "Rodrigo";
        aluno1.Nota = 6;
        aluno1.ExibirDetalhes();

        Estudante aluno2 = new Estudante();
        aluno2.Nome = "Maria";
        aluno2.Nota = 5.9;
        aluno2.ExibirDetalhes();

        Estudante aluno3 = new Estudante();
        aluno3.Nome = "Joao";
        aluno3.Nota = 11;
        aluno3.ExibirDetalhes();
        
    }
}