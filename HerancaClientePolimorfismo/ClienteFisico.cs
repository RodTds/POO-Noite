using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerancaClientePolimorfismo
{
            // classe derivada: classe base/superclasse
    public class ClienteFisico : Cliente
    {
        public int Rg { get; set; }
           
          // aqui acontece polimorfismo usando a palavra override, usa o nome do metodo igual da superclasse, mas 
          // aqui sera necessario mudar a programacao deixando diferente da superclasse
          public override void Mostrar(){
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