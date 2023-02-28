using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste_mensagem
{
    class Mensagem
    {
        private int codigo_usuario;
        private int codigo_destinatario;
        private String mensagem_usuario;
        private String nome_usuario_destino;

        public int Codigo_usuario
        {
            get { return codigo_usuario; }
            set { codigo_usuario = value; }
        }

        public int Codigo_destinatario
        {
            get { return codigo_destinatario; }
            set { codigo_destinatario = value; }
        }        

        public String Mensagem_usuario
        {
            get { return mensagem_usuario; }
            set { mensagem_usuario = value; }
        }

        public String Nome_usuario_destino
        {
            get { return nome_usuario_destino; }
            set { nome_usuario_destino = value; }
        }
    }
}
