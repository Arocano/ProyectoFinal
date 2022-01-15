package com.example.appmovil.model;

public class Usuario {
    private String user;
    private String contrasenia;
    private String nombre;
    private String apellido;
    private String correo;
    private String tipoUsuario;

    public Usuario(String user, String contra, String nombre, String apellido, String correo,String tipoUsuario)
    {
        this.user = user;
        this.contrasenia = contra;
        this.nombre = nombre;
        this.apellido = apellido;
        this.correo = correo;
        this.tipoUsuario=tipoUsuario;
    }
    public Usuario(String user, String contra, String nombre, String apellido, String correo)
    {
        this.user = user;
        this.contrasenia = contra;
        this.nombre = nombre;
        this.apellido = apellido;
        this.correo = correo;

    }

    public Usuario()
    {
    }

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

    public String getCorreo() {
        return correo;
    }

    public void setCorreo(String correo) {
        this.correo = correo;
    }

    public String getTipoUsuario() {
        return tipoUsuario;
    }

    public void setTipoUsuario(String tipoUsuario) {
        this.tipoUsuario = tipoUsuario;
    }
}
