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
            btn_vincular.Enabled = false; 
            AtualizarListaTurma loadclass = new AtualizarListaTurma();
            int numerosturmas = loadclass.ClassNumbers(), countclass = 0;
            do
            {
                countclass++;
                String listadisciplina = loadclass.ClassList(countclass);
                lst_turma.Items.Add(listadisciplina);
            } while (countclass < numerosturmas);

            AtualizarListaDisciplina loaddiscipline = new AtualizarListaDisciplina();
            int numerosdisciplina = loaddiscipline.DisciplinesNumbers(), countdisciplina = 0;
            do
            {
                countdisciplina++;
                String listadisciplina = loaddiscipline.DisciplinesList(countdisciplina);
                lst_disciplina.Items.Add(listadisciplina);
            } while (countdisciplina < numerosdisciplina);

            AtualizarListaTurno loadbout = new AtualizarListaTurno();
            int numerosturno = loadbout.BoutNumbers(), countturno = 0;
            do
            {
                countturno++;
                String listaturno = loadbout.BoutList(countturno);
                lst_turno.Items.Add(listaturno);
            } while (countturno < numerosturno);

            AtualizarListaCurso loadcourse = new AtualizarListaCurso();
            int numeroscurso = loadcourse.CourseNumbers(), countcourse = 0;
            do
            {
                countcourse++;
                String listacurso = loadcourse.CourseList(countcourse);
                lst_curso.Items.Add(listacurso);
            } while (countcourse < numeroscurso);
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
                    lst_disciplina.Items.Clear();
                    AtualizarListaDisciplina loaddiscipline = new AtualizarListaDisciplina();
                    int numerosdisciplina = loaddiscipline.DisciplinesNumbers(), countdisciplina = 0;
                    do
                    {
                        countdisciplina++;
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
                    lst_curso.Items.Clear();
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

        private void btn_visualizar_cadastro_curso_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_visualizar_cadastro_disciplina_Click(object sender, EventArgs e)
        {
            
        }

        private void lst_disciplina_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lst_curso.SelectedItems.Count > 0 && lst_disciplina.SelectedItems.Count > 0 && lst_turma.SelectedItems.Count > 0 && lst_turno.SelectedItems.Count > 0)
            {
                btn_vincular.Enabled = true;
            }
            else
            {
                btn_vincular.Enabled = false;
            }
        }

        private void btn_vincular_Click(object sender, EventArgs e)
        {
            String course, discipline, classe, bout;
            Boolean disciplinacurso, disciplinar;
            course = lst_curso.SelectedItem.ToString();
            Vincula.Curso = course.Replace("\n", "");
            discipline = lst_disciplina.SelectedItem.ToString();
            Vincula.Disciplina = discipline.Replace(" ", "");
            classe = lst_turma.SelectedItem.ToString();
            Vincula.Turma = classe.Replace("\n", "");
            bout = lst_turno.SelectedItem.ToString();
            Vincula.Turno = bout.Replace("\n", "");

            Vincula Vinculando = new Vincula();
            string c;
            MessageBox.Show(String.Concat("", course , " " , discipline, classe, bout));

            int turninho = Vinculando.BoutId();
            int cursinho = Vinculando.CourseId();
            int turminha = Vinculando.ClassId();
            int disciplininha = Vinculando.DisciplineId();

            MessageBox.Show(""+turninho+" "+disciplininha);

            disciplinacurso = Vinculando.InsertDisciplinaCurso(turninho, cursinho, turminha, disciplininha);
            disciplinar = Vinculando.InsertDisciplinar(turninho, cursinho, turminha, disciplininha);

            if (disciplinacurso && disciplinar)
            {
                MessageBox.Show("Cadastrado!", "Tudo certo!");
            }
            else
            {
                MessageBox.Show("Não foi possível concluir o cadastro!", "Erro!");
            }
        }

        private void lst_curso_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lst_curso.SelectedItems.Count > 0 && lst_disciplina.SelectedItems.Count > 0 && lst_turma.SelectedItems.Count > 0 && lst_turno.SelectedItems.Count > 0)
            {
                btn_vincular.Enabled = true;
            }
            else
            {
                btn_vincular.Enabled = false;
            }
        }

        private void lst_turno_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lst_curso.SelectedItems.Count > 0 && lst_disciplina.SelectedItems.Count > 0 && lst_turma.SelectedItems.Count > 0 && lst_turno.SelectedItems.Count > 0)
            {
                btn_vincular.Enabled = true;
            }
            else
            {
                btn_vincular.Enabled = false;
            }
        }

        private void lst_turma_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lst_curso.SelectedItems.Count > 0 && lst_disciplina.SelectedItems.Count > 0 && lst_turma.SelectedItems.Count > 0 && lst_turno.SelectedItems.Count > 0)
            {
                btn_vincular.Enabled = true;
            }
            else
            {
                btn_vincular.Enabled = false;
            }
        }
    }
}
