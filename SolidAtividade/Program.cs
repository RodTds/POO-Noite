using SolidAtividade;

Conta conta1 = new Conta("Rodrigo",300);// Criei a Conta
conta1.Deposito(400);// depositei
conta1.Sacar(233);// saquei

GeradorRelatorios relatorio1 = new GeradorRelatorios();// Criei um objeto relatiorio
ValidadorUsuarios validar = new ValidadorUsuarios(); // criei um objeto validar

Console.Write("Digite O nome para o relatório: ");
string nome = Console.ReadLine();
if (validar.ValidarUsuario(nome,conta1))
    Console.WriteLine(relatorio1.GerarRelatorio(conta1)); // A função poderia ser um Void na classe GeradorRelatorios
else
    Console.WriteLine("Usuario invalido");



