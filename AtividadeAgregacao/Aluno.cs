using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtividadeAgregacao
{

    public class Aluno
    {
        private string matricula;
        private string nome;

        public string Matricula
        {
            get
            {
                return matricula;
            }
            set
            {
                matricula = value;
            }
        }
        public string Nome {
             get{ return nome;} 
             set{ nome = value;} 
             }



        public Aluno(string matricula, string nome)
        {
            Matricula = matricula;
            Nome = nome;
        }

        public void ExibirDadosAluno()
        {
            System.Console.WriteLine($"Matricula: {Matricula} -- Nome: {Nome}");
        }
    }
}