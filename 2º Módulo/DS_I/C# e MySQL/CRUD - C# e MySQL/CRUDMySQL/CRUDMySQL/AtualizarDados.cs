using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDMySQL
{
    class AtualizarDados
    {        
        private String nome_novo; // Nome para atualizar
        private String email_novo; // E-mail para atualizar
        private String email_atual; // Funciona para encontrar o registro através da cláusula WHERE
        public string Nome_novo // GET e SET para o atributo nome_novo
        {
            get { return nome_novo; }
            set { nome_novo = value; }
        }

        public string Email_novo // GET e SET para o atributo email_novo
        {
            get { return email_novo; }
            set { email_novo = value; }
        }

        public string Email_atual // GET e SET para o atributo email_atual
        {
            get { return email_atual; }
            set { email_atual = value; }
        }

    }
}
