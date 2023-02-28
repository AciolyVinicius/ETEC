package exemplo_pc2_bd;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.SQLException;

/**
 *
 * @author Aluno
 */
public class Conexao {

    //método estático - não precisa de objeto para ser executado
    public static Connection conectar(String user, String senha) throws SQLException {
        return DriverManager.getConnection("jdbc:mysql://localhost/agenda", user, senha);
    }
    
    
}
