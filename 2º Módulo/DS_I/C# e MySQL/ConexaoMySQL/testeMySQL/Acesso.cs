using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace testeMySQL
{
    class Acesso
    {
        private MySqlConnection conexao;

        public void Cadastro(Modelo mo)
        {
            string caminho = "SERVER=localhost;DATABASE=db_csharp;UID=root;PASSWORD=patrickao";

            try
            {
                conexao = new MySqlConnection(caminho);
                conexao.Open();

                string inserir = "INSERT INTO tb_usuario(nm_usuario, nm_email) VALUES ('" + mo.Nome + "','" + mo.Email + "')";

                MySqlCommand comandos = new MySqlCommand(inserir, conexao);

                comandos.ExecuteNonQuery();
                conexao.Close();
            }
            catch(Exception excecao)
            {
                throw new Exception("Erro de comandos: " + excecao.Message);
            }
        }
    }
}
