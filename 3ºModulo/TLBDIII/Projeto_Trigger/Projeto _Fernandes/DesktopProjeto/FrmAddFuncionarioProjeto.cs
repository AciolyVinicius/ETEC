using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopProjeto
{
    public partial class FrmAddFuncionarioProjeto : Form
    {
        FormCollection OpenForms;
        public FrmAddFuncionarioProjeto()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lstFuncionarios1.SelectedItems.Count > 0) {
                lstFuncionarios2.Items.Add(lstFuncionarios1.GetItemText(lstFuncionarios1.Text));
                lstFuncionarios1.Items.RemoveAt(lstFuncionarios1.SelectedIndex);
            } else {
                MessageBox.Show("Selecione algum funcionário!");
            }
        }

        private void btnRemoveFuncionarioProjeto_Click(object sender, EventArgs e)
        {
            if (lstFuncionarios2.SelectedItems.Count > 0) {
                lstFuncionarios1.Items.Add(lstFuncionarios2.GetItemText(lstFuncionarios2.Text));
                lstFuncionarios2.Items.RemoveAt(lstFuncionarios2.SelectedIndex);
            } else {
                MessageBox.Show("Selecione algum funcionário!");
            }
        }

        private void FrmFuncionarioProjeto_Load(object sender, EventArgs e)
        {
            lblQtdHora.Visible = false;
            txtNmHora.Visible = false;
            lblFuncionarioHora.Visible = false;
        }

        private void lstFuncionarios2_DoubleClick(object sender, EventArgs e)
        {
            int i = -1;
            i = (lstFuncionarios2.SelectedIndex);
            if (i == -1) {
                lblFuncionarioHora.Text = lstFuncionarios2.GetItemText(lstFuncionarios2.Text);
                lblFuncionarioHora.Visible = false;
                lblQtdHora.Visible = false;
                txtNmHora.Visible = false;
            }
            if (i >= 0) {
                lblFuncionarioHora.Text = lstFuncionarios2.GetItemText(lstFuncionarios2.Text);
                lblFuncionarioHora.Visible = true;
                lblQtdHora.Visible = true;
                txtNmHora.Visible = true;
            }
        }

        private void txtNmHora_KeyPress(object sender, KeyPressEventArgs e)
        {
            string numbers = "1234567890.";
            if (!(numbers.Contains(e.KeyChar.ToString().ToUpper()))) {
                e.Handled = true;
            }
        }

        private void FrmAddFuncionarioProjeto_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("DESEJA FERCHAR O FORMULÁRIO?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) {
                if (lstFuncionarios2.Items.Count > 0) {
                    if (Application.OpenForms.OfType<FrmProjetos>().Count() > 0) {
                        Form segundo = Application.OpenForms["FrmProjetos"];
                        segundo.Show();
                        this.Hide();
                    } else {
                        FrmProjetos segundo = new FrmProjetos();
                        segundo.Show();
                        this.Hide();
                    }
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (lstFuncionarios2.Items.Count > 0) {
                if (Application.OpenForms.OfType<FrmProjetos>().Count() > 0) {
                    Form segundo = Application.OpenForms["FrmProjetos"];
                    segundo.Show();
                    this.Hide();
                } else {
                    FrmProjetos segundo = new FrmProjetos();
                    segundo.Show();
                    this.Hide();
                }
            } else {
                MessageBox.Show("O projeto deve ter pelo menos um associado!");
            }
        }
    }
}
