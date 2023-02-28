using ProjetoWebService.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;

namespace ProjetoWebService.DAO
{
    public class DependenteDAO
    {
        public static List<DependenteDTO> select()
        {
            String sql = "SELECT cd_dependente, nm_dependente, nm_parentesco FROM dependente";
            MySqlConnection conexao = Conexao.getConexao();
            MySqlCommand comandoSelect = new MySqlCommand(sql, conexao);
            MySqlDataReader dr;
            conexao.Open();
            dr = comandoSelect.ExecuteReader();
            List<DependenteDTO> dependenteDTOs = new List<DependenteDTO>();
            while (dr.Read())
            {
                DependenteDTO dependente = new DependenteDTO();
                dependente.Id = dr.GetInt32(0);
                dependente.Nome = dr.GetString(1);
                dependente.Parentesco = dr.GetString(2);
                dependenteDTOs.Add(dependente);
            }
            conexao.Close();
            return dependenteDTOs;
        }
        public static bool insert(DependenteDTO dependente)
        {
            String sql = "INSERT INTO dependente (cd_dependente, nm_dependente, nm_parentesco) select coalesce(max(cd_dependente),0)+1, @nome" + ", @parentesco" + " from dependente";
            MySqlConnection conexao = Conexao.getConexao();
            MySqlCommand comando = new MySqlCommand(sql, conexao);
            comando.Parameters.Add(new MySqlParameter("@nome", MySqlDbType.VarChar)).Value = dependente.Nome;
            comando.Parameters.Add(new MySqlParameter("@parentesco", MySqlDbType.VarChar)).Value = dependente.Parentesco;
            int linhasAfetadas = 0;
            conexao.Open();
            linhasAfetadas = comando.ExecuteNonQuery();
            conexao.Close();
            return linhasAfetadas != 0 ? true : false;
        }
        public static bool update(DependenteDTO dependente)
        {
            String sql = "UPDATE dependente SET nm_dependente = @nome" + ", nm_parentesco = @parentesco" + " WHERE cd_dependente = @id";
            MySqlConnection conexao = Conexao.getConexao();
            MySqlCommand comando = new MySqlCommand(sql, conexao);
            comando.Parameters.Add(new MySqlParameter("@nome", MySqlDbType.VarChar)).Value = dependente.Nome;
            comando.Parameters.Add(new MySqlParameter("@parentesco", MySqlDbType.VarChar)).Value = dependente.Parentesco;
            comando.Parameters.Add(new MySqlParameter("@id", MySqlDbType.Int64)).Value = dependente.Id;
            int linhasAfetadas = 0;
            conexao.Open();
            linhasAfetadas = comando.ExecuteNonQuery();
            conexao.Close();
            return linhasAfetadas != 0 ? true : false;
        }
        public static bool delete(int id)
        {
            String sql = "DELETE FROM dependente WHERE cd_dependente = @id";
            MySqlConnection conexao = Conexao.getConexao();
            MySqlCommand comando = new MySqlCommand(sql, conexao);
            comando.Parameters.Add(new MySqlParameter("@id", MySqlDbType.Int64)).Value = id;
            int linhasAfetadas = 0;
            conexao.Open();
            linhasAfetadas = comando.ExecuteNonQuery();
            conexao.Close();
            return linhasAfetadas != 0 ? true : false;
        }
        public static DependenteDTO search(int id)
        {
            String sql = "SELECT cd_dependente, nm_dependente, nm_parentesco FROM dependente WHERE cd_dependente = @id";
            MySqlConnection conexao = Conexao.getConexao();
            MySqlCommand comandoSelect = new MySqlCommand(sql, conexao);
            comandoSelect.Parameters.Add(new MySqlParameter("@id", MySqlDbType.Int64)).Value = id;
            MySqlDataReader dr;
            conexao.Open();
            dr = comandoSelect.ExecuteReader();
            DependenteDTO dependente = new DependenteDTO();
            if (dr.Read())
            {
                dependente.Id = dr.GetInt32(0);
                dependente.Nome = dr.GetString(1);
                dependente.Parentesco = dr.GetString(2);
            }
            conexao.Close();
            return dependente;
        }
        
        public static List<DependenteDTO> func_dependente() {
            String sql = "call func_dependente();";
            MySqlConnection conexao = Conexao.getConexao();
            MySqlCommand comandoSelect = new MySqlCommand(sql, conexao);
            MySqlDataReader dr;
            conexao.Open();
            dr = comandoSelect.ExecuteReader();
            List<DependenteDTO> dependentes = new List<DependenteDTO>();
            if (dr.Read())
            {
                DependenteDTO dependente = new DependenteDTO();
                dependente.Nome = dr.GetString(0);
                dependente.Parentesco = dr.GetString(1);
                dependentes.Add(dependente);
            }
            conexao.Close();
            return dependentes;
        }
    }
}