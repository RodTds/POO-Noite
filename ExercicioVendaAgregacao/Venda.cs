using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



namespace ExercicioVendaAgregacao
{
    public class Venda
    {
        public static int CodigoVenda { get; set; }
        public Comprador Comp { get; set; }
        public Vendedor Vend { get; set; }
        public List<Produtos> VetProdutos{ get; set; }
    
        public double TotalVenda { get; set; }
        
        public Venda()
        {
            CodigoVenda++;
        }
        
        /*  Outra forma de adicionar produtos e calcular comissao do vendedor
        
        public void AdicionarProduto(Produto produto){
            VetProdutos.Add(produto);
            Vend.CalcularComissao(produto.Preco);

        }
         */
         // Agicionando o produto Na PROGRAM
        public void MostrarAtributos()
        {
            System.Console.WriteLine($"Venda: {CodigoVenda}");
            foreach (Produtos item in VetProdutos)
            {
                  TotalVenda += item.Preco;
                  item.MostrarAtributos();
            }
            Vend.CalcularComissao(TotalVenda);
            Comp.DescontarVerba(TotalVenda);
            System.Console.WriteLine($"Total da Venda: {TotalVenda}");
            Vend.MostrarAtributos();
            Comp.MostrarAtributos();
        }
    }
}