using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Teste_mensagem
{
    class ReceberMensagem
    {
        MySqlConnection conexao;

        public String mensagem(Mensagem recebe)
        {
            String resultado = "";
            String caminho = "SERVER=localhost;DATABASE=db_mensagem;UID=root;PASSWORD=patrickao";
            MySqlDataReader leitura;

            try
            {
                conexao = new MySqlConnection(caminho);
                conexao.Open();

                String selecao = "SELECT tb_usuario.nm_usuario, tb_mensagem.ds_mensagem "
                + "FROM tb_mensagem JOIN tb_usuario "
                + "ON tb_mensagem.cd_usuario = tb_usuario.cd_usuario "
                + "WHERE tb_mensagem.cd_destinatario = " + recebe.Codigo_usuario + " OR tb_mensagem.cd_usuario = " + recebe.Codigo_usuario + ";";

                MySqlCommand comandos = new MySqlCommand(selecao, conexao);
                leitura = comandos.ExecuteReader();

                while (leitura.Read())
                {
                    resultado = resultado + leitura["nm_usuario"] + ": " + leitura["ds_mensagem"] + Environment.NewLine;                  
                }

                return resultado;
            }
            catch (Exception excecao)
            {
                throw new Exception("Mensagem de erro: " + excecao.Message);
            }           
        }
    }
}
