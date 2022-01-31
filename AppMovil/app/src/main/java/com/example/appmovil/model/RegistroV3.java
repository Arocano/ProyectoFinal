package com.example.appmovil.model;

import com.google.gson.annotations.SerializedName;

public class RegistroV3 {
    private Integer id;
    private String estado;
    private String fecha;
    private String horas;
    private int actividad;
    private String usuario;
    private  int empleado;
    private String observaciones;

    public RegistroV3(String estado, String fecha, String horas, int actividad, String usuario, int empleado, String observaciones) {
        this.estado = estado;
        this.fecha = fecha;
        this.horas = horas;
        this.actividad = actividad;
        this.usuario = usuario;
        this.empleado = empleado;
        this.observaciones = observaciones;
    }

    public RegistroV3(){

    }

    public String getEstado() {
        return estado;
    }

    public void setEstado(String estado) {
        this.estado = estado;
    }

    public String getFecha() {
        return fecha;
    }

    public void setFecha(String fecha) {
        this.fecha = fecha;
    }

    public String getHoras() {
        return horas;
    }

    public void setHoras(String horas) {
        this.horas = horas;
    }

    public int getActividad() {
        return actividad;
    }

    public void setActividad(int actividad) {
        this.actividad = actividad;
    }

    public String getUsuario() {
        return usuario;
    }

    public void setUsuario(String usuario) {
        this.usuario = usuario;
    }

    public int getEmpleado() {
        return empleado;
    }

    public void setEmpleado(int empleado) {
        this.empleado = empleado;
    }

    public String getObservaciones() {
        return observaciones;
    }

    public void setObservaciones(String observaciones) {
        this.observaciones = observaciones;
    }
}
