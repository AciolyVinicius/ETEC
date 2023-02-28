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
    public partial class Frm_insert : Form
    {

        FormCollection OpenForms;

        public Frm_insert()
        {
            InitializeComponent();
        }

        private void lbl_confirm_Click(object sender, EventArgs e)
        {

        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            //Verificar se exise um formulario já aberto
            if (Application.OpenForms.OfType<Frm_login>().Count() > 0)
            {
                //Verifica quais formulários estão abertos
                OpenForms = Application.OpenForms;
                foreach (Form Open in OpenForms)
                {
                    if (Open.Name == "Frm_login")
                    {
                        //Realiza a exibição do Formulário
                        Open.Show();
                    }
                }
            }
            else
            {
                //Realiza uma nova instância do Formulário
                Frm_login login = new Frm_login();
                login.Show();
            }
            this.Hide();
        }

        private void Frm_insert_Load(object sender, EventArgs e)
        {
            txt_UsuarioInsert.CharacterCasing = CharacterCasing.Lower;
            txt_PasswordInsert.CharacterCasing = CharacterCasing.Lower;
            txt_ConfirmInsert.CharacterCasing = CharacterCasing.Lower;
            txt_PasswordInsert.PasswordChar =   '*';
            txt_ConfirmInsert.PasswordChar = '*';
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (txt_PasswordInsert.Text.Trim() == txt_ConfirmInsert.Text.Trim() && txt_ConfirmInsert.Text != "" && txt_PasswordInsert.Text != "" && txt_UsuarioInsert.Text != "")
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
                comando.Parameters.Add(new SqlParameter("@usuario", SqlDbType.VarChar)).Value = txt_UsuarioInsert.Text;
                
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
                if (usuariobanco == "") {

                    // Comeco a fazer o codigo para insert
                    String sql = "";

                    // Variavel para comecar o insert no banco 
                    sql = "insert into tb_login (nm_usuario, cd_senha) values (@usuario, @senha)";

                    // Comeco a editar o sqlcommand para inserir
                    SqlCommand comando2 = new SqlCommand(sql, conexao);

                    // Comeco a trocar os @ para o que foi digitado, Segurança
                    comando2.Parameters.Add(new SqlParameter("@usuario", SqlDbType.VarChar)).Value = txt_UsuarioInsert.Text;
                    comando2.Parameters.Add(new SqlParameter("@senha", SqlDbType.VarChar)).Value = txt_PasswordInsert.Text;

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
                        lbl_MessageInsert.Text = "Cadastro Realizado";
                        lbl_MessageInsert.ForeColor = Color.Green;
                    }
                    else
                    {
                        lbl_MessageInsert.Text = "ERRO!";
                        lbl_MessageInsert.ForeColor = Color.Red;
                    }
                }
                else
                {
                    lbl_MessageInsert.Text = "Usuário Já Existente!!";
                    lbl_MessageInsert.ForeColor = Color.Red;
                    txt_UsuarioInsert.Clear();
                    txt_UsuarioInsert.Focus();
                }
            }
            else
            {
                lbl_MessageInsert.Text = "Senhas Diferentes ou Campos Vazios";
                lbl_MessageInsert.ForeColor = Color.Red;
                txt_UsuarioInsert.Clear();
                txt_PasswordInsert.Clear();
                txt_ConfirmInsert.Clear();
                txt_UsuarioInsert.Focus();
            }
        }

        private void txt_ConfirmInsert_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
