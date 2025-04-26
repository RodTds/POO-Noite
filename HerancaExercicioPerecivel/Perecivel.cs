using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerancaExercicioPerecivel
{
    public class Perecivel: Produto
    {
     

        public string DtValidade { get; set; }
        public string DtFabricacao { get; set; }
        public string Lote{get;set;}

        public Perecivel(){

        }
        public Perecivel(int codigo,string nome , double preco, string dtValidade,string dtFabricacao,string lote):base(codigo,nome,preco){
            DtValidade = dtValidade;
            DtFabricacao = dtFabricacao;
            Lote = lote;
        }
        public void Mostrar(){
            base.Mostrar();
            System.Console.WriteLine("Validade: " + DtValidade + "Fabricação: " + DtFabricacao + "Lote: " + Lote);
        }
    }
}