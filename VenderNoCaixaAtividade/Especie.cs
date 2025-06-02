using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VenderNoCaixaAtividade
{
    public class Especie : Pagamento
    {
        private double quantia;
        private double troco;

        public Especie(string dataPag,double quantia) : base(dataPag)
        {
            Quantia = quantia;
        }
        // propriedades
        public double Quantia
        {
            get { return quantia; }
            set { quantia = value; }
        }
        public double Troco
        {
            get { return troco; }
            set { troco = value; }
        }

        // Metodos
        public override double CalcularTroco(double total)
        {
            if (Quantia != total)
                return Quantia - total;
            return 0;
        }
        public override void MostrarPagamento()
        {
            Console.WriteLine("Pagamento em Dinheiro ");
            base.MostrarPagamento();
            Console.WriteLine($"Quantia: {Quantia}");
        }
        
        
    }// Classe
}