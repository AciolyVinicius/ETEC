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
        String SubChave = @"3 Modulo";

        private void btn_CriarCaminho_Click(object sender, EventArgs e)
        {
            if (txt_ValorRegistro.Text != "")
            {
                //Objeto Chave de Registro
                Microsoft.Win32.RegistryKey ChaveRegistro;

                //Criando a Chave no Registro
                ChaveRegistro = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(Chave);

                //Atribuir valor a Chave
                ChaveRegistro.SetValue(SubChave, txt_ValorRegistro.Text.ToString());

                //Encerrando o Objeto
                ChaveRegistro.Close();
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
            txt_LendoRegistro.Text = Resultado;

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
            txt_Caminho.Text = this.openFileDialog1.FileName;
        }

        private void btn_GravarCaminho_Click(object sender, EventArgs e)
        {
            try
            {
                RegistryKey rk = Registry.CurrentUser.CreateSubKey(Chave);
                rk = rk.CreateSubKey("GravaRegistro");
                rk.SetValue("CAMINHO_TXT", txt_Caminho.Text);
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
            try
            {
                RegistryKey rk = Registry.CurrentUser.CreateSubKey(Chave);
                txt_CaminhoGravado.Text = rk.OpenSubKey("GravaRegistro", true).GetValue("CAMINHO_TXT").ToString();
                rk.SetValue("CAMINHO_TXT", txt_Caminho.Text);
                rk.Close();
            }
            catch(Exception erro)
            {
                MessageBox.Show("Erro na gravação do Registro: " + erro.Message);
            }
        }
    }
}