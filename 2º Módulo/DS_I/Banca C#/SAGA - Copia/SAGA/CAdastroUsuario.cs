using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SAGA
{
    class CadastroUsuario
    {

        private MySqlConnection conexao;
        public bool CadastrarUsuario(Cadastro registro)
        {
            Classe route = new SAGA.Classe();
            String caminho = route.Caminho();
            int linhas = 0;

            try
            {
                conexao = new MySqlConnection(caminho);
                conexao.Open();

                String inserir = "INSERT INTO tb_usuario (cd_tipo, nm_nome, nm_senha, nm_email) VALUES ( '" + registro.Tipo + "', '" + registro.Nome + "', '" + registro.Senha + "', '" + registro.Email + "');";

                MySqlCommand comandos = new MySqlCommand(inserir, conexao);
                linhas = comandos.ExecuteNonQuery();
                conexao.Close();
            }
            catch (Exception excecao)
            {
                throw new Exception("Erro ocorrido: " + excecao.Message);
            }

            if (linhas > 0)
                return true;
            else
                return false;
        }
    }
}
