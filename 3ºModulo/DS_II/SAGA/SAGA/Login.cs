using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SAGA
{
    class Login
    {
        private static String nome_login;
        private static String senha_usuario;

        public static String Nome_login
        {
            get { return nome_login; }
            set { nome_login = value; }
        }

        public static String Senha_usuario
        {
            get { return senha_usuario; }
            set { senha_usuario = value; }
        }


        private MySqlConnection connection;
        public bool Verificar()
        {
            MySqlDataReader teste;
            int linhas = 0;
            Caminho route = new Caminho();
            String path = route.Route();

            try
            {
                connection = new MySqlConnection(path);
                connection.Open();

                String verificar = "SELECT nome FROM users"
                    + " WHERE email LIKE '" + Login.Nome_login + "' and passwords LIKE '" + Login.Senha_usuario + "';";

                MySqlCommand comandos = new MySqlCommand(verificar, connection);
                teste = comandos.ExecuteReader();

                while (teste.Read())
                {
                    linhas = linhas + 1;
                }
                connection.Close();
            }
            catch (Exception excecao)
            {
                throw new Exception("Mensagem de erro: " + excecao.Message);
            }

            if (linhas > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
