using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SAGA
{
    class AtualizarListaAluno
    {
        private MySqlConnection connection;
        public int StudentsNumbers()
        {
            int listar = 0;
            MySqlDataReader alunos;
            Caminho route = new Caminho();
            String path = route.Route();

            try
            {
                connection = new MySqlConnection(path);
                connection.Open();

                String verificar = "SELECT u.nome FROM users u RIGHT JOIN role_user ru ON u.id = ru.users_id LEFT JOIN roles r ON ru.roles_id = r.id WHERE r.id = 4;";

                MySqlCommand comandos = new MySqlCommand(verificar, connection);
                alunos = comandos.ExecuteReader();

                while (alunos.Read())
                {
                    listar += 1;
                }

                connection.Close();
            }
            catch (Exception excecao)
            {
                throw new Exception("Mensagem de erro: " + excecao.Message);
            }
            return listar;
        }

        public int StudentsId(int ID)
        {
            int listar = 0;
            MySqlDataReader alunos;
            Caminho route = new Caminho();
            String path = route.Route();

            try
            {
                connection = new MySqlConnection(path);
                connection.Open();

                String verificar = "SELECT u.id FROM users u RIGHT JOIN role_user ru ON u.id = ru.users_id LEFT JOIN roles r ON ru.roles_id = r.id WHERE r.id = 4 and u.id > " + ID + ";";

                MySqlCommand comandos = new MySqlCommand(verificar, connection);
                alunos = comandos.ExecuteReader();

                while (alunos.Read())
                {
                    listar = Convert.ToInt32(alunos["u.id"].ToString());
                    break;
                }
                connection.Close();
            }
            catch (Exception excecao)
            {
                throw new Exception("Mensagem de erro: " + excecao.Message);
            }
            return listar;
        }

        public String StudentsList(int StudentsId)
        {
            String list = "";
            MySqlDataReader alunos;
            Caminho route = new Caminho();
            String path = route.Route();

            try
            {
                connection = new MySqlConnection(path);
                connection.Open();

                String verificar = "SELECT u.nome FROM users u RIGHT JOIN role_user ru ON u.id = ru.users_id LEFT JOIN roles r ON ru.roles_id = r.id WHERE u.id" + StudentsId + ";";

                MySqlCommand comandos = new MySqlCommand(verificar, connection);
                alunos = comandos.ExecuteReader();

                while (alunos.Read())
                {
                    list = alunos["u.nome"].ToString() + Environment.NewLine;
                }

                connection.Close();
            }
            catch (Exception excecao)
            {
                throw new Exception("Mensagem de erro: " + excecao.Message);
            }
            return list;
        }
    }
}
