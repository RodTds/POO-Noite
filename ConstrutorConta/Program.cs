using ConstrutorConta;
internal class Program
{
    private static void Main(string[] args)
    {
        Conta c1 = new Conta(); // Contrututor inicializa os atributos do Objeto
        c1.ExibirDetalhes();
        
        Conta c2 = new Conta(2);
        c2.ExibirDetalhes();

        Conta c3 = new Conta(3,"Rodrigo");
        c3.Saldo = 20000;
        c3.ExibirDetalhes();

        System.Console.WriteLine("Quantoidade" + Conta.Contador);


    }
}