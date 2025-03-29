using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioVendaAgregacao
{
    public class Comprador
    {   

        
        public static double Verba { get; set; }
        
        public Comprador(double verba){
          Verba = verba;
        }
        public void DescontarVerba(double valor){
            Verba -= valor;
        }

        public void MostrarAtributos(){
            System.Console.WriteLine($"Total da Verba: {Verba}");
        }
    }
}