using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContrutorFuncionario2
{
    public class Funcionario
    {
        
        public string Nome{get; set;}
        public decimal Salario { get; set; }
        public static int Codigo { get; set; }
        public static int Contador { get; set; }

        static Funcionario(){
           Codigo = 99;
        }
        public Funcionario(string nome,decimal salario){
            Codigo++;
            Nome = nome;
            Salario = salario;
            Contador++;

        }

        public void ExibirDetalhes(){
            System.Console.WriteLine("-----------------------------------------------------------");
            System.Console.WriteLine($"Codigo: {Codigo} -- Nome: {Nome} -- Salario: {Salario:c}");
            
            System.Console.WriteLine("------------------------------------------------------------");
        }
    }
}