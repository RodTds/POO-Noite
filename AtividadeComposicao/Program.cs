using AtividadeComposicao;

Livro livro1 = new Livro("Hardware Básico",1999);

Autor autor3 =  new Autor("","Americano"); // para verificar a validação na  de nome vazio
Autor autor4=  new Autor("Maycon",""); // para verificar a validação da nacionalidade vazia
Autor autor1 = new Autor("Joao","Basileiro");
Autor autor2 =  new Autor("Charles","Americano");


livro1.AdicionarAutor(autor1);
livro1.AdicionarAutor(autor2);
livro1.AdicionarAutor(autor3);
livro1.AdicionarAutor(autor4);

livro1.ExibirDados();


