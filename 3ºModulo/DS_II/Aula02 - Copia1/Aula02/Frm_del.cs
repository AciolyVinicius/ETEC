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
    public partial class Frm_del : Form
    {
        public Frm_del()
        {
            InitializeComponent();
        }

        private void btn_pesquisar_Click(object sender, EventArgs e)
        {
            SqlConnection conexao = new SqlConnection(@"Data Source=127.0.0.1;Initial Catalog=dbDados;Integrated Security=True");
            String sql = "SELECT nm_usuario, cd_senha FROM tb_login WHERE nm_usuario=@usuario and cd_senha=@senha";
            SqlCommand comando = new SqlCommand(sql, conexao);
            comando.Parameters.Add(new SqlParameter("@usuario", SqlDbType.VarChar)).Value = txt_UsuarioDel.Text;
            comando.Parameters.Add(new SqlParameter("@senha", SqlDbType.VarChar)).Value = txt_PasswordDel.Text;
            int linhasAfetadas = 0;
            conexao.Open();
            linhasAfetadas = comando.ExecuteNonQuery();
            conexao.Close();
            if (linhasAfetadas != 0)
            {
                lbl_del.ForeColor = Color.Green;
                lbl_del.Text = "Usuário encontrado!";
                btn_deletar.Visible = true;
                btn_pesquisar.Visible = false;
                txt_PasswordDel.Enabled = false;
                btn_deletar.Visible = false;
            }
            else
            {
                lbl_del.ForeColor = Color.Red;
                lbl_del.Text = "ERROR!";
            }
        }

        private void btn_deletar_Click(object sender, EventArgs e)
        {
            SqlConnection conexao = new SqlConnection(@"Data Source=127.0.0.1;Initial Catalog=dbDados;Integrated Security=True");
            String sql = "DELETE FROM tb_login WHERE nm_usuario=@usuario and cd_senha=@senha";
            SqlCommand comando = new SqlCommand(sql, conexao);
            comando.Parameters.Add(new SqlParameter("@usuario", SqlDbType.VarChar)).Value = txt_UsuarioDel.Text;
            comando.Parameters.Add(new SqlParameter("@senha", SqlDbType.VarChar)).Value = txt_PasswordDel.Text;
            int linhasAfetadas = 0;
            conexao.Open();
            linhasAfetadas = comando.ExecuteNonQuery();
            conexao.Close();
            if (linhasAfetadas != 0)
            {
                lbl_del.ForeColor = Color.Green;
                lbl_del.Text = "Excluído com sucesso!";
                txt_UsuarioDel.Enabled = false;
            }
            else
            {
                lbl_del.ForeColor = Color.Red;
                lbl_del.Text = "ERROR!";
            }
        }
    }
}
