using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_17082017
{
    public partial class lbl_chk_rdb_grb : Form
    {
        int milhar = 0, centena=0, dezena=0, unidade=0;
        public lbl_chk_rdb_grb()
        {
            InitializeComponent();
        }

        private void chk_milhar_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_milhar.Checked == true)
                grp_milhar.Visible = true;
            else
            {
                grp_milhar.Visible = false;
                
                rdb_ummilhar.Checked = false;
                rdb_doismilhar.Checked = false;
                rdb_tresmilhar.Checked = false;
                rdb_quatromilhar.Checked = false;
                rdb_cincomilhar.Checked = false;
                rdb_seismilhar.Checked = false;
                rdb_setemilhar.Checked = false;
                rdb_oitomilhar.Checked = false;
                rdb_novemilhar.Checked = false;
            }
        }

        private void chk_centena_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_centena.Checked == true)
                grp_centena.Visible = true;
            else
            {
                grp_centena.Visible = false;
                
                rdb_umcentena.Checked = false;
                rdb_doiscentena.Checked = false;
                rdb_trescentena.Checked = false;
                rdb_quatrocentena.Checked = false;
                rdb_cincocentena.Checked = false;
                rdb_seiscentena.Checked = false;
                rdb_setecentena.Checked = false;
                rdb_oitocentena.Checked = false;
                rdb_novecentena.Checked = false;
            }
        }

        private void chk_dezena_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_dezena.Checked == true)
                grp_dezena.Visible = true;
            else
            {
                grp_dezena.Visible = false;
                
                rdb_umdezena.Checked = false;
                rdb_doisdezena.Checked = false;
                rdb_tresdezena.Checked = false;
                rdb_quatrodezena.Checked = false;
                rdb_cincodezena.Checked = false;
                rdb_seisdezena.Checked = false;
                rdb_setedezena.Checked = false;
                rdb_oitodezena.Checked = false;
                rdb_novedezena.Checked = false;
            }
        }

        private void chk_unidade_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_unidade.Checked == true)
                grp_unidade.Visible = true;
            else
            {
                grp_unidade.Visible = false;
                
                rdb_umunidade.Checked = false;
                rdb_doisunidade.Checked = false;
                rdb_tresunidade.Checked = false;
                rdb_quatrounidade.Checked = false;
                rdb_cincounidade.Checked = false;
                rdb_seisunidade.Checked = false;
                rdb_seteunidade.Checked = false;
                rdb_oitounidade.Checked = false;
                rdb_noveunidade.Checked = false;
            }
        }

        private void btn_escreve_Click(object sender, EventArgs e)
        {
            if (rdb_ummilhar.Checked == true)
                milhar = 1;
            else if (rdb_doismilhar.Checked == true)
                milhar = 2;
            else if (rdb_tresmilhar.Checked == true)
                milhar = 3;
            else if (rdb_quatromilhar.Checked == true)
                milhar = 4;
            else if (rdb_cincomilhar.Checked == true)
                milhar = 5;
            else if (rdb_seismilhar.Checked == true)
                milhar = 6;
            else if (rdb_setemilhar.Checked == true)
                milhar = 7;
            else if (rdb_oitomilhar.Checked == true)
                milhar = 8;
            else if (rdb_novemilhar.Checked == true)
                milhar = 9;

            if (rdb_umcentena.Checked == true)
                centena = 1;
            else if (rdb_doiscentena.Checked == true)
                centena = 2;
            else if (rdb_trescentena.Checked == true)
                centena = 3;
            else if (rdb_quatrocentena.Checked == true)
                centena = 4;
            else if (rdb_cincocentena.Checked == true)
                centena = 5;
            else if (rdb_seiscentena.Checked == true)
                centena = 6;
            else if (rdb_setecentena.Checked == true)
                centena = 7;
            else if (rdb_oitocentena.Checked == true)
                centena = 8;
            else if (rdb_novecentena.Checked == true)
                centena = 9;

            if (rdb_umdezena.Checked == true)
                dezena = 1;
            else if (rdb_doisdezena.Checked == true)
                dezena = 2;
            else if (rdb_tresdezena.Checked == true)
                dezena = 3;
            else if (rdb_quatrodezena.Checked == true)
                dezena = 4;
            else if (rdb_cincodezena.Checked == true)
                dezena = 5;
            else if (rdb_seisdezena.Checked == true)
                dezena = 6;
            else if (rdb_setedezena.Checked == true)
                dezena = 7;
            else if (rdb_oitodezena.Checked == true)
                dezena = 8;
            else if (rdb_novedezena.Checked == true)
                dezena = 9;

            if (rdb_umunidade.Checked == true)
                unidade = 1;
            else if (rdb_doisunidade.Checked == true)
                unidade = 2;
            else if (rdb_tresunidade.Checked == true)
                unidade = 3;
            else if (rdb_quatrounidade.Checked == true)
                unidade = 4;
            else if (rdb_cincounidade.Checked == true)
                unidade = 5;
            else if (rdb_seisunidade.Checked == true)
                unidade = 6;
            else if (rdb_seteunidade.Checked == true)
                unidade = 7;
            else if (rdb_oitounidade.Checked == true)
                unidade = 8;
            else if (rdb_noveunidade.Checked == true)
                unidade = 9;

            txt_escreve.Text = milhar.ToString() + centena.ToString() + dezena.ToString() + unidade.ToString();
        }
    }
}
