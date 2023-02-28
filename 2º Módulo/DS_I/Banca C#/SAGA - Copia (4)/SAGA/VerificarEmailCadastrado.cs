using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SAGA
{
    class VerificarEmailCadastrado
    {
        private static String email;

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
        private MySqlConnection connection;
        public Boolean VerifyRegister()
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
                    + " WHERE email = '" + Login.Nome_login + "';";

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
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
