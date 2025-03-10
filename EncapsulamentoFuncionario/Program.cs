using EncapsulamentoFuncionario;

internal class Program
{
    private static void Main(string[] args)
    {
        Funcionario f1 = new Funcionario();
        // utilizacao dos atributos encapsulados

        // metodo set chamado
        
        Console.WriteLine("Digite o código do funcionário ");
        f1.Codigo = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite O salario");
        f1.Salario = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Digite o Nome do funcionário ");
        f1.Nome = Console.ReadLine();

         // metodo get chamado
         Console.WriteLine("Exibindo Estado");
         Console.WriteLine("Salario " + f1.Codigo);
         Console.WriteLine("Salario " + f1.Nome);
         Console.WriteLine("Salario " + f1.Salario);

    }
}