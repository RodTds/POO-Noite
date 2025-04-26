using HerancaCliente;

Cliente c = new Cliente();
c.Codigo =1;
c.Nome = "Ana";
c.Mostrar();

ClienteFisico cf = new ClienteFisico();
cf.Rg =100;
cf.Codigo =2;
cf.Nome = "Bia";
cf.Mostrar();

Cliente c2 = new Cliente(10,"Ana Lucia");

ClienteFisico cf2 = new ClienteFisico(20,"Beatriz",2000);
cf2.Mostrar();

ClienteJuridico cj = new ClienteJuridico();
cj.Codigo = 3;
cj.Nome = "Rodrigo";
cj.Cnpj = 234;
cj.Mostrar();





