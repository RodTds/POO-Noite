using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace ExercicioVendaAgregacao
{
    public class Vendedor
    {
       
        public double Comissao { get; set; }

        
        public void CalcularComissao(double valor){
            Comissao += valor * 2 /100;

        }
        public void MostrarAtributos(){
            
            System.Console.WriteLine($"Comissão do Vendedor: {Comissao:c}");
        }
    }
}