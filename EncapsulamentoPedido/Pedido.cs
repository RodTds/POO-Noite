using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EncapsulamentoPedido
{
    public class Pedido
    {

        public  int NumPEdido { get; set; }
        public decimal Valor { get; set; }
        private List<string> itens = new List<string>();


        public Pedido(int numPedido)
        {
            NumPEdido = numPedido;
        }


        public void AdicionarIem(string item, decimal preco)
        {
            if (preco > 0)
            {
                itens.Add(item);
                Valor += preco;
            }
            else
              System.Console.WriteLine($"Item: *** {item} *** Não foi adicionado a lsta, Informe o valor");
        }
        public void ExibirDetalhes()
        {
            System.Console.WriteLine("----------------------------------------------------------");
            System.Console.WriteLine($"Numero Pedidio: {NumPEdido}");
            foreach (var item in itens)
            {
                System.Console.WriteLine($"Itens: {item} ");
            }
            System.Console.WriteLine($"Valor do Pedido: {Valor:c}");
            System.Console.WriteLine("----------------------------------------------------------");
        }
    }
}