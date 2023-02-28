using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SAGA
{
    class VerificarTipo
    {
        private MySqlConnection connection;
        public String VerifyType()
        {
            MySqlDataReader id;
            Caminho route = new Caminho();
            String path = route.Route(), stringtype="";

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
                    stringtype = id["id"].ToString();
                }
                connection.Close();
            }
            catch (Exception excecao)
            {
                throw new Exception("Mensagem de erro: " + excecao.Message);
            }
            return stringtype;
        }
    }
}
