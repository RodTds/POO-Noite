using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstratoFuncionario
{
    public class Dependente
    {
        private int codigo;
        private string? nome;
        private int idade;

        public int Codigo {
            get { return codigo; }
            set { codigo = value; }

        }
        public string? Nome {
            get { return nome; }
            set { nome = value; }
        }
        public int Idade
        {
            get { return idade; }
            set { idade = value; }
        }
        public Dependente(int codigo, string nome, int idade)
        {
            Codigo = codigo;
            Nome = nome;
            Idade = idade;
        }

        public bool verificaMaioridade()
        {
            if (Idade > 17)
                return true;
            else
                return false;
        }

      
    
    }
}