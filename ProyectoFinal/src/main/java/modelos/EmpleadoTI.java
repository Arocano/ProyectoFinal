/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package modelos;

import java.io.Serializable;
import javax.json.Json;
import javax.json.JsonObject;
import javax.json.JsonObjectBuilder;

/**
 *
 * @author josel
 */
public class EmpleadoTI extends Usuario implements Serializable {

    String TipoUsuario;

    public EmpleadoTI() {
    }

    public EmpleadoTI(String user, String contrasenia, String nombre, String apellido, String correo) {
        super(user, contrasenia, nombre, apellido, correo);
        this.TipoUsuario = "EmpleadoTI";
    }

    @Override
    public String toString() {
        return "EmpleadoTI{" + "TipoUsuario=" + TipoUsuario + '}';
    }

    public String toJson() {

        JsonObjectBuilder buiderEmpleadoTI = Json.createObjectBuilder();
        buiderEmpleadoTI.add("user", user)
                .add("contrasenia", contrasenia)
                .add("nombre", nombre)
                .add("apellido", apellido)
                .add("tipoUsuario", TipoUsuario)
                .add("correo", correo);
        JsonObject perroJson = buiderEmpleadoTI.build();

        return perroJson.toString();
    }

}
