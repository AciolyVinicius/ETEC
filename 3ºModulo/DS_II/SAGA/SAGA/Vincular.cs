using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SAGA
{
    class Vincula
    {

        private static String curso;
        private static String disciplina;
        private static String turma;
        private static String turno;



        private MySqlConnection connection;

        public static String Curso
        {
            get
            {
                return curso;
            }

            set
            {
                curso = value;
            }
        }

        public static String Disciplina
        {
            get
            {
                return disciplina;
            }

            set
            {
                disciplina = value;
            }
        }

        public static String Turma
        {
            get
            {
                return turma;
            }

            set
            {
                turma = value;
            }
        }

        public static String Turno
        {
            get
            {
                return turno;
            }

            set
            {
                turno = value;
            }
        }

        public static String Cursostring
        {
            get
            {
                return cursostring;
            }

            set
            {
                cursostring = value;
            }
        }

        public static String Turnostring
        {
            get
            {
                return turnostring;
            }

            set
            {
                turnostring = value;
            }
        }

        public static String Turmastring
        {
            get
            {
                return turmastring;
            }

            set
            {
                turmastring = value;
            }
        }

        public static String Disciplinastring
        {
            get
            {
                return disciplinastring;
            }

            set
            {
                disciplinastring = value;
            }
        }

        MySqlDataReader course;
        MySqlDataReader discipline;
        MySqlDataReader bout;
        MySqlDataReader classe;

        private static String cursostring;
        private static String turnostring;
        private static String turmastring;
        private static String disciplinastring;


        public int CourseId()
        {
            Caminho route = new Caminho();
            String caminho = route.Route();
            try
            {
                connection = new MySqlConnection(caminho);
                connection.Open();

                String cursin = "select id from cursos where nome like '"+Vincula.Curso+"' ";

                MySqlCommand comandoscurso = new MySqlCommand(cursin, connection);
                course = comandoscurso.ExecuteReader();

                while (course.Read())
                {
                    cursostring = course["id"].ToString();
                    break;
                }

                connection.Close();

            }
            catch (Exception excecao)
            {
                throw new Exception("Erro ocorrido: " + excecao.Message);
            }
            int cursoid = Convert.ToInt32(cursostring);
            return cursoid;
        }

        public int BoutId()
        {
            Caminho route = new Caminho();
            String caminho = route.Route();
            try
            {
                connection = new MySqlConnection(caminho);
                connection.Open();

                String turnostring = "select id from turnos where ds_turno like '" + Vincula.Turno + "' ;";

                MySqlCommand comandosturno = new MySqlCommand(turnostring, connection);
                bout = comandosturno.ExecuteReader();

                while (bout.Read())
                {
                    turnostring = bout["id"].ToString();
                    break;
                }

                connection.Close();
            }
            catch (Exception excecao)
            {
                throw new Exception("Erro ocorrido: " + excecao.Message);
            }
            int turnoid = Convert.ToInt32(turnostring);
            return turnoid;
        }

        public int ClassId()
        {
            Caminho route = new Caminho();
            String caminho = route.Route();
            try
            {
                connection = new MySqlConnection(caminho);
                connection.Open();

                String turmastring = "select id from turmas where nome like  '" + Vincula.Turma + "';";

                MySqlCommand comandosturma = new MySqlCommand(turmastring, connection);
                classe = comandosturma.ExecuteReader();

                while (classe.Read())
                {
                    turmastring = classe["id"].ToString();
                    break;
                }

                connection.Close();

            }
            catch (Exception excecao)
            {
                throw new Exception("Erro ocorrido: " + excecao.Message);
            }
            int turmaid = Convert.ToInt32(turmastring);
            return turmaid;
        }

        public int DisciplineId()
        {
            Caminho route = new Caminho();
            String caminho = route.Route();
            try
            {
                connection = new MySqlConnection(caminho);
                connection.Open();

                String disciplinastring = "select cd_disciplina from tb_disciplina where nm_disciplina like (replace('" + Vincula.Disciplina + "', '\n', '')) ;";

                MySqlCommand comandosdisciplina = new MySqlCommand(disciplinastring, connection);
                discipline = comandosdisciplina.ExecuteReader();

                while (discipline.Read())
                {
                    disciplinastring = discipline["cd_disciplina"].ToString();
                    break;
                }

                connection.Close();

            }
            catch (Exception excecao)
            {
                throw new Exception("Erro ocorrido: " + excecao.Message);
            }
            int disciplinaid = Convert.ToInt32(disciplinastring);
            return disciplinaid;
        }

        public Boolean InsertDisciplinaCurso(int turnin, int cursin, int turmin, int disciplin)
        {
            Caminho route = new Caminho();
            String caminho = route.Route();
            int linhas = 0;
            try
            {
                connection = new MySqlConnection(caminho);
                connection.Open();

               String inserir = "insert into disciplina_curso (cursos_id, turnos_id, turmas_id) values ( " + cursin + ", " + turnin + ", " + turmin + ");";

                MySqlCommand comand = new MySqlCommand(inserir, connection);
                linhas = comand.ExecuteNonQuery();

                connection.Close();

            }
            catch (Exception excecao)
            {
                throw new Exception("Erro ocorrido: " + excecao.Message);
            }

            if (linhas > 0)
                return true;
            else
                return false;
        }

        public Boolean InsertDisciplinar(int turnin, int cursin, int turmin, int disciplin)
        {
            Caminho route = new Caminho();
            String caminho = route.Route();
            int linhas = 0;

            try
            {
                connection = new MySqlConnection(caminho);
                connection.Open();

                string inserir = "INSERT INTO tb_disciplinar (cd_disciplina_curso, cd_disciplina) VALUES ((SELECT id FROM disciplina_curso WHERE cursos_id = " + cursin + " AND turnos_id = " + turnin + " AND turmas_id = " + turmin + ") ,(SELECT cd_disciplina FROM tb_disciplina WHERE nm_disciplina LIKE '" + disciplin + "')); ";

                MySqlCommand comandos = new MySqlCommand(inserir, connection);
                linhas = comandos.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception excecao)
            {
                throw new Exception("Erro ocorrido: " + excecao.Message);
            }

            if (linhas > 0)
                return true;
            else
                return false;
        }
    }
}
