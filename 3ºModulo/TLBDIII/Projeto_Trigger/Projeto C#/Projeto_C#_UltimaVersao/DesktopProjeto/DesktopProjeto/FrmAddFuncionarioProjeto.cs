using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DesktopProjeto
{
    public partial class FrmAddFuncionarioProjeto : Form
    {
        WebProjeto.WebService1SoapClient serv = new WebProjeto.WebService1SoapClient();
        FormCollection OpenForms;
        public FrmAddFuncionarioProjeto()
        {
            InitializeComponent();
        }

        public void carregaFuncProj()
        {
            dtg_associado.DataSource = serv.ProjetoAssociadoFunc(int.Parse(txtCod.Text)).DefaultView;
        }
        public void carregaFuncNaoProj()
        {
            dtg_nao_associado.DataSource = serv.ProjetoNaoAssociadoFunc(int.Parse(txtCod.Text)).DefaultView;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(dtg_nao_associado.SelectedRows.Count > 0 && txtNmHora.ToString()!="")
            {
                serv.InsertFuncProj(int.Parse(dtg_nao_associado
                    .SelectedRows[0].Cells[0].Value.ToString()), int.Parse(txtCod.Text.ToString()) , int.Parse(txtNmHora.Text.ToString()));
                carregaFuncNaoProj();
                carregaFuncProj();
            }
        }

        private void btnRemoveFuncionarioProjeto_Click(object sender, EventArgs e)
        {
            if (dtg_nao_associado.SelectedRows.Count > 0 && txtNmHora.ToString() != "" && txtNmHora.ToString() != null)
            {
                serv.ExcluiFuncProjeto(int.Parse(dtg_associado
                    .SelectedRows[0].Cells[0].Value.ToString()), int.Parse(txtCod.Text.ToString()));
                carregaFuncProj();
                carregaFuncNaoProj();
            }
        }

        private void FrmFuncionarioProjeto_Load(object sender, EventArgs e)
        {
        }

        private void lstFuncionarios2_DoubleClick(object sender, EventArgs e)
        {
                
        }

        private void txtNmHora_KeyPress(object sender, KeyPressEventArgs e)
        {
            string numbers = "1234567890";
            if (!(numbers.Contains(e.KeyChar.ToString().ToUpper())))
            {
                e.Handled = true;
            }
        }

        private void FrmAddFuncionarioProjeto_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("DESEJA FERCHAR O FORMULÁRIO?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                    if (Application.OpenForms.OfType<FrmProjetos>().Count() > 0)
                    {
                        Form segundo = Application.OpenForms["FrmProjetos"];
                        segundo.Show();
                        this.Hide();
                    }
                    else
                    {
                        FrmProjetos segundo = new FrmProjetos();
                        segundo.Show();
                        this.Hide();
                    }
                
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            btnAddFuncionarioProjeto.Visible = false;
            btnRemoveFuncionarioProjeto.Visible = false;
            txtNmHora.Visible = false;
                if (Application.OpenForms.OfType<FrmProjetos>().Count() > 0)
                {
                    Form segundo = Application.OpenForms["FrmProjetos"];
                    segundo.Show();
                    this.Hide();
                }
                else
                {
                    FrmProjetos segundo = new FrmProjetos();
                    segundo.Show();
                    this.Hide();
                }
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            if (!txtCod.Text.Equals(null) && !txtCod.Text.Equals(""))
            {
                btnAddFuncionarioProjeto.Visible = true;
                btnRemoveFuncionarioProjeto.Visible = true;
                txtCod.Enabled = false;
                btnOk.Enabled = false;
                txtNmHora.Visible = true;
                carregaFuncProj();
                carregaFuncNaoProj();
            }
        }

        private void txtCod_KeyPress(object sender, KeyPressEventArgs e)
        {
            string numbers = "1234567890";
            if (!(numbers.Contains(e.KeyChar.ToString().ToUpper())) && e.KeyChar.ToString().Count() > 9)
            {
                e.Handled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            btnOk.Enabled = true;
            txtCod.Enabled = true;
            txtNmHora.Visible = false;
            btnAddFuncionarioProjeto.Visible = false;
            btnRemoveFuncionarioProjeto.Visible = false;
        }
    }
}
