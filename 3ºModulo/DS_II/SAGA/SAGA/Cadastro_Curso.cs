using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SAGA
{
    class Cadastro_Curso
    {
        private static String nome, descricao;
        private MySqlConnection conexao;
        private static int carga_horaria;

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

        public static int Carga_horaria
        {
            get
            {
                return carga_horaria;
            }

            set
            {
                carga_horaria = value;
            }
        }

        public Boolean InsertCourse()
        {
            Caminho route = new Caminho();
            String caminho = route.Route();
            int linhas = 0;



            try
            {
                conexao = new MySqlConnection(caminho);
                conexao.Open();

                string inserir = "INSERT INTO cursos (nome, ds_curso, qt_carga_horaria) VALUES" +
                    "('" + Cadastro_Curso.Nome + "', '" + Cadastro_Curso.Descricao + "', " + Cadastro_Curso.Carga_horaria + " );";

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
