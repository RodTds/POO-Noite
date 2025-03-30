using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioVendaAgregacao
{
    public class Produtos
    {

        public static int Codigo { get; set; }
        public string Nome { get; set; }
        public double Preco { get; set; }

        static Produtos()
        {
            Codigo = 499;
        }

        public Produtos(string nome, double preco)
        {
            Codigo++;
            Nome = nome;
            Preco = preco;
        }

        public void MostrarAtributos()
        {
            System.Console.WriteLine($"Codigo: {Codigo} -- Nome_Produto: {Nome} -- Preço: {Preco:c}");
        }

    }
}