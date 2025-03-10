using EncapsulamentoProduto;
internal class Program
{
    private static void Main(string[] args)
    {
        // tipo
        // classe  objeto  alocação de memoria    contrutor
        Produto     p1 =    new Produto();
        p1.Codigo = 101;
        p1.Nome = "Caramelo";
        p1.Preco= 4.5;

        Produto p2 = new Produto();
        p2.Codigo = 102;
        p2.Nome = "teclado";
        p2.Preco = 55.91;
        Console.WriteLine("Nome do Produto " +p1.Nome + "Codigo ");




    }
}
