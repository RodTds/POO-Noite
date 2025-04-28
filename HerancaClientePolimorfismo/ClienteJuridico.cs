using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerancaClientePolimorfismo
{
    public class ClienteJuridico : Cliente
    {
        public int Cnpj { get; set; }
           // aqui no metodo mostrar acontece o polimorfismo o metodo tem o mesmo nome usando override
          public override void Mostrar(){
            base.Mostrar();// Chama o metodo mostrar da classe base
            Console.WriteLine("CNPJ: " + Cnpj );
        }
         public ClienteJuridico(int codigo,string nome,int cnpj):base(codigo,nome){
            Cnpj = cnpj;
          }

          public ClienteJuridico(){
            
          }
    }
    
}