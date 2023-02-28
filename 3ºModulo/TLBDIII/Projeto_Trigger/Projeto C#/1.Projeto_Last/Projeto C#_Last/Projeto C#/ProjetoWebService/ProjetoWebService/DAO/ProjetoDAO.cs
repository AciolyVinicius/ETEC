using ProjetoWebService.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;

namespace ProjetoWebService.DAO
{
    public class ProjetoDAO
    {
        public static List<ProjetoDTO> select()
        {
            String sql = "SELECT cd_projeto, nm_projeto, nm_tipo, nm_verbba, cd_cpf_func, cd_dpto FROM projeto";
            MySqlConnection conexao = Conexao.getConexao();
            MySqlCommand comandoSelect = new MySqlCommand(sql, conexao);
            MySqlDataReader dr;
            conexao.Open();
            dr = comandoSelect.ExecuteReader();
            List<ProjetoDTO> projetoDTOs = new List<ProjetoDTO>();
            while (dr.Read())
            {
                ProjetoDTO projeto = new ProjetoDTO();
                projeto.Id = dr.GetInt32(0);
                projeto.Nome = dr.GetString(1);
                projeto.Tipo = dr.GetString(2);
                projeto.Verba = dr.GetString(3);
                projeto.Departamento = DepartamentoDAO.search(dr.GetInt32(5));
                projetoDTOs.Add(projeto);
            }
            conexao.Close();
            return projetoDTOs;
        }
        public static bool insert(ProjetoDTO projeto)
        {
            String sql = "INSERT INTO projeto (cd_projeto, nm_projeto, nm_tipo, nm_verbba, cd_cpf_func, cd_dpto) select coalesce(max(cd_projeto),0)+1, @nome" + ", @tipo" + ", @verba" + ", @cpf" + ", @departamento" + " from projeto";
            MySqlConnection conexao = Conexao.getConexao();
            MySqlCommand comando = new MySqlCommand(sql, conexao);
            comando.Parameters.Add(new MySqlParameter("@nome", MySqlDbType.VarChar)).Value = projeto.Nome;
            comando.Parameters.Add(new MySqlParameter("@tipo", MySqlDbType.VarChar)).Value = projeto.Tipo;
            comando.Parameters.Add(new MySqlParameter("@verba", MySqlDbType.VarChar)).Value = projeto.Verba;
            comando.Parameters.Add(new MySqlParameter("@cpf", MySqlDbType.Int64)).Value = projeto.CpfFuncionario;
            comando.Parameters.Add(new MySqlParameter("@departamento", MySqlDbType.Int64)).Value = projeto.Departamento.Id;
            int linhasAfetadas = 0;
            conexao.Open();
            linhasAfetadas = comando.ExecuteNonQuery();
            conexao.Close();
            return linhasAfetadas != 0 ? true : false;
        }
        public static bool update(ProjetoDTO projeto)
        {
            String sql = "UPDATE projeto SET nm_projeto = @nome" + ", nm_tipo = @tipo" + ", nm_verbba = @verba" + ", cd_cpf_func = @cpf" + ", cd_dpto = @departamento" + " WHERE cd_projeto = @id";
            MySqlConnection conexao = Conexao.getConexao();
            MySqlCommand comando = new MySqlCommand(sql, conexao);
            comando.Parameters.Add(new MySqlParameter("@nome", MySqlDbType.VarChar)).Value = projeto.Nome;
            comando.Parameters.Add(new MySqlParameter("@tipo", MySqlDbType.VarChar)).Value = projeto.Tipo;
            comando.Parameters.Add(new MySqlParameter("@verba", MySqlDbType.VarChar)).Value = projeto.Verba;
            comando.Parameters.Add(new MySqlParameter("@cpf", MySqlDbType.Int64)).Value = projeto.CpfFuncionario;
            comando.Parameters.Add(new MySqlParameter("@departamento", MySqlDbType.Int64)).Value = projeto.Departamento.Id;
            comando.Parameters.Add(new MySqlParameter("@id", MySqlDbType.Int64)).Value = projeto.Id;
            int linhasAfetadas = 0;
            conexao.Open();
            linhasAfetadas = comando.ExecuteNonQuery();
            conexao.Close();
            return linhasAfetadas != 0 ? true : false;
        }
        public static bool delete(int id)
        {
            String sql = "DELETE FROM projeto WHERE cd_projeto = @id";
            MySqlConnection conexao = Conexao.getConexao();
            MySqlCommand comando = new MySqlCommand(sql, conexao);
            comando.Parameters.Add(new MySqlParameter("@id", MySqlDbType.Int64)).Value = id;
            int linhasAfetadas = 0;
            conexao.Open();
            linhasAfetadas = comando.ExecuteNonQuery();
            conexao.Close();
            return linhasAfetadas != 0 ? true : false;
        }
        public static ProjetoDTO search(int id)
        {
            String sql = "SELECT cd_projeto, nm_projeto, nm_tipo, nm_verbba, cd_cpf_func, cd_dpto FROM projeto WHERE cd_projeto = @id";
            MySqlConnection conexao = Conexao.getConexao();
            MySqlCommand comandoSelect = new MySqlCommand(sql, conexao);
            comandoSelect.Parameters.Add(new MySqlParameter("@id", MySqlDbType.Int64)).Value = id;
            MySqlDataReader dr;
            conexao.Open();
            dr = comandoSelect.ExecuteReader();
            ProjetoDTO projeto = new ProjetoDTO();
            if (dr.Read())
            {
                projeto.Id = dr.GetInt32(0);
                projeto.Nome = dr.GetString(1);
                projeto.Tipo = dr.GetString(2);
                projeto.Verba = dr.GetString(3);
                projeto.CpfFuncionario = dr.GetInt32(4);
                projeto.Departamento = DepartamentoDAO.search(dr.GetInt32(5));
            }
            conexao.Close();
            return projeto;
        }

        public static List<ProjetoDTO> func_proj_verb_indefinida_xbolsas(int bolsas)
        {
            String sql = "call proj_verb_indefinida_xbolsas(@bolsas); ";
            MySqlConnection conexao = Conexao.getConexao();
            MySqlCommand comandoSelect = new MySqlCommand(sql, conexao);
            comandoSelect.Parameters.Add(new MySqlParameter("@bolsas", MySqlDbType.Int64)).Value = bolsas;
            MySqlDataReader dr;
            conexao.Open();
            dr = comandoSelect.ExecuteReader();
            List<ProjetoDTO> projetos = new List<ProjetoDTO>();
            if (dr.Read())
            {
                ProjetoDTO projeto = new ProjetoDTO();
                projeto.Verba = dr.GetString(0);
                projetos.Add(projeto);
            }
            conexao.Close();
            return projetos;
        }

        public static List<ProjetoDTO> func_proj_verb_indefinida_xtipo(string tipo){
            String sql = "call proj_verb_indefinida_xbolsas(@tipo); ";
            MySqlConnection conexao = Conexao.getConexao();
            MySqlCommand comandoSelect = new MySqlCommand(sql, conexao);
            comandoSelect.Parameters.Add(new MySqlParameter("@tipo", MySqlDbType.Int64)).Value = tipo;
            MySqlDataReader dr;
            conexao.Open();
            dr = comandoSelect.ExecuteReader();
            List<ProjetoDTO> projetos = new List<ProjetoDTO>();
            if (dr.Read())
            {
                ProjetoDTO projeto = new ProjetoDTO();
                projeto.Tipo = dr.GetString(0);
                projeto.Verba = dr.GetString(1);
                projetos.Add(projeto);
            }
            conexao.Close();
            return projetos;
        }
    }
}