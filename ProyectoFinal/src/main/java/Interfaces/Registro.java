/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Interfaces;

import java.io.IOException;
import java.io.OutputStream;
import java.net.HttpURLConnection;
import java.net.MalformedURLException;
import java.net.URI;
import java.net.URL;
import java.net.http.HttpClient;
import java.net.http.HttpRequest;
import java.net.http.HttpResponse;
import java.util.logging.Level;
import java.util.logging.Logger;
import java.util.regex.Matcher;
import java.util.regex.Pattern;
import javax.json.Json;
import javax.json.JsonObject;
import javax.json.JsonObjectBuilder;
import javax.swing.ImageIcon;
import javax.swing.JOptionPane;
import modelos.EmpleadoTI;

/**
 *
 * @author josel
 */
public class Registro extends javax.swing.JFrame {

    private HttpClient httpClient = HttpClient.newBuilder().version(HttpClient.Version.HTTP_2).build();

    /**
     * Creates new form Registro
     */
    public Registro() {
        initComponents();

    }

    /**
     * This method is called from within the constructor to initialize the form.
     * WARNING: Do NOT modify this code. The content of this method is always
     * regenerated by the Form Editor.
     */
    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        jLabel1 = new javax.swing.JLabel();
        jLabel2 = new javax.swing.JLabel();
        jtxtNombre = new javax.swing.JTextField();
        jtxtUser = new javax.swing.JTextField();
        jPassword1 = new javax.swing.JPasswordField();
        jLabel6 = new javax.swing.JLabel();
        jbtnRegistrar = new javax.swing.JButton();
        jButton2 = new javax.swing.JButton();
        jLabel7 = new javax.swing.JLabel();
        jPassword2 = new javax.swing.JPasswordField();
        jtxtEmail = new javax.swing.JTextField();
        jLabel5 = new javax.swing.JLabel();
        jLabel3 = new javax.swing.JLabel();
        jtxtApellido = new javax.swing.JTextField();
        jLabel4 = new javax.swing.JLabel();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);
        setTitle("REGISTRO DE EMPLEADOS DE TI");
        setIconImage(new ImageIcon(getClass().getResource("/Imagenes/registros.png")).getImage());
        setResizable(false);

        jLabel1.setFont(new java.awt.Font("Tw Cen MT Condensed Extra Bold", 0, 36)); // NOI18N
        jLabel1.setText("Registro");

        jLabel2.setFont(new java.awt.Font("Tw Cen MT Condensed Extra Bold", 0, 16)); // NOI18N
        jLabel2.setText("Nombre");

        jLabel6.setFont(new java.awt.Font("Tw Cen MT Condensed Extra Bold", 0, 16)); // NOI18N
        jLabel6.setText("Password");

        jbtnRegistrar.setBackground(new java.awt.Color(92, 130, 242));
        jbtnRegistrar.setFont(new java.awt.Font("Tw Cen MT Condensed Extra Bold", 0, 14)); // NOI18N
        jbtnRegistrar.setIcon(new javax.swing.ImageIcon(getClass().getResource("/Imagenes/registrado.png"))); // NOI18N
        jbtnRegistrar.setText("Registrar");
        jbtnRegistrar.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jbtnRegistrarActionPerformed(evt);
            }
        });

        jButton2.setBackground(new java.awt.Color(242, 105, 92));
        jButton2.setFont(new java.awt.Font("Tw Cen MT Condensed Extra Bold", 0, 14)); // NOI18N
        jButton2.setIcon(new javax.swing.ImageIcon(getClass().getResource("/Imagenes/cancelar.png"))); // NOI18N
        jButton2.setText("Cancelar");
        jButton2.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jButton2ActionPerformed(evt);
            }
        });

        jLabel7.setFont(new java.awt.Font("Tw Cen MT Condensed Extra Bold", 0, 16)); // NOI18N
        jLabel7.setText("Password");

        jLabel5.setFont(new java.awt.Font("Tw Cen MT Condensed Extra Bold", 0, 16)); // NOI18N
        jLabel5.setText("Email");

        jLabel3.setFont(new java.awt.Font("Tw Cen MT Condensed Extra Bold", 0, 16)); // NOI18N
        jLabel3.setText("Apellido");

        jLabel4.setFont(new java.awt.Font("Tw Cen MT Condensed Extra Bold", 0, 16)); // NOI18N
        jLabel4.setText("Usuario");

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addGap(34, 34, 34)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(layout.createSequentialGroup()
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING)
                            .addGroup(layout.createSequentialGroup()
                                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                                    .addComponent(jLabel6)
                                    .addComponent(jLabel4)
                                    .addComponent(jLabel2))
                                .addGap(18, 18, 18)
                                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                                    .addComponent(jtxtUser, javax.swing.GroupLayout.PREFERRED_SIZE, 103, javax.swing.GroupLayout.PREFERRED_SIZE)
                                    .addComponent(jtxtNombre, javax.swing.GroupLayout.PREFERRED_SIZE, 103, javax.swing.GroupLayout.PREFERRED_SIZE)
                                    .addComponent(jPassword1, javax.swing.GroupLayout.PREFERRED_SIZE, 103, javax.swing.GroupLayout.PREFERRED_SIZE)))
                            .addComponent(jbtnRegistrar))
                        .addGap(39, 39, 39)
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                            .addGroup(layout.createSequentialGroup()
                                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                                    .addComponent(jLabel5)
                                    .addComponent(jLabel3))
                                .addGap(27, 27, 27)
                                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING, false)
                                    .addComponent(jtxtEmail)
                                    .addComponent(jtxtApellido, javax.swing.GroupLayout.PREFERRED_SIZE, 100, javax.swing.GroupLayout.PREFERRED_SIZE)))
                            .addGroup(layout.createSequentialGroup()
                                .addComponent(jLabel7)
                                .addGap(18, 18, 18)
                                .addComponent(jPassword2, javax.swing.GroupLayout.PREFERRED_SIZE, 100, javax.swing.GroupLayout.PREFERRED_SIZE))
                            .addComponent(jButton2)))
                    .addGroup(layout.createSequentialGroup()
                        .addGap(138, 138, 138)
                        .addComponent(jLabel1)))
                .addContainerGap(34, Short.MAX_VALUE))
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addContainerGap(javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                .addComponent(jLabel1)
                .addGap(18, 18, 18)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(layout.createSequentialGroup()
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                            .addComponent(jLabel2)
                            .addComponent(jtxtNombre, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                        .addGap(18, 18, 18)
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                            .addComponent(jLabel4)
                            .addComponent(jtxtUser, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                        .addGap(18, 18, 18)
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                            .addComponent(jLabel6)
                            .addComponent(jPassword1, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)))
                    .addGroup(layout.createSequentialGroup()
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                            .addComponent(jLabel3)
                            .addComponent(jtxtApellido, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                        .addGap(18, 18, 18)
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                            .addComponent(jLabel5)
                            .addComponent(jtxtEmail, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                        .addGap(18, 18, 18)
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                            .addComponent(jLabel7)
                            .addComponent(jPassword2, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))))
                .addGap(18, 18, 18)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(jButton2)
                    .addComponent(jbtnRegistrar))
                .addContainerGap())
        );

        pack();
        setLocationRelativeTo(null);
    }// </editor-fold>//GEN-END:initComponents

    private void jbtnRegistrarActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jbtnRegistrarActionPerformed
        postRequests();

