using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient; // Importante - tem que estar em todas as classes de conexão com o banco.

namespace CRUDMySQL
{
    class Inserir
    {
        private MySqlConnection conexao; // Objeto de conexão com o banco       

        public bool Cadastrar(ObterDados registro) /* Significa que o método só é executado
            se um objeto da classe ObterDados for enviado como argumento */
        {
            int linhas; // Quantia de linhas afetadas durante a execução do comando
            string caminho = "SERVER=localhost;DATABASE=db_csharp;UID=root;PASSWORD=patrickao"; // Caminho para estabelecer conexão com o banco

            try
            {
                conexao = new MySqlConnection(caminho); // Instanciando objeto de conexão com o banco
                conexao.Open(); // Abrindo conexão

                // String de inserção dos dados inseridos no formulário
                string inserir = "INSERT INTO tb_usuario(nm_usuario, nm_email) VALUES ('" + registro.Nome + "', '" + registro.Email + "');";

                MySqlCommand comandos = new MySqlCommand(inserir, conexao); // Executando Query

                linhas = comandos.ExecuteNonQuery(); // Obtendo quantia de linhas afetadas pelo Query
                conexao.Close(); // Fechando conexão 
            }
            catch(Exception excecao)
            {
                // Caso ocorra algum erro durante a execução das instruções acima, o erro é descrito
                throw new Exception("Erro de comandos: " + excecao.Message);
            }

            if (linhas > 0) // Se alguma linha foi afetada durante a execução do Query, então
                return true; // Retorno true
            else // Se não, então
                return false; // Retorno false
        }
    }
}
