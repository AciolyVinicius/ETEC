package Model;

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
 * @author Aluno
 */
public class TabelaContato extends AbstractTableModel {

    private int colunas, linhas;
    private ResultSet rs;
    private ResultSetMetaData metaData;
    //Atributos para trabalhar com ArrayList
    private List<Contato> linhasT;
    //Array com nomes das colunas
    private String [] colunasT = {"Telefone","Nome","Tipo"};
    
    //Criar modelo com zero linhas
    public TabelaContato() {
        linhasT = new ArrayList<Contato>();
    }

    //Cria um modelo de tabela com base em uma Lista específica
    public TabelaContato(List<Contato> listagem) {
        linhasT = new ArrayList<Contato>(listagem);
    }
    
    public TabelaContato(ResultSet rs) throws SQLException {
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
        if (linhasT != null){
            return linhasT.size();
        }
        else{
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
        if(linhasT!=null){
            //Lê o contato da linha específica
            Contato cl = linhasT.get(indiceLinha);
            //Retorna o valor com base na coluna selecionada
            switch(indiceColuna){
                case 0: //Telefone
                    return cl.getTelefone();
                case 1: //Nome
                    return cl.getNome();
                case 2: //Tipo
                    return cl.getTipo();
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
        
    if(linhasT!=null){
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
    //Retorna um contato específico da tabela
    public Contato getContato(int indiceLinha) {
        return linhasT.get(indiceLinha);
    }
    
    //Adicionar um Contato a tabela
    public void addContato(Contato cl){
        linhasT.add(cl);
        //É necessário mandar atualizar a tabela
        //Pega o último índice
        int ultimo = getRowCount() - 1;
        //Reporta a mudança para a JTable
        fireTableRowsInserted(ultimo, ultimo);
    }
    
    //Remover um contato específico
    public void removeContato(int IndiceLinha){
        linhasT.remove(IndiceLinha);
        //Reporta a mudança
        fireTableRowsDeleted(IndiceLinha, IndiceLinha);
    }
    
    //Remover todos os contatos da tabela
    public void limpar(){
        linhasT.clear();
        //Reporta a mudança
        fireTableDataChanged();
    }
}