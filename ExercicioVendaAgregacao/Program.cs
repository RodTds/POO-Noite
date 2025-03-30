using ExercicioVendaAgregacao;

Comprador comprador1 = new Comprador(1000);// comprador JA ADICIONANDO A VERBA
Vendedor vendedor1 = new Vendedor(); // vendedor

Produtos prod1 = new Produtos("Notbook",500); // instanciando(criando) produtos COM NOME E PRECO
Produtos prod2 = new Produtos("Celular",300);

Venda venda1 = new Venda(); // Instancia Venda
venda1.Comp = comprador1; // Agregando Comprador
venda1.Vend = vendedor1; // Agregando Vendedor

venda1.VetProdutos = new List<Produtos>();
venda1.VetProdutos.Add(prod1);// Agregando Produto
venda1.VetProdutos.Add(prod2);// Agregando Produto

venda1.MostrarAtributos();

// Instanciar outro vendedor
Vendedor vendedor2 = new Vendedor();
Comprador comprador2 = new Comprador(600);

Venda venda2 = new Venda();
venda2.Comp = comprador2;
venda2.Vend = vendedor2;
venda2.VetProdutos = new List<Produtos>();
venda2.VetProdutos.Add(prod1); // Adicionando produtos criados na venda 1 
venda2.VetProdutos.Add(prod2); // que tambem foram agregados na venda 2;
venda2.MostrarAtributos();
// **** Aqui eu entendi que depois de criados(Instanciados) comprador, vendedor e produtos, eu posso
// associar a qualquer venda  criada(INstanciada)




