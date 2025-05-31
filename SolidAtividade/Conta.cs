using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SolidAtividade
{
    public class Conta
    {
        public string? Titular { get; set; }
        public decimal Saldo { get; set; }

        public Conta(string titular, decimal saldo)
        {
            Titular = titular;
            Saldo = saldo;
      
        }
        public void Deposito(decimal valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("O valor deve ser positivo ");
            }
            Saldo += valor;
        }// void deposito

        public void Sacar(decimal valor)
        {
            if (valor > Saldo)
            {
                Console.WriteLine("Saldo Insuficiente");
            }
            Saldo -= valor;
        }

    }// classe
}