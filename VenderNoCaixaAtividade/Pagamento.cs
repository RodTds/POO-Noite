using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VenderNoCaixaAtividade
{
    public abstract class Pagamento
    {
        protected string dataPag;
        protected double totalPag;

        public abstract double CalcularTroco(double total);
        // Contrutor
        public Pagamento(string dataPag)
        {
            DataPag = dataPag;
        }

        // Propriedades
        public string DataPag
        {
            get { return dataPag; }
            set { dataPag = value; }
        }
        public double TotalPag
        {
            get { return totalPag; }
            set { totalPag = value; }
        }
        public  virtual void  MostrarPagamento( )
        {
            Console.WriteLine($"Data Pagamento: {DataPag} -- Total Pagamento: {TotalPag:c}");
        }
    }// Classe
}