using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Aula02
{
    public partial class Frm_login : Form
    {
        public Frm_login()
        {
            InitializeComponent();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Deseja Finalizar?", "Finalizando!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btn_Ok_Click(object sender, EventArgs e)
        {
            //Criando Objeto de Conexão, passando a string de conexão
            //O servidor, banco, usuario e senha do SQL
            //SqlConnection conexao = SqlConnection(@"Data Source=NomeDoServidor;Initial Catalog=NomeDoBanco;UserId=login, Password=senha");
            SqlConnection conexao = new SqlConnection(@"Data Source=127.0.0.1;Initial Catalog=dbDados;Integrated Security=True");

            //Variaveis que futuramente irão armazenar os dados vindos do banco 
            String usuariobanco = "";
            String senhaBanco = "";

            //Prevenindo o SQL Inject não será utilizado na forma abaixo
            //Cria um novo comando, passando o sql e a conexao criada
            /*
            SqlCommand comando = new SqlCommand("SELECT [nm_usuaro], [cd_senha] FROM [dbo].[tb_login] WHERE nm_usuario ='" + txt_Usuario.Text + "' AND cd_senha = '" + txt_Password + "'", conexao);
            */
            //Prevenindo o SQL Inject será utilizado na forma abaixo
            SqlCommand comando = new SqlCommand("SELECT [nm_usuario], [cd_senha] FROM [dbo].[tb_login] WHERE nm_usuario =@usuario" + " AND cd_senha =@senha", conexao);
            comando.Parameters.Add(new SqlParameter("@usuario", SqlDbType.VarChar)).Value = txt_Usuario.Text;
            comando.Parameters.Add(new SqlParameter("@senha", SqlDbType.VarChar)).Value = txt_Password.Text;

            //Cria um objeto DataReader que vai receber os dados lidos 
            SqlDataReader dr;

            //Abrindo o banco
            conexao.Open();

            //Executando a leitura
            dr = comando.ExecuteReader();

            //O método Read retorna um boolean, que diz se existe tal valor
            //no caso abaixo. enquanto existirem resultados ele estará rodando
            //e em cada loop o 'dr' vai representar uma linha diferente do resultado
            // no nosso caso provavelmente só ira haver um loop
            //portanto estarei inserindo direto as variáveis e não um array
            while (dr.Read())
            {
                //dr.Read();
                //getString pois o valor é string, o numero significando o posicionamento da coluna
                //no query executado
                usuariobanco = dr.GetString(0); //GetString pois é variável alfanumérica
                senhaBanco = dr.GetString(1);//Poderia ser GetInt, GetBoolean, Etc.
            }

            //Fercho a minha conexao
            conexao.Close();

            if (usuariobanco.Trim() == txt_Usuario.Text.Trim() && senhaBanco.Trim() == txt_Password.Text.Trim()&& txt_Usuario.Text.Trim()!=""&& txt_Password.Text.Trim()!="")
            {
                lbl_Message.Visible = true;
                lbl_Message.ForeColor = Color.Green;
                lbl_Message.Text = "Entrada Permitida";
                txt_Usuario.Clear();
                txt_Password.Clear();
            }
            else
            {
               lbl_Message.Visible = true;
                lbl_Message.ForeColor = Color.Red;
                lbl_Message.Text = "Entrada Negada";
            }
        }
    }
}
