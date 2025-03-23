using EncapsulamentoPedido;
internal class Program
{
    private static void Main(string[] args)
    {
        Pedido p1 = new Pedido(1);
        p1.AdicionarIem("carro", 1500);
        p1.AdicionarIem("Moto", 3500);
        p1.ExibirDetalhes();

        Pedido p2 = new Pedido(2);
        p2.AdicionarIem("Barco", 1500);
        p2.AdicionarIem("Lancha", 3500);
        p2.ExibirDetalhes();

        p1.AdicionarIem("Barco", 0);
        p1.AdicionarIem("Lancha", 3500);
        p1.ExibirDetalhes();



    }
}