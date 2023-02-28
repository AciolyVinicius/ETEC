using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LISTA5_EXE4_MGVM_VAES
{
    public partial class frm_pizzaria : Form
    {
        public frm_pizzaria()
        {
            InitializeComponent();
        }

        private void btn_enunciado_Click(object sender, EventArgs e)
        {
            MessageBox.Show("4. Calcule o valor do pagamento da entrega de uma pizzaria.\n Sabendo que: (UTILIZE SELECT CASE EM ALGUMA PARTE DESTE PROGRAMA) \n a. Para Borda Recheada será cobrado uma tarifa de R$ 1,50 (As opções de borda são: calabresa moída, mussarela e catupiry) \n b. Para todas as entregas independente da quantidade de pizzas será cobrado uma taxa única de R$ 2,00. \n c. Ao solicitar pizza ½ a ½ será cobrado pelo valor da mais cara. \n d. A pizza ½ a ½ só poderá possuir dois sabores. \n e. Calcule o total a pagar para todas as pizzas solicitadas. Para isso inclua um botão adicionar nova pizza e outro botão finalizar pedido. Utilize sua criatividade para operacionalizar este projeto. ");
        }

    }
}
