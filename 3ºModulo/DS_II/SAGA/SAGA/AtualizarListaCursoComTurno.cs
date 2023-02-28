using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SAGA
{
    class AtualizarListaCursoComTurno
    {
        private MySqlConnection connection;
        public int BoutNumbers(String CourseName)
        {
            int listar = 0;
            MySqlDataReader turnos;
            Caminho route = new Caminho();
            String path = route.Route();

            try
            {
                connection = new MySqlConnection(path);
                connection.Open();

                String verificar = "SELECT t.* FROM turnos t  RIGHT JOIN disciplina_curso dc   ON t.id = dc.turnos_id   LEFT JOIN cursos c    ON dc.cursos_id = c.id      WHERE c.nome LIKE '%"+ CourseName +"%' GROUP BY t.id; ";

                MySqlCommand comandos = new MySqlCommand(verificar, connection);
                turnos = comandos.ExecuteReader();

                while (turnos.Read())
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

        public String BoutList(int BoutNumbers)
        {
            String list = "";
            MySqlDataReader turnos;
            Caminho route = new Caminho();
            String path = route.Route();

            try
            {
                connection = new MySqlConnection(path);
                connection.Open();

                String verificar = "SELECT ds_turno FROM turnos WHERE id =" + BoutNumbers + ";";

                MySqlCommand comandos = new MySqlCommand(verificar, connection);
                turnos = comandos.ExecuteReader();

                while (turnos.Read())
                {
                    list = turnos["ds_turno"].ToString() + Environment.NewLine;
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
