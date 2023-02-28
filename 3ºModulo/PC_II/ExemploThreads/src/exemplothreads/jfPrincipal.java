package exemplothreads;

import java.awt.Dimension;
import java.awt.Toolkit;
import java.text.SimpleDateFormat;
import java.util.Calendar;

public class jfPrincipal extends javax.swing.JFrame {

    Thread t1, t2;
    int largura, altura;
    boolean move;
    int posX, posY; // POSIÇÃO DA JANELA

    public jfPrincipal() {
        initComponents();
        mostraHora();
        // OBTER A RESOLUÇÃO DO MONITOR
        Dimension tela = Toolkit.getDefaultToolkit().getScreenSize();
        largura = (int) tela.getWidth();
        altura = (int) tela.getHeight();
        // ESCREVER NA BARRA DE TITULO DA RESOLUÇÃO ATUAL
        setTitle("Resolução: " + largura + " x " + altura);
    }

    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        lblRelogio = new javax.swing.JLabel();
        btnMovimentar = new javax.swing.JButton();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);

        lblRelogio.setText("jLabel1");

        btnMovimentar.setText("Movimentar");
        btnMovimentar.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnMovimentarActionPerformed(evt);
            }
        });

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addGap(40, 40, 40)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addComponent(btnMovimentar)
                    .addComponent(lblRelogio))
                .addContainerGap(271, Short.MAX_VALUE))
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addGap(34, 34, 34)
                .addComponent(lblRelogio)
                .addGap(75, 75, 75)
                .addComponent(btnMovimentar)
                .addContainerGap(154, Short.MAX_VALUE))
        );

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private void btnMovimentarActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnMovimentarActionPerformed
        move = !move; // TROCA RAPIDA
        mover();
    }//GEN-LAST:event_btnMovimentarActionPerformed

    public static void main(String args[]) {

        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                new jfPrincipal().setVisible(true);
            }
        });
    }

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton btnMovimentar;
    private javax.swing.JLabel lblRelogio;
    // End of variables declaration//GEN-END:variables

    private void mostraHora() {
        t1 = new Thread() { // CLASSE INTERNA CRIADA DIRETAMENTE
            // SOBREESCRITA DO METODO RUN()
            @Override
            public void run() { // ESSE É O CODIGO QUE SERÁ EXECUTADO
                // NA THREAD QUANDO INICIADA
                Calendar cal; // CONTROLE PARA A DATA
                // FORMATAÇÃO DA DATA
                SimpleDateFormat sd = new SimpleDateFormat(
                        "dd/MM/yyyy - HH:mm:ss");
                // REPETIÇÃO INFINITA (ENQUANTO O PROGRAMA ESTIVER ABERTO)
                while (true) {
                    try {
                        // OBTER A DATA/HORA ATUAL
                        cal = Calendar.getInstance();
                        // ESCREVER NA LABEL
                        lblRelogio.setText(sd.format(cal.getTime()));
                        // VAMOS INSERIR UMA PAUSE ENTRE UM LOOP E OUTRO
                        Thread.sleep(1000); // EM MILESSEGUNDOS
                    } catch (InterruptedException eX) {
                    }
                }
            }
        };
        // CHAMA O METODO RUN(), EXIBE A HORA
        t1.start(); // EXECUTA O METODO QUE FOI SOBRESCRITO
    }

    private void mover() {
        if (t2 == null) {
            t2 = new Thread() {
                public void run() {
                    posX = getLocation().x;
                    posY = getLocation().y;
                    while (move) {
                        // POSICIONAR NA ESQUERDA E NA DIREITA
                        do {
                            posX++;
                            pausa();
                        } while (posX <= largura - getWidth());
                        do {
                            posX--;
                            pausa();
                        } while (posX >= 0);
                    }
                }

            };
            t2.start();
        }
    }

    private void pausa() {
        try {
            Thread.sleep(1);
        } catch (Exception ex) {
        }
        setLocation(posX, posY);
    }
}
