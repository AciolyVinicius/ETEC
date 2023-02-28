using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SAGA
{
    class Conexao
    {
        private MySqlConnection conexao; // Objeto de conexão com o banco       
        string caminho = "SERVER=localhost;DATABASE=db_csharp;UID=root;PASSWORD=root"; // Caminho para estabelecer conexão com o banco
        public void Conectar()
        {
            try
            {
                conexao = new MySqlConnection(caminho); // Instanciando objeto de conexão com o banco
                conexao.Open(); // Abrindo conexão
            }
            catch (Exception excecao)
            {
                // Caso ocorra algum erro durante a execução das instruções acima, o erro é descrito
                throw new Exception("Erro de comandos: " + excecao.Message);
            }
        }
    }
}
