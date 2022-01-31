/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.mycompany.proyectofinal.forms;

import java.io.Serializable;

/**
 * "user": "string", "contrasenia": "string", "nombre": "string", "apellido":
 * "string", "tipoUsuario": "string", "correo": "string"
 *
 * @author josel
 */
public class Post implements Serializable {

    private String user;
    private String contrasenia;
    private String nombre;
    private String apellido;
//    private String tipoUsuario;
//    private String correo;

    public String getUser() {
        return user;
    }

    public void setUser(String user) {
        this.user = user;
    }

    public String getContrasenia() {
        return contrasenia;
    }

    public void setContrasenia(String contrasenia) {
        this.contrasenia = contrasenia;
    }

    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public String getApellido() {
        return apellido;
    }

    public void setApellido(String apellido) {
        this.apellido = apellido;
    }

//    public String getTipoUsuario() {
//        return tipoUsuario;
//    }
//
//    public void setTipoUsuario(String tipoUsuario) {
//        this.tipoUsuario = tipoUsuario;
//    }
//
//    public String getCorreo() {
//        return correo;
//    }
//
//    public void setCorreo(String correo) {
//        this.correo = correo;
//    }
}
