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
    public partial class Frm_Update : Form
    {
        FormCollection OpenForms;

        public Frm_Update()
        {
            InitializeComponent();
        }

        private void btn_Pesquisa_Click(object sender, EventArgs e)
        {
            if (txt_Usuario.Text.Trim() != "")
            {
                SqlConnection conexao = new SqlConnection(@"Data Source=127.0.0.1;Initial Catalog=dbDados;Integrated Security=True");
                String usuarioBanco = "";
                String sql = "";
                sql = "SELECT nm_usuario FROM tb_usuario WHERE nm_usuario=@Usuario";
                SqlCommand comando = new SqlCommand(sql, conexao);
                comando.Parameters.Add(new SqlParameter("@Usuario", SqlDbType.VarChar)).Value = txt_Usuario.Text;
                SqlDataReader dr;
                conexao.Open();
                dr = comando.ExecuteReader();
                while (dr.Read())
                {
                    usuarioBanco = dr.GetString(0);
                }
                conexao.Close();
                if (usuarioBanco != "")
                {
                    lbl_Message.Visible = true;
                    lbl_Message.ForeColor = Color.Green;
                    lbl_Message.Text = "Usuário Encontrado";
                    txt_Usuario.Enabled = false;
                    txt_Password.Enabled = true;
                    btn_Update.Visible = true;
                    btn_Pesquisa.Visible = false;
                    btn_Update.Visible = true;
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
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            SqlConnection conexao = new SqlConnection(@"Data Source=127.0.0.1;Initial Catalog=dbDados;Integrated Security=True");
                      
                String sql = "";
                sql = "UPDATE tb_usuario SET cd_senha=@Senha WHERE nm_usuario=@Usuario";
                SqlCommand comando1 = new SqlCommand(sql, conexao);
                comando1.Parameters.Add(new SqlParameter("@Usuario", SqlDbType.VarChar)).Value = txt_Usuario.Text;
                comando1.Parameters.Add(new SqlParameter("@Senha", SqlDbType.VarChar)).Value = txt_Password.Text;
                int linhasAfetadas = 0;
                conexao.Open();
                linhasAfetadas = comando1.ExecuteNonQuery();
                conexao.Close();
                if (linhasAfetadas != 0)
                {
                    lbl_Message.ForeColor = Color.Green;
                    lbl_Message.Text = "Atualizado com Sucesso!";
                    txt_Password.Enabled = false;
                    txt_Password.Text = "";
                    txt_Usuario.Enabled = false;
                }
                else
                {
                    lbl_Message.ForeColor = Color.Red;
                    lbl_Message.Text = "ERRO!";
                }
            
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

        private void Frm_Update_Load(object sender, EventArgs e)
        {
            txt_Usuario.CharacterCasing = CharacterCasing.Lower;
            txt_Password.CharacterCasing = CharacterCasing.Lower;
            txt_Password.PasswordChar = '*';
        }
    }
}
