using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Teste_mensagem
{
    class VerificaCadastro
    {
        private MySqlConnection conexao;

        public bool Verificar(Entrar registro)
        {
            MySqlDataReader teste;
            int linhas = 0;            
            String caminho = "SERVER=localhost;DATABASE=db_mensagem;UID=root;PASSWORD=patrickao";

            try
            {
                conexao = new MySqlConnection(caminho);
                conexao.Open();

                String verificar = "SELECT cd_usuario FROM tb_usuario"
                    + " WHERE cd_login = '" + registro.Nome_login + "' and cd_senha = '" + registro.Senha_usuario + "';";

                MySqlCommand comandos = new MySqlCommand(verificar, conexao);
                teste = comandos.ExecuteReader();

                while (teste.Read())
                {
                    linhas = linhas + 1;
                }
                conexao.Close();                
            }
            catch (Exception excecao)
            {
                throw new Exception("Mensagem de erro: " + excecao.Message);
            }

            if (linhas > 0)
                return true;
            else
                return false;
        }

        public int ObterCodigo(Entrar registro)
        {
            String caminho = "SERVER=localhost;DATABASE=db_mensagem;UID=root;PASSWORD=patrickao";
            MySqlDataReader obterResultado;
            int codigo = 0;
            try
            {
                conexao = new MySqlConnection(caminho);
                conexao.Open();

                String verificar = "SELECT cd_usuario FROM tb_usuario"
                    + " WHERE cd_login = '" + registro.Nome_login + "' and cd_senha = '" + registro.Senha_usuario + "';";

                MySqlCommand comandos = new MySqlCommand(verificar, conexao);
                obterResultado = comandos.ExecuteReader();
                while (obterResultado.Read())
                {
                    codigo = int.Parse(obterResultado["cd_usuario"].ToString());
                }

                conexao.Close();
            }
            catch (Exception excecao)
            {
                throw new Exception("Mensagem de erro: " + excecao.Message);
            }

            return codigo;
        }

    }
}
