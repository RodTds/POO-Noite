using HerancaCliente;

Cliente c = new Cliente();
c.Codigo =1;
c.Nome = "Ana";
c.Mostrar();

Cliente cc2 = new Cliente(2,"rodrigo");
cc2.Mostrar();

ClienteFisico cf = new ClienteFisico();
cf.Rg =100;
cf.Codigo =3;
cf.Nome = "Bia";
cf.Mostrar();

Cliente c2 = new Cliente(4,"Ana Lucia");

ClienteFisico cf2 = new ClienteFisico(5,"Beatriz",2000);
cf2.Mostrar();

ClienteJuridico cj = new ClienteJuridico(6,"Joao",4000);
cj.Mostrar();

ClienteJuridico cj2 = new ClienteJuridico();
cj2.Codigo = 7;
cj2.Nome = "Rodrigo";
cj2.Cnpj = 234;
cj2.Mostrar();





