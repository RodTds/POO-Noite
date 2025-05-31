using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SolidAtividade
{
    public class GeradorRelatorios
    {
        
        public string GerarRelatorio(Conta usuario)
        {
            return $"Titular: {usuario.Titular}\t Saldo: {usuario.Saldo:c}";
        }
    }
}