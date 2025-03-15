using EncapsulamentoVeiculo;
internal class Program
{
    private static void Main(string[] args)
    {
        Veiculo v1 = new Veiculo();
        v1.Ano = 1899;
        v1.Marca = "ford";
        v1.Modelo = "CAMARO";
        v1.RdgistrarQuilometragem(333.33);
        Console.WriteLine("Exibindo Detalhes");
        v1.ExibirDetalhes();
    }
}