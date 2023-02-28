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
    public partial class Frm_Full : Form
    {
        FormCollection OpenForms;
        SqlConnection conexao = new SqlConnection(@"Data Source=127.0.0.1;Initial Catalog=dbDados;Integrated Security=True");
        String varUsuario = "", varSenha = "";

        public Frm_Full()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            OpenForms = Application.OpenForms;
            foreach (Form Open in OpenForms)
            {
                if (Open.Name == "Frm_Login")
                    Open.Show();
            }
            this.Dispose();
        }

        private void btn_Incluir_Click(object sender, EventArgs e)
        {
            if (txt_Password.Text == txt_Confirm.Text)
            {
                txt_Password.Visible = true;
                lbl_Password.Visible = true;
                txt_Confirm.Visible = true;
                lbl_Confirm.Visible = true;
                String usuarioBanco = "";
                String sqlSelect = "SELECT nm_usuario, cd_senha FROM tb_usuario WHERE nm_usuario=@Usuario";
                SqlCommand comandoSelect = new SqlCommand(sqlSelect, conexao);
                comandoSelect.Parameters.Add(new SqlParameter("@Usuario", SqlDbType.VarChar)).Value = txt_Usuario.Text;
                SqlDataReader dr;
                conexao.Open();
                dr = comandoSelect.ExecuteReader();
                while (dr.Read())
                {
                    usuarioBanco = dr.GetString(0);
                }
                conexao.Close();
                if (usuarioBanco.Trim() != txt_Usuario.Text.Trim() && txt_Usuario.Text.Trim() != "" && txt_Password.Text.Trim() != "")
                {
                    String sqlInsert = "INSERT INTO tb_usuario (nm_usuario, cd_senha) VALUES (@Usuario ,@Senha)";
                    SqlCommand comandoInsert = new SqlCommand(sqlInsert, conexao);
                    comandoInsert.Parameters.Add(new SqlParameter("@Usuario", SqlDbType.VarChar)).Value = txt_Usuario.Text;
                    comandoInsert.Parameters.Add(new SqlParameter("@Senha", SqlDbType.VarChar)).Value = txt_Password.Text;
                    int linhasAfetadas = 0;
                    conexao.Open();
                    linhasAfetadas = comandoInsert.ExecuteNonQuery();
                    conexao.Close();
                    if (linhasAfetadas != 0)
                    {
                        Atualiza();
                        txt_Usuario.Clear();
                        txt_Password.Clear();
                        txt_Password.Visible = false;
                        txt_Confirm.Clear();
                        txt_Confirm.Visible = false;
                        lbl_Confirm.Visible = false;
                        lbl_Password.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("Erro ao Inserir", "ERRO!!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            else
            {
                MessageBox.Show("Senhas Diferentes", "ATENÇÃO!!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void Atualiza()
        {
            SqlConnection conexao = new SqlConnection(@"Data Source=127.0.0.1;Initial Catalog=dbDados;Integrated Security=True");
            conexao.Open();
            String sqlUsuario = "SELECT * FROM tb_usuario";
            SqlCommand comando = new SqlCommand(sqlUsuario, conexao);
            SqlDataAdapter adptAtualiza = new SqlDataAdapter(comando);
            DataTable dt = new DataTable();
            adptAtualiza.Fill(dt);
            dtg_Usuario.DataSource = dt.DefaultView;
            dtg_Usuario.Columns[0].HeaderText = "Usuário";
            dtg_Usuario.Columns[0].MinimumWidth = 215;
            dtg_Usuario.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtg_Usuario.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtg_Usuario.Columns[1].HeaderText = "Senha";
            dtg_Usuario.Columns[1].MinimumWidth = 215;
            dtg_Usuario.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtg_Usuario.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            conexao.Close();
        }

        private void Frm_Full_Load(object sender, EventArgs e)
        {
            Atualiza();
        }

        private void dtg_Usuario_MouseClick(object sender, MouseEventArgs e)
        {
            int indiceselecionado = -1;
            // Se o usuário selecionou a Linha
            if (dtg_Usuario.SelectedRows.Count > 0)
            {
                indiceselecionado = dtg_Usuario.SelectedRows[0].Index;
            }
            else
            { // Se o usuário selecionou a célula
                if (dtg_Usuario.SelectedCells.Count > 0)
                {
                    indiceselecionado = dtg_Usuario.SelectedCells[0].RowIndex;
                }
            }
            if (indiceselecionado != -1)
            {
                DataRowView dr = (DataRowView)dtg_Usuario.Rows[indiceselecionado].DataBoundItem;
                varUsuario = dr["nm_usuario"].ToString();
                varSenha = dr["cd_senha"].ToString();
            }
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            String sql = "";
            sql = "DELETE FROM tb_usuario WHERE nm_usuario = @Usuario and cd_senha = @Senha";
            SqlCommand comando = new SqlCommand(sql, conexao);
            comando.Parameters.Add(new SqlParameter("@Usuario", SqlDbType.VarChar)).Value = varUsuario;
            comando.Parameters.Add(new SqlParameter("@Senha", SqlDbType.VarChar)).Value = varSenha;
            int linhasAfetadas = 0;
            conexao.Open();
            linhasAfetadas = comando.ExecuteNonQuery();
            conexao.Close();
            if (linhasAfetadas != 0)
            {
                Atualiza();
            }
            else
            {
                MessageBox.Show("Erro ao Excluir", "ERRO!!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
                txt_Password.Visible = true;
                lbl_Password.Visible = true;
                txt_Confirm.Visible = true;
                lbl_Confirm.Visible = true;

                if (varUsuario != "")
                {
                    if (txt_Password.Text != "" && txt_Confirm.Text != "")
                    {
                        if (txt_Password.Text == txt_Confirm.Text)
                        {
                            String sql = "";
                            sql = "UPDATE tb_usuario SET cd_senha=@Senha WHERE nm_usuario=@Usuario";
                            SqlCommand comando = new SqlCommand(sql, conexao);
                            comando.Parameters.Add(new SqlParameter("@Usuario", SqlDbType.VarChar)).Value = varUsuario;
                            comando.Parameters.Add(new SqlParameter("@Senha", SqlDbType.VarChar)).Value = txt_Password.Text;
                            int linhasAfetadas = 0;
                            conexao.Open();
                            linhasAfetadas = comando.ExecuteNonQuery();
                            conexao.Close();
                            if (linhasAfetadas != 0)
                            {
                                Atualiza();
                                txt_Usuario.Clear();
                                txt_Password.Clear();
                                txt_Password.Visible = false;
                                txt_Confirm.Clear();
                                txt_Confirm.Visible = false;
                                lbl_Confirm.Visible = false;
                                lbl_Password.Visible = false;
                            }
                            else
                            {
                                MessageBox.Show("Erro ao Atualizar", "ERRO!!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Senhas Diferentes", "ERRO!!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Preencha as senhas", "ERRO!!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("Selecione o Usuário", "ERRO!!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Apagar a Tabela?", "Zerando!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                String sql = "";
                sql = "DELETE FROM tb_usuario WHERE nm_usuario != ''";
                SqlCommand comando = new SqlCommand(sql, conexao);
                int linhasAfetadas = 0;
                conexao.Open();
                linhasAfetadas = comando.ExecuteNonQuery();
                conexao.Close();
                if (linhasAfetadas != 0)
                {
                    MessageBox.Show("Banco Zerado", "ATENÇÃO!!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("Erro ao Apagar", "ERRO!!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                Atualiza();
            }
        }
    }
}
