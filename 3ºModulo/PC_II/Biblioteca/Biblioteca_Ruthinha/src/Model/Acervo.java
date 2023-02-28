/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

package Model;

/**
 *
 * @author viníciusaciolyelias
 */
public class Acervo {
    private int codigo;
    private String titulo;
    private String edicao;
    private String autor;
    private String editora;
    private Boolean ativo;
    private String categoria;
    private String material;

    public Acervo(int codigo, String titulo, String edicao, String autor, String editora, Boolean ativo, String categoria, String material){
        this.codigo = codigo;
        this.titulo = titulo;
        this.edicao = edicao;
        this.autor = autor;
        this.editora = editora;
        this.ativo = ativo;
        this.categoria = categoria;
        this.material  = material;
    }
    
    public String getTitulo() {
        return titulo;
    }

    public void setTitulo(String titulo) {
        this.titulo = titulo;
    }

    public String getEdicao() {
        return edicao;
    }

    public void setEdicao(String edicao) {
        this.edicao = edicao;
    }

    public String getAutor() {
        return autor;
    }

    public void setAutor(String autor) {
        this.autor = autor;
    }

    public String getEditora() {
        return editora;
    }

    public void setEditora(String editora) {
        this.editora = editora;
    }

    public Boolean getAtivo() {
        return ativo;
    }

    public void setAtivo(Boolean ativo) {
        this.ativo = ativo;
    }



    public int getCodigo() {
        return codigo;
    }

    public void setCodigo(int codigo) {
        this.codigo = codigo;
    }

    public String getCategoria() {
        return categoria;
    }

    public void setCategoria(String categoria) {
        this.categoria = categoria;
    }

    public String getMaterial() {
        return material;
    }

    public void setMaterial(String material) {
        this.material = material;
    }
    
    
}
