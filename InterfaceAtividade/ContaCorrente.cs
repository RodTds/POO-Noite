using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceAtividade
{
    public class ContaCorrente : ITributavel
    {
        private double saldo;
        public double Saldo
        {
            get
            {
                return saldo;
            }
            set
            {
                saldo = value;
            }
        }

        public double CalculaTributos()
        {
            return Saldo * 5 / 100;
        }

    }// Classe
}