using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstrataCliente
{
    public class ClienteJuridico : Cliente
    {
        private int cnpj;
        public int Cnpj
        {
            get { return cnpj; }
            set { cnpj = value; }
        }
            public override void Mostrar(){
            base.Mostrar();
            Console.WriteLine("CNPJ: " + Cnpj);
        }
          public override void Cadastrar(int codigo,string nome,int documento){
               Codigo = codigo;
               Nome = nome;
               Cnpj = documento;
    }
      public override void VerificaIdade()
      {// É um polimorfismo
         if(Idade >=40)
            System.Console.WriteLine("Cliente Juridico");
    }
    
}
}