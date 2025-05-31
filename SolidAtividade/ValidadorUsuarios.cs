using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SolidAtividade
{
    public class ValidadorUsuarios
    {
        private Conta usuario;

        public bool ValidarUsuario(string nome)
        {
           if(nome == usuario.Titular)
             return true;
            else
              return false;
        }
    }
}