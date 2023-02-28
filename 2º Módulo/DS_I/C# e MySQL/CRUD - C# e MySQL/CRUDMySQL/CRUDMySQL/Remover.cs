using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient; // Importante - tem que estar em todas as classes de conexão com o banco

namespace CRUDMySQL
{
    class Remover
    {
        private MySqlConnection conexao; // Objeto de conexão que vem do pacote MySql.Data.MySqlClient
        
        public bool Excluir(ObterDados registro) /* Significa que, para chamar o método Excluir da classe Remover,
            é necessário enviar um objeto da classe ObterDados - a classe que permite o tráfico de dados entre o banco
            e o formulário*/
        {
            int linhas; // Para verificar se a quantia de registros afetados no banco é maior do que 0
            String caminho = "SERVER=localhost;DATABASE=db_csharp;UID=root;PASSWORD=patrickao"; // Caminho da conexão para o servidor
            String excluir = ""; // Comando de exclusão para o SQL Script
        
            try
            {
                conexao = new MySqlConnection(caminho); // Instanciando o objeto
                conexao.Open();

                if (registro.Email != null && registro.Email != "") // Se o usuário preencheu o campo 'e-mail'
                {
                    /* então eu executo o Query que diz paraa deletar da tabela tb_usuario os registros que contém
                    que contém o e-mail enunciado pelo usuário na coluna nm_email */
                    excluir = "DELETE FROM tb_usuario WHERE nm_email = '" + registro.Email + "';"; 
                }
                                
                MySqlCommand comandos = new MySqlCommand(excluir, conexao); // Executando Query               

                linhas = comandos.ExecuteNonQuery(); // Obtendo as linhas afetadas pela Query
                conexao.Close(); // Fechando conexão com o banco

            }
            catch(Exception excecao)
            {
                throw new Exception(excecao.Message); // Se houve alguma falha no try, o catch anuncia
            }

            if (linhas > 0) // Se alguma linha for afetada no banco, então
                return true; // Retorno true
            else // Senão, 
                return false; // então retorno false
        }
    }   
}
