using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula02
{
    public partial class Frm_full : Form
    {
        public Frm_full()
        {
            InitializeComponent();
        }

        private void tb_loginBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tb_loginBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dbDadosDataSet);
        }

        private void Frm_full_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbDadosDataSet.tb_login' table. You can move, or remove it, as needed.
            this.tb_loginTableAdapter.Fill(this.dbDadosDataSet.tb_login);
        }

        private void btn_incluirFull_Click(object sender, EventArgs e)
        {
            if(txt_UsuarioFull.Text != "" && txt_PasswordFull.Text != "" && txt_ConfirmFull.Text != "" && txt_PasswordFull.Text == txt_ConfirmFull.Text)
            {
                // Para futura conexão
                SqlConnection conexao = new SqlConnection(@"Data Source=127.0.0.1;Initial Catalog=dbDados;Integrated Security=True");

                // String para, futuramente, guardar o resultado que vai sair do read
                String usuariobanco = "";

                // É um select, que vai retornar um valor, pois não podera ser cadastrado usuarios com nomes iguais
                // @ para proteção contra Sql Injection
                // Olha que a conexao esta sendo utilizada agora, pois estamos utilizando um sqlCommand
                SqlCommand comando = new SqlCommand("SELECT nm_usuario FROM tb_login WHERE nm_usuario = @usuario", conexao);
                // Nós vamos substituir o @usuario pelo o q foi digitado, que vai ser um sqlparameter igual a varchar
                comando.Parameters.Add(new SqlParameter("@usuario", SqlDbType.VarChar)).Value = txt_UsuarioFull.Text;

                // Váriavel para ler no banco futuramente 
                SqlDataReader dr;

                // Abrimos uma conexão
                conexao.Open();

                // Guardamos o que foi processado lá no comando na variavel dr, com o select para ser lido
                dr = comando.ExecuteReader();

                // Vai ler tudo que tiver
                while (dr.Read())
                {
                    // Pegara o que for exibido da primeira coluna e guardara na variavel que nos utilizaremos para comparar se existe resultado ou não
                    usuariobanco = dr.GetString(0);
                }

                // Encerramos a conexao que fora inicializada
                conexao.Close();

                // Vejo se a variavel guarda algum valor, evidenciando se existe um usuario com mesmo nome, que fora pesquisado atraves do select
                if (usuariobanco == "")
                {

                    // Comeco a fazer o codigo para insert
                    String sql = "";

                    // Variavel para comecar o insert no banco 
                    sql = "insert into tb_login (nm_usuario, cd_senha) values (@usuario, @senha)";

                    // Comeco a editar o sqlcommand para inserir
                    SqlCommand comando2 = new SqlCommand(sql, conexao);

                    // Comeco a trocar os @ para o que foi digitado, Segurança
                    comando2.Parameters.Add(new SqlParameter("@usuario", SqlDbType.VarChar)).Value = txt_UsuarioFull.Text;
                    comando2.Parameters.Add(new SqlParameter("@senha", SqlDbType.VarChar)).Value = txt_PasswordFull.Text;

                    //Para verificar se ocorreu o insert
                    int linhasAfetadas = 0;

                    // Inicio a conexao
                    conexao.Open();

                    // Executo o comando e recebo a quantidade de linhas que foram afetadas
                    linhasAfetadas = comando2.ExecuteNonQuery();

                    // Fercho a conexão
                    conexao.Close();

                    // Verifico se o código rodou no banco
                    if (linhasAfetadas != 0)
                    {
                        lbl_MessageFull.Text = "Cadastro Realizado";
                        lbl_MessageFull.ForeColor = Color.Green;
                    }
                    else
                    {
                        lbl_MessageFull.Text = "ERRO!";
                        lbl_MessageFull.ForeColor = Color.Red;
                    }
                }
                else
                {
                    lbl_MessageFull.Text = "Usuário Já Existente!!";
                    lbl_MessageFull.ForeColor = Color.Red;
                    txt_UsuarioFull.Clear();
                    txt_UsuarioFull.Focus();
                }
            }
            else
            {
                MessageBox.Show("Digite todos os dados corretamente!");
            }
            this.tb_loginTableAdapter.Fill(this.dbDadosDataSet.tb_login);
        }

        private void btn_exluirFull_Click(object sender, EventArgs e)
        {
            SqlConnection conexao = new SqlConnection(@"Data Source=127.0.0.1;Initial Catalog=dbDados;Integrated Security=True");
            String sql = "DELETE FROM tb_login WHERE nm_usuario=@usuario";
            SqlCommand comando = new SqlCommand(sql, conexao);
            comando.Parameters.Add(new SqlParameter("@usuario", SqlDbType.VarChar)).Value = tb_loginDGV.CurrentRow.Cells[0].Value.ToString();
            int linhasAfetadas = 0;
            conexao.Open();
            linhasAfetadas = comando.ExecuteNonQuery();
            conexao.Close();
            if (linhasAfetadas != 0)
            {
                lbl_MessageFull.ForeColor = Color.Green;
                lbl_MessageFull.Text = "Excluído com sucesso!";
            }
            else
            {
                lbl_MessageFull.ForeColor = Color.Red;
                lbl_MessageFull.Text = "ERROR!";
            }
            this.tb_loginTableAdapter.Fill(this.dbDadosDataSet.tb_login);
        }

        private void btn_updateFull_Click(object sender, EventArgs e)
        {
            if (txt_UsuarioFull.Text != "" && txt_PasswordFull.Text != "" && txt_ConfirmFull.Text != "" && txt_PasswordFull.Text == txt_ConfirmFull.Text) {
                SqlConnection conexao = new SqlConnection(@"Data Source=127.0.0.1;Initial Catalog=dbDados;Integrated Security=True");

                String usuariobanco = "";

                SqlCommand comando = new SqlCommand("SELECT nm_usuario FROM tb_login WHERE nm_usuario = @usuario", conexao);
                comando.Parameters.Add(new SqlParameter("@usuario", SqlDbType.VarChar)).Value = txt_UsuarioFull.Text;

                SqlDataReader dr;

                conexao.Open();

                dr = comando.ExecuteReader();

                while (dr.Read())
                {
                    usuariobanco = dr.GetString(0);
                }

                conexao.Close();

                if (usuariobanco == "")
                {
                    SqlConnection conexao1 = new SqlConnection(@"Data Source=127.0.0.1;Initial Catalog=dbDados;Integrated Security=True");
                    String sql = "UPDATE tb_login SET cd_senha=@senha, nm_usuario=@usuarioset WHERE nm_usuario=@usuario";
                    SqlCommand comando1 = new SqlCommand(sql, conexao);
                    comando1.Parameters.Add(new SqlParameter("@usuario", SqlDbType.VarChar)).Value = tb_loginDGV.CurrentRow.Cells[0].Value.ToString();
                    comando1.Parameters.Add(new SqlParameter("@usuarioset", SqlDbType.VarChar)).Value = txt_UsuarioFull.Text;
                    comando1.Parameters.Add(new SqlParameter("@senha", SqlDbType.VarChar)).Value = txt_PasswordFull.Text;
                    int linhasAfetadas = 0;
                    conexao.Open();
                    linhasAfetadas = comando1.ExecuteNonQuery();
                    conexao.Close();
                    if (linhasAfetadas != 0)
                    {
                        lbl_MessageFull.ForeColor = Color.Green;
                        lbl_MessageFull.Text = "Atualizado com sucesso!";
                    }
                    else
                    {
                        lbl_MessageFull.ForeColor = Color.Red;
                        lbl_MessageFull.Text = "ERROR!";
                    }
                }
            }
            this.tb_loginTableAdapter.Fill(this.dbDadosDataSet.tb_login);
        }

        private void btn_zerarFull_Click(object sender, EventArgs e)
        {
            SqlConnection conexao = new SqlConnection(@"Data Source=127.0.0.1;Initial Catalog=dbDados;Integrated Security=True");
            String sql = "DELETE FROM tb_login WHERE nm_usuario!=''";
            SqlCommand comando = new SqlCommand(sql, conexao);
            int linhasAfetadas = 0;
            conexao.Open();
            linhasAfetadas = comando.ExecuteNonQuery();
            conexao.Close();
            if (linhasAfetadas != 0)
            {
                lbl_MessageFull.ForeColor = Color.Green;
                lbl_MessageFull.Text = "Excluído com sucesso!";
            }
            else
            {
                lbl_MessageFull.ForeColor = Color.Red;
                lbl_MessageFull.Text = "ERROR!";
            }
        }
    }
}
