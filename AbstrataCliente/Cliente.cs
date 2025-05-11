using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstrataCliente
{
    // quando a classe e abstrata nao é possivel instanciar essa classe no objeto
    // podemos instanciar as classes filhas usando os atributos da classe mae
    // exemplo na MAIN
    public abstract class Cliente
    {
        
        protected int codigo;
        protected string? nome;
        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        public string? Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        
        private int idade;
        public int Idade
        {
            get { return idade; }
            set { idade = value; }
        }
        
        public virtual void Mostrar(){
            // quando o metodo tem logica, ele e um METODO CONCRETO
            Console.WriteLine("Codigo: " + Codigo + "\nNome: " + Nome);
        }
        public abstract void Cadastrar(int codigo,string nome,int documeto);// documeto representara rg ou cnpj, ele nao existe nessa classe
        public abstract void VerificaIdade(); 
    
}
}