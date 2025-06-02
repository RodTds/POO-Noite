using VenderNoCaixaAtividade;

// Instanciar Produtos
Produto p1 = new Produto(1, "Arroz", 20, 10);
Produto p2 = new Produto(2, "Feijão", 15, 10);
Produto p3 = new Produto(3, "Oleo", 10, 50);
// Instanciar Venda
Venda venda1 = new Venda(1, "17/02/2025");
// Instanciar Itens // Instacia junto com produto e quantidade
ItemVenda item1 = new ItemVenda(p1,3);
ItemVenda item2 = new ItemVenda(p2, 3);
ItemVenda item3 = new ItemVenda(p3, 45);
//Adicionando itens na venda
venda1.AdicionarItem(item1);
venda1.AdicionarItem(item2);
venda1.AdicionarItem(item3);

// Mostrando a venda
venda1.MostrarVenda();

// Pagamentos

// Instanciar Pagamentos 
Especie especie = new Especie("17/02/2025", 600);
Cheque cheque = new Cheque("18/06/2025", 123, "25/06/2025", 700, 1);
Cartao cartao = new Cartao("19/06/2025",500,"1FX980");
venda1.AdicionarPagamento(cartao);

venda1.MostrarPagamento();




