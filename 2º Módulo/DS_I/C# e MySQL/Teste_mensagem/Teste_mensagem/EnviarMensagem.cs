using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Teste_mensagem
{
    class EnviarMensagem
    {
        MySqlConnection conexao;

        public bool Enviar(Mensagem mensagem)
        {
            String caminho = "SERVER=localhost;DATABASE=db_mensagem;UID=root;PASSWORD=patrickao";
            int linhas;

            try
            {
                conexao = new MySqlConnection(caminho);
                conexao.Open();

                String insercao = "INSERT INTO tb_mensagem(ds_mensagem, cd_destinatario, cd_usuario) VALUES"
                    + "('" + mensagem.Mensagem_usuario + "', " + mensagem.Codigo_destinatario + ", " + mensagem.Codigo_usuario + ");";

                MySqlCommand comandos = new MySqlCommand(insercao, conexao);
                linhas = comandos.ExecuteNonQuery();
                conexao.Close();
            }
            catch(Exception excecao)
            {
                throw new Exception("Mensagem de erro: " + excecao.Message);
            }

            if (linhas > 0)
                return true;
            else
                return false;

        }
    }
}
