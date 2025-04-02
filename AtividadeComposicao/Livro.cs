using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtividadeComposicao
{
    public class Livro
    {
        public string Titulo { get; set; }
        public int AnoPublicacao {get;set;}

        public List<Autor> VetAutor { get; set; }

        public Livro(string titulo,int anopublicacao)
        {
            Titulo = titulo;
            AnoPublicacao = anopublicacao;
            VetAutor = new List<Autor>();
        }

        public void AdicionarAutor(Autor autor){
             VetAutor.Add(autor);
        }
        public void ExibirDados(){
            System.Console.WriteLine($"Titulo: {Titulo} -- Ano de Publicação: {AnoPublicacao}");
            System.Console.WriteLine("Autores: ");
            foreach (var autor in VetAutor)
            {
                System.Console.WriteLine($"Nome: {autor.Nome} -- Nacionalidade: {autor.Nacionalidade}");
            }
        }

    }
}