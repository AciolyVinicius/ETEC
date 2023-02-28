using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms; // Importante - tem que estar em todas as classes de conexão com o banco

namespace CRUDMySQL
{
    class Selecionar
    {
        private MySqlConnection conexao; // Objeto de conexão com o banco de dados

        public string Pesquisar(ObterDados registro) /* Significa que, para que o método seja executado,
            ele necessita de um objeto da classe ObterDados - responsável por obter e enviar os dados
            do formulário ao banco e vice-versa */
        {
            MySqlDataReader semi_resultado; // Para obter o resultado da Query, do SELECT no caso
            string resultado = ""; // O retorno do método, que é o SELECT
            string caminho = "SERVER=localhost;DATABASE=db_csharp;UID=root;PASSWORD=patrickao"; // Caminho de conexão

            try
            {
                conexao = new MySqlConnection(caminho); // Estabelecendo conexão com o banco
                conexao.Open(); // Abrindo conexão
                String selecionar = ""; // Para o comando SQL Script

                if (registro.Nome != null && registro.Nome != "") // Selecionar através do nome
                {
                    /* O comando do SQL Script - selecionar os registros da tabela tb_usuario onde, na coluna
                    nm_usuario, haja o nome descrito pelo usuário */
                    selecionar = "SELECT * FROM tb_usuario WHERE nm_usuario = '" + registro.Nome + "';";
                }
                else if (registro.Email != null && registro.Email != "") // Selecionar através do e-mail
                {
                    /* O comando do SQL Script - selecionar os registros da tabela tb_usuario onde, na coluna
                    nm_usuario, haja o e-mail descrito pelo usuário */
                    selecionar = "SELECT * FROM tb_usuario WHERE nm_email = '" + registro.Email + "';";
                }
                else // Selecionar através do código
                {
                    /* O comando do SQL Script - selecionar os registros da tabela tb_usuario onde, na coluna
                    nm_usuario, haja o código descrito pelo usuário */
                    selecionar = "SELECT * FROM tb_usuario WHERE cd_usuario = " + registro.Codigo + ";"; 
                }

                MySqlCommand comandos; // Objeto para executar o Query

                if (selecionar != "")
                {
                    comandos = new MySqlCommand(selecionar, conexao); // Instanciando objeto para execução do Query
                    semi_resultado = comandos.ExecuteReader(); // Obtendo resultado do Query - o SELECT

                    while (semi_resultado.Read()) // Enquanto houver registros de resultado,
                    {
                        // Acumulo-os na variável resultado, sempre quebrando linha
                        resultado = resultado + semi_resultado["cd_usuario"].ToString() + " | " + semi_resultado["nm_usuario"] + " | " + semi_resultado["nm_email"] + "\n";
                        
                    }                    
                }                
                conexao.Close(); // Fechando conexão
            }
            catch(Exception excecao)
            {
                // Caso ocorra algum durante a execução das instruções acima, ele é descrito
                throw new Exception("Erro de comandos: " + excecao.Message); 
            }

            return resultado; // Retornar o resultado da Query - o SELECT
        }
    }
}
