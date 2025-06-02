using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VenderNoCaixaAtividade
{
    public class Venda
    {
        private int codVenda;
        private string dataVenda;
        private double totalVenda;
        private int qtdTotal;
        private List<ItemVenda> vetItem;
        private Pagamento pagto;
        private double desconto = 0;


        // Contrutor
        public Venda(int codVenda, string dataVenda)
        {
            CodVenda = codVenda;
            DataVenda = dataVenda;
            VetItem = new List<ItemVenda>();
        }

        // Propriedades
        public int CodVenda
        {
            get { return codVenda; }
            set { codVenda = value; }
        }
        public string DataVenda
        {
            get { return dataVenda; }
            set { dataVenda = value; }
        }
        public List<ItemVenda> VetItem
        {
            get { return vetItem; }
            set { vetItem = value; }
        }
        public int QtdTotal
        {
            get { return qtdTotal; }
            set { qtdTotal = value; }
        }
        public double TotalVenda
        {
            get { return totalVenda; }
            set { totalVenda = value; }
        }
        public Pagamento Pagto
        {
            get { return pagto; }
            set { pagto = value; }
        }
        // Metodos
        public void AdicionarItem(ItemVenda item)
        {
            VetItem.Add(item);
        }
        public bool CalcularTotal()
        {   // Calcula o valor total da venda
            // Tabembem calcular q quantidade de produtos para desconto acima de 50 itens
            foreach (var item in VetItem)
            {
                TotalVenda += item.Subtotal;
                QtdTotal += item.Quantidade;
            }
            if (QtdTotal >= 50) // Calcular desconto atacado 50 produtos
            {
                desconto = TotalVenda * 20 / 100;
                return true;
            }
            return false;
            
        }
        public void MostrarVenda()
        {
           
            Console.WriteLine("Venda Nº: " + CodVenda + " -- Data: " + DataVenda);
            foreach (var item in VetItem)
            {
                item.MostrarProduto();
            }
            if (CalcularTotal())
            {
                Console.WriteLine($"***  Parabéns Voce Ganhou {desconto:c} de desconto; ");
                TotalVenda = TotalVenda - desconto;
                Console.WriteLine($"Valor Total da Compra: {TotalVenda:c}");
            }
            else
                Console.WriteLine($"Total da Venda:{TotalVenda:c}");
        }

        public void AdicionarPagamento(Pagamento pgto)
        {
            Pagto = pgto;
        }

        public void MostrarPagamento()
        {
            Pagto.MostrarPagamento();
            MostrarTroco();
        }
        public void MostrarTroco()
        {
            Console.WriteLine($"Troco: {Pagto.CalcularTroco(TotalVenda):c}");
        }
    }
}