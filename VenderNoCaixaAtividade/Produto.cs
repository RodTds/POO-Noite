using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VenderNoCaixaAtividade
{
    public class Produto
    {
        private long codProduto;
        private string nome;
        private double preco;
        private int qtdEstoque;

        // Construtor
        public Produto(long codProduto, string nome, double preco, int qtdEstoque)
        {
            CodProduto = codProduto;
            Nome = nome;
            Preco = preco;
            QtdEstoque = qtdEstoque;
        }
        // propriedades
        public long CodProduto
        {
            get { return codProduto; }
            set { codProduto = value; }
        }
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public double Preco
        {
            get { return preco; }
            set { preco = value; }
        }
        public int QtdEstoque
        {
            get { return qtdEstoque; }
            set { qtdEstoque = value; }
        }

        public void  MostrarProduto()
        {
            Console.WriteLine($"Codigo: {CodProduto} -- Nome: {Nome} -- Preço:{Preco:c}");
        }
    }
}