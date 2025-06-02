using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SolidAtividade
{
  public class ValidadorUsuarios
  {

    public bool ValidarUsuario(string nome, Conta usuario)
    {
      return usuario.Titular == nome;
    }
  }
}

/*  OUTRA FORMA
  namespace SolidAtividade
{
    public class ValidadorUsuarios
    {
        private readonly Conta _usuario;

        // Injetar a conta no construtor
        public ValidadorUsuarios(Conta conta)
        {
            _usuario = conta;
        }

        // Validar só pelo nome
        public bool ValidarUsuario(string nome)
        {
            return _usuario.Titular == nome;
        }
    }
}

using SolidAtividade;

class Program
{
    static void Main(string[] args)
    {
        // Criar conta
        var conta = new Conta("Maria", 1000.00m);

        // Passar a conta para o validador
        var validador = new ValidadorUsuarios(conta);

        // Validar apenas com o nome
        bool resultado = validador.ValidarUsuario("Maria");

        Console.WriteLine($"Usuário válido? {resultado}");
    }
}


*/