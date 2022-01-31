package Interfaces;

import java.sql.Connection;
import java.sql.DriverManager;

import javax.swing.JOptionPane;

public class Conexion {

    Connection connect = null;

    public Connection conectar() {
        try {
            Class.forName("org.postgresql.Driver");
            //jdbc:postgresql://ec2-18-234-17-166.compute-1.amazonaws.com:5432/dafglf3dst0epk
            connect = DriverManager.getConnection("jdbc:postgresql://ec2-18-234-17-166.compute-1.amazonaws.com:5432/dafglf3dst0epk", "oneyuguryozvdr", "cad6ada832d6edbdf490aa1b1203a8e68b5ce70756dae237087294dbb161fe9c");

            //JOptionPane.showMessageDialog(null, "¡Felicitaciones!");
        } catch (Exception ex) {
            JOptionPane.showMessageDialog(null, "La base de datos no esta disponible temporalmente");
            System.out.println(ex);
        }
        return connect;
    }
//    public Connection conectar() {
//        try {
//            Class.forName("com.mysql.jdbc.Driver");
//            connect = DriverManager.getConnection("jdbc:mysql://www.db4free.net/pfroctapoje", "andrestgonza", "proyectofinal");
//
//            //JOptionPane.showMessageDialog(null, "¡Felicitaciones!");
//        } catch (Exception ex) {
//            JOptionPane.showMessageDialog(null, "La base de datos no esta disponible temporalmente");
//        }
//        return connect;
//    }
}
