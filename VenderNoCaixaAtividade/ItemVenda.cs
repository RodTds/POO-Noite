using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VenderNoCaixaAtividade
{
    public class ItemVenda
    {
        private int quantidade;

        private double subtotal;

        private Produto prod;

        //Contrutor
        public ItemVenda(Produto prod, int quantidade)
        {
            Prod = prod;
            Quantidade = quantidade;
            Subtotal += Prod.Preco * Quantidade; 
        }

        // propriedades
        public Produto Prod
        {
            get { return prod; }
            set { prod = value; }
        }
        public int Quantidade
        {
            get { return quantidade; }
            set { quantidade = value; }
        }
        public double Subtotal
        {
            get { return subtotal; }
            set { subtotal = value; }
        }

        public void MostrarProduto()
        {
            Prod.MostrarProduto();
            Console.WriteLine($"Quantidade: {Quantidade} -- Subtotal:{Subtotal:c}");
        }
    }
}