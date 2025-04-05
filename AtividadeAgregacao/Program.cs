using AtividadeAgregacao;

Aluno aluno1 = new Aluno("1234","Rodrigo");
Aluno aluno2 = new Aluno("4321","");
Aluno aluno3 = new Aluno("","Ana");
Aluno aluno4 = new Aluno("777","Larissa");
Aluno aluno5 = new Aluno("777","Marcos");

Curso curso1 = new Curso();
curso1.NomeCurso = "ADS";
curso1.AdicionarAlunos(aluno5);
curso1.AdicionarAlunos(aluno1);
curso1.AdicionarAlunos(aluno2);
curso1.AdicionarAlunos(aluno3);
curso1.AdicionarAlunos(aluno4);


curso1.ExibirDadosCurso();

Curso curso2 = new Curso();
curso2.NomeCurso = "Agronomia";
curso2.AdicionarAlunos(aluno1);
curso2.ExibirDadosCurso();

