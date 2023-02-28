using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SAGA
{
    class AtualizarListaCurso
    {
        private MySqlConnection connection;
        public int CourseNumbers()
        {
            int listar = 0;
            MySqlDataReader cursos;
            Caminho route = new Caminho();
            String path = route.Route();

            try
            {
                connection = new MySqlConnection(path);
                connection.Open();

                String verificar = "SELECT nome FROM cursos";

                MySqlCommand comandos = new MySqlCommand(verificar, connection);
                cursos = comandos.ExecuteReader();

                while (cursos.Read())
                {
                    listar+=1;
                }

                connection.Close();
            }
            catch (Exception excecao)
            {
                throw new Exception("Mensagem de erro: " + excecao.Message);
            }
            return listar;
        }

        public String CourseList(int CourseNumbers)
        {
            String list = "";
            MySqlDataReader cursos;
            Caminho route = new Caminho();
            String path = route.Route();

            try
            {
                connection = new MySqlConnection(path);
                connection.Open();

                String verificar = "SELECT nome FROM cursos WHERE id =" + CourseNumbers+"";

                MySqlCommand comandos = new MySqlCommand(verificar, connection);
                cursos = comandos.ExecuteReader();

                while (cursos.Read())
                {
                    list = cursos["nome"].ToString() + Environment.NewLine;
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
