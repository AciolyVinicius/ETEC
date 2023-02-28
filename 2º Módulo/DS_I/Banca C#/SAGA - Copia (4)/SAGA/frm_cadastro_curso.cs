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
    public partial class frm_cadastro_curso : Form
    {
        public frm_cadastro_curso()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void frm_cadastro_curso_Load(object sender, EventArgs e)
        {
            AtualizarListaCurso loadcurso = new AtualizarListaCurso();
            int numeroscursos = loadcurso.CourseNumbers(), countcurso=0;
            do
            {
                countcurso++;
                String listacurso = loadcurso.CourseList(countcurso);
                lst_curso.Items.Add(listacurso);
            } while (countcurso<numeroscursos);

            AtualizarListaDisciplina loaddiscipline = new AtualizarListaDisciplina();
            int numerosdisciplina = loaddiscipline.DisciplinesNumbers(), countdisciplina = 0;
            do
            {
                String listadisciplina = loaddiscipline.DisciplinesList(countdisciplina);
                lst_disciplina.Items.Add(listadisciplina);
            } while (countdisciplina < numerosdisciplina);
        }

        private void btn_cadastrar_disciplina_Click(object sender, EventArgs e)
        {
            if (txt_nome_disciplina.Text!="" && txt_descricao_disciplina.Text!="")
            {
                Cadastro_Disciplina.Nome = txt_nome_disciplina.Text;
                Cadastro_Disciplina.Descricao = txt_descricao_disciplina.Text;
                Cadastro_Disciplina disciplina = new Cadastro_Disciplina();
                if (disciplina.InsertDiscipline())
                {
                    MessageBox.Show("Cadastro feito com sucesso!");
                    AtualizarListaDisciplina loaddiscipline = new AtualizarListaDisciplina();
                    int numerosdisciplina = loaddiscipline.DisciplinesNumbers(), countdisciplina = 0;
                    do
                    {
                        String listadisciplina = loaddiscipline.DisciplinesList(countdisciplina);
                        lst_disciplina.Items.Add(listadisciplina);
                    } while (countdisciplina < numerosdisciplina);
                }
                else
                {
                    MessageBox.Show("Erro fatal!");
                }
            }
            else
            {
                MessageBox.Show("Preencha todos os campos corretamente!");
            }
        }

        private void btn_cadastrar_curso_Click(object sender, EventArgs e)
        {
            if (txt_nome_curso.Text != "" && txt_descricao_curso.Text != "" && txt_carga_horaria.Text!="")
            {
                Cadastro_Curso.Nome = txt_nome_curso.Text;
                Cadastro_Curso.Descricao = txt_descricao_curso.Text;
                Cadastro_Curso.Carga_horaria = Convert.ToInt32(txt_carga_horaria.Text);
                Cadastro_Curso disciplina = new Cadastro_Curso();
                if (disciplina.InsertCourse())
                {
                    MessageBox.Show("Cadastro feito com sucesso!");
                    AtualizarListaCurso loadcurso = new AtualizarListaCurso();
                    int numeroscursos = loadcurso.CourseNumbers(), countcurso = 0;
                    do
                    {
                        countcurso++;
                        String listacurso = loadcurso.CourseList(countcurso);
                        lst_curso.Items.Add(listacurso);
                    } while (countcurso < numeroscursos);
                }
                else
                {
                    MessageBox.Show("Erro fatal!");
                }
            }
            else
            {
                MessageBox.Show("Preencha todos os campos corretamente!");
            }
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            frm_home home = new frm_home();
            home.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
