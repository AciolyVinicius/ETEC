/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Control;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.SQLException;

/**
 *
 * @author Pedro
 */
public class Conexao {
    //mpetodo estático - não precisa de objeto para ser executafo
    
    public static Connection conectar(String user, String senha) throws SQLException
    {
        return DriverManager.getConnection("jdbc:mysql://localhost/agenda", user, senha);
    }
}
