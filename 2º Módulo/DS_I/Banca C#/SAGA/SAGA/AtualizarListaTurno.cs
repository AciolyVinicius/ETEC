using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SAGA
{
    class AtualizarListaTurno
    {
        private MySqlConnection connection;
        public int BoutNumbers()
        {
            int listar = 0;
            MySqlDataReader turnos;
            Caminho route = new Caminho();
            String path = route.Route();

            try
            {
                connection = new MySqlConnection(path);
                connection.Open();

                String verificar = "SELECT nome FROM turnos;";

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
