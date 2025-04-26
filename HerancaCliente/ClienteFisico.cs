using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerancaCliente
{
            // classe derivada: classe base/superclasse
    public class ClienteFisico : Cliente
    {
        public int Rg { get; set; }
           
          
          public void Mostrar(){
            base.Mostrar();
            Console.WriteLine("RG: " + Rg);
        }
        // criando um contrutor usando
        public ClienteFisico(int codigo,string nome,int rg):base(codigo,nome){
            Rg = rg;
          }

          public ClienteFisico(){

          }
    }
    
}