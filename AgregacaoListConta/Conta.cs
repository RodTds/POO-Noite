using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgregacaoListConta
{
    public class Conta
    {
        public int Numero { get; set; }
        // A agregação acontera aqui no titular e do tipo classe Cliente
        // ligacao estrutural, uma classe conversa com a outra
        public List<Cliente> VetTitulares { get; set; }// = new List<cliente>();  poderia ser aqui a instancia

        public double Saldo { get; set; }

         public void ExibirDetalhes(){
            Console.WriteLine($"Numero: {Numero} Saldo: {Saldo:C} ");
            foreach (Cliente c in VetTitulares)
            {
                c.ExibirDetalhes();
            }
        }
    }
     
}