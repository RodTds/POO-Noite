using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VenderNoCaixaAtividade
{
    public class Cheque : Pagamento
    {
        private long numero;
        private string dataDeposito;
        private int situacao;
        private double valorCheque;

        public Cheque(string dataPag, long numero, string dataDeposito, double valorCheque, int situacao) : base(dataPag)
        {
            DataDeposito = dataDeposito;
            Situacao = situacao;
            ValorCheque = valorCheque;
            Numero = numero;
        }
        public long Numero
        {
            get { return numero; }
            set { numero = value; }
        }
        public string DataDeposito
        {
            get { return dataDeposito; }
            set { dataDeposito = value; }
        }
        public double ValorCheque
        {
            get { return valorCheque; }
            set{ valorCheque = value; }
        }
        public int Situacao
        {
            get { return situacao; }
            set { situacao = value; }
        }

        public override double CalcularTroco(double total)
        {
            return ValorCheque - total;
         }
        public override void MostrarPagamento()
        {
            Console.WriteLine("Pagamento em Cheque ");
            base.MostrarPagamento();
            Console.WriteLine($"Numero Cheque: {Numero} -- Data Depósito: {DataDeposito} -- Situação: {Situacao}");
        }
        
    }
}