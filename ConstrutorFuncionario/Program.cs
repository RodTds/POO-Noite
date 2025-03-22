// See https://aka.ms/new-console-template for more information
using ConstrutorFuncionario;

Funcionario f1 = new Funcionario();
f1.ExibirDetalhes();

Funcionario f2 = new Funcionario(20);
f2.ExibirDetalhes();

Funcionario f3 = new Funcionario(21,"Rodrigo", 4500);
f3.ExibirDetalhes();

System.Console.WriteLine(Funcionario.Contador);

