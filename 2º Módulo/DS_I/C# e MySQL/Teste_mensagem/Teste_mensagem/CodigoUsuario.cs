using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste_mensagem
{
    class CodigoUsuario
    {
        private static int codigo_usuario;

        public static int Codigo_usuario
        {
            get { return codigo_usuario; }
            set { codigo_usuario = value; }
        }
    }
}
