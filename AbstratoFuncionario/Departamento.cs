using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstratoFuncionario
{
    public class Departamento
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public List<Funcionario> VetF { get; set; }

        public Departamento(int codigo, string nome)
        {
            Codigo = codigo;
            Nome = nome;
        }
        public void Admitir(Funcionario funcionario)
        {
            VetF.Add(funcionario);
        }

        public void ListarFuncionarios()
        {
            Console.WriteLine($"Departamento: {Nome}");
            foreach (var func in VetF)
            {
                func.MostrarAtributos();
               
            }
        }
        public void MostrarQuantDependentes()
        {
            int total = 0;
            foreach (var funcionario in VetF)
            {
                total += funcionario.CalcularTotalDependentes();
            }
            Console.WriteLine("Total de Funcionário deprtamento " + Nome + ":" + total); 
        }
        public void Demitir(int codigo)
        {
            for (int i = 0; i < VetF.Count; i++)
            {
                Funcionario f = VetF.ElementAt<Funcionario>(i);
                if (f.Codigo == codigo)
                {
                    VetF.Remove(f);
                    System.Console.WriteLine("Exclusão realizada com sucesso");
                }
            }
        }

        public double CalcularFolha(int diasUteis)
        {
            double folha = 0;
            for (int i = 0; i < VetF.Count; i++)
            {
                Funcionario f = VetF.ElementAt<Funcionario>(i);
                folha += f.CalcularSalario(diasUteis);
            }
            return folha;
        }

    }// Classe

}