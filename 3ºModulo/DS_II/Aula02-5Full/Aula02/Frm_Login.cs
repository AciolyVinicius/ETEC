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
    public partial class Frm_Login : Form
    {
        FormCollection OpenForms;

        public Frm_Login()
        {
            InitializeComponent();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Finalizar?", "Finalizando!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }

        private void btn_Ok_Click(object sender, EventArgs e)
        {
            //Cria um objeto conexao, passando da string de conexão
            //O servidor, banco, usuario e senha do SQL
            //SqlConnection conexao = new SqlConnection(@"Data Source=NomeDoServidor;Initial Catalog=NomeDoBanco;UserId=login; Password=senha");
            SqlConnection conexao = new SqlConnection(@"Data Source=127.0.0.1;Initial Catalog=dbDados;Integrated Security=True");

            //variaveis que futuramente irão armazenar os dados advindos do banco
            String usuarioBanco = "";
            String senhaBanco = "";

            //cria um novo comando, passando o sql e a conexao criada
            //SqlCommand comando = new SqlCommand("SELECT nm_usuario, cd_senha FROM tb_usuario WHERE nm_usuario='" + txt_Usuario.Text + "' and cd_senha='"+ txt_Password.Text + "'", conexao);

            //Eliminando o SQLDebugging Inject
            SqlCommand comando = new SqlCommand("SELECT nm_usuario, cd_senha FROM tb_usuario WHERE nm_usuario=@Usuario and cd_senha=@Senha", conexao);
            comando.Parameters.Add(new SqlParameter("@Usuario", SqlDbType.VarChar)).Value = txt_Usuario.Text;
            comando.Parameters.Add(new SqlParameter("@Senha", SqlDbType.VarChar)).Value = txt_Password.Text;

            //cria um objeto dataReader q vai receber os dados lidos
            SqlDataReader dr;

            //abrindo a conexão com o banco
            conexao.Open();

            //executando a leitura
            dr = comando.ExecuteReader();

            //o metodo Read do dataReader retorna um boolean, que diz se existe proximo valor
            //no caso abaixo, enquanto existirem resultados ele estará rodando
            //e em cada loop o dr vai representar um linha diferente do resultado
            //no nosso caso provavelmente soh irá haver um loop
            //portando estou inserindo direto em variaveis e não em um array
            while (dr.Read())
            {
                //dr.Read()
                //getString pois o valor é string, o numero inteiro ai significa o posicionamento
                //da coluna no query executado
                usuarioBanco = dr.GetString(0); //GetString pois é variavel alfanumerica
                senhaBanco = dr.GetString(1);   //Poderia ser GetInt, GetBoolean
            }

            //aqui fecha a conexão
            //caso surja essa duvida:
            //não se pode fechar a conexão antes de ler (Read()) o data reader
            //pois ao contrario do dataSet o dataReader não trabalha com dados 
            //desconectados, então enquando precisar de ler o dataReader
            //precisará que a conexão esteja aberta
            conexao.Close();

            //para evitar um SqlInject estamos comparando em um if
            //se realmente o que está na textbox bate com o que vem do banco
            //a função TRIM() retira possiveis espaços em branco no começo e no final
            //da string
             
            if (usuarioBanco.Trim() == txt_Usuario.Text.Trim() && senhaBanco.Trim() == txt_Password.Text.Trim() && txt_Usuario.Text.Trim() != "" && txt_Password.Text.Trim() != "")
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

        private void btn_New_Click(object sender, EventArgs e)
        {
            //Verifica se existe algum formulário já aberto
            if (Application.OpenForms.OfType<Frm_Insert>().Count() > 0)
            {
                //Verifica quais os formulários abertos
                OpenForms = Application.OpenForms;
                foreach (Form Open in OpenForms)
                {
                    //Verifica se o Frm_Details esta aberto
                    if (Open.Name == "Frm_Insert")
                    {
                        //Realiza a exibição do Frm_Details
                        Open.Show();
                    }
                }
            }
            else
            {
                //Realiza uma nova instância do Frm_Details
                Frm_Insert newFrm_Insert = new Frm_Insert();
                newFrm_Insert.Show();
            }
            this.Hide();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            //Verifica se existe algum formulário já aberto
            if (Application.OpenForms.OfType<Frm_Delete>().Count() > 0)
            {
                //Verifica quais os formulários abertos
                OpenForms = Application.OpenForms;
                foreach (Form Open in OpenForms)
                {
                    //Verifica se o Frm_Details esta aberto
                    if (Open.Name == "Frm_Delete")
                    {
                        //Realiza a exibição do Frm_Details
                        Open.Show();
                    }
                }
            }
            else
            {
                //Realiza uma nova instância do Frm_Details
                Frm_Delete newFrm_Delete = new Frm_Delete();
                newFrm_Delete.Show();
            }
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Verifica se existe algum formulário já aberto
            if (Application.OpenForms.OfType<Frm_Update>().Count() > 0)
            {
                //Verifica quais os formulários abertos
                OpenForms = Application.OpenForms;
                foreach (Form Open in OpenForms)
                {
                    //Verifica se o Frm_Details esta aberto
                    if (Open.Name == "Frm_Update")
                    {
                        //Realiza a exibição do Frm_Details
                        Open.Show();
                    }
                }
            }
            else
            {
                //Realiza uma nova instância do Frm_Details
                Frm_Update newFrm_Update = new Frm_Update();
                newFrm_Update.Show();
            }
            this.Hide();
        }

        private void btn_Full_Click(object sender, EventArgs e)
        {
            //Verifica se existe algum formulário já aberto
            if (Application.OpenForms.OfType<Frm_Full>().Count() > 0)
            {
                //Verifica quais os formulários abertos
                OpenForms = Application.OpenForms;
                foreach (Form Open in OpenForms)
                {
                    //Verifica se o Frm_Details esta aberto
                    if (Open.Name == "Frm_Full")
                    {
                        //Realiza a exibição do Frm_Details
                        Open.Show();
                    }
                }
            }
            else
            {
                //Realiza uma nova instância do Frm_Details
                Frm_Full newFrm_Full = new Frm_Full();
                newFrm_Full.Show();
            }
            this.Hide();
        }

        private void Frm_Login_Load(object sender, EventArgs e)
        {
            txt_Usuario.CharacterCasing = CharacterCasing.Lower;
            txt_Password.CharacterCasing = CharacterCasing.Lower;
            //Transforma o textbox em caixa de senha.
            txt_Password.PasswordChar = '*';
        }

        private void txt_Password_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
