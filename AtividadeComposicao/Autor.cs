using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtividadeComposicao
{
    public class Autor
    {
        public string Nome { get; set; }
        public string Nacionalidade { get; set; }

        public Autor(string nome, string nacionalidade)
        {
            Nome = nome;
            Nacionalidade = nacionalidade;
        }

        public void ExibirDados(){
            System.Console.WriteLine($"Nome: {Nome} -- Nacionalidade: {Nacionalidade}");
        }
    }
}