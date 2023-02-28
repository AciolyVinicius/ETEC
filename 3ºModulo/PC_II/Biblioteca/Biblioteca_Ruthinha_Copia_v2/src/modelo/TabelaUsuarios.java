package modelo;

/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
import biblioteca.*;
import javax.swing.table.AbstractTableModel;
import java.sql.*;
import java.util.ArrayList;
import java.util.List;

/**
 *
 * @author Bruno
 */
public class TabelaUsuarios extends AbstractTableModel {

    private int linhas;
    private ResultSet rs;
    private ResultSetMetaData metaData;
    //Atributos para trabalhar com ArrayList
    private List<Usuarios> users;
    private String [] colunasT = {"Código", "Nome", "Telefone", "Email", "SeProfessor", "Ativo", "Curso"};

    public TabelaUsuarios(){
        users = new ArrayList();
    }
    public TabelaUsuarios(List<Usuarios> user){
        users = new ArrayList<Usuarios>(user);
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
        if (users != null){
            return users.size();
        }
        else{
            return linhas;
        }
    }

    //Obtem o número de colunas
    @Override
    public int getColumnCount() {
        if(users!=null){
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
        if(users!=null){
            //Lê o Usuarios da linha específica
            Usuarios cl = users.get(indiceLinha);
            //Retorna o valor com base na coluna selecionada
            switch(indiceColuna){
                case 0: //Telefone
                    return cl.getCodigo();
                case 1: //Nome
                    return cl.getNome();
                case 2: //Tipo
                    return cl.getTelefone();
                case 3: //Tipo
                    return cl.getEmail();
                case 4: //Tipo
                    return cl.getProfessor();
                case 5: //Tipo
                    return cl.getAtivo();                
                case 6: //Tipo
                    return cl.getCurso();
                default: //Gera uma exceção caso o índice não exista
                    throw new IndexOutOfBoundsException("Coluna inexistente");
            }
        }
        //Aqui é com o BD
        else{
        try {
            this.rs.absolute(indiceLinha + 1);
            return rs.getObject(indiceColuna + 1);
        } catch (SQLException e) {
            e.getMessage();
        }
        }
        return "";
    }

    @Override
    public String getColumnName(int coluna) {
        
    if(users!=null){
        return colunasT[coluna];
    }
    else{
        try {
            return metaData.getColumnLabel(coluna + 1);
        } catch (SQLException e) {
            e.getMessage();
        }
    }
        //Se der alguma problema, retorna uma string vazia
        return "";
    }
    
    //Métodos particulares para essa classe
    //Retorna um Usuarios específico da tabela
    public Usuarios getUsuarios(int indiceLinha) {
        return users.get(indiceLinha);
    }
    
    //Adicionar um Usuarios a tabela
    public void addUsuarios(Usuarios cl){
        users.add(cl);
        //É necessário mandar atualizar a tabela
        //Pega o último índice
        int ultimo = getRowCount() - 1;
        //Reporta a mudança para a JTable
        fireTableRowsInserted(ultimo, ultimo);
    }
    
    //Remover um Usuarios específico
    public void removeUsuarios(int IndiceLinha){
        users.remove(IndiceLinha);
        //Reporta a mudança
        fireTableRowsDeleted(IndiceLinha, IndiceLinha);
    }
    
    //Remover todos os Usuarioss da tabela
    public void limpar(){
        users.clear();
        //Reporta a mudança
        fireTableDataChanged();
    }
}
