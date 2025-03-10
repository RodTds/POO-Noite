using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClasseFuncionario
{
    public class Funcionario
    {
      // atributos
      public int codigo;
      public string nome;
      public double salario;

      //declarao metodos  
      
      public void CalcularAumento(double percent){
           this.salario += salario * percent /100;
      }
      public void Mostrar(){
        Console.WriteLine($"Codigo: {codigo} -- Nome: {nome} -- Salario: {salario}" );
      }
    }
}