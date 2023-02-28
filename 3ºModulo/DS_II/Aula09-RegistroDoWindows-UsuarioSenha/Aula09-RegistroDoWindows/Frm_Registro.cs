using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace Aula09_RegistroDoWindows
{
    public partial class Frm_Registro : Form
    {
        public Frm_Registro()
        {
            InitializeComponent();
        }

        String Chave = "ETECDRCSV";
        String SubChave;

        private void btn_CriarCaminho_Click(object sender, EventArgs e)
        {
            if (txt_CPF.Text != "" && txt_Usuario.Text != "" && txt_Senha.Text != "")
            {
                try
                {
                    RegistryKey rk = Registry.CurrentUser.CreateSubKey(Chave);
                    rk = rk.CreateSubKey(txt_CPF.Text.ToString());
                    rk.SetValue(txt_Usuario.Text.ToString(), txt_Senha.Text.ToString());
                    rk.Close();
                    txt_CPF.Text = "";
                    txt_Usuario.Text = "";
                    txt_Senha.Text = "";
                }
                catch (Exception erro)
                {
                    MessageBox.Show("Erro na gravação do Registro!");
                }
            }
            else
            {
                MessageBox.Show("Preencha os campos", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void btn_LendoRegistro_Click(object sender, EventArgs e)
        {
            //Definindo a Chave
            String Path = @"ETECDRCSV";
            String Resultado;

            //Instanciar o Objeto
            //Objeto Chave de Registro
            Microsoft.Win32.RegistryKey ChaveRegistro;

            //Criando a Chave no Registro
            ChaveRegistro = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(Chave);

            //Realizando a leitura
            Resultado = ChaveRegistro.GetValue(SubChave).ToString();

            //Atribuindo valor ao textbox
            //txt_LendoRegistro.Text = Resultado;

            //Encerrando o objeto
            ChaveRegistro.Close();
        }

        private void btn_ExcluirRegistro_Click(object sender, EventArgs e)
        {
            Registry.CurrentUser.DeleteSubKey(Chave);
        }

        private void btn_Abrir_Click(object sender, EventArgs e)
        {
            //Coloca o título na janela
            this.openFileDialog1.Title = "Escolha a fonte de dados...";

            //Informar qual será o diretório inicial
            this.openFileDialog1.InitialDirectory = "C:\\";

            //Configura o filtro para o tipo do arquivo
            this.openFileDialog1.Filter = "txt files (*.txt)|*.txt";

            //Abre a janela para a escolha do usuário
            this.openFileDialog1.ShowDialog();

            //Guarda o caminho escolhido
            //txt_Caminho.Text = this.openFileDialog1.FileName;
        }

        private void btn_GravarCaminho_Click(object sender, EventArgs e)
        {
            try
            {
                RegistryKey rk = Registry.CurrentUser.CreateSubKey(Chave);
                rk = rk.CreateSubKey("GravaRegistro");
                //rk.SetValue("CAMINHO_TXT", txt_Caminho.Text);
                rk.Close();
                MessageBox.Show("Caminho gravado com sucesso!");
            }
            catch(Exception erro)
            {
                MessageBox.Show("Erro na gravação do Registro: "+erro.Message);
            }
        }

        private void btn_CaminhoGravado_Click(object sender, EventArgs e)
        {
            if (txtExcluir.Text != "")
            {
                try
                {
                    Registry.CurrentUser.CreateSubKey(Chave).DeleteSubKey(txtExcluir.Text.ToString());
                    Listar();
                    MessageBox.Show("Registro Excluido com Sucesso!");
                }
                catch (Exception erro)
                {
                    MessageBox.Show("Erro na deletar do Registro!");
                }
            }
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            try
            {
                String Usuario, Senha;
                RegistryKey rk = Registry.CurrentUser.CreateSubKey(Chave);
                Usuario = rk.OpenSubKey(txt_CPF_Login.Text.ToString(), true).GetValue(txt_Usuario_Login.Text.ToString()).ToString();
                Senha = rk.OpenSubKey(txt_CPF_Login.Text.ToString(), true).GetValue(txt_Senha_Login.Text.ToString()).ToString();
                rk.Close();
                txt_CPF.Text = "";
                txt_Usuario.Text = "";
                txt_Senha.Text = "";
                MessageBox.Show("Login realizado com sucesso!");
            }
            catch (Exception erro)
            {
                MessageBox.Show("Login Inválido");
            }
        }

        private void btn_Listar_Click(object sender, EventArgs e)
        {
            try
            {
                lst_Listar.Items.Clear();
                RegistryKey rk = Registry.CurrentUser.OpenSubKey(Chave);
                foreach(String rka in rk.GetSubKeyNames()){
                    lst_Listar.Items.Add(rka);
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao listar: " + erro.Message);
            }
        }

        private void txt_CPF_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Verifica se é um número digitado
            if (!char.IsDigit(e.KeyChar))
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }

        private void txt_CPF_Login_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Verifica se é um número digitado
            if (!char.IsDigit(e.KeyChar))
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }

        private void lst_Listar_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtExcluir.Text = lst_Listar.SelectedItems[0].ToString();
            txtCPFEditar.Text = lst_Listar.SelectedItems[0].ToString();
        }
        public void Listar()
        {
            try
            {
                lst_Listar.Items.Clear();
                RegistryKey rk = Registry.CurrentUser.OpenSubKey(Chave);
                foreach (String rka in rk.GetSubKeyNames())
                {
                    lst_Listar.Items.Add(rka);
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao listar: " + erro.Message);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (txtCPFEditar.Text != "" && txtUsuarioEdit.Text != "" && txtSenhaEdit.Text != "")
            {
                try
                {
                    Registry.CurrentUser.CreateSubKey(Chave).DeleteSubKey(txtCPFEditar.Text.ToString());
                    RegistryKey rk = Registry.CurrentUser.CreateSubKey(Chave);
                    rk = rk.CreateSubKey(txtCPFEditar.Text.ToString());
                    rk.SetValue(txtUsuarioEdit.Text.ToString(), txtSenhaEdit.Text.ToString());
                    rk.Close();
                    txtUsuarioEdit.Text = "";
                    txtSenhaEdit.Text = "";
                    MessageBox.Show("Usuário Editado com Sucesso");
                    Listar();
                }
                catch (Exception erro)
                {
                    MessageBox.Show("Erro na edição do Registro!");
                }
            }
        }
    }
}