using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtividadeConstrutor
{
    public class Livro
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int AnoPublicacao { get; set; }
        public int QuantidadePaginas { get; set; }
        public int PaginasLidas { get; set; }

        public Livro()
        {
            
        }
        public Livro(string titulo,string autor,int anopublicacao,int quantidadepaginas)
        {
            Titulo = titulo;
            Autor = autor;
            AnoPublicacao = anopublicacao;
            QuantidadePaginas = quantidadepaginas;   
        }

        public void LerPAginas(int paginas){
            PaginasLidas += paginas;
        }
        public bool LivroConcluido(){ // Funcao chamda no metodo ExibirDetalhes
            if(PaginasLidas == QuantidadePaginas)
                return true;
            else
               return false;
        }
        public void ExibirDetalhes(){
            System.Console.WriteLine($"-----------------------------Informações Do Livro--------------------------");
            System.Console.WriteLine("Titulo: " + Titulo);
            System.Console.WriteLine("Autor: " + Autor);
            System.Console.WriteLine("Ano de Publicação: " + AnoPublicacao);
            System.Console.WriteLine("Paginas: " + QuantidadePaginas);
            System.Console.WriteLine("Paginas Lidas: " + PaginasLidas);
            if(LivroConcluido()) // chamadno booleana LIvro Concluido
                 System.Console.WriteLine(" **** Parabéns --- Leitura Concluída");
            else
                System.Console.WriteLine(" **** Que Pena --- Você ainda não concluiu a leitura");
        }
    }
}