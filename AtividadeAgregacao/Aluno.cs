using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtividadeAgregacao
{
    public class Aluno
    {
        public static int Matricula { get; set; }
        public string Nome { get; set; }

        static Aluno(){
            Matricula = 500;
        }

        public Aluno(string nome){
            Matricula++;
            Nome = nome;
        }

        public void ExibirDadosAluno(){
            System.Console.WriteLine($"Matricula: {Matricula} -- Nome: {Nome}");
        }
    }
}