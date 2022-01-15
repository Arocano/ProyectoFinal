package com.example.appmovil.model;

public class EmpleadoTI extends Usuario{

    public EmpleadoTI(String user, String contra, String nombre, String apellido, String correo) {
        super(user, contra, nombre, apellido, correo);
        this.setTipoUsuario("EmpleadoTI");
    }


    public EmpleadoTI()
    {

    }

    public boolean RegistrarActividad(Actividad a)
    {
        return false;
    }
}
