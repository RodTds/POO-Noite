using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstratoFuncionario: Funcionario
{
    public class Assalariado
    {
         public Assalariado(int codigo,string nome,double salario): base(codigo,nome,salario)
         {
            // poderia colocar um novo atributo
         }

         public override double CalcularSalario(int diasUteis)
         {
            return Salario/ 30 * diasUteis;
         }
    }
}