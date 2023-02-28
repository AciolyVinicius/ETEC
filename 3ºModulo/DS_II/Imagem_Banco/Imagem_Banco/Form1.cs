using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace Imagem_Banco
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private SqlConnection conexaoSQLServer;
        private long tamanhoArquivoImagem = 0;
        private byte[] vetorImagens;
        SqlCommand sqlcmd = default(SqlCommand);

        private void btn_ativar_Click(object sender, EventArgs e)
        {
            conexaoSQLServer = new SqlConnection(txt_stringconexaoBD.Text);
            getImagensSQLServer(conexaoSQLServer);
            btn_obterimagem.Enabled = true;
            btn_carregarimagem.Enabled = true;
            btn_salvarimagem.Enabled = true;
            btn_ativar.Enabled = false;
        }

        void getImagensSQLServer(SqlConnection conexaoSQLServer)
        {
            try
            {
                //Inicializar SQL adapter
                SqlDataAdapter ADAP = new SqlDataAdapter("select id, descricao, imagem from Imagem", conexaoSQLServer);

                //Inicializa o DataSet
                DataSet DS = new DataSet();

                //Preenche o dataset com a tabela Imagem
                ADAP.Fill(DS, "Imagem");

                dtvImagens.DataSource = DS.Tables["Imagem"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_carregarimagem_Click(object sender, EventArgs e)
        {
            CarregaImagem();
        }

        private void CarregaImagem()
        {
            try
            {
                this.openFileDialog1.ShowDialog(this);
                string strFn = this.openFileDialog1.FileName;

                if (string.IsNullOrEmpty(strFn))
                    return;
                    this.pcb_imagens.Image = Image.FromFile(strFn);
                    FileInfo arqImagem = new FileInfo(strFn);
                    tamanhoArquivoImagem = arqImagem.Length;
                    FileStream fs = new FileStream(strFn, FileMode.Open, FileAccess.Read, FileShare.Read);
                    vetorImagens = new byte[Convert.ToInt32(this.tamanhoArquivoImagem)];
                    int iBytesRead = fs.Read(vetorImagens, 0, Convert.ToInt32(this.tamanhoArquivoImagem));
                    fs.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);                
            }
        }

        private void btn_salvarimagem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_descricao.Text))
            {
                MessageBox.Show("Informe a descrição da imagem", "Código da Imagem", MessageBoxButtons.OK
                    , MessageBoxIcon.Information);
                return;
            }
            try
            {
                this.conexaoSQLServer.Open();
                this.sqlcmd = new SqlCommand();
                sqlcmd.Connection = conexaoSQLServer;
                if (sqlcmd.Parameters.Count == 0)
                {
                    this.sqlcmd.CommandText = "insert into Imagem(descricao, imagem) values (@descricao, @imagem)";
                    this.sqlcmd.Parameters.Add("@descricao", System.Data.SqlDbType.VarChar, 150);
                    this.sqlcmd.Parameters.Add("@imagem", System.Data.SqlDbType.Image);
                }
                this.sqlcmd.Parameters["@descricao"].Value = this.txt_descricao.Text;
                this.sqlcmd.Parameters["@imagem"].Value = this.vetorImagens;

                int iresultado = this.sqlcmd.ExecuteNonQuery();

                if (iresultado <= 0)
                    MessageBox.Show("Falha ao incluir imagem no banco de dados.");

                getImagensSQLServer(conexaoSQLServer);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.conexaoSQLServer.Close();
            }
        }

        private void btn_obterimagem_Click(object sender, EventArgs e)
        {
            if(txt_codigo.Text == string.Empty)
            {
                MessageBox.Show("Informe o código da imagem no Banco de Dados", "Código da Imagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                SqlCommand cmdSelect = new SqlCommand("select imagem from Imagem where id=@ID", this.conexaoSQLServer);
                cmdSelect.Parameters.Add("@ID", SqlDbType.Int, 4);
                cmdSelect.Parameters["@ID"].Value = this.txt_codigo.Text;

                this.conexaoSQLServer.Open();
                byte[] vetImagem = (byte[])cmdSelect.ExecuteScalar();
                string strNomeArquivo = Convert.ToString(DateTime.Now.ToFileTime());
                FileStream fs = new FileStream(strNomeArquivo, FileMode.CreateNew, FileAccess.Write);
                fs.Write(vetorImagens, 0, vetorImagens.Length);
                fs.Flush();
                fs.Close();

                pcb_imagens.Image = Image.FromFile(strNomeArquivo);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

