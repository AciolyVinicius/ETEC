using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SAGA
{
    class PesquisaAluno
    {
        private MySqlConnection connection;
        public int StudentsNumbers(String StudentName)
        {
            int listar = 0;
            MySqlDataReader alunos;
            Caminho route = new Caminho();
            String path = route.Route();

            try
            {
                connection = new MySqlConnection(path);
                connection.Open();

                String verificar = "SELECT u.nome FROM users u RIGHT JOIN role_user ru ON u.id = ru.users_id LEFT JOIN roles r ON ru.roles_id = r.id WHERE r.id = 4 AND u.nome = '%"+ StudentName + "';";

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
        public String StudentsList(String StudentsName)
        {
            String list = "";
            MySqlDataReader alunos;
            Caminho route = new Caminho();
            String path = route.Route();

            try
            {
                connection = new MySqlConnection(path);
                connection.Open();

                String verificar = "SELECT u.nome FROM users u RIGHT JOIN role_user ru ON u.id = ru.users_id LEFT JOIN roles r ON ru.roles_id = r.id WHERE r.id = 4 and u.nome = '%" + StudentsName + "%';";

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
