using AbstratoFuncionario;

// Criando funcionarios
Assalariado assalariado1 = new Assalariado(1, "Ana", 1000);
Assalariado assalariado2 = new Assalariado(2, "Bia", 1000);
Comissionado comissionado1 = new Comissionado(3, "Bel", 1000, 20);
Comissionado comissionado2 = new Comissionado(4, "Lia", 1000, 30);

// Criando departamentos
Departamento ti = new Departamento(10, "TI");
ti.VetF = new List<Funcionario>();
Departamento rh = new Departamento(11, "RH");
rh.VetF = new List<Funcionario>();

// Admitindo Funcionários aos departamentos
ti.Admitir(assalariado1);// Admitindo em TI
ti.Admitir(comissionado1);
rh.Admitir(assalariado2);// Admitindo em RH
rh.Admitir(comissionado2);
ti.Demitir(1); // quando demiti, aparece os dependentes por funcionario, 
// mas por departamento nao, porque o funcionario é exluido da list de funcionarios do departamento 

// Criando Dependentes
Dependente filho1 = new Dependente(1, "Joazinho", 14);
Dependente filho2 = new Dependente(1, "Betinho", 17);
Dependente filho3 = new Dependente(3, "Mariazinha", 18);
Dependente filho4 = new Dependente(4, "Joaninha", 15);
Dependente filho5 = new Dependente(5, "Rodriguinho", 18);

// Adicionandp Dependentes 
comissionado1.AdicionarDependentes(filho1);
assalariado1.AdicionarDependentes(filho2);
comissionado2.AdicionarDependentes(filho3);
assalariado1.AdicionarDependentes(filho4);
assalariado2.AdicionarDependentes(filho5);

//Removendo filho 5
assalariado2.RemoverDependentesMaioridade(5); // codigo 5


// Exibindo Lista de Funcionarios por departamento
ti.ListarFuncionarios();
rh.ListarFuncionarios();

// Exibindo Lista de dependentes por Funcionário
assalariado1.ListarDependentes();
assalariado2.ListarDependentes();
comissionado1.ListarDependentes();
comissionado2.ListarDependentes();

// Mostando total de dependentes por funcionario
Console.WriteLine($"Total de Dependentes Funcionário: {comissionado1.Nome} Total: {comissionado1.CalcularTotalDependentes()}");
Console.WriteLine($"Total de Dependentes Funcionário: {assalariado1.Nome} Total: {assalariado1.CalcularTotalDependentes()}");
Console.WriteLine($"Total de Dependentes Funcionário: {comissionado2.Nome} Total: {comissionado2.CalcularTotalDependentes()}");
Console.WriteLine($"Total de Dependentes Funcionário: {assalariado2.Nome} Total: {assalariado2.CalcularTotalDependentes()}");

// Mostrando total de dependentes por departamento
ti.MostrarQuantDependentes();
rh.MostrarQuantDependentes();

// Mostrando calculo de folha DE PAGAMENTO
System.Console.WriteLine($"Total folha pagamentos departamento:{ti.Nome} -- {ti.CalcularFolha(30):c}");
System.Console.WriteLine($"Total folha pagamentos departamento:{rh.Nome} --  {rh.CalcularFolha(30):c}");





