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
    public partial class Frm_Insert : Form
    {
        FormCollection OpenForms;

        public Frm_Insert()
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

        private void Frm_Insert_Load(object sender, EventArgs e)
        {
            //Aceita somente letras minúsculas.
            txt_Usuario.CharacterCasing = CharacterCasing.Lower;
            txt_Password.CharacterCasing = CharacterCasing.Lower;
            txt_Confirm.CharacterCasing = CharacterCasing.Lower;
            //Transforma o textbox em caixa de senha.
            txt_Password.PasswordChar = '*';
            txt_Confirm.PasswordChar = '*';
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (txt_Password.Text == txt_Confirm.Text)
            {
                /////ATIVIDADE DA MENÇÃO
                SqlConnection conexao = new SqlConnection(@"Data Source=127.0.0.1;Initial Catalog=dbDados;Integrated Security=True");
                String usuarioBanco = "";
                String senhaBanco = "";
                String sql = "";
                sql = "SELECT nm_usuario, cd_senha FROM tb_usuario WHERE nm_usuario=@Usuario";
                SqlCommand comandoSelect = new SqlCommand(sql, conexao);
                comandoSelect.Parameters.Add(new SqlParameter("@Usuario", SqlDbType.VarChar)).Value = txt_Usuario.Text;
                SqlDataReader dr;
                conexao.Open();
                dr = comandoSelect.ExecuteReader();
                while (dr.Read())
                {
                    usuarioBanco = dr.GetString(0);
                }
                conexao.Close();
                if (usuarioBanco.Trim() != txt_Usuario.Text.Trim() && senhaBanco.Trim() != txt_Password.Text.Trim() && txt_Usuario.Text.Trim() != "" && txt_Password.Text.Trim() != "")
                {
                    //SqlConnection conexao = new SqlConnection(@"Data Source=WINDOWS\SQLEXPRESS;Initial Catalog=dados;Integrated Security=True");
                    //String sql = "";
                    //sql = "INSERT INTO tb_usuario (nm_Usuario, cd_senha) VALUES ('" + txt_Usuario.Text + "','" + txt_Password.Text + "'";
                    sql = "INSERT INTO tb_usuario (nm_usuario, cd_senha) VALUES (@Usuario ,@Senha)";
                    SqlCommand comandoInsert = new SqlCommand(sql, conexao);
                    comandoInsert.Parameters.Add(new SqlParameter("@Usuario", SqlDbType.VarChar)).Value = txt_Usuario.Text;
                    comandoInsert.Parameters.Add(new SqlParameter("@Senha", SqlDbType.VarChar)).Value = txt_Password.Text;
                    int linhasAfetadas = 0;
                    conexao.Open();
                    linhasAfetadas = comandoInsert.ExecuteNonQuery();
                    conexao.Close();
                    if (linhasAfetadas != 0)
                    {
                        lbl_Message.ForeColor = Color.Green;
                        lbl_Message.Text = "Cadastro realizado!";
                        txt_Confirm.Text = "";
                        txt_Password.Text = "";
                        txt_Usuario.Text = "";
                    }
                    else
                    {
                        lbl_Message.ForeColor = Color.Red;
                        lbl_Message.Text = "ERRO!";
                    }
                }
                else
                {
                    lbl_Message.ForeColor = Color.Red;
                    lbl_Message.Text = "Usuário Existente!";
                    txt_Usuario.Clear();
                    txt_Password.Clear();
                    txt_Confirm.Clear();
                    txt_Usuario.Focus();
                }
            }
            else
            {
                lbl_Message.ForeColor = Color.Red;
                lbl_Message.Text = "Senhas Diferentes!";
                txt_Usuario.Clear();
                txt_Password.Clear();
                txt_Confirm.Clear();
                txt_Usuario.Focus();
            }
        }
    }
}
