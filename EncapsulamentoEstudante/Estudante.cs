using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EncapsulamentoEstudante
{
    public class Estudante
    {
        private string nome;
        private double nota;
        int valida = 0;
        public string Nome
        {
            get { return nome; }
            set
            {
                nome = value;
            }
        }
        public double Nota
        {
            get { return nota; }
            set
            {
                if (value > 0 && value < 11)
                {
                    nota = value;
                    valida = 1;
                }
                else
                {
                    Console.WriteLine("Intervalo de notas de 0 a 10 - Voce digitou uma nota invalida");
                    valida = 0;
                }
            }
        }
        private bool EstaAprovado()
        {
            if (nota >= 6)
                return true;
            else
                return false;
        }

        public void ExibirDetalhes()
        {
            Console.WriteLine("Nome do Aluno: " + nome);
            Console.WriteLine("Nota: " + nota);
            Console.Write("Status: ");
            if (EstaAprovado() && valida == 1)
                Console.WriteLine("Aprovado");
            else if(!EstaAprovado() && valida == 1 )
                Console.WriteLine("Reprovado");
            else
                Console.WriteLine("Em Analise -- Esperando nota valida");
            Console.WriteLine("--------------------------------------------------------------");
        }
    }
}
