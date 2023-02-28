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
    public partial class FrmEditProjeto : Form
    {
        public FrmEditProjeto()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmEditFuncionarioProjeto editFuncionarioProjeto = new FrmEditFuncionarioProjeto();
            editFuncionarioProjeto.Visible = true;
            this.Dispose();
        }
    }
}
