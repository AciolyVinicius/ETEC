using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SAGA
{
    class Cadastro_Disciplina
    {
        private static String nome, descricao;
        private MySqlConnection conexao;

        public static string Descricao
        {
            get
            {
                return descricao;
            }

            set
            {
                descricao = value;
            }
        }

        public static string Nome
        {
            get
            {
                return nome;
            }

            set
            {
                nome = value;
            }
        }

        public Boolean InsertDiscipline()
        {
            Caminho route = new Caminho();
            String caminho = route.Route();
            int linhas = 0;



            try
            {
                conexao = new MySqlConnection(caminho);
                conexao.Open();

                string inserir = "INSERT INTO tb_disciplina (nm_disciplina, ds_disciplina) VALUES" +
                    "('" + Cadastro_Disciplina.Nome + "', '" + Cadastro_Disciplina.Descricao + "' );";

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
