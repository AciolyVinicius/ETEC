using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste_mensagem
{
    class Cadastrar
    {
        private String nome_usuario;
        private String nome_login;
        private String senha_usuario;

        public String Nome_usuario
        {
            get { return nome_usuario; }
            set { nome_usuario = value; }
        }

        public String Nome_login
        {
            get { return nome_login; }
            set { nome_login = value; }
        }

        public String Senha_usuario
        {
            get { return senha_usuario; }
            set { senha_usuario = value; }
        }
    }
}
