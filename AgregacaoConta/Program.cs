using AgregacaoConta;

Cliente cli = new Cliente("Rodrigo",123);

Conta c1 = new Conta();
c1.Numero = 10001;
c1.Saldo = 50;

// Titular é uma propriedade do atributo da Classe Conta que e do tipo da classe Cliente
// objeto.Atributi recebe um objeto
//aqui efetiva a agrecgacao
c1.Titular = cli;

// Proxima instancia 

//outra forma de agregacao, de ligacao entre duas classes
Conta c2 = new Conta();
c2.Numero = 10100;
c2.Saldo = 100;
c2.Titular = new Cliente();// aqui acontece a agregacao
c2.Titular.Nome = "Joao";
c2.Titular.Rg = 133;


