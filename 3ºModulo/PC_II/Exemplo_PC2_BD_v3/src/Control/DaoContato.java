/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Control;

import Model.Contato;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;

/**
 *
 * @author Aluno
 */
public class DaoContato {
    private Connection con;
    private PreparedStatement ps;
    private ArrayList<Contato> listagem;
    //Conexão com o BD
    private final String END = "jdbc://mysql://localhost/agenda";
    private final String USER = "root";
    private final String PASS = "root";
    
    //Construtor
    public DaoContato(){
        listagem=new ArrayList();
    }
    //adicionar contato
    public boolean adicionar(String telefone, String nome, int tipo){
        //inserir no BD
        try{
            conectar();
            ps=con.prepareStatement("insert into contato(telefone,nome,tipo) values(?,?,?)");
            ps.setString(1, telefone);
            ps.setString(2, nome);
            ps.setInt(3,tipo);
            ps.execute();
            desconectar();
            return true;
        }
        catch(SQLException ex){
            System.out.println(ex.getMessage());
        }
        return false;
    }

    private void conectar() throws SQLException {
        if(con==null){
            con=Conexao.conectar(USER,PASS);    
        }
    }
    private void desconectar() throws SQLException {
        con.close();
        ps.close();
        con=null;
    }
    //popular o ArrayList
    public ArrayList<Contato> populaContatos(){
        try{
            conectar();
            //limpar o ArrayList antes
            listagem.clear();
            ps = con.prepareStatement(
                    "SELECT contato.telefone, "
                        + "contato.nome, "
                        + "vinculo.tipo "
                    + "FROM contato JOIN vinculo "
                        + "ON contato.tipo = vinculo.codigo"
            );          
            
            // Receber os dados do banco
            ResultSet rs = ps.executeQuery();
            //Adicionar no ArrayList
            while(rs.next()){
                listagem.add(new Contato(rs.getString(1),rs.getString(2),rs.getString(3)));
            }
            desconectar();
        }
        catch(SQLException ex){
            System.out.println(ex.getMessage());
        }
        return listagem;
    }
    public ArrayList<Contato> busca(String busca){
        ArrayList<Contato> lista=new ArrayList();
        for(Contato c:listagem){
            if(c.getNome().toUpperCase().contains(busca.toUpperCase()) ||
                  c.getTelefone().toUpperCase().contains(busca.toUpperCase())  ){
                lista.add(c);
            }
        }
        return lista;
    }
    
    public boolean deletar(String telefone){
        //inserir no BD
        try{
            conectar();
            ps=con.prepareStatement("DELETE FROM contato WHERE telefone = ?");
            ps.setString(1, telefone);
            ps.execute();
            desconectar();
            return true;
        }
        catch(SQLException ex){
            System.out.println(ex.getMessage());
        }
        return false;
    }
    
    public boolean atualizar(String nome, int tipo, String telefone){
        //inserir no BD
        try{
            conectar();
         //   ps=con.prepareStatement("DELETE FROM contato WHERE telefone = ?");
            ps=con.prepareStatement("UPDATE contato set nome=?, tipo=? WHERE telefone=?");
            ps.setString(1, nome);
            ps.setInt(2, tipo);
            ps.setString(3, telefone);
            ps.execute();
            desconectar();
            return true;
        }
        catch(SQLException ex){
            System.out.println(ex.getMessage());
        }
        return false;
    }
}
