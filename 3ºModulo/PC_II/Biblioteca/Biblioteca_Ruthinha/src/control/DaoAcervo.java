/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package control;

import javax.swing.table.AbstractTableModel;
import Model.Acervo;
import Model.Acervo;
import biblioteca.Biblio_Class;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;
import java.util.List;
import java.sql.*;

/**
 *
 * @author Aluno
 */
public class DaoAcervo {
    private Connection con;
    private PreparedStatement ps;
    private ArrayList<Acervo> listagem;
    private final String END = "jdbc://mysql://localhost/agenda";
    private final String USER = "root";
    private final String PASS = "root";
    
    private void desconectar() throws SQLException {
        con.close();
        ps.close();
        con=null;
    }
    //popular o ArrayList
    public ArrayList<Acervo> populaAcervo(){
            try{
            con = Biblio_Class.conectar("root","root");
            ps = con.prepareStatement("select tb_acervo.cd_acervo as 'Código', "
                    + "tb_acervo.nm_titulo as 'Título', "
                    + "tb_acervo.nm_autor as 'Autor', "                    
                    + "tb_acervo.nm_edicao as 'Edição', "
                    + "tb_acervo.nm_editora as 'Editora', "
                    + "tb_acervo.ic_ativo as 'Disponibilidade', "
                    + "tb_tipo_material.nm_tipo as 'Tipo de Material', "
                    + "tb_categoria.nm_categoria as 'Categoria' "
                    + "from tb_tipo_material right join tb_acervo "
                    + " on tb_tipo_material.cd_material = tb_acervo.cd_material left join tb_categoria "
                    + "on tb_acervo.cd_categoria = tb_categoria.cd_categoria");
            // Receber os dados do banco
            ResultSet rs = ps.executeQuery();
            //Adicionar no ArrayList
            while(rs.next()){
                listagem.add(new Acervo(rs.getInt(1),rs.getString(2),rs.getString(3),rs.getString(4),rs.getString(5),rs.getBoolean(6),rs.getString(7),rs.getString(8)));
            }
            desconectar();
        }
        catch(SQLException ex){
            System.out.println(ex.getMessage());
        }
        return listagem;
    }
}
