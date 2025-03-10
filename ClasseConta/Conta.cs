using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClasseConta
{
    public class Conta
    {
        //  atributos
        public int numero;
        public string titular;
        public double saldo;
        

        // declaração dos metodos

        public void  Sacar(double valorSaque)
        {
          this.saldo = this.saldo - valorSaque;
           
        }
        public void Depositar(double depoisto)
        {
           saldo += depoisto; 
        }
        public void MostraAtributos(){
            Console.WriteLine($"Numero: {this.numero} -- Saldo: {this.titular} -- Limite: {this.saldo}");
        }
        
        public void Transferir(double valorTransferencia, Conta objetoDestino){
            saldo  -= valorTransferencia;
            objetoDestino.saldo += valorTransferencia;
            //objetoDestino.Depositar(valorTransferencia);

        }


    }
}