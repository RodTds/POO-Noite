using AtividadeAgregacao;

Aluno aluno1 = new Aluno("Rodrigo");
Aluno aluno2 = new Aluno("Joao");
Aluno aluno3 = new Aluno("Ana");
Aluno aluno4 = new Aluno("Larissa");

Curso curso1 = new Curso();
curso1.NomeCurso = "ADS";
curso1.AdicionarAlunos(aluno1);
curso1.AdicionarAlunos(aluno2);
curso1.AdicionarAlunos(aluno3);
curso1.AdicionarAlunos(aluno4);

curso1.ExibirDadosCurso();

Curso curso2 = new Curso();
curso2.NomeCurso = "Agronomia";
curso2.AdicionarAlunos(aluno1);
curso2.ExibirDadosCurso();

