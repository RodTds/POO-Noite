using InterfaceAutenticavel;

Gerente gerente = new Gerente();
gerente.Senha = 100;

Diretor diretor = new Diretor();
diretor.Senha =200;

Cliente cliente = new Cliente();
cliente.Senha = 300;

// Nao existe     IAutenticavel ia = new IAutenticavel();

IAutenticavel ia = diretor;
ia.Autenticar(200); 


