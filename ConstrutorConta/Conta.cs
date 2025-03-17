using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConstrutorConta
{
    public class Conta
    {
        public int Numero { get; set; }
        public string Titular { get; set; }
        public decimal Saldo { get; set; }
        public bool Situacao { get; set; }
        public static int Contador{get;set;}
        // atalho contrutor " ctor "
        public Conta(){
          // contrutor padrao
          Contador++;
        }
        public Conta(int numero){
             Numero = numero;
             Contador++;
         }

         public Conta(int numero, string nome){
             Numero = numero;
             Titular = nome;
             Contador++;
        }
        public void ExibirDetalhes(){
            System.Console.WriteLine($"Numero: {Numero} Titular: {Titular} Saldo: {Saldo:C} Situação: {Situacao}");
        }
    }
}