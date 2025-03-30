using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtividadeAgregacao
{
    public class Curso
    {
        public string NomeCurso { get; set; }
        public List<Aluno> VetAlunos { get; set; } = new List<Aluno>();

        public void AdicionarAlunos(Aluno aluno){
            VetAlunos.Add(aluno);
        }
        
        public void ExibirDadosCurso(){
            System.Console.WriteLine("Curso: " + NomeCurso);
            foreach (Aluno alu in VetAlunos)
            {
                alu.ExibirDadosAluno();
            }
        }
        
    }
}