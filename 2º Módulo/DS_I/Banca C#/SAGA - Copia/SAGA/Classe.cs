using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SAGA
{
    class Classe
    {
        private MySqlConnection conexao;

        public String Caminho()
        {
            string caminho = "SERVER=localhost;DATABASE=c;UID=root;PASSWORD=bitnami"; // Caminho para estabelecer conexão com o banco
            return caminho;
        }
        public void Inserir()
        {
            Conexao conexao = new Conexao();
            conexao.Conectar();

            String caminho = Caminho();


            Desconexao desconexao = new Desconexao();
            desconexao.Desconectar();
        }
        //Para logar
        private String nome_login;
        private String senha_usuario;

        public String Nome_login
        {
            get { return nome_login; }
            set { nome_login = value; }
        }

        public String Senha_usuario
        {
            get { return senha_usuario; }
            set { senha_usuario = value; }
        }

        public static string Emaill
        {
            get
            {
                return emaill;
            }

            set
            {
                emaill = value;
            }
        }

        public static string Nomee
        {
            get
            {
                return nomee;
            }

            set
            {
                nomee = value;
            }
        }

        public bool Verificar(Classe registro)
        {
            MySqlDataReader teste;
            int linhas = 0;
            String caminho = Caminho();

            try
            {
                conexao = new MySqlConnection(caminho);
                conexao.Open();

                String verificar = "SELECT nm_usuario FROM tb_usuario"
                    + " WHERE nm_email = '" + registro.Nome_login + "' and nm_senha = '" + registro.Senha_usuario + "';";

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

        private static String emaill;
        private static String nomee;

        public String Nm_nome(Classe registro)
        {
            MySqlDataReader name;
            int linhas = 0;
            String caminho = Caminho();
            String nome = "";

            try
            {
                conexao = new MySqlConnection(caminho);
                conexao.Open();

                String verificar = "SELECT nm_nome FROM usuario"
                    + " WHERE nm_email = '" + registro.Nome_login + "' and nm_senha = '" + registro.Senha_usuario + "';";

                MySqlCommand comandos = new MySqlCommand(verificar, conexao);
                name = comandos.ExecuteReader();
                    while (name.Read()) // Enquanto houver registros de resultado,
                    {
                        // Acumulo-os na variável resultado, sempre quebrando linha
                        nome = nome + name["nm_nome"].ToString();

                    }
                conexao.Close();
            }
            catch
            { 
                
            }

            return nome;
        }
    }
}

