using ClasseFuncionario;

internal class Program
{
    private static void Main(string[] args)
    {
        Funcionario funcionario = new Funcionario();
        funcionario.codigo = 1;
        funcionario.nome ="Rodrigo";
        funcionario.salario = 2500;
        funcionario.CalcularAumento(10);
        funcionario.Mostrar();
    }
}