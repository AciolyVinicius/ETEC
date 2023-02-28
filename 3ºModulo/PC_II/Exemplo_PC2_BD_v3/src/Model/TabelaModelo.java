package model;

/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
import javax.swing.table.AbstractTableModel;
import java.sql.*;

/**
 *
 * @author Aluno
 */
public class TabelaModelo extends AbstractTableModel {

    private int colunas, linhas;
    private ResultSet rs;
    private ResultSetMetaData metaData;

    public TabelaModelo() {

    }

    public TabelaModelo(ResultSet rs) throws SQLException {
        this.rs = rs;
        this.metaData = rs.getMetaData();
        //Determina um número de linhas em um ResultSet
        this.rs.last(); //Move para última linha
        linhas = rs.getRow(); //pega o número da linha
        //Notifica o JTable das alterações
        fireTableStructureChanged();
    }

    @Override
    //Obtem o número de linhas
    public int getRowCount() {
        return linhas;
    }

    //Obtem o número de colunas
    @Override
    public int getColumnCount() {
        try {
            return metaData.getColumnCount();
        } catch (SQLException e) {
            System.out.println(e.getMessage());
        }
        //Se tiver algum problema retorna 0 para o número de colunas
        return 0;

    }

    @Override
    public Object getValueAt(int indiceLinha, int indiceColuna) {
        try {
            this.rs.absolute(indiceLinha + 1);
            return rs.getObject(indiceColuna + 1);
        } catch (SQLException e) {
            e.getMessage();
        }
        return "";
    }

    @Override
    public String getColumnName(int coluna) {
        //determina o nome da coluna
        try {
            return metaData.getColumnLabel(coluna + 1);
        } catch (SQLException e) {
            e.getMessage();
        }
        //Se der alguma problema, retorna uma string vazia
        return "";
    }
}
