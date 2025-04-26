using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerancaExercicioPerecivel
{
    public class Produto
    {
        protected int codigo;
        protected string nome;
        protected double preco;
        
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public double Preco { get; set; }
        public Produto(){

        }
        public Produto(int codigo,string nome , double preco){
            Codigo = codigo;
            Nome = nome;
            Preco = preco;
        }
        public void Mostrar(){
            Console.WriteLine("Codigo: " + Codigo + "Nome: " + Nome + "Preco: " + Preco);
        }
    }
}