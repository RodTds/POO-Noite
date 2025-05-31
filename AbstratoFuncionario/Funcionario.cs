using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstratoFuncionario
{
    public abstract class Funcionario
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public double Salario { get; set; }

        public List<Dependente> VetFilhos { get; set; }

        public Funcionario(int codigo, string nome, double salario)
        {
            Codigo = codigo;
            Nome = nome;
            Salario = salario;
        }

        public abstract double CalcularSalario(int diasUteis); // Abstrato Calcular Salario
        
        public void AdicionarDependentes(Dependente dependente)
        {
            VetFilhos.Add(dependente);
        }

        /* Remover com Lambda 
         public void RemoverDependentes(int codigo)
         {
            VetFilhos.RemoveAll(filho => filho.Codigo == codigo && filho.verificaMaioridade());
         } */
        public void RemoverDependentesMaioridade(int codigo)
        {
            if (VetFilhos.Count > 0)
            {
                for (int i = VetFilhos.Count - 1; i >= 0; i--)
                {
                    if (VetFilhos[i].Codigo == codigo && VetFilhos[i].verificaMaioridade())
                    {
                        VetFilhos.RemoveAt(i); // Remove com segurança
                    }
                }
                Console.WriteLine("Dependente Removido com Sucesso");
            }
            else
                Console.WriteLine("Não Existes depensentes para este funcioário");

        }
        public int CalcularTotalDependentes()
        {
            if (VetFilhos.Count > 0)
            {
                return VetFilhos.Count;
            }
            else
                return 0;
        }

        public void ListarDependentes()
        {
            Console.WriteLine($"Lista de Dependentes do Funcionário: {Codigo} -- Nome: {Nome}");
            if (VetFilhos.Count > 0)
            {
                foreach (var filho in VetFilhos)
                {
                    Console.WriteLine($"Codigo: {filho.Codigo} -- Nome: {filho.Nome} -- Idade: {filho.Idade}");

                }
                Console.WriteLine("___________________________________________________________________________");
            }
            else
            {
                Console.WriteLine("Funcionário não possui dependentes ");
                Console.WriteLine("------------------------------------------------------------------------");
            }
        }

        public virtual void MostrarAtributos()
        {
            // metodo concreto
            Console.WriteLine("---------------------------------------------------------------------");
            System.Console.WriteLine($"Código: {Codigo} -- Nome: {Nome} -- Salário: {Salario:c}");

        }

    }
}