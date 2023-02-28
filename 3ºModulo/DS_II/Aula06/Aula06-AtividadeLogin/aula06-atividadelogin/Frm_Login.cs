using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Aula06_AtividadeLogin
{
    public partial class Frm_Login : Form
    {
        public Frm_Login()
        {
            InitializeComponent();
        }

        private void Frm_Login_Load(object sender, EventArgs e)
        {
            txt_Usuario.CharacterCasing = CharacterCasing.Lower;
            txt_Password.CharacterCasing = CharacterCasing.Lower;
        }

        private void btn_Cadastrar_Click(object sender, EventArgs e)
        {
            if (txt_Usuario.Text != "" && txt_Password.Text != "")
            {
                string linha = txt_Usuario.Text + ";" + txt_Password.Text;
                FileInfo arquivo = new FileInfo(@"C:\Aula\FileLog.txt");
                StreamWriter cadastra = arquivo.AppendText();
                cadastra.WriteLine(linha);
                cadastra.Close();
                cadastra.Dispose();
            }
            txt_Usuario.Clear();
            txt_Password.Clear();
        }

        private void btn_Relatorio_Click(object sender, EventArgs e)
        {
            DataTable tabela = new DataTable();
            DataColumn coluna = null;
            coluna = new DataColumn("Usuário");
            tabela.Columns.Add(coluna);
            coluna = new DataColumn("Password");
            tabela.Columns.Add(coluna);
            dtg_Relatorio.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataRow registro = null;
            FileInfo arquivo = new FileInfo(@"C:\Aula\FileLog.txt");
            StreamReader leitura = arquivo.OpenText();
            string linha;
            do
            {
                linha = leitura.ReadLine();
                if (linha != null)
                {
                    char token = char.Parse(";");
                    String[] output = linha.Split(token);
                    registro = tabela.NewRow();
                    registro["Usuário"] = output[0];
                    registro["Password"] = output[1];
                    tabela.Rows.Add(registro);
                }
            }
            while (leitura.Peek() != -1);
            dtg_Relatorio.DataSource = tabela;
            leitura.Close();
            leitura.Dispose();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            FileInfo arquivo = new FileInfo(@"C:\Aula\FileLog.txt");
            StreamReader leitura = arquivo.OpenText();
            string linha;
            String usuario = txt_Usuario.Text;
            String password = txt_Password.Text;
            Boolean logado = false;
            do
            {
                linha = leitura.ReadLine();
                if (linha != null)
                {
                    char token = char.Parse(";");
                    String[] output = linha.Split(token);
                    if (usuario == output[0] && password == output[1])
                    {
                        logado = true;
                    }
                    else
                    {
                        logado = false;
                    }
                }
            }
            while (leitura.Peek() != -1);
            if (logado == true)
            {
                MessageBox.Show("Usuário Existente!");
            }
            else
            {
                MessageBox.Show("Usuário Inexistente!");
            }
            leitura.Close();
            leitura.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
