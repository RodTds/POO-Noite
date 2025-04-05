using AtividadeConstrutor;

// PRIMEIRA  instancia
Livro livro1 = new Livro("Orientado Objeto","Gabriel Torres",1998,167);
livro1.LerPAginas(16);
livro1.ExibirDetalhes();

// SEGUNDA Instancia com contrutor padrao
Livro livro2 = new Livro();
livro2.Titulo = "Hardware Avançado";
livro2.Autor = "Junior Franco";
livro2.AnoPublicacao = 1999;
livro2.QuantidadePaginas = 200;
livro2.LerPAginas(200);
livro2.ExibirDetalhes();

// Terceira instancia
Livro livro3 = new Livro("","Gabriel Torres",2000,25); // testando validação atributo titulo vazio
livro3.LerPAginas(16);
livro3.ExibirDetalhes();



