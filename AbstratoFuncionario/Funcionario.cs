using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstratoFuncionario
{
    public abstract class Funcionario
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public double Salario { get; set; }

        public Funcionario(int codigo,string nome,double salario)
        {
            Codigo = codigo;
            Nome = nome;
            Salario = salario;
        }
        public abstract double CalcularSalario(int diasUteis);
        public virtual MostrarAtributos()
        {
            System.Console.WriteLine($"Código: {Codigo} -- Nome: {Nome} -- Salário: {Salario:c}");
        }
    }
}