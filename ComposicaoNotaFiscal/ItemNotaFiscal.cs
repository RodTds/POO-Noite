using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComposicaoNotaFiscal
{
    public class ItemNotaFiscal
    {
        public int Qtde { get; set; }
        public ItemNotaFiscal(int qtde)
        {
            Qtde = qtde;
        }
          ~ItemNotaFiscal(){//Destrutor
          
            System.Console.WriteLine("Destrutor Item Nota Fiscal");
        }
    }
}