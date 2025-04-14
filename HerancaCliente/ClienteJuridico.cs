using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerancaCliente
{
    public class ClienteJuridico : Cliente
    {
        public int Cnpj { get; set; }
          public void Mostrar(){
            base.Mostrar();// Chama o metodo mostrar da classe base
            Console.WriteLine("CNPJ: " + Cnpj );
        }
    }
    
}