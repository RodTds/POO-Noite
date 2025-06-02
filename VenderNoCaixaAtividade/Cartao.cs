using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VenderNoCaixaAtividade
{
    public class Cartao : Pagamento
    {
        private string dadosTransacao;
        private int resultadoTransacao;
        private double valor;

        // Contrutor
        public Cartao(string dataPag,double valor, string dadosTransacao) : base(dataPag)
        {
            Valor = valor;
            DadosTransacao = dadosTransacao;
        }

        // propriedades
        public string DadosTransacao
        {
            get { return dadosTransacao; }
            set { dadosTransacao = value; }
        }
        public int ResultadoTransacao
        {
            get { return resultadoTransacao; }
            set { resultadoTransacao = value; }
        }
        public double Valor
        {
            get { return valor; }
            set{ valor = value; }
        }
        // metodos
        public override double CalcularTroco(double total)
        {
            return Valor - total;
        }
       
        public override void MostrarPagamento()
        {
            Console.WriteLine("Pagamento em Cartão ");
            base.MostrarPagamento();
            Console.WriteLine($"Dados Transação: {DadosTransacao} --Valor: {Valor:c} -- Resultado Transação: {ResultadoTransacao}");
        }

    }
}