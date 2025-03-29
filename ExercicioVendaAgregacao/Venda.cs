using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioVendaAgregacao
{
    public class Venda
    {
       public Comprador Comp { get; set; }
       public Vendedor Vend { get; set; }

       private List<Produtos> vetProdutos = new List<Produtos>();
        
        public Vendas(Comprador comp,Vendedor vend,List produtos){
            

        }
       public void MostrarAtributos(){
        
       }
    }
}