using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstrataCliente
{
    public class Teste
    {   // relacionamento/associação de DEPENDENCIA
    // por meio do parametro
    // recurso computacional de c# que faz eu sair de uma classe/arquivo para outro e o PONTO " . "
        public void AvaliarIdade(Cliente objcliente){

         System.Console.WriteLine("Visualizado classe teste funcionando");
            objcliente.VerificaIdade();

        }
    }
}