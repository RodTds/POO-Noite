using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace SolidAtividade
{
    public class GeradorRelatorios
    {
        
        public string GerarRelatorio(Conta conta)
        {
           return $"Titular: {conta.Titular}\t Saldo: {conta.Saldo:c}";
        }
    }
}