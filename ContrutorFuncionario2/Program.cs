// See https://aka.ms/new-console-template for more information
using ContrutorFuncionario2;

Funcionario f1 = new Funcionario("Rodrigo",3500);
f1.ExibirDetalhes();
Funcionario f2 = new Funcionario("Joao",2333);
f2.ExibirDetalhes();
System.Console.WriteLine("Quantidade de Funcionarios: " + Funcionario.Contador);

