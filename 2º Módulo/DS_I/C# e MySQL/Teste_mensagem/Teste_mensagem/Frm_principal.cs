using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teste_mensagem
{
    public partial class Frm_principal : Form
    {
        ArrayList lista = new ArrayList();
        

        public Frm_principal()
        {
            InitializeComponent();
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_sair_conta_Click(object sender, EventArgs e)
        {
            Form sair_conta = Application.OpenForms["Frm_inicio"];
            this.Dispose();
            sair_conta.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form sair = Application.OpenForms["Frm_inicio"];
            sair.Dispose();
        }

        private void btn_enviar_Click(object sender, EventArgs e)
        {
            // Devo enviar ds_mensagem, cd_destinatario, cd_usuario

            if (txt_mensagem.Text != null && txt_mensagem.Text != "")
            {                
                Mensagem enviar_dados = new Mensagem();
                enviar_dados.Nome_usuario_destino = txt_usuario_destino.Text; // Enviando nome do usuário
                enviar_dados.Mensagem_usuario = txt_mensagem.Text; // Enviando mensagem
                ObterCodigoDestinatario codigo_destino = new ObterCodigoDestinatario();
                enviar_dados.Codigo_usuario = CodigoUsuario.Codigo_usuario; // Enviando código do usuário atual                    
                int codigo_destinatario = codigo_destino.codigoDestinatario(txt_usuario_destino.Text);
                enviar_dados.Codigo_destinatario = codigo_destinatario; // Enviando código do destinatário
                    
                EnviarMensagem envio = new EnviarMensagem();
                bool sucesso = envio.Enviar(enviar_dados);
                    
                if (sucesso)
                    MessageBox.Show("Mensagem enviada com sucesso!", "Chat MilGraus - Enviar Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Não foi possível enviar a mensagem.", "Chat MilGraus - Enviar Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);

                atualizarMensagem();                
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Frm_principal_Load(object sender, EventArgs e)
        {
            
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txt_recebe_mensagem_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void txt_recebe_mensagem_MouseClick_1(object sender, MouseEventArgs e)
        {
           
        }

        private void atualizarMensagem()
        {
            Mensagem enviarCodigo = new Mensagem();
            enviarCodigo.Codigo_usuario = CodigoUsuario.Codigo_usuario;

            ReceberMensagem recebe = new ReceberMensagem();
            String resultado = recebe.mensagem(enviarCodigo);

            txt_recebe_mensagem.Text = resultado;          
        }

        private void txt_recebe_mensagem_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void txt_recebe_mensagem_MouseClick_2(object sender, MouseEventArgs e)
        {
            atualizarMensagem();
        }
    }
}
