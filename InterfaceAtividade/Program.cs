using InterfaceAtividade;
// Instanciados 2 contas
ContaCorrente conta1 = new ContaCorrente();
conta1.Saldo = 1500;
ContaCorrente conta2 = new ContaCorrente();
conta2.Saldo = 2000;

// Intanciados 2 Seguros de Vida
SeguroVida seguro1 = new SeguroVida();
SeguroVida seguro2 = new SeguroVida();

// instanciado 2 totalizador 1 para contas e outro para seguros
TotalizadorDeTributos tribContas = new TotalizadorDeTributos();
TotalizadorDeTributos tribSeguros = new TotalizadorDeTributos();

// Adicionando contas e seguros ao Totalizador
tribContas.Adiciona(conta1);
tribContas.Adiciona(conta2);
tribSeguros.Adiciona(seguro1);
tribSeguros.Adiciona(seguro2);
Console.WriteLine("Total de Atributos das Contas: " + tribContas.Total);
Console.WriteLine("Total de Atributos dos Seguros: " + tribSeguros.Total);


