using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceAtividade
{
    public class SeguroVida : ITributavel
    {
        private double valorSeguro;

        public double ValorSeguro
        {
            get { return valorSeguro; }
            set { valorSeguro = value; }
        }

        public double CalculaTributos()
        {
            return 75;
        }
    }// classe
}