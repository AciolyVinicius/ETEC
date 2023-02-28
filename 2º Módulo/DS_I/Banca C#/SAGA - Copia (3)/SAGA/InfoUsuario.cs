using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SAGA
{
    class InfoUsuario
    {
        private static string nome_responsavel, cpf_responsavel, contato_responsavel, email_responsavel, nome, nascimento, senha, cpf, rg, contato1, contato2;
        private static int usersrole;
        private static string email;
        private static string endereco;

        public static string Contato1
        {
            get
            {
                return contato1;
            }

            set
            {
                contato1 = value;
            }
        }

        public static string Contato2
        {
            get
            {
                return contato2;
            }

            set
            {
                contato2 = value;
            }
        }

        public static string Contato_responsavel
        {
            get
            {
                return contato_responsavel;
            }

            set
            {
                contato_responsavel = value;
            }
        }

        public static string Cpf
        {
            get
            {
                return cpf;
            }

            set
            {
                cpf = value;
            }
        }

        public static string Cpf_responsavel
        {
            get
            {
                return cpf_responsavel;
            }

            set
            {
                cpf_responsavel = value;
            }
        }

        public static string Email_responsavel
        {
            get
            {
                return email_responsavel;
            }

            set
            {
                email_responsavel = value;
            }
        }

        public static string Nascimento
        {
            get
            {
                return nascimento;
            }

            set
            {
                nascimento = value;
            }
        }

        public static string Nome
        {
            get
            {
                return nome;
            }

            set
            {
                nome = value;
            }
        }

        public static string Nome_responsavel
        {
            get
            {
                return nome_responsavel;
            }

            set
            {
                nome_responsavel = value;
            }
        }

        public static string Rg
        {
            get
            {
                return rg;
            }

            set
            {
                rg = value;
            }
        }

        public static string Senha
        {
            get
            {
                return senha;
            }

            set
            {
                senha = value;
            }
        }

        public static int Usersrole
        {
            get
            {
                return usersrole;
            }

            set
            {
                usersrole = value;
            }
        }

        public static string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        public static string Endereco
        {
            get
            {
                return endereco;
            }

            set
            {
                endereco = value;
            }
        }
        private MySqlConnection connection;

        public void Informations()
        {
            MySqlDataReader id;
            Caminho route = new Caminho();
            String path = route.Route(), stringtype = "";

            try
            {
                connection = new MySqlConnection(path);
                connection.Open();

                String verificar = "SELECT r.id FROM users u RIGHT JOIN role_user ru ON u.id = ru.users_id LEFT JOIN roles r on ru.roles_id = r.id"
                    + " WHERE email = '" + Login.Nome_login + "' and passwords = '" + Login.Senha_usuario + "';";

                MySqlCommand comandos = new MySqlCommand(verificar, connection);
                id = comandos.ExecuteReader();

                while (id.Read())
                {
                    stringtype = id["r.id"].ToString();
                }
                connection.Close();
            }
            catch (Exception excecao)
            {
                throw new Exception("Mensagem de erro: " + excecao.Message);
            }
        }
    }
}
