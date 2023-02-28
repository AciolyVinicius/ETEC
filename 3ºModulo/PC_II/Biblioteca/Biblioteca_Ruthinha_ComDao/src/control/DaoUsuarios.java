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
import modelo.Usuarios;
import biblioteca.Biblio_Class;

/**
 *
 * @author Admin
 */
public class DaoUsuarios {
    private Connection con;
    private PreparedStatement ps;
    private ArrayList<Usuarios>listagem;
    //CONSTANTES
    private final String END = "jdbc://mysql://localhost/biblio";
    private final String USER = "root";
    private final String PASS = "root";
    
    public DaoUsuarios(){
        listagem = new ArrayList();
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
    
    public ArrayList<Usuarios> populaUsuario(){
        try {
            
            conectar();
            //limpar o arraylist
            listagem.clear();
            ps = con.prepareStatement("select tb_usuario.cd_usuario as 'Código', "
                    + "tb_usuario.nm_usuario as 'Nome', "
                    + "tb_usuario.cd_telefone as 'Telefone', "                    
                    + "tb_usuario.nm_email as 'Email', "
                    + "tb_usuario.ic_professor as 'Professor', "
                    + "tb_usuario.ic_ativo as 'Ativo', "
                    + "tb_curso.nm_curso as 'Curso' "
                    + "from tb_usuario left join tb_curso "
                    + " on tb_usuario.cd_curso = tb_curso.cd_curso");
            ResultSet rs;
            rs = ps.executeQuery();
            //ADICIONAR NO ARRAYLIST
            while(rs.next()){
                listagem.add(new Usuarios(rs.getInt(1),rs.getString(2),rs.getString(3),rs.getString(4),rs.getBoolean(5),rs.getBoolean(6)));
            }
            //desconectar();
        } 
        catch (SQLException ex) {
            System.out.println(ex.getMessage());
            //desconectar();
        }
        
        return listagem;
    }
}
