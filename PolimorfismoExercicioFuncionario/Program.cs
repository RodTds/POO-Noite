using PolimorfismoExercicioFuncionario;
Secretario secretario = new Secretario(1,"Joao",3000);
Gerente gerente = new Gerente(2,"Carlos",3000);
Diretor diretor = new Diretor(3,"Marcos",3000);

Console.WriteLine($"Bonificação do secretário:  {secretario.CalcularBonificacao():c}");
Console.WriteLine($"Bonificação do gerente:  {gerente.CalcularBonificacao():c}");
Console.WriteLine($"Bonificação do diretor:  {diretor.CalcularBonificacao():c}");
