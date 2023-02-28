using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using MySql.Data.MySqlClient;
using System.Data;

namespace ProjetoWebService
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {
        MySqlConnection conexao = new MySqlConnection("server = localhost; port = 3306; username = root; password = root; database = dpto_projeto");
        [WebMethod]
        public Boolean InsertDepart(int id, String nome, String local)
        {
            String sql = "call insert_dpto(@id, @nome, @localizacao)";
            MySqlCommand comando = new MySqlCommand(sql, conexao);
            comando.Parameters.Add(new MySqlParameter("@id", MySqlDbType.Int64)).Value = id;
            comando.Parameters.Add(new MySqlParameter("@nome", MySqlDbType.VarChar)).Value = nome;
            comando.Parameters.Add(new MySqlParameter("@localizacao", MySqlDbType.VarChar)).Value = local;
            int linhasAfetadas = 0;
            conexao.Open();
            linhasAfetadas = comando.ExecuteNonQuery();
            conexao.Close();
            return linhasAfetadas != 0 ? true : false;
        }
        [WebMethod]
        public Boolean InsertDependente(int idf, int idd, String nome, String parente)
        {
            String sql = "call insert_dependente(@idf, @idd, @nome, @par)";
            MySqlCommand comando = new MySqlCommand(sql, conexao);
            comando.Parameters.Add(new MySqlParameter("@idf", MySqlDbType.Int64)).Value = idf;
            comando.Parameters.Add(new MySqlParameter("@idd", MySqlDbType.Int64)).Value = idd;
            comando.Parameters.Add(new MySqlParameter("@nome", MySqlDbType.VarChar)).Value = nome;
            comando.Parameters.Add(new MySqlParameter("@par", MySqlDbType.VarChar)).Value = parente;
            int linhasAfetadas = 0;
            conexao.Open();
            linhasAfetadas = comando.ExecuteNonQuery();
            conexao.Close();
            return linhasAfetadas != 0 ? true : false;
        }
        [WebMethod]
        public Boolean InsertFunc(int id, String nome, String end, String telefone, int salario, int idpto, int idptoger)
        {
            String sql = "call insert_func(@id, @nome, @end, @telefone, @sal, @idpto, @idptoger)";
            MySqlCommand comando = new MySqlCommand(sql, conexao);
            comando.Parameters.Add(new MySqlParameter("@id", MySqlDbType.Int64)).Value = id;
            comando.Parameters.Add(new MySqlParameter("@end", MySqlDbType.VarChar)).Value = end;
            comando.Parameters.Add(new MySqlParameter("@nome", MySqlDbType.VarChar)).Value = nome;
            comando.Parameters.Add(new MySqlParameter("@telefone", MySqlDbType.VarChar)).Value = telefone;
            comando.Parameters.Add(new MySqlParameter("@sal", MySqlDbType.Decimal)).Value = salario;
            comando.Parameters.Add(new MySqlParameter("@idpto", MySqlDbType.Int64)).Value = idpto;
            comando.Parameters.Add(new MySqlParameter("@idptoger", MySqlDbType.Int64)).Value = idptoger;
            int linhasAfetadas = 0;
            conexao.Open();
            linhasAfetadas = comando.ExecuteNonQuery();
            conexao.Close();
            return linhasAfetadas != 0 ? true : false;
        }
        [WebMethod]
        public Boolean InsertProj(int id, String nome, String tipo, String verba, int idpto, int cpffunc)
        {
            String sql = "call insert_projeto(@id, @nome, @tipo, @verba, @idpto, @cpffunc)";
            MySqlCommand comando = new MySqlCommand(sql, conexao);
            comando.Parameters.Add(new MySqlParameter("@id", MySqlDbType.Int64)).Value = id;
            comando.Parameters.Add(new MySqlParameter("@nome", MySqlDbType.VarChar)).Value = nome;
            comando.Parameters.Add(new MySqlParameter("@verba", MySqlDbType.VarChar)).Value = verba;
            comando.Parameters.Add(new MySqlParameter("@cpffunc", MySqlDbType.Int64)).Value = cpffunc;
            comando.Parameters.Add(new MySqlParameter("@idpto", MySqlDbType.Int64)).Value = idpto;
            comando.Parameters.Add(new MySqlParameter("@tipo", MySqlDbType.VarChar)).Value = tipo;
            int linhasAfetadas = 0;
            conexao.Open();
            linhasAfetadas = comando.ExecuteNonQuery();
            conexao.Close();
            return linhasAfetadas != 0 ? true : false;
        }
        [WebMethod]
        public Boolean InsertFuncProj(int idf, int idp, int hora)
        {
            String sql = "call insert_func_projeto(@idf, @idp, @hora)";
            MySqlCommand comando = new MySqlCommand(sql, conexao);
            comando.Parameters.Add(new MySqlParameter("@idf", MySqlDbType.Int64)).Value = idf;
            comando.Parameters.Add(new MySqlParameter("@idp", MySqlDbType.Int64)).Value = idp;
            comando.Parameters.Add(new MySqlParameter("@hora", MySqlDbType.Int64)).Value = hora;
            int linhasAfetadas = 0;
            conexao.Open();
            linhasAfetadas = comando.ExecuteNonQuery();
            conexao.Close();
            return linhasAfetadas != 0 ? true : false;
        }
        [WebMethod]
        public Boolean ExcluiDependente(int id, int idf)
        {
            String sql = "call exclui_dependente(@id, @idf)";
            MySqlCommand comando = new MySqlCommand(sql, conexao);
            comando.Parameters.Add(new MySqlParameter("@id", MySqlDbType.Int64)).Value = id;
            comando.Parameters.Add(new MySqlParameter("@idf", MySqlDbType.Int64)).Value = idf;
            int linhasAfetadas = 0;
            conexao.Open();
            linhasAfetadas = comando.ExecuteNonQuery();
            conexao.Close();
            return linhasAfetadas != 0 ? true : false;
        }
        [WebMethod]
        public Boolean UpdateDependente(int id, String nome, String par)
        {
            String sql = "call update_dependente(@id, @nome, @par)";
            MySqlCommand comando = new MySqlCommand(sql, conexao);
            comando.Parameters.Add(new MySqlParameter("@id", MySqlDbType.Int64)).Value = id;
            comando.Parameters.Add(new MySqlParameter("@nome", MySqlDbType.VarChar)).Value = nome;
            comando.Parameters.Add(new MySqlParameter("@par", MySqlDbType.VarChar)).Value = par;
            int linhasAfetadas = 0;
            conexao.Open();
            linhasAfetadas = comando.ExecuteNonQuery();
            conexao.Close();
            return linhasAfetadas != 0 ? true : false;
        }
        [WebMethod]
        public Boolean ExcluiDpto(int id)
        {
            String sql = "call exclui_dpto(@id)";
            MySqlCommand comando = new MySqlCommand(sql, conexao);
            comando.Parameters.Add(new MySqlParameter("@id", MySqlDbType.Int64)).Value = id;
            int linhasAfetadas = 0;
            conexao.Open();
            linhasAfetadas = comando.ExecuteNonQuery();
            conexao.Close();
            return linhasAfetadas != 0 ? true : false;
        }
        [WebMethod]
        public Boolean UpdateDpto(int id, String nome, String local)
        {
            String sql = "call update_dpto(@id, @nome, @local)";
            MySqlCommand comando = new MySqlCommand(sql, conexao);
            comando.Parameters.Add(new MySqlParameter("@id", MySqlDbType.Int64)).Value = id;
            comando.Parameters.Add(new MySqlParameter("@nome", MySqlDbType.VarChar)).Value = nome;
            comando.Parameters.Add(new MySqlParameter("@local", MySqlDbType.VarChar)).Value = local;
            int linhasAfetadas = 0;
            conexao.Open();
            linhasAfetadas = comando.ExecuteNonQuery();
            conexao.Close();
            return linhasAfetadas != 0 ? true : false;
        }
        [WebMethod]
        public Boolean ExcluiFunc(int id)
        {
            String sql = "call exclui_func(@id)";
            MySqlCommand comando = new MySqlCommand(sql, conexao);
            comando.Parameters.Add(new MySqlParameter("@id", MySqlDbType.Int64)).Value = id;
            int linhasAfetadas = 0;
            conexao.Open();
            linhasAfetadas = comando.ExecuteNonQuery();
            conexao.Close();
            return linhasAfetadas != 0 ? true : false;
        }
        [WebMethod]
        public Boolean UpdateFunc(int id, String nome, String end, String tel, int sal, int dp, int dpger)
        {
            String sql = "call update_func(@id, @nome, @end, @tel, @sal, @dp, @dpger)";
            MySqlCommand comando = new MySqlCommand(sql, conexao);
            comando.Parameters.Add(new MySqlParameter("@id", MySqlDbType.Int64)).Value = id;
            comando.Parameters.Add(new MySqlParameter("@nome", MySqlDbType.VarChar)).Value = nome;
            comando.Parameters.Add(new MySqlParameter("@end", MySqlDbType.VarChar)).Value = end;
            comando.Parameters.Add(new MySqlParameter("@tel", MySqlDbType.VarChar)).Value = tel;
            comando.Parameters.Add(new MySqlParameter("@sal", MySqlDbType.Decimal)).Value = sal;
            comando.Parameters.Add(new MySqlParameter("@dp", MySqlDbType.Int64)).Value = dp;
            comando.Parameters.Add(new MySqlParameter("@dpger", MySqlDbType.Int64)).Value = dpger;
            int linhasAfetadas = 0;
            conexao.Open();
            linhasAfetadas = comando.ExecuteNonQuery();
            conexao.Close();
            return linhasAfetadas != 0 ? true : false;
        }
        [WebMethod]
        public Boolean ExcluiProjeto(int id)
        {
            String sql = "call exclui_projeto(@id)";
            MySqlCommand comando = new MySqlCommand(sql, conexao);
            comando.Parameters.Add(new MySqlParameter("@id", MySqlDbType.Int64)).Value = id;
            int linhasAfetadas = 0;
            conexao.Open();
            linhasAfetadas = comando.ExecuteNonQuery();
            conexao.Close();
            return linhasAfetadas != 0 ? true : false;
        }
        [WebMethod]
        public Boolean UpdateProjeto(int id, Boolean conc, String nome, String tipo, String verba, int dp, int cdf)
        {
            String sql = "call update_projeto(@id," + conc +" , @nome, @tipo, @verba, @dp, @cdf)";
            MySqlCommand comando = new MySqlCommand(sql, conexao);
            comando.Parameters.Add(new MySqlParameter("@id", MySqlDbType.Int64)).Value = id;
            comando.Parameters.Add(new MySqlParameter("@nome", MySqlDbType.VarChar)).Value = nome;
            comando.Parameters.Add(new MySqlParameter("@tipo", MySqlDbType.VarChar)).Value = tipo;
            comando.Parameters.Add(new MySqlParameter("@verba", MySqlDbType.VarChar)).Value = verba;
            comando.Parameters.Add(new MySqlParameter("@dp", MySqlDbType.Int64)).Value = dp;
            comando.Parameters.Add(new MySqlParameter("@cdf", MySqlDbType.Int64)).Value = cdf;
            int linhasAfetadas = 0;
            conexao.Open();
            linhasAfetadas = comando.ExecuteNonQuery();
            conexao.Close();
            return linhasAfetadas != 0 ? true : false;
        }
        [WebMethod]
        public Boolean UpdateProjetoIc(int id, Boolean conc)
        {
            String sql = "call update_projeto(@id," + conc + " , '', '', '', null, null)";
            MySqlCommand comando = new MySqlCommand(sql, conexao);
            comando.Parameters.Add(new MySqlParameter("@id", MySqlDbType.Int64)).Value = id;
            int linhasAfetadas = 0;
            conexao.Open();
            linhasAfetadas = comando.ExecuteNonQuery();
            conexao.Close();
            return linhasAfetadas != 0 ? true : false;
        }
        [WebMethod] 
        public Boolean UpdateFuncProjeto(int idf, int idp, int aidf, int aidp, int hora)
        {
            String sql = "call exclui_func_projeto(@idf, @idp, @aidf, @aidp, @hora)";
            MySqlCommand comando = new MySqlCommand(sql, conexao);
            comando.Parameters.Add(new MySqlParameter("@idf", MySqlDbType.Int64)).Value = idf;
            comando.Parameters.Add(new MySqlParameter("@aidf", MySqlDbType.Int64)).Value = aidf;
            comando.Parameters.Add(new MySqlParameter("@idp", MySqlDbType.Int64)).Value = idp;
            comando.Parameters.Add(new MySqlParameter("@aidp", MySqlDbType.Int64)).Value = aidp;
            comando.Parameters.Add(new MySqlParameter("@hora", MySqlDbType.Int64)).Value = hora;
            int linhasAfetadas = 0;
            conexao.Open();
            linhasAfetadas = comando.ExecuteNonQuery();
            conexao.Close();
            return linhasAfetadas != 0 ? true : false;
        }
        [WebMethod]
        public Boolean ExcluiFuncProjeto(int idf, int idp)
        {
            String sql = "call excluir_func_projeto(@idf, @idp)";
            MySqlCommand comando = new MySqlCommand(sql, conexao);
            comando.Parameters.Add(new MySqlParameter("@idf", MySqlDbType.Int64)).Value = idf;
            comando.Parameters.Add(new MySqlParameter("@idp", MySqlDbType.Int64)).Value = idp;
            int linhasAfetadas = 0;
            conexao.Open();
            linhasAfetadas = comando.ExecuteNonQuery();
            conexao.Close();
            return linhasAfetadas != 0 ? true : false;
        }
        [WebMethod]
        public DataTable Departamento()
        {
            String sql = "select * from cdepartamento";
            MySqlCommand comandoSelect = new MySqlCommand(sql, conexao);
            MySqlDataAdapter adaptador = new MySqlDataAdapter(comandoSelect);
            DataTable resultado = new DataTable("resultado");
            adaptador.Fill(resultado);
            return resultado;
        }
        [WebMethod]
        public DataTable Dependente()
        {
            String sql = "select * from cdependente";
            MySqlCommand comandoSelect = new MySqlCommand(sql, conexao);
            MySqlDataAdapter adaptador = new MySqlDataAdapter(comandoSelect);
            DataTable resultado = new DataTable("resultado");
            adaptador.Fill(resultado);
            return resultado;
        }
        [WebMethod]
        public DataTable Funcionario()
        {
            String sql = "select * from cfuncionario";
            MySqlCommand comandoSelect = new MySqlCommand(sql, conexao);
            MySqlDataAdapter adaptador = new MySqlDataAdapter(comandoSelect);
            DataTable resultado = new DataTable("resultado");
            adaptador.Fill(resultado);
            return resultado;
        }
        [WebMethod]
        public DataTable ProjetoAndamento()
        {
            String sql = "select * from cprojeto_andamento";
            MySqlCommand comandoSelect = new MySqlCommand(sql, conexao);
            MySqlDataAdapter adaptador = new MySqlDataAdapter(comandoSelect);
            DataTable resultado = new DataTable("resultado");
            adaptador.Fill(resultado);
            return resultado;
        }
        [WebMethod]
        public DataTable ProjetoConcluido()
        {
            String sql = "select * from cprojeto_concluido";
            MySqlCommand comandoSelect = new MySqlCommand(sql, conexao);
            MySqlDataAdapter adaptador = new MySqlDataAdapter(comandoSelect);
            DataTable resultado = new DataTable("resultado");
            adaptador.Fill(resultado);
            return resultado;
        }
        [WebMethod]
        public DataTable Projeto()
        {
            String sql = "select * from cprojeto";
            MySqlCommand comandoSelect = new MySqlCommand(sql, conexao);
            MySqlDataAdapter adaptador = new MySqlDataAdapter(comandoSelect);
            DataTable resultado = new DataTable("resultado");
            adaptador.Fill(resultado);
            return resultado;
        }
        [WebMethod]
        public DataTable ProjetoAssociadoFunc(int proj)
        {
            String sql = "call projet_associado_func(@proj)";
            MySqlCommand comando = new MySqlCommand(sql, conexao);
            comando.Parameters.Add(new MySqlParameter("@proj", MySqlDbType.Int64)).Value = proj;
            conexao.Open();
            MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
            DataTable resultado = new DataTable("resultado");
            adaptador.Fill(resultado);
            conexao.Close();
            return resultado;
        }
        [WebMethod]
        public DataTable ProjetoNaoAssociadoFunc(int proj)
        {
            String sql = "call projet_nao_associado_func(@proj)";
            MySqlCommand comando = new MySqlCommand(sql, conexao);
            comando.Parameters.Add(new MySqlParameter("@proj", MySqlDbType.Int64)).Value = proj;
            conexao.Open();
            MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
            DataTable resultado = new DataTable("resultado");
            adaptador.Fill(resultado);
            conexao.Close();
            return resultado;
        }
    }
}
