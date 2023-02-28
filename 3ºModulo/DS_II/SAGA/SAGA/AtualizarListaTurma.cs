using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SAGA
{
    class AtualizarListaTurma
    {
        private MySqlConnection connection;
        public int ClassNumbers()
        {
            int listar = 0;
            MySqlDataReader turma;
            Caminho route = new Caminho();
            String path = route.Route();

            try
            {
                connection = new MySqlConnection(path);
                connection.Open();

                String verificar = "SELECT nome FROM turmas";

                MySqlCommand comandos = new MySqlCommand(verificar, connection);
                turma = comandos.ExecuteReader();

                while (turma.Read())
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

        public String ClassList(int CourseNumbers)
        {
            String list = "";
            MySqlDataReader turma;
            Caminho route = new Caminho();
            String path = route.Route();

            try
            {
                connection = new MySqlConnection(path);
                connection.Open();

                String verificar = "SELECT nome FROM turmas WHERE id =" + CourseNumbers + "";

                MySqlCommand comandos = new MySqlCommand(verificar, connection);
                turma = comandos.ExecuteReader();

                while (turma.Read())
                {
                    list = turma["nome"].ToString() + Environment.NewLine;
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
