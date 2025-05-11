using AbstrataCliente;

ClienteFisico cli1 = new ClienteFisico();
cli1.Codigo =1;
cli1.Nome ="Rodrigo";
cli1.Rg =1234;
cli1.Mostrar();

ClienteJuridico cli2 = new ClienteJuridico();
cli2.Codigo = 2;
cli2.Nome ="Joao";
cli2.Cnpj =4321;
cli2.Mostrar();
cli2.Idade =42;
cli2.VerificaIdade();

ClienteFisico cli3 = new ClienteFisico();
cli3.Cadastrar(3,"Marcos",12321);
cli3.Mostrar();
cli3.Idade = 20;
cli3.VerificaIdade();

ClienteFisico cli4 = new ClienteFisico();
cli4.Cadastrar(4,"Fernanda",4534);
cli4.Mostrar();

Teste t = new Teste();
t.AvaliarIdade(cli2);
t.AvaliarIdade(cli3);
