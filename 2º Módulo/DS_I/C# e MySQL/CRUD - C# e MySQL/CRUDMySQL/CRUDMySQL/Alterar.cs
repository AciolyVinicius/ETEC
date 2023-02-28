using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient; // Importante - tem que estar em todas as classes de conexão com o banco.

namespace CRUDMySQL
{
    class Alterar
    {
        private MySqlConnection conexao; // Objeto de conexão com o banco        

        public bool Atualizar(AtualizarDados registro) /* Significa que a função Atualizar precisa 
            de um objeto da classe AtualizarDados como argumento*/
        {
            int linhas; // Para contar quantas linhas foram afetadas pela Query
            string caminho = "SERVER=localhost;DATABASE=db_csharp;UID=root;PASSWORD=patrickao"; // Caminho de acesso para o servidor
            string alterar = ""; // Linha de comando do SQL Script

            try
            {
                conexao = new MySqlConnection(caminho); // Instanciando objeto de conexão com o banco
                conexao.Open(); // Abrindo conexão

                if (registro.Nome_novo != null && registro.Nome_novo != "")  // Se o usuário preencheu o campo de nome novo, então
                {
                    /* Executo a seguinte instrução no SQL Script - Atualizo a tabela tb_usuario definindo que, onde houver o e-mail atual
                    descrito por ele, devo alterar a coluna nm_usuario para o dado que ele descreveu como nome novo no formulário */
                    alterar = "UPDATE tb_usuario SET nm_usuario = '" + registro.Nome_novo + "' WHERE nm_email = '" + registro.Email_atual + "';";
                }
                else if (registro.Email_novo != null && registro.Email_novo != "") // Senão, se o usuário preencheu o campo de e-mail novo, então
                {
                    /*Executo a instrução no SQL Script que diz para atualizar a tabela tb_usuario definindo que, onde houver o e-mail atual, 
                    descrito por ele, devo alterar a coluna nm_email para o dado que ele descreveu como e-mail novo no formulário */
                    alterar = "UPDATE tb_usuario SET nm_email = '" + registro.Email_novo + "' WHERE nm_email = '" + registro.Email_atual + "';";
                }
               
                MySqlCommand comandos = new MySqlCommand(alterar, conexao); // Executando Query

                linhas = comandos.ExecuteNonQuery(); // Obtendo quantas linhas foram afetadas pela Query
                conexao.Close(); // Fechando conexão com o banco

            }
            catch(Exception excecao)
            {
                // Se o processador encontrar algum erro no bloco de códigos acima, então o Catch dá um retorno com a mensagem de erro
                throw new Exception("Erro de comandos: " + excecao.Message);
            }

            if (linhas > 0) // Se alguma linha foi afetada no banco, 
                return true; // então retorno true
            else // Senão
                return false; // então retorno false
        }
    }
}
