using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SolidAtividade
{
  public class ValidadorUsuarios
  {

    public bool ValidarUsuario(string nome,Conta usuario)
    {
      return usuario.Titular == nome;
    }
  }
}