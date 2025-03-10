using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EncapsulamentoFuncionario
{
  public class Funcionario
  {
    // atributos
    private int codigo;
    private string nome;
    private double salario;

    //declarao metodos de encapsulamento

    public double Salario
    {
      set
      {
        this.salario = value;
      }
      get
      {
        return this.salario;
      }
    }
    public int Codigo
    {
      set
      {
        this.codigo = value;
      }
      get
      {
        return this.codigo;
      }
    }
    public string Nome
    {
      set
      {
        this.nome = value;
      }
      get
      {
        return this.nome;
      }
    }
    public void CalcularAumento(double percent)
    {
      this.salario += salario * percent / 100;
    }
    public void Mostrar()
    {
      Console.WriteLine($"Codigo: {codigo} -- Nome: {nome} -- Salario: {salario}");
    }
  }
}