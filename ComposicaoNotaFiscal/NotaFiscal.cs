using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComposicaoNotaFiscal
{
    public class NotaFiscal
    {
        public int NumeroNf { get; set; }
        public string? Data { get; set; }// ? Interrogaçao depois da string elimina os textos amarelos na compilacao
        // estabelecendo a composicao 
        public List<ItemNotaFiscal> VetItemNf { get; set; }
         
         // *** composição a instanciação da classe todo e a classe parte acontece juntos, no contrutor abaixo
         // essa e a classe que tem o losango/diamante
         // *** essa classe nota fiscal e compoista pela ItemNotaFiscal
        public NotaFiscal(int numeronf,string data)
        {// aqui e a representação da composição
            NumeroNf = numeronf;
            Data = data;
            VetItemNf = new List<ItemNotaFiscal>();// aqui compondo a outra classe;
        }
        public void AdicionarItens(ItemNotaFiscal item){
             VetItemNf.Add(item);
        }
        public void MostrarAtributos(){
            System.Console.WriteLine($"Número da Nota Fiscal: {NumeroNf} -- Data da Compra: {Data} " );
            foreach (var it in VetItemNf)
            {
                System.Console.WriteLine(it.Qtde);;
            }
        }
        ~NotaFiscal(){//Destrutor
            VetItemNf = null;// destruindo objeto ItemNotaFiscal
            System.Console.WriteLine("Destrutor Nota Fiscal");
        }

    }
}