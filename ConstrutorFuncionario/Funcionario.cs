using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConstrutorFuncionario
{
    public class Funcionario
    {
        // declaracao de atributo de forma implicita
        // por conta do encapsiulamento compacto-propriedade
        public int Matricula { get; set; }
        public string Nome { get; set; }
        public decimal Salario { get; set; }
        public static int Contador { get; private set; }

         // atalho construtuor ctor
        public Funcionario() // construtor padrao
        {  
            Contador++;
        }
        public Funcionario(int matricula)
        {
            Matricula = matricula;
            Contador++;
        }
        public Funcionario(int matricula,string nome,decimal salario)
        {
            Matricula = matricula;
            Nome = nome;
            Salario = salario;
            Contador++;

        }
        public void ExibirDetalhes(){
            System.Console.WriteLine($"Matricula: {Matricula} -- Nome: {Nome} -- Salario: {Salario:c}");
        }

    }
}