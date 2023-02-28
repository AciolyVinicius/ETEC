using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Teste_mensagem
{
    class ObterCodigoDestinatario
    {
        MySqlConnection conexao;

        public int codigoDestinatario(String nome_destinatario)
        {
            String caminho = "SERVER=localhost;DATABASE=db_mensagem;UID=root;PASSWORD=patrickao";
            int codigo_destinatario = -1;
            MySqlDataReader resultado_query;

            try
            {
                conexao = new MySqlConnection(caminho);
                conexao.Open();

                String selecionar = "SELECT cd_usuario FROM tb_usuario WHERE nm_usuario = '" + nome_destinatario + "';";

                MySqlCommand comandos = new MySqlCommand(selecionar, conexao);
                resultado_query = comandos.ExecuteReader();
                while (resultado_query.Read())
                {
                    codigo_destinatario = int.Parse(resultado_query["cd_usuario"].ToString());
                }

                conexao.Close();
            }
            catch(Exception excecao)
            {
                throw new Exception("Mensagem de erro: " + excecao.Message);
            }

            if (codigo_destinatario > -1)
                return codigo_destinatario;
            else
                return 0;
        }
    }
}
