using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerancaClientePolimorfismo
{
    public class Cliente
    {
        protected int codigo;
        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        protected string? nome;
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public Cliente(){

        }
          public Cliente(int codigo,string nome){
            Codigo = codigo;
            Nome = nome;
          }
        public virtual void Mostrar(){
            Console.WriteLine("Código: " + codigo + " -- Nome: " + nome);
        }
         
    }
}