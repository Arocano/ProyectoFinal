package com.example.appmovil.io.response;

import com.example.appmovil.model.EmpleadoTI;
import com.example.appmovil.model.TipoDeActividad;

import java.util.List;

public class ResponseEmpleadoTI {
    public List<com.example.appmovil.model.EmpleadoTI> getEmpleadoTI() {
        return EmpleadoTI;
    }

    public void setEmpleadoTI(List<com.example.appmovil.model.EmpleadoTI> empleadoTI) {
        EmpleadoTI = empleadoTI;
    }

    List<EmpleadoTI> EmpleadoTI;
    boolean error;




    public boolean isError() {
        return error;
    }

    public void setError(boolean error) {
        this.error = error;
    }
}
