internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Digite Ano de nascimento");
        
        int ano_nasc = Convert.ToInt32(Console.ReadLine());
        int idade = 2025 - ano_nasc;
        Console.WriteLine($"A idade é: {idade}");
    }
}