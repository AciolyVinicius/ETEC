package modelo;

/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
import javax.swing.table.AbstractTableModel;
import java.sql.*;
import java.util.ArrayList;
import java.util.List;

/**
 *
 * @author Bruno
 */
public class TabelaUsuarios extends AbstractTableModel {

    private int colunas, linhas;
    private ResultSet rs;
    private ResultSetMetaData metaData;
    private List<Usuarios>linhasT;
    private String [] colunasT = {"Código", "Nome", "Telefone", "Email", "SeProfessor", "Ativo"};
    
    
    public TabelaUsuarios() {
        linhasT = new ArrayList<Usuarios>();
    }
    
    public TabelaUsuarios(List<Usuarios>listagem) {
        
        linhasT = new ArrayList<Usuarios>(listagem);
    }

    public TabelaUsuarios(ResultSet rs) throws SQLException {
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
        if(linhasT.size()>=0){
            return linhasT.size();
        } else {
        
        return linhas;
        }
    }

    //Obtem o número de colunas
    @Override
    public int getColumnCount() {
        if(linhasT!=null){
            return colunasT.length;
        }
        else{
            try {
                return metaData.getColumnCount();
            } catch (SQLException e) {
                System.out.println(e.getMessage());
            }
        }
        //Se tiver algum problema retorna 0 para o número de colunas
        return 0;
    }

    @Override
    public Object getValueAt(int indiceLinha, int indiceColuna) {
        if(linhasT != null){
            //Lê o contato da linha específica
            Usuarios a1 = linhasT.get(indiceLinha);
            //Retorna o valor com base na coluna selecionada
            switch(indiceColuna){
                case 0:
                    return a1.getCodigo();
                case 1: 
                    return a1.getNome();
                case 2: 
                    return a1.getTelefone();
                case 3:
                    return a1.getEmail();  
                case 4:
                    return a1.getProfessor();
                case 5:
                    return a1.getAtivo();
                default://gera uma exceção caso o índice não exista
                    throw new IndexOutOfBoundsException("Coluna inexistente");   
            }
        }
        else{
            try {
                
                this.rs.absolute(indiceLinha + 1);
                return rs.getObject(indiceColuna + 1);
            }
            catch (SQLException e) {
                e.getMessage();
            }
        }
        return "";
    }

    @Override
    public String getColumnName(int coluna) {
        if(linhasT!=null){
            return colunasT[coluna];
        }   
        else{
            try {
                 return metaData.getColumnLabel(coluna + 1);
             } 
            catch (SQLException e) {
                 e.getMessage();
            }
        }
        //determina o nome da coluna
        //Se der alguma problema, retorna uma string vazia
        return "";
    }
    
    public Usuarios getUsuarios(int indiceLinha){
        return linhasT.get(indiceLinha);
    }
    
    public void addUsuarios(Usuarios a1){
        linhasT.add(a1);
        int ultimo = getRowCount() -1;
        fireTableRowsInserted(ultimo, ultimo);
    }
    
    public void removeUsuarios(int indiceLinha){
        linhasT.remove(indiceLinha);
        fireTableRowsDeleted(indiceLinha, indiceLinha);
    }
    
    public void limpar(){
        linhasT.clear();
        //reporta a mudança
        fireTableDataChanged();
    }
}
