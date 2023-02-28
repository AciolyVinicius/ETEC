using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Aula02
{
    public partial class Frm_Delete : Form
    {
        FormCollection OpenForms;

        public Frm_Delete()
        {
            InitializeComponent();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            OpenForms = Application.OpenForms;
            foreach (Form Open in OpenForms)
            {
                if (Open.Name == "Frm_Login")
                    Open.Show();
            }
            this.Dispose();
        }

        private void Frm_Delete_Load(object sender, EventArgs e)
        {
            //Aceita somente letras minúsculas.
            txt_Usuario.CharacterCasing = CharacterCasing.Lower;
            txt_Password.CharacterCasing = CharacterCasing.Lower;
            //Transforma o textbox em caixa de senha.
            txt_Password.PasswordChar = '*';
            btn_Deletar.Visible = false;
        }

        private void Btn_Deletar_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_Pesquisa_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_Ptbd_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_Ptbd_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Apagar a Tabela?", "Zerando!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlConnection conexao = new SqlConnection(@"Data Source=127.0.0.1;Initial Catalog=dbDados;Integrated Security=True");
                String sql = "";
                sql = "DELETE FROM tb_login where nm_usuario!=''";
                SqlCommand comando = new SqlCommand(sql, conexao);
                int linhasAfetadas = 0;
                conexao.Open();
                linhasAfetadas = comando.ExecuteNonQuery();
                conexao.Close();
                if (linhasAfetadas != 0)
                {
                    lbl_Message.ForeColor = Color.Green;
                    lbl_Message.Text = "BANCO ZERADO!";
                    btn_Deletar.Visible = false;
                }
                else
                {
                    lbl_Message.ForeColor = Color.Red;
                    lbl_Message.Text = "ERRO!";
                }
            }
        }

        private void btn_Pesquisa_Click_1(object sender, EventArgs e)
        {
            if (txt_Usuario.Text.Trim() != "" && txt_Password.Text.Trim() != "")
            {
                SqlConnection conexao = new SqlConnection(@"Data Source=127.0.0.1;Initial Catalog=dbDados;Integrated Security=True");
                String usuarioBanco = "";
                String senhaBanco = "";
                String sql = "";
                sql = "SELECT nm_usuario, cd_senha FROM tb_usuario WHERE nm_usuario=@Usuario and cd_senha=@Senha";
                SqlCommand comando = new SqlCommand(sql, conexao);
                comando.Parameters.Add(new SqlParameter("@Usuario", SqlDbType.VarChar)).Value = txt_Usuario.Text;
                comando.Parameters.Add(new SqlParameter("@Senha", SqlDbType.VarChar)).Value = txt_Password.Text;
                SqlDataReader dr;
                conexao.Open();
                dr = comando.ExecuteReader();
                while (dr.Read())
                {
                    usuarioBanco = dr.GetString(0);
                    senhaBanco = dr.GetString(1);
                }
                conexao.Close();
                if (usuarioBanco.Trim() == txt_Usuario.Text.Trim() && senhaBanco.Trim() == txt_Password.Text.Trim())
                {
                    lbl_Message.Visible = true;
                    lbl_Message.ForeColor = Color.Green;
                    lbl_Message.Text = "Usuário Encontrado";
                    txt_Usuario.Enabled = false;
                    txt_Password.Enabled = false;
                    btn_Deletar.Visible = true;
                    btn_Pesquisa.Visible = false;
                }
                else
                {
                    lbl_Message.Visible = true;
                    txt_Usuario.Clear();
                    txt_Password.Clear();
                    lbl_Message.ForeColor = Color.Red;
                    lbl_Message.Text = "Usuário Inexistente";
                }
            }
            else
            {
                lbl_Message.Visible = true;
                txt_Usuario.Clear();
                txt_Password.Clear();
                lbl_Message.ForeColor = Color.Red;
                lbl_Message.Text = "Digite a senha!";
            }
        }

        private void btn_Deletar_Click_1(object sender, EventArgs e)
        {
            SqlConnection conexao = new SqlConnection(@"Data Source=127.0.0.1;Initial Catalog=dbDados;Integrated Security=True");
            String sql = "";
            sql = "DELETE FROM tb_usuario WHERE nm_usuario=@Usuario and cd_senha=@Senha";
            SqlCommand comando = new SqlCommand(sql, conexao);
            comando.Parameters.Add(new SqlParameter("@Usuario", SqlDbType.VarChar)).Value = txt_Usuario.Text;
            comando.Parameters.Add(new SqlParameter("@Senha", SqlDbType.VarChar)).Value = txt_Password.Text;
            int linhasAfetadas = 0;
            conexao.Open();
            linhasAfetadas = comando.ExecuteNonQuery();
            conexao.Close();
            if (linhasAfetadas != 0)
            {
                lbl_Message.ForeColor = Color.Green;
                lbl_Message.Text = "Excluido com Sucesso!";
                btn_Deletar.Visible = false;
            }
            else
            {
                lbl_Message.ForeColor = Color.Red;
                lbl_Message.Text = "ERRO!";
            }
        }

        private void btn_Back_Click_1(object sender, EventArgs e)
        {
            OpenForms = Application.OpenForms;
            foreach (Form Open in OpenForms)
            {
                if (Open.Name == "Frm_Login")
                    Open.Show();
            }
            this.Dispose();
        }
    }
}
