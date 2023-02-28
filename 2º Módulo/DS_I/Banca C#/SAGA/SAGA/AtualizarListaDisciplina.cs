using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SAGA
{
    class AtualizarListaDisciplina
    {
        private MySqlConnection connection;
        public int DisciplinesNumbers()
        {
            int listar = 0;
            MySqlDataReader disciplinas;
            Caminho route = new Caminho();
            String path = route.Route();

            try
            {
                connection = new MySqlConnection(path);
                connection.Open();

                String verificar = "SELECT nm_disciplina FROM tb_disciplina;";

                MySqlCommand comandos = new MySqlCommand(verificar, connection);
                disciplinas = comandos.ExecuteReader();

                while (disciplinas.Read())
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

        public String DisciplinesList(int DisciplinesNumbers)
        {
            String list = "";
            MySqlDataReader disciplinas;
            Caminho route = new Caminho();
            String path = route.Route();

            try
            {
                connection = new MySqlConnection(path);
                connection.Open();

                String verificar = "SELECT nm_disciplina FROM tb_disciplina WHERE cd_disciplina =" + DisciplinesNumbers + ";";

                MySqlCommand comandos = new MySqlCommand(verificar, connection);
                disciplinas = comandos.ExecuteReader();

                while (disciplinas.Read())
                {
                    list = disciplinas["nm_disciplina"].ToString() + Environment.NewLine;
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
