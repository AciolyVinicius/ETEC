using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SAGA
{
    class Desconexao
    {
        private MySqlConnection conexao; // Objeto de conexão com o banco       
        string caminho = "SERVER=localhost;DATABASE=db_csharp;UID=root;PASSWORD=root"; // Caminho para estabelecer conexão com o banco
        public void Desconectar()
        {
            try
            {
                conexao = new MySqlConnection(caminho);
                conexao.Close();
            }
            catch (Exception excecao)
            {
                throw new Exception("Erro de comandos: " + excecao.Message);
            }
        }
    }
}
