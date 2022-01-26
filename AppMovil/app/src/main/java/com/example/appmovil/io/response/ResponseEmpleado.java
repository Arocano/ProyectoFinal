package com.example.appmovil.io.response;

import com.example.appmovil.model.Empleado;
import com.example.appmovil.model.EmpleadoTI;

import java.util.List;

public class ResponseEmpleado {
    public List<Empleado> getEmpleado() {
        return Empleado;
    }

    public void setEmpleado(List<Empleado> empleado) {
        Empleado = empleado;
    }

    List<Empleado> Empleado;
    boolean error;




    public boolean isError() {
        return error;
    }

    public void setError(boolean error) {
        this.error = error;
    }
}
