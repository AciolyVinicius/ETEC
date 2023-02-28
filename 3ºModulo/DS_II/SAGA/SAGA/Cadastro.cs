using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SAGA
{
    class Cadastro
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

        private MySqlConnection conexao;

        public Boolean ConfirmRegister()
        {
            Caminho route = new Caminho();
            String caminho = route.Route();
            int linhas = 0;



            try
            {
                conexao = new MySqlConnection(caminho);
                conexao.Open();

                string inserir = "INSERT INTO users (nome, endereco, email, cpf, rg, passwords, contato1, contato2, responsavel, contato_responsavel, email_responsavel, cpf_responsavel) VALUES" +
                    "('" + Cadastro.Nome + "', '" + Cadastro.Endereco + "', '" + Cadastro.Email + "', '" + Cadastro.Cpf + "', '" + Cadastro.Rg + "', '" + Cadastro.Senha + "', '" + Cadastro.Contato1 + "', '" + Cadastro.Contato2 + "', '" + Cadastro.Nome_responsavel + "', '" + Cadastro.Contato_responsavel + "', '" + Cadastro.Email_responsavel + "', '" + Cadastro.Cpf_responsavel + "');" +
                    "INSERT INTO role_user (users_id, roles_id) VALUES ( (SELECT u.id  FROM users u WHERE u.email = '" + Cadastro.Email + "' and u.passwords = '" + Cadastro.Senha + "'), " + Cadastro.Usersrole +" );";

                MySqlCommand comandos = new MySqlCommand(inserir, conexao);
                linhas = comandos.ExecuteNonQuery();
                conexao.Close();
            }
            catch (Exception excecao)
            {
                throw new Exception("Erro ocorrido: " + excecao.Message);
            }

            if (linhas > 0)
                return true;
            else
                return false;
        }
    }
}
