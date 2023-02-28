/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package control;

import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;
import modelo.Acervo;
import biblioteca.Biblio_Class;

/**
 *
 * @author Admin
 */
public class DaoAcervo {
    private Connection con;
    private PreparedStatement ps;
    private ArrayList<Acervo>listagem;
    //CONSTANTES
    private final String END = "jdbc://mysql://localhost/biblio";
    private final String USER = "root";
    private final String PASS = "root";
    
    public DaoAcervo(){
        listagem = new ArrayList();
    }
    
    public boolean adicionar(int acervo, String titulo, String autor, String editora /*int material, int categoria*/){
        try{
            conectar();
            ps = con.prepareStatement("insert into tb_acervo (cd_acervo, nm_titulo, nm_autor, nm_editora) values"
                    + " (?,?,?,?)");
            ps.setInt(1,acervo);
            ps.setString(2,titulo);
            ps.setString(3,autor);
            ps.setString(4,editora);
            ps.execute();
            //desconectar();
            return true;
        }
        catch(SQLException e){
            System.out.println(e.getMessage());
        }
        return false;
    }
    
    private void conectar() throws SQLException {
        if(con==null){
            con = Biblio_Class.conectar(USER, PASS);
        }
    }

    private void desconectar() throws SQLException {
        con.close();
        ps.close();
    }
    
    public ArrayList<Acervo> populaAcervo(){
        try {
            
            conectar();
            //limpar o arraylist
            listagem.clear();
            ps = con.prepareStatement("select cd_acervo, nm_titulo, nm_autor, nm_editora from tb_acervo");
            ResultSet rs;
            rs = ps.executeQuery();
            //ADICIONAR NO ARRAYLIST
            while(rs.next()){
                listagem.add(new Acervo(rs.getInt(1),
                rs.getString(2), rs.getString(3), rs.getString(4)));
            }
            //desconectar();
        } 
        catch (SQLException ex) {
            System.out.println(ex.getMessage());
            //desconectar();
        }
        
        return listagem;
    }
    
    public ArrayList<Acervo> busca(String buscar){
        ArrayList<Acervo> lista = new ArrayList();
        
        for(Acervo a:listagem){
            if(a.getAutor().toUpperCase().contains(buscar.toUpperCase()) || a.getEditora().toUpperCase().contains(buscar.toUpperCase())){
                lista.add(a);
            }
        }
        return lista;
    }
    
    
    
}
