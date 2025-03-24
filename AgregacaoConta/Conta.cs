using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgregacaoConta
{
    public class Conta
    {
        public int Numero { get; set; }
        // A agregação acontera aqui no titular e do tipo classe Cliente
        // ligacao estrutural, uma classe conversa com a outra
        public Cliente Titular { get; set; }

        public double Saldo { get; set; }
    }
}