using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtividadePolimorfismo
{
    public class GerenciadorBonificacao
    {
        private double totalFuncionario;
        private double totalDiretor;
        private double totalgerente;
        private double totalSecretario;

        public double TotalFuncionario
        {
            get { return totalFuncionario; }
            set { totalFuncionario = value; }
        }

        public double TotalDiretor
        {
            get { return totalDiretor; }
            set { totalDiretor = value; }
        }  
        
     
        public double TotalGerente
        {
            get { return totalgerente; }
            set { totalgerente = value; }
        }

        public double TotalSecretario
        {
            get { return totalSecretario; }
            set { totalSecretario = value;}
        }



        // se aqui eu colocar o parametro no tipo funcionario eu consigo na instancia jogar qualquer objeto herdado
        public void TotalizadorBonificacao(Funcionario funcionario)
        {
            this.TotalFuncionario += funcionario.CalcularBonificacao();

        }
        public void TotalizadorBonificacao(Diretor diretor)
        {
            this.TotalDiretor += diretor.CalcularBonificacao();

        }
        public void TotalizadorBonificacao(Gerente gerente)
        {
            this.TotalGerente += gerente.CalcularBonificacao();

        }
        public void TotalizadorBonificacao(Secretario secretario)
        {
            this.TotalSecretario += secretario.CalcularBonificacao();

        }



    }
}