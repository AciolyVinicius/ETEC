using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDMySQL
{
    class ObterDados
    {
        private int codigo; // Atributo código (cd_usuario no banco)
        private string nome; // Atributo nome (nm_usuario no banco)
        private string email; // Atributo email (nm_email no banco)

        public int Codigo // GET e SET do atributo codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public string Nome // GET e SET do atributo nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Email // GET e SET do atributo email
        {
            get { return email; }
            set { email = value; }    
        }
    }
}
