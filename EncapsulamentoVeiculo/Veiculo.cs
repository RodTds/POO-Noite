using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EncapsulamentoVeiculo
{
    public class Veiculo
    {

        private int ano;
        private string marca;
        private string modelo;
        private double quilometragem;
        public int Ano
        {
            get { return ano; }
            set
            {
                if (value >= 1900 && ano <= DateTime.Now.Year)
                    ano = value;
                else
                    Console.WriteLine("Ano Inválido");
            }
        }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public double Quilometragem { get; set; }

        public void RdgistrarQuilometragem(double quilometragem){
            this.quilometragem += value;
        }
        public void ExibirDetalhes(){
            Console.WriteLine($"Ano: {ano} -- Marca: {marca} -- Modelo: {modelo} -- Quilomentragem: {quilometragem}");

        }

    }
}