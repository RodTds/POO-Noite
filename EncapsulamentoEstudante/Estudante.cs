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

        public string Nome
        {
            get { return nome; }
            set { 
                   nome = value;
               }
        }
        public double Nota { 
         get{ return nota}
         set{
            if(value > 0 && value < 11){
                nota = value;
            }else
                Console.WriteLine("Intervalo de notas de 0 a 10 - Voce digitou uma nota invalida");

         }
             
        }
        private bool EstaAprovado(){
           if(nota >= 6)
              return true;
            else
            return false; 
        }
        public void ExibirDetalhes(){
             Console.WriteLine("Nome do Aluno: " + nome);
             Console.WriteLine("Nota: " + nota);
             Console.Write("Status: ");
             if(EstaAprovado())
                 Console.Write("Aprovado");
            else
             Console.WriteLine("Reprovado");
          
        }
        
    }
}