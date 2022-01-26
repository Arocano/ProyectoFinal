package com.example.appmovil.model;

public class Registro {
    private int idRegistro;
    private String estado;
    private String fecha;
    private String horas;
    private Actividad actividad;
    private EmpleadoTI empleadoTI;
    private Empleado empleado;
    private String observaciones;

    public Registro(int idRegistro, String estado, String fecha, String horas, Actividad actividad, EmpleadoTI empleadoTI, Empleado empleado,
                    String observaciones) {
        this.idRegistro = idRegistro;
        this.estado = estado;
        this.fecha = fecha;
        this.horas = horas;
        this.actividad = actividad;
        this.empleadoTI = empleadoTI;
        this.empleado = empleado;
        this.observaciones = observaciones;
    }

    public Registro() {
    }


    public int getIdRegistro() {
        return idRegistro;
    }

    public void setIdRegistro(int idRegistro) {
        this.idRegistro = idRegistro;
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

    public Actividad getActividad() {
        return actividad;
    }

    public void setActividad(Actividad actividad) {
        this.actividad = actividad;
    }

    public EmpleadoTI getEmpleadoTI() {
        return empleadoTI;
    }

    public void setEmpleadoTI(EmpleadoTI empleadoTI) {
        this.empleadoTI = empleadoTI;
    }

    public Empleado getEmpleado() {
        return empleado;
    }

    public void setEmpleado(Empleado empleado) {
        this.empleado = empleado;
    }

    public String getObservaciones() {
        return observaciones;
    }

    public void setObservaciones(String observaciones) {
        this.observaciones = observaciones;
    }

    @Override
    public String toString() {
        return "Registro{" +
                "estado='" + estado +
                ",fecha='" + fecha +
                ",horas=" + horas +
                ",actividad=" + actividad +
                ",empleadoTI=" + empleadoTI +
                ",empleado=" + empleado +
                ",observaciones=" + observaciones +
                '}';
    }

}