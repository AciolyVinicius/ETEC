/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

package control;

import modelo.Usuarios;
import modelo.Usuarios;
import biblioteca.Biblio_Class;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;
import java.util.List;

/**
 *
 * @author viníciusaciolyelias
 */
public class DaoUsuarios {
    public List<Usuarios> users;
    private Connection con;
    private PreparedStatement ps;
    private ArrayList<Usuarios> listagem;
    private ResultSet rs;
    
    private void desconectar() throws SQLException {
        con.close();
        ps.close();
        con=null;
    }
    //popular o ArrayList
    public ArrayList<Usuarios> populaUsuario(){
            try{
            con = Biblio_Class.conectar("root","root");
            ps = con.prepareStatement("select tb_usuario.cd_usuario as 'Código', "
                    + "tb_usuario.nm_usuario as 'Nome', "
                    + "tb_usuario.cd_telefone as 'Telefone', "                    
                    + "tb_usuario.nm_email as 'Email', "
                    + "tb_usuario.ic_professor as 'Professor', "
                    + "tb_usuario.ic_ativo as 'Ativo', "
                    + "tb_curso.nm_curso as 'Curso' "
                    + "from tb_usuario left join tb_curso "
                    + " on tb_usuario.cd_curso = tb_curso.cd_curso");
            // Receber os dados do banco
            ResultSet rs = ps.executeQuery();
            //Adicionar no ArrayList
            while(rs.next()){
                listagem.add(new Usuarios(rs.getInt(1),rs.getString(2),rs.getString(3),rs.getString(4),rs.getBoolean(5),rs.getBoolean(6),rs.getString(7)));
            }
            desconectar();
        }
        catch(SQLException ex){
            System.out.println(ex.getMessage());
        }
        return listagem;
    }
}