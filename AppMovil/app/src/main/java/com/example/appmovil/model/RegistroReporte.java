package com.example.appmovil.model;

import androidx.appcompat.app.AlertDialog;
import androidx.appcompat.app.AppCompatActivity;

import android.app.DatePickerDialog;
import android.content.DialogInterface;
import android.content.Intent;
import android.graphics.Color;
import android.os.Bundle;
import android.view.KeyEvent;
import android.view.View;
import android.widget.AdapterView;
import android.widget.ArrayAdapter;
import android.widget.Button;
import android.widget.DatePicker;
import android.widget.EditText;
import android.widget.ImageButton;
import android.widget.Spinner;
import android.widget.Toast;

import com.example.appmovil.Login;
import com.example.appmovil.R;
import com.example.appmovil.io.AppApiAdapter;
import com.example.appmovil.io.response.ResponseTipoDeActividad;

import java.util.ArrayList;
import java.util.Calendar;
import java.util.List;

import retrofit2.Call;
import retrofit2.Callback;
import retrofit2.Response;
import retrofit2.Retrofit;

public class RegistroReporte extends AppCompatActivity implements AdapterView.OnItemSelectedListener {
    ArrayList<TipoDeActividad> tipoDeActividad = new ArrayList<TipoDeActividad>();
    ArrayList<Actividad> actividad = new ArrayList<Actividad>();
    Spinner spinnertipoActividad;
    Spinner spinnerActividad;
    String tipoActividad;
    String empleadoRegistra;
    String actividadRegistra;
    String user;
    Spinner spinnerEstado;
    Spinner spinnerHoras;
    Spinner spinnerPersonaSolicita;
    EditText txtpersonaQueRegistra;
    EditText txtfecha;
    ImageButton btnFecha;
    Button btnCancelar;
    Button btnRegistar;
    EditText txtObs;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_registro_reporte);
        spinnertipoActividad = findViewById(R.id.spnTipoActividad);
        spinnerActividad = findViewById(R.id.spnActividad);
        spinnerEstado = findViewById(R.id.spnEstado);
        spinnerHoras = findViewById(R.id.spnHoras);
        txtObs = findViewById(R.id.txtObs);
        spinnerPersonaSolicita = findViewById(R.id.spnPersonaSolicita);
        user = getIntent().getStringExtra("user");
        txtpersonaQueRegistra = findViewById(R.id.txtPersonaRegistra);
        txtpersonaQueRegistra.setEnabled(false);
        txtpersonaQueRegistra.setText(user);
        llenarPersonaSolicita();
        llenarEstado();
        llenarHoras();
        getTipoActividad();
        spinnertipoActividad.setOnItemSelectedListener(this);
        txtfecha = findViewById(R.id.txtFecha);
        txtfecha.setEnabled(false);
        btnFecha = findViewById(R.id.btnCalendario);
        btnFecha.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                calendario();
            }
        });
        btnCancelar = findViewById(R.id.btnCancelar);
        btnCancelar.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                cancelar();
            }
        });
        btnRegistar = findViewById(R.id.btnRegistar);
        btnRegistar.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                      registro();
            }
        });
    }

    public void calendario() {
        Calendar cal = Calendar.getInstance();
        int anio = cal.get(Calendar.YEAR);
        int mes = cal.get(Calendar.MONTH);
        int dia = cal.get(Calendar.DAY_OF_MONTH);
        DatePickerDialog dpd = new DatePickerDialog(RegistroReporte.this, new DatePickerDialog.OnDateSetListener() {
            @Override
            public void onDateSet(DatePicker datePicker, int i, int i1, int i2) {
                int aux = i1 + 1;
                String fecha = i + "-" + aux + "-" + i2;
                txtfecha.setText(fecha);
            }
        }, anio, mes, dia);
        dpd.show();
    }

    public void getTipoActividad() {
        tipoDeActividad.clear();
        tipoDeActividad.add(new TipoDeActividad(1, "Configuración", "Configuración"));
        tipoDeActividad.add(new TipoDeActividad(2, "Soporte TI", "Soporte TI"));
        ArrayList<String> list = new ArrayList<String>();
        for (TipoDeActividad t : tipoDeActividad) {
            String aux = t.getIdTipo() + "." + t.getNombre();
            list.add(aux);
        }
        ArrayAdapter<String> spinnerArrayAdapter = new ArrayAdapter<String>(RegistroReporte.this, android.R.layout.simple_spinner_item
                , list);
        spinnerArrayAdapter.setDropDownViewResource(android.R.layout.simple_spinner_dropdown_item);
        spinnertipoActividad.setAdapter(spinnerArrayAdapter);
    }

    @Override
    public void onItemSelected(AdapterView<?> a, View v, int p, long l) {
        switch (a.getId()) {
            case R.id.spnTipoActividad:
                getActivdad();
                break;
        }
    }

    @Override
    public void onNothingSelected(AdapterView<?> adapterView) {

    }

    public void llenarEstado() {
        ArrayList<String> estados = new ArrayList<String>();
        estados.add("No iniciada");
        estados.add("Iniciada");
        estados.add("Terminada");
        ArrayAdapter<String> spinnerArrayAdapter = new ArrayAdapter<String>(RegistroReporte.this, android.R.layout.simple_spinner_item
                , estados);
        spinnerArrayAdapter.setDropDownViewResource(android.R.layout.simple_spinner_dropdown_item);
        spinnerEstado.setAdapter(spinnerArrayAdapter);
    }

    public void llenarHoras() {
        ArrayList<String> horas = new ArrayList<String>();
        horas.add("1");
        horas.add("2");
        horas.add("3");
        horas.add("4");
        horas.add("5");
        horas.add("6");
        horas.add("7");
        horas.add("8");
        ArrayAdapter<String> spinnerArrayAdapter = new ArrayAdapter<String>(RegistroReporte.this, android.R.layout.simple_spinner_item
                , horas);
        spinnerArrayAdapter.setDropDownViewResource(android.R.layout.simple_spinner_dropdown_item);
        spinnerHoras.setAdapter(spinnerArrayAdapter);
    }

    public void llenarPersonaSolicita() {
        Call<List<Empleado>> call = AppApiAdapter.getApiService().getEmpleado();
        call.enqueue(new Callback<List<Empleado>>() {
            @Override
            public void onResponse(Call<List<Empleado>> call, Response<List<Empleado>> response) {
                ArrayList<String> solicita = new ArrayList<String>();
                for (Empleado s : response.body()) {

                    String e = s.getIdEmpleado() + "." + s.getNombre() + " " + s.getApellido();

                    solicita.add(e);
                }
                ArrayAdapter<String> spinnerArrayAdapter = new ArrayAdapter<String>(RegistroReporte.this, android.R.layout.simple_spinner_item
                        , solicita);
                spinnerArrayAdapter.setDropDownViewResource(android.R.layout.simple_spinner_dropdown_item);
                spinnerPersonaSolicita.setAdapter(spinnerArrayAdapter);

            }

            @Override
            public void onFailure(Call<List<Empleado>> call, Throwable t) {

            }
        });
    }

    public void getActivdad() {
        tipoActividad = spinnertipoActividad.getSelectedItem().toString();
        actividad.clear();
        actividad.add(new Actividad(1, "Teléfono IP", "Teléfono IP", 1));
        actividad.add(new Actividad(2, "Servidor BD", "Servidor BD", 1));
        actividad.add(new Actividad(3, "Servidor correo", "Servidor correo", 1));
        actividad.add(new Actividad(4, "PC", "PC", 1));
        actividad.add(new Actividad(5, "Tablet", "Tablet", 1));
        actividad.add(new Actividad(6, "Ventas", "Ventas", 2));
        actividad.add(new Actividad(7, "Compras", "Compras", 2));
        actividad.add(new Actividad(8, "Facturación", "Facturación", 2));
        actividad.add(new Actividad(9, "Nómina", "Nómina", 2));
        actividad.add(new Actividad(10, "Inventarios", "Inventarios", 2));
        String[] parts = tipoActividad.toString().split("[.]");
        int z = Integer.valueOf(parts[0]);


        ArrayList<String> list = new ArrayList<String>();
        for (Actividad a : actividad) {
            if (a.getTipo() == z) {
                String actividad = a.getIdActividad() + "." + a.getNombre();
                list.add(actividad);
            }

        }
        ArrayAdapter<String> spinnerArrayAdapter = new ArrayAdapter<String>(RegistroReporte.this, android.R.layout.simple_spinner_dropdown_item
                , list);
        spinnerArrayAdapter.setDropDownViewResource(android.R.layout.simple_spinner_dropdown_item);
        spinnerActividad.setAdapter(spinnerArrayAdapter);


    }

    @Override
    public boolean onKeyDown(int keyCode, KeyEvent event) {
        if (keyCode == event.KEYCODE_BACK) {
            cancelar();
        }
        return super.onKeyDown(keyCode, event);
    }

    public void cancelar() {
        AlertDialog.Builder builder = new AlertDialog.Builder(RegistroReporte.this);
        builder.setMessage("Los cambios que no se registren no se guardaran " +
                " ¿Desea Cancelar?")
                .setPositiveButton("Si", new DialogInterface.OnClickListener() {
                    @Override
                    public void onClick(DialogInterface dialog, int wich) {
                        RegistroReporte.this.finish();
                    }
                })
                .setNegativeButton("No", new DialogInterface.OnClickListener() {
                    @Override
                    public void onClick(DialogInterface dialog, int wich) {
                        dialog.dismiss();
                    }
                });
        builder.show();
    }


    public void registro() {
        if(txtfecha.getText().toString().equals("")){
            alertaVacio();
        }else {


            AlertDialog.Builder builder = new AlertDialog.Builder(RegistroReporte.this);
            builder.setMessage("¿Esta seguro que quieres registrar este Reporte?")
                    .setPositiveButton("Si", new DialogInterface.OnClickListener() {
                        @Override
                        public void onClick(DialogInterface dialog, int wich) {
                            actividadRegistra = spinnerActividad.getSelectedItem().toString();
                            empleadoRegistra=spinnerPersonaSolicita.getSelectedItem().toString();
                            LoadingDialog loadingDialog = new LoadingDialog(RegistroReporte.this);
                            String estado = spinnerEstado.getSelectedItem().toString();
                            String fecha = txtfecha.getText().toString();
                            String horas = spinnerHoras.getSelectedItem().toString();
                            String[] partsActividad = actividadRegistra.toString().split("[.]");
                            int actividad=Integer.valueOf(partsActividad[0]);
                            String usuario = txtpersonaQueRegistra.getText().toString();

                            String[] partsEmpleado = empleadoRegistra.toString().split("[.]");
                            int empleado= Integer.valueOf(partsEmpleado[0]);
                            String observaciones;
                            if (txtObs.getText().toString().equals("")) {
                                observaciones = "Ninguna";
                            } else {
                                observaciones = txtObs.getText().toString();
                            }
                            loadingDialog.iniciarDialogo();
                            RegistroV3 registroV3=new RegistroV3(estado,fecha,horas,actividad,usuario,empleado,observaciones);
                            Call<Boolean> call = AppApiAdapter.getApiService().registrar(registroV3);
                            call.enqueue(new Callback<Boolean>() {
                                @Override
                                public void onResponse(Call<Boolean> call, Response<Boolean> response) {
                                    Boolean si=true;
                                    if(si=response.body()){

                                        loadingDialog.cancelarDialogo();
                                        exito();

                                    }else{
                                        fallo();
                                        loadingDialog.cancelarDialogo();
                                    }
                                }

                                @Override
                                public void onFailure(Call<Boolean> call, Throwable t) {

                                }
                            });
                        }
                    })
                    .setNegativeButton("No", new DialogInterface.OnClickListener() {
                        @Override
                        public void onClick(DialogInterface dialog, int wich) {
                            dialog.dismiss();
                        }
                    });
            builder.show();
        }
    }

    public void exito() {
        AlertDialog.Builder builder = new AlertDialog.Builder(RegistroReporte.this);
        builder.setMessage("Registrado con exito")
                .setPositiveButton("Aceptar", new DialogInterface.OnClickListener() {
                    @Override
                    public void onClick(DialogInterface dialog, int wich) {
                        dialog.dismiss();
                    }
                });
        builder.show();
    }

    public void fallo() {
        AlertDialog.Builder builder = new AlertDialog.Builder(RegistroReporte.this);
        builder.setMessage("No se pudo Registrar")
                .setPositiveButton("Aceptar", new DialogInterface.OnClickListener() {
                    @Override
                    public void onClick(DialogInterface dialog, int wich) {
                        dialog.dismiss();
                    }
                });
        builder.show();


    }
    public void alertaVacio(){
        AlertDialog.Builder builder=new AlertDialog.Builder(RegistroReporte.this);
        builder.setMessage("Debe llenar la fecha")
                .setPositiveButton("Aceptar", new DialogInterface.OnClickListener() {
                    @Override
                    public void onClick(DialogInterface dialog, int wich) {
                        dialog.dismiss();
                    }
                });
        builder.show();
    }
}