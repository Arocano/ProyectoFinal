package com.example.appmovil.io.response;

import com.example.appmovil.model.TipoDeActividad;


import java.util.List;

public class ResponseTipoDeActividad {
    List<TipoDeActividad> TipoDeActividad;
    boolean error;
    public List<TipoDeActividad> getTipoDeActividad() {
        return TipoDeActividad;
    }

    public void setTipoDeActividad(List<TipoDeActividad> tipoDeActividad) {
        this.TipoDeActividad = tipoDeActividad;
    }



    public boolean isError() {
        return error;
    }

    public void setError(boolean error) {
        this.error = error;
    }


}
