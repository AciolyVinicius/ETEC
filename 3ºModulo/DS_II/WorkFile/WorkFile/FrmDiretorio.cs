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

namespace WorkFile
{
    public partial class FrmDiretorio : Form
    {
        public FrmDiretorio()
        {
            InitializeComponent();
        }

        private void btn_CriaDir_Click(object sender, EventArgs e)
        {
            //Criando um diretório
            if (Directory.Exists(@"C:\aula"))
            {
                MessageBox.Show("Diretório Existente");
            }
            else
            {
                Directory.CreateDirectory(@"C:\aula");
                MessageBox.Show("Diretório Criado com Sucesso");
            }
        }

        private void btn_DelDir_Click(object sender, EventArgs e)
        {
            //Criando um diretório
            if (Directory.Exists(@"C:\aula"))
            {
                Directory.Delete(@"C:\aula");
                MessageBox.Show("Diretório Excluído com Sucesso");
            }
            else
            {
                MessageBox.Show("Diretório Inexistente");
            }
        }

        private void btn_ListDir_Click(object sender, EventArgs e)
        {
            lst_Relacione.Items.Clear();//Apagando a Lista
            DirectoryInfo diretorio = new DirectoryInfo(@"C:\aula");//Determinando o diretório a ser trabalhado
            DirectoryInfo[] subdir = diretorio.GetDirectories();//Criando um Array com todas as pastas
            FileInfo[] arquivo = diretorio.GetFiles("*.*");// Criando um Array com todos os arquivos
            foreach(DirectoryInfo relacaoDir in subdir)//Repeticao selecionando "um" diretório por vez até o termino do array subdir
            {
                lst_Relacione.Items.Add(relacaoDir.Name);//Adicionando o diretório selecionado na List
            }
            foreach (FileInfo relacaoFile in arquivo)//Repeticao selecionando "um" arquivo por vez até o termino do array arquivo
            {
                lst_Relacione.Items.Add(relacaoFile.Name);//Adicionando o arquivo selecionado na List
            }
        }

        private void btn_CriaFile_Click(object sender, EventArgs e)
        {
            //FileInfo arquivo = new FileInfo(@"C:\aula\NovoArquivo.txt");

            String nome = DateTime.Now.Day.ToString() + " - " + DateTime.Now.Month.ToString() + " - " + DateTime.Now.Year.ToString() + " - "+ DateTime.Now.Hour.ToString() + " - " + DateTime.Now.Minute.ToString() + " - " + DateTime.Now.Second.ToString();
            FileInfo arquivo = new FileInfo(@"C:\aula\"+nome+".txt");
            if (arquivo.Exists)
                MessageBox.Show("Arquivo Existente");
            else
            {
                arquivo.Create();
                MessageBox.Show("Arquivo Criado com Sucesso!");
            }
        }

        private void btn_WriteFile_Click(object sender, EventArgs e)
        {
            StreamWriter gravar = new StreamWriter(@"C:\aula\teste.txt");
            gravar.WriteLine("Texto");
            gravar.Close();
        }

        private void btn_ReadFile_Click(object sender, EventArgs e)
        {
            lst_Relacione.Items.Clear();
            if (File.Exists(@"C:\aula\teste.txt"))
            {
                StreamReader leitura = new StreamReader(@"C:\aula\teste.txt");
                lst_Relacione.Items.Add(leitura.ReadToEnd());
                leitura.Close();
                lst_Relacione.Items.Add("");
                lst_Relacione.Items.Add("-- Fim do Arquivo --");
            }
            else
                MessageBox.Show("Arquivo Inexistente!");
        }

        private void btn_DelFile_Click(object sender, EventArgs e)
        {
            FileInfo arquivo = new FileInfo(@"C:\aula\teste.txt");
            if (arquivo.Exists) { 
                arquivo.Create();
                MessageBox.Show("Arquivo Excluído com Sucesso!");
            }        
            else
            {
                MessageBox.Show("Arquivo Inexistente");
            }
        }

        private void btn_Properties_Click(object sender, EventArgs e)
        {
            lst_Relacione.Items.Clear();
            if (File.Exists(@"C:\aula\teste.txt"))
            {
                lst_Relacione.Items.Add("Arquivo criado em: " + File.GetCreationTime(@"C:\aula\teste.txt"));
                lst_Relacione.Items.Add("");
                lst_Relacione.Items.Add("Arquivo criado em: " + File.GetAttributes(@"C:\aula\teste.txt"));
            }
            else
            {
                MessageBox.Show("Arquivo Inexistente");
            }
        }
    }
}