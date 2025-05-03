using AtividadePolimorfismo;

// Secretarios
Secretario secretario = new Secretario(1,"Joao",3000);
Secretario secretario2 = new Secretario(6,"Joana",3000);
Secretario secretario3 = new Secretario(7,"Marcela",3000);
// Gerentes
Gerente gerente = new Gerente(2,"Carlos",3000);
Gerente gerente2 = new Gerente(8,"Linda",3000);
Gerente gerente3 = new Gerente(9,"Marcia",3000);
// Diretores
Diretor diretor = new Diretor(3,"Marcos",3000);
Diretor diretor2 = new Diretor(4,"Joao",3000);
Diretor diretor3 = new Diretor(5,"Carlos",3000);

GerenciadorBonificacao gerenciar = new GerenciadorBonificacao();
gerenciar.TotalizadorBonificacao(diretor);
gerenciar.TotalizadorBonificacao(diretor2);

gerenciar.TotalizadorBonificacao(gerente2);
gerenciar.TotalizadorBonificacao(gerente);

// Exiber Resultados
System.Console.WriteLine("Total Bonificação dos diretores: R$ " + gerenciar.TotalBonificacao);

