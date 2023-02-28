/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package heranca_locadora;

/**
 *
 * @author Guilherme
 */
public class filme extends item{
    
    private String diretor;
    private int duracao;

    public String getDiretor() {
        return diretor;
    }

    public void setDiretor(String diretor) {
        this.diretor = diretor;
    }

    public int getDuracao() {
        return duracao;
    }

    public void setDuracao(int duracao) {
        this.duracao = duracao;
    }

    @Override
    public String toString() {
        return "filme{"  + "id=" + super.getId() + ", titulo=" + super.getTitulo() + ", Descricao=" + super.getDescricao() + ", preco=" + super.getPreco() + ", numeroDias=" + super.getNumeroDias() + ", categoria=" + super.getCategoria() + "diretor=" + diretor + ", duracao=" + duracao + '}';
    }
    
    
}
