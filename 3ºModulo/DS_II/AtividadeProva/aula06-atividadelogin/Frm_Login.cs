using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;

namespace Aula06_AtividadeLogin
{
    public partial class Frm_Login : Form
    {
        public Frm_Login()
        {
            InitializeComponent();
        }
        private static byte[] biv = { 0x50, 0x08, 0xF1, 0xDD, 0xDE, 0x3C, 0xF2, 0x18, 0x44, 0x74, 0x19, 0x2C, 0x53, 0x49, 0xAB, 0xBC };

        private void Frm_Login_Load(object sender, EventArgs e)
        {
            txt_Usuario.CharacterCasing = CharacterCasing.Lower;
            txt_Password.CharacterCasing = CharacterCasing.Lower;
        }
        string chave = "1234567890123456";
        string linhacript, linhadecript;
        string user;
        private void btn_Cadastrar_Click(object sender, EventArgs e)
        {
            Boolean exists = false;
            if (txt_Usuario.Text != "" && txt_Password.Text != "")
            {
                string linha = txt_Usuario.Text + ";" + txt_Password.Text;
                FileInfo arquivo = new FileInfo(@"C:\Aula\FileLog.txt");
                StreamReader leitura = arquivo.OpenText();
                do
                {
                    linha = leitura.ReadLine();
                    if (linha != null)
                    {
                        linhadecript = Decryptor(linha, chave);
                        char token = char.Parse(";");
                        String[] output = linhadecript.Split(token);
                        user = output[0];
                        if (user.Equals(txt_Usuario.Text.Trim()))
                        {
                            exists = true;
                            break;
                        }
                    }
                }
                while (leitura.Peek() != -1);
                leitura.Close();
                leitura.Dispose();
                linha = txt_Usuario.Text + ";" + txt_Password.Text;
                if (!exists)
                {
                    linhacript = Encrypt(linha, chave);
                    StreamWriter cadastra = arquivo.AppendText();
                    cadastra.WriteLine(linhacript);
                    cadastra.Close();
                    cadastra.Dispose();
                }
                else
                {
                    MessageBox.Show("O usuário já existe!");
                }
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
                    linhadecript = Decryptor(linha, chave);
                    char token = char.Parse(";");
                    String[] output = linhadecript.Split(token);
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
            String usuario = txt_Usuario.Text.Trim();
            String password = txt_Password.Text.Trim();
            Boolean logado = false;
            do
            {
                linha = leitura.ReadLine();
                if (linha != null)
                {
                    linhadecript = Decryptor(linha, chave);
                    char token = char.Parse(";");
                    String[] output = linhadecript.Split(token);
                    if (usuario.Equals(output[0]) && password.Equals(output[1]))
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
            txt_Usuario.Clear();
            txt_Password.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public static string Encrypt(string text, string cryptoKey)
        {
            if (!string.IsNullOrEmpty(text))
            {
                //cria instancias de vetores de bytes com as chaves
                byte[] bkey = Convert.FromBase64String(cryptoKey);
                byte[] btext = new UTF8Encoding().GetBytes(text);

                //instancia a classe de criptografia Rijndael
                Rijndael rijndael = new RijndaelManaged();

                //Define o tamanho da chave '8*32 = 256'
                //128(16 caracteres)
                rijndael.KeySize = 256;

                //Cria o espaço de memoria para guardar o valor criptografado
                MemoryStream mStream = new MemoryStream();
                //Instancia o encriptado
                CryptoStream encrypton = new CryptoStream(mStream, rijndael.CreateEncryptor(bkey, biv), CryptoStreamMode.Write);

                //Faz a escrita dos dados criptografados no espaço de memória
                encrypton.Write(btext, 0, btext.Length);
                //Despeja toda a memória 
                encrypton.FlushFinalBlock();

                return Convert.ToBase64String(mStream.ToArray());
            }
            else
            {
                return null;
            }
        }
        public static string Decryptor(string text, string cryptoKey)
        {
            if (!string.IsNullOrEmpty(text))
            {
                //cria instancias de vetores de bytes com as chaves
                byte[] bkey = Convert.FromBase64String(cryptoKey);
                byte[] btext = Convert.FromBase64String(text);

                //instancia a classe de criptografia Rijndael
                Rijndael rijndael = new RijndaelManaged();

                //Define o tamanho da chave '8*32 = 256'
                //128(16 caracteres)
                rijndael.KeySize = 256;

                //Cria o espaço de memoria para guardar o valor criptografado
                MemoryStream mStream = new MemoryStream();
                //Instancia o encriptado
                CryptoStream decryptor = new CryptoStream(mStream, rijndael.CreateDecryptor(bkey, biv), CryptoStreamMode.Write);

                //Faz a escrita dos dados criptografados no espaço de memória
                decryptor.Write(btext, 0, btext.Length);
                //Despeja toda a memória
                decryptor.FlushFinalBlock();
                UTF8Encoding utf8 = new UTF8Encoding();
                return utf8.GetString(mStream.ToArray());
            }
            else
            {
                return null;
            }
        }
    }
}
