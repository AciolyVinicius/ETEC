package Model;

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
public class TabelaAcervo extends AbstractTableModel {

    private int  linhas;
    private ResultSet rs;
    private ResultSetMetaData metaData;
    //Atributos para trabalhar com ArrayList
    private List<Acervo> acervos;
    private String [] colunasT = {"Código", "Título", "Edição", "Autor", "Editora", "Ativo", "Categoria", "Material"};

    public TabelaAcervo(){
        acervos = new ArrayList();
    }
    public TabelaAcervo(List<Acervo> acervos){
        acervos = new ArrayList<Acervo>(acervos);
    }
    
    public TabelaAcervo(ResultSet rs) throws SQLException {
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
        if (acervos != null){
            return acervos.size();
        }
        else{
            return linhas;
        }
    }

    //Obtem o número de colunas
    @Override
    public int getColumnCount() {
        if(acervos!=null){
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
        if(acervos!=null){
            //Lê o Acervo da linha específica
            Acervo cl = acervos.get(indiceLinha);
            //Retorna o valor com base na coluna selecionada 
            switch(indiceColuna){
                case 0: //Telefone
                    return cl.getCodigo();
                case 1: //Nome
                    return cl.getTitulo();
                case 2: //Tipo
                    return cl.getEdicao();
                case 3: //Tipo
                    return cl.getAutor();
                case 4: //Tipo
                    return cl.getEditora();
                case 5: //Tipo
                    return cl.getAtivo();                
                case 6: //Tipo
                    return cl.getCategoria();
                case 7: //Tipo
                    return cl.getMaterial();
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
        
    if(acervos!=null){
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
    //Retorna um Acervo específico da tabela
    public Acervo getAcervo(int indiceLinha) {
        return acervos.get(indiceLinha);
    }
    
    //Adicionar um Acervo a tabela
    public void addAcervo(Acervo cl){
        acervos.add(cl);
        //É necessário mandar atualizar a tabela
        //Pega o último índice
        int ultimo = getRowCount() - 1;
        //Reporta a mudança para a JTable
        fireTableRowsInserted(ultimo, ultimo);
    }
    
    //Remover um Acervo específico
    public void removeAcervo(int IndiceLinha){
        acervos.remove(IndiceLinha);
        //Reporta a mudança
        fireTableRowsDeleted(IndiceLinha, IndiceLinha);
    }
    
    //Remover todos os Acervos da tabela
    public void limpar(){
        acervos.clear();
        //Reporta a mudança
        fireTableDataChanged();
    }
}
