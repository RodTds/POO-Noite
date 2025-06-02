using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceAtividade
{
    public class TotalizadorDeTributos
    {
        private double total;

        public double Total
        {
            get { return total; }
            set { total = value; }
        }

        public void Adiciona(ITributavel tributos)
        {
              //  perguntar this
             this.Total += tributos.CalculaTributos();
        }
    }
}