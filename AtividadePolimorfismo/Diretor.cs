using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtividadePolimorfismo
{
    public class Diretor: Funcionario
    {
        public Diretor(int codigo,string nome,double salario):base(codigo,nome,salario){

        }
        public override double CalcularBonificacao(){
            // traz o calculo aplicando 10 + 1000%
            return base.CalcularBonificacao() + 1000;
        }
    }
}