//        EmpleadoTI e = new EmpleadoTI(jtxtUser.getText(), jPassword1.getText(), jtxtNombre.getText(), jtxtApellido.getText(), jtxtEmail.getText());
//        String jsonEmpleadoTI = e.toJson();
//        System.out.println("Json generado: " + jsonEmpleadoTI);
    }//GEN-LAST:event_jbtnRegistrarActionPerformed

    private void jButton2ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jButton2ActionPerformed
        cancelar();
    }//GEN-LAST:event_jButton2ActionPerformed

    /**
     * @param args the command line arguments
     */
    private static void testCrearObjetoJson() {
        JsonObjectBuilder builder = Json.createObjectBuilder();
        builder.add("nombre", "Firulais")
                .add("raza", "Golden")
                .add("peso", "31,5");
        JsonObject objJson = builder.build();
        System.out.println("JSON:" + objJson.toString());
    }

    public void postRequests() {
        if (!validarDatos()) {
        } else {

            try {
                URL url = new URL("https://proyecto-final-ps.herokuapp.com/api/EmpleadoTI");
                HttpURLConnection conexion = (HttpURLConnection) url.openConnection();
                conexion.setRequestMethod("POST");

                EmpleadoTI e = new EmpleadoTI(jtxtUser.getText(), jPassword1.getText(), jtxtNombre.getText(), jtxtApellido.getText(), jtxtEmail.getText());
                String jsonEmpleadoTI = e.toJson();

                conexion.setRequestProperty("Content-Type", "application/json");
                conexion.setDoOutput(true);
                OutputStream output = conexion.getOutputStream();
                output.write(jsonEmpleadoTI.getBytes());
                output.flush();
                output.close();
                System.out.println(conexion.getResponseCode());
                System.out.println(conexion.getResponseMessage());
                if (conexion.getResponseCode() == 200) {
                    JOptionPane.showMessageDialog(null, "Bienvenido " + jtxtNombre.getText() + " " + jtxtApellido.getText());
                } else {
                    JOptionPane.showMessageDialog(null, "Servidor no disponible, intente mas tarde");
                }

                Login l = new Login();
                l.setVisible(true);
                this.dispose();

            } catch (MalformedURLException e) {

            } catch (IOException ex) {
                Logger.getLogger(Registro.class.getName()).log(Level.SEVERE, null, ex);
            }
        }
    }

    public boolean validarUser(String user) {
        String url = "https://proyecto-final-ps.herokuapp.com/api/Autenticacion/user/" + user;
        final HttpRequest requestPosts = HttpRequest.newBuilder().GET().uri(URI.create(url)).build();
        final HttpResponse<String> response;
        try {
            response = httpClient.send(requestPosts, HttpResponse.BodyHandlers.ofString());
            if (response.body().equals("")) {
                return false;
            } else {
                return true;
            }
        } catch (IOException | InterruptedException ex) {
            JOptionPane.showMessageDialog(null, "El sistema no responde, intente mas tarde");
            return false;
        }
    }

    public boolean validarEmail(String email) {
        // Patrón para validar el email
        Pattern pattern = Pattern.compile("^[_A-Za-z0-9-\\+]+(\\.[_A-Za-z0-9-]+)*@" + "[A-Za-z0-9-]+(\\.[A-Za-z0-9]+)*(\\.[A-Za-z]{2,})$");

        // El email a validar --> email
        Matcher mather = pattern.matcher(email);

        //true=valido y false=invalido
        return mather.find();
    }

    public static void main(String args[]) {

//        Perros pluto = new Perros("Pl01", "Pluto", 24.5f, new Date());
//        String jsonPerro = pluto.toJson();
//        System.out.println("Json generado: "+jsonPerro);
        /* Set the Nimbus look and feel */
        //<editor-fold defaultstate="collapsed" desc=" Look and feel setting code (optional) ">
        /* If Nimbus (introduced in Java SE 6) is not available, stay with the default look and feel.
         * For details see http://download.oracle.com/javase/tutorial/uiswing/lookandfeel/plaf.html 
         */
        try {
            for (javax.swing.UIManager.LookAndFeelInfo info : javax.swing.UIManager.getInstalledLookAndFeels()) {
                if ("Nimbus".equals(info.getName())) {
                    javax.swing.UIManager.setLookAndFeel(info.getClassName());
                    break;
                }
            }
        } catch (ClassNotFoundException ex) {
            java.util.logging.Logger.getLogger(Registro.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (InstantiationException ex) {
            java.util.logging.Logger.getLogger(Registro.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (IllegalAccessException ex) {
            java.util.logging.Logger.getLogger(Registro.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (javax.swing.UnsupportedLookAndFeelException ex) {
            java.util.logging.Logger.getLogger(Registro.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        }
        //</editor-fold>

        /* Create and display the form */
        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                new Registro().setVisible(true);
            }
        });
    }

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton jButton2;
    private javax.swing.JLabel jLabel1;
    private javax.swing.JLabel jLabel2;
    private javax.swing.JLabel jLabel3;
    private javax.swing.JLabel jLabel4;
    private javax.swing.JLabel jLabel5;
    private javax.swing.JLabel jLabel6;
    private javax.swing.JLabel jLabel7;
    private javax.swing.JPasswordField jPassword1;
    private javax.swing.JPasswordField jPassword2;
    private javax.swing.JButton jbtnRegistrar;
    private javax.swing.JTextField jtxtApellido;
    private javax.swing.JTextField jtxtEmail;
    private javax.swing.JTextField jtxtNombre;
    private javax.swing.JTextField jtxtUser;
    // End of variables declaration//GEN-END:variables

    private void cancelar() {
        Login l = new Login();
        if (JOptionPane.showConfirmDialog(l, "¿Estás seguro que deseas cancelar?", "Cancelar", JOptionPane.WARNING_MESSAGE, JOptionPane.YES_NO_OPTION) == JOptionPane.YES_OPTION) {
            this.dispose();
            l.setVisible(true);
        }
    }

    private boolean validarDatos() {
        if (jtxtNombre.getText().isEmpty() || " ".equals(jtxtNombre.getText())) {
            JOptionPane.showMessageDialog(this, "Debe ingresar un Nombre");
            jtxtNombre.requestFocus();
            return false;
        } else if (jtxtApellido.getText().isEmpty() || " ".equals(jtxtApellido.getText())) {
            JOptionPane.showMessageDialog(this, "Debe ingresar un Apellido");
            jtxtApellido.requestFocus();
            return false;
        } else if (jtxtUser.getText().isEmpty() || " ".equals(jtxtUser.getText())) {
            JOptionPane.showMessageDialog(this, "Debe ingresar un Usuario");
            jtxtUser.requestFocus();
            return false;
        } else if (validarUser(jtxtUser.getText())) {
            JOptionPane.showMessageDialog(this, "El usuario ya existe");
            jtxtUser.requestFocus();
            return false;
        } else if (jtxtEmail.getText().isEmpty() || " ".equals(jtxtEmail.getText())) {
            JOptionPane.showMessageDialog(this, "Debe ingresar un Email");
            jtxtEmail.requestFocus();
            return false;
        } else if (validarEmail(jtxtEmail.getText()) == false) {
            JOptionPane.showMessageDialog(this, "Debe ingresar un Email valido");
            jtxtEmail.requestFocus();
            return false;
        } else if (jPassword1.getText().isEmpty() || " ".equals(jPassword1.getText())) {
            JOptionPane.showMessageDialog(this, "Debe ingresar una Contraseña");
            jPassword1.requestFocus();
            return false;
        } else if (!jPassword1.getText().equals(jPassword2.getText())) {
            JOptionPane.showMessageDialog(this, "Las contraseñas no coinciden");
            jPassword1.requestFocus();
            return false;
        } else {
            return true;
        }
    }
}
