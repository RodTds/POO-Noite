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

        private bool ValidarNumeroMatricula(Aluno aluno)
        {
            bool existe = false;
            foreach (var item in VetAlunos)
            {
                if (aluno.Matricula == item.Matricula)
                    existe = true;
            }
            return existe;
        }
        public void AdicionarAlunos(Aluno aluno)
        {
            if (aluno.Matricula == "")
            {   
                System.Console.WriteLine($" **** Aluno: {aluno.Nome} NÃO cadastrado Voce nao informou o Número da -- Matricula -- do aluno");
                System.Console.WriteLine("----------------------------------------------------------------------------");
            }
            else if(aluno.Nome == ""){
               System.Console.WriteLine($"**** Mátricula: {aluno.Matricula} NÃO cadastrada você não informou o -- NOME -- do aluno");
               System.Console.WriteLine("-----------------------------------------------------------------------------");
            }
            else
            {
                if (ValidarNumeroMatricula(aluno))
                {
                    System.Console.WriteLine($" *** Aluno: {aluno.Nome}  NÃO  cadastrado");
                    System.Console.WriteLine(" ***Número de matricula já cadastrada, informe outro número de matricula");
                }
                else
                    VetAlunos.Add(aluno);
            }
        }



        public void ExibirDadosCurso()
        {
            System.Console.WriteLine("Curso: " + NomeCurso);
            foreach (Aluno alu in VetAlunos)
            {
                alu.ExibirDadosAluno();
            }
        }

    }
}