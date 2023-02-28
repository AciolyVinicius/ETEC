using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAGA
{
    public partial class frm_cadastro_aluno_curso : Form
    {
        int idstudent = 0;
        public frm_cadastro_aluno_curso()
        {
            InitializeComponent();
        }

        private void ckb_pesquisar_aluno_CheckedChanged(object sender, EventArgs e)
        {
            if (ckb_pesquisar_aluno.Checked)
            {
                lst_pesquisa_aluno.Enabled = true;
                btn_pesquisa_aluno.Enabled = true;
                txt_pesquisa_aluno.Enabled = true;
                lst_alunos_disponiveis.Enabled = false;
            }
            else
            {
                lst_pesquisa_aluno.Enabled = false;
                btn_pesquisa_aluno.Enabled = false;
                txt_pesquisa_aluno.Enabled = false;
                lst_alunos_disponiveis.Enabled = true;
            }
        }

        private void btn_pesquisa_aluno_Click(object sender, EventArgs e)
        {
            PesquisaAluno loadstudent = new PesquisaAluno();
            String nomealuno = txt_pesquisa_aluno.Text;
            int numerosaluno = loadstudent.StudentsNumbers(nomealuno), countstudent = 0;
            do
            {
                countstudent++;
                String listaestudante = loadstudent.StudentsList(nomealuno);
                lst_pesquisa_aluno.Items.Add(listaestudante);
            } while (countstudent < numerosaluno);
        }


        private void frm_cadastro_aluno_curso_Load(object sender, EventArgs e)
        {
            AtualizarListaAluno loadstudent = new AtualizarListaAluno();
            int numerosaluno = loadstudent.StudentsNumbers(), countstudent = 0;
            do
            {
                countstudent++;
                idstudent = loadstudent.StudentsId(idstudent);
                String listaestudante = loadstudent.StudentsList(idstudent);
                lst_alunos_disponiveis.Items.Add(listaestudante);
            } while (countstudent < numerosaluno);

            AtualizarListaCurso loadcourse = new AtualizarListaCurso();
            int numeroscurso = loadcourse.CourseNumbers(), countcourse = 0;
            do
            {
                countcourse++;
                String listacurso = loadcourse.CourseList(countcourse);
                lst_curso.Items.Add(listacurso);
            } while (countcourse < numeroscurso);
        }

        private void btn_vincular_Click(object sender, EventArgs e)
        {

        }

        private void lst_curso_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lst_curso.Items.Count != 0)
            {
                lst_turno.Enabled = true;

                AtualizarListaCursoComTurno loadbout = new AtualizarListaCursoComTurno();
                int numerosturno = loadbout.BoutNumbers(lst_turno.SelectedItem.ToString()), countturno = 0;
                do
                {
                    countturno++;
                    String listaturno = loadbout.BoutList(countturno);
                    lst_turno.Items.Add(listaturno);
                } while (countturno < numerosturno);

            }
            else
            {
                lst_turno.Enabled = false;
            }
        }
    }
}
