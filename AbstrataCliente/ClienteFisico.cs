using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstrataCliente
{
    public class ClienteFisico : Cliente
    {
        
        private int rg;
        public int Rg
        {
            get { return rg; }
            set { rg = value; }
        }
            public override void Mostrar(){
            base.Mostrar();
            Console.WriteLine("RG: " + Rg);
        }
        public override void Cadastrar(int codigo,string nome,int documento){
               Codigo = codigo;
             Nome = nome;
             Rg = documento;
    }
    public override void VerificaIdade(){
         if(Idade >0 && Idade < 40)
            System.Console.WriteLine("Cliente Fisico");
    }
}
}