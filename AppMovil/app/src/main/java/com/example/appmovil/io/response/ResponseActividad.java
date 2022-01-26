package com.example.appmovil.io.response;



import com.example.appmovil.model.Actividad;

import java.util.List;

public class ResponseActividad {
    List<Actividad> Actividad;
    boolean error;
    public List<Actividad> getActividad() {
        return Actividad;
    }

    public void setTipoDeActividad(List<Actividad> Actividad) {
        this.Actividad = Actividad;
    }



    public boolean isError() {
        return error;
    }

    public void setError(boolean error) {
        this.error = error;
    }
}
