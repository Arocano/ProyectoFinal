package com.example.appmovil.model;

public class TipoDeActividad {
    private int idTipo;
    private String nombre;
    private String descripcion;

    public TipoDeActividad(int id, String nombre, String descripcion)
    {
        this.idTipo = id;
        this.nombre = nombre;
        this.descripcion = descripcion;
    }
    public TipoDeActividad(){
        
    }

    public int getIdTipo() {
        return idTipo;
    }

    public void setIdTipo(int idTipo) {
        this.idTipo = idTipo;
    }

    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public String getDescripcion() {
        return descripcion;
    }

    public void setDescripcion(String descripcion) {
        this.descripcion = descripcion;
    }


}
