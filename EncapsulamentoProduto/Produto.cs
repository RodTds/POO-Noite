using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EncapsulamentoProduto;

namespace EncapsulamentoProduto
{
    public class Prtoduto
    {
      private int codigo;
      private string nome;
      private double preco;
      
      public double Preco // Propriedade
      {
        get { return preco; }
        set { preco = value; }
      }
      
      public string Nome // propriedade
      {
        get { return nome.ToUpper(); }
        set { nome = value; }
      }
      
      public int Codigo // metodos get set sao propriedades
      {
        get { return codigo; }
        set {
              if(value > 0)
                 codigo = value;
              else Console.WriteLine("Código Inválido");
            }
      }


    }
}