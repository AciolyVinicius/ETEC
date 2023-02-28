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
using System.Security.Cryptography;

namespace Aula07_Criptografia
{
    public partial class Frm_Cripto : Form
    {
        private static byte[] biv = { 0x50, 0x08, 0xF1, 0xDD, 0xDE, 0x3C, 0xF2, 0x18, 0x44, 0x74, 0x19, 0x2C, 0x53, 0x49, 0xAB, 0xBC };
        public Frm_Cripto()
        {
            InitializeComponent();
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
        private void btn_Cripto_Click(object sender, EventArgs e)
        {
            string input = txt_Input.Text;
            string cryptoKey = txt_Key.Text;
            string output;
            output = Encrypt(input, cryptoKey);
            txt_Output.Text = output;
        }

        private void btn_Descripto_Click(object sender, EventArgs e)
        {
            string input = txt_Input.Text;
            string cryptoKey = txt_Key.Text;
            string output;
            output = Decryptor(input, cryptoKey);
            txt_Output.Text = output;
        }
    }
}
