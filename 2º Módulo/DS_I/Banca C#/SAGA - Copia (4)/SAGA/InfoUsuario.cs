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
        private static string usersrole;
        private static string email;
        private static string endereco;
        private static int id;

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

        public static string Usersrole
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

        public static int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        private MySqlConnection connection;

        public void Informations()
        {
            MySqlDataReader id;
            Caminho route = new Caminho();
            String path = route.Route();

            try
            {
                connection = new MySqlConnection(path);
                connection.Open();

                String verificar = "SELECT * FROM users WHERE email = '" + Login.Nome_login + "' and passwords = '" + Login.Senha_usuario + "';";

                MySqlCommand comandos = new MySqlCommand(verificar, connection);
                id = comandos.ExecuteReader();

                while (id.Read())
                {
                    InfoUsuario.Id  = Convert.ToInt32(id["id"].ToString());
                    InfoUsuario.Nome = id["nome"].ToString();
                    InfoUsuario.Nascimento = id["nascimento"].ToString();
                    InfoUsuario.Email = id["email"].ToString();
                    InfoUsuario.Cpf = id["cpf"].ToString();
                    InfoUsuario.Rg = id["rg"].ToString();
                    InfoUsuario.Senha = id["passwords"].ToString();
                    InfoUsuario.Contato1 = id["contato1"].ToString();
                    InfoUsuario.Contato2 = id["contato2"].ToString();
                    InfoUsuario.Nome_responsavel = id["responsavel"].ToString();
                    InfoUsuario.Contato_responsavel = id["contato_responsavel"].ToString();
                    InfoUsuario.Email_responsavel = id["email_responsavel"].ToString();
                    InfoUsuario.Cpf_responsavel = id["cpf_responsavel"].ToString();
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
