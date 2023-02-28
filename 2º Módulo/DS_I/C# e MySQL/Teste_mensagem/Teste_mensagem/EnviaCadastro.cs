using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Teste_mensagem
{
    class EnviaCadastro
    {
        private MySqlConnection conexao;
        
        public bool CadastrarUsuario(Cadastrar registro)
        {
            int linhas;
            String caminho = "SERVER=localhost;DATABASE=db_mensagem;UID=root;PASSWORD=patrickao";

            try
            {
                conexao = new MySqlConnection(caminho);
                conexao.Open();

                String inserir = "INSERT INTO tb_usuario(nm_usuario, cd_login, cd_senha)" 
                    + "VALUES ('" + registro.Nome_usuario + "', '" + registro.Nome_login + "', '" + registro.Senha_usuario + "');";

                MySqlCommand comandos = new MySqlCommand(inserir, conexao);
                linhas = comandos.ExecuteNonQuery();
                conexao.Close();
            }
            catch(Exception excecao)
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
