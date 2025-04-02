using AtividadeComposicao;

Livro livro1 = new Livro("Hardware Básico",1999);
Autor autor1 = new Autor("Joao","Basileiro");
Autor autor2 =  new Autor("Charles","Americano");
livro1.AdicionarAutor(autor1);
livro1.AdicionarAutor(autor2);

livro1.ExibirDados();

