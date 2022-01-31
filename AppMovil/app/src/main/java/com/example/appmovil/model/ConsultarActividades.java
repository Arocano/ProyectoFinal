package com.example.appmovil.model;

import androidx.appcompat.app.AlertDialog;
import androidx.appcompat.app.AppCompatActivity;

import android.app.DatePickerDialog;
import android.content.DialogInterface;
import android.os.Bundle;
import android.view.LayoutInflater;
import android.view.View;
import android.widget.Button;
import android.widget.DatePicker;
import android.widget.EditText;
import android.widget.ImageButton;
import android.widget.TableLayout;
import android.widget.TextView;
import android.widget.Toast;

import com.example.appmovil.Login;
import com.example.appmovil.R;
import com.example.appmovil.io.AppApiAdapter;

import java.util.ArrayList;
import java.util.Calendar;
import java.util.List;

import retrofit2.Call;
import retrofit2.Callback;
import retrofit2.Response;

public class ConsultarActividades extends AppCompatActivity {
    TableLayout tabla;
    EditText txtinicio;
    EditText txtxfinal;
    ImageButton btn1;
    ImageButton btn2;
    Button btnBuscar;
    String user;





    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_consultar_actividades);
        txtinicio=findViewById(R.id.txtIncio);
        txtxfinal=findViewById(R.id.txtFinal);
        txtinicio.setEnabled(false);
        txtxfinal.setEnabled(false);
        user= getIntent().getStringExtra("userConsultar");
        btn1 = findViewById(R.id.btn1);
        btn1.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                calendario1();
            }
        });

        btn2 = findViewById(R.id.btn2);
        btn2.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                calendario2();
            }
        });
        tabla=findViewById(R.id.tabla);
        btnBuscar=findViewById(R.id.btnBuscar);
        btnBuscar.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                     llenar();
            }
        });





    }


    public void llenar(){
        if(txtinicio.getText().toString().equals("") ||txtxfinal.getText().toString().equals("")){
            alertaVacio();
        }else{
            LoadingDialog loadingDialog = new LoadingDialog(ConsultarActividades.this);
            loadingDialog.iniciarDialogo();
            Call <List <RegistroV4> > call = AppApiAdapter.getApiService().getPorFecha(user,txtinicio.getText().toString(),txtxfinal.getText().toString());
            call.enqueue(new Callback<List<RegistroV4>>() {
                @Override
                public void onResponse(Call<List<RegistroV4>> call, Response<List<RegistroV4>> response) {
                    tabla.removeAllViews();

                    View registrot= LayoutInflater.from(ConsultarActividades.this).inflate(R.layout.table_row_registro, null, false);
                    TextView estadot= ((TextView) registrot.findViewById(R.id.txtEstado));
                    TextView fechat= ((TextView) registrot.findViewById(R.id.txtFecha));
                    TextView actividadt= ((TextView) registrot.findViewById(R.id.txtActividad));
                    TextView empt= ((TextView) registrot.findViewById(R.id.txtEmp));
                    estadot.setText("Estado");
                    fechat.setText("Fecha");
                    actividadt.setText("Actividad");
                    empt.setText("Solicitante");
                    tabla.addView(registrot);
                    for(RegistroV4 r:response.body()){
                        View registro= LayoutInflater.from(ConsultarActividades.this).inflate(R.layout.table_row_registro, null, false);
                        TextView estado= ((TextView) registro.findViewById(R.id.txtEstado));
                        TextView fecha= ((TextView) registro.findViewById(R.id.txtFecha));
                        TextView actividad= ((TextView) registro.findViewById(R.id.txtActividad));
                        TextView emp= ((TextView) registro.findViewById(R.id.txtEmp));
                        estado.setText(r.getEstado().toString());
                        String auxFe[]=r.getFecha().split(" ");
                        fecha.setText(auxFe[0].toString());
                        actividad.setText(r.getActividad());
                        emp.setText(r.getEmpleado());
                        tabla.addView(registro);
                    }
                    loadingDialog.cancelarDialogo();
                }

                @Override
                public void onFailure(Call<List<RegistroV4>> call, Throwable t) {
                    fallo();
                    loadingDialog.cancelarDialogo();
                }
            });
        }

    }

    public void calendario1() {
        Calendar cal = Calendar.getInstance();
        int anio = cal.get(Calendar.YEAR);
        int mes = cal.get(Calendar.MONTH);
        int dia = cal.get(Calendar.DAY_OF_MONTH);
        DatePickerDialog dpd = new DatePickerDialog(ConsultarActividades.this, new DatePickerDialog.OnDateSetListener() {
            @Override
            public void onDateSet(DatePicker datePicker, int i, int i1, int i2) {
                int aux = i1 + 1;
                String fecha = i + "-" + aux + "-" + i2;
                txtinicio.setText(fecha);
            }
        }, anio, mes, dia);
        dpd.show();
    }
    public void calendario2() {
        Calendar cal = Calendar.getInstance();
        int anio = cal.get(Calendar.YEAR);
        int mes = cal.get(Calendar.MONTH);
        int dia = cal.get(Calendar.DAY_OF_MONTH);
        DatePickerDialog dpd = new DatePickerDialog(ConsultarActividades.this, new DatePickerDialog.OnDateSetListener() {
            @Override
            public void onDateSet(DatePicker datePicker, int i, int i1, int i2) {
                int aux = i1 + 1;
                String fecha = i + "-" + aux + "-" + i2;
                txtxfinal.setText(fecha);
            }
        }, anio, mes, dia);
        dpd.show();
    }

    public void alertaVacio(){
        AlertDialog.Builder builder=new AlertDialog.Builder(ConsultarActividades.this);
        builder.setMessage("Debe llenar las fechas")
                .setPositiveButton("Aceptar", new DialogInterface.OnClickListener() {
                    @Override
                    public void onClick(DialogInterface dialog, int wich) {
                        dialog.dismiss();
                    }
                });
        builder.show();
    }

    public void fallo() {
        AlertDialog.Builder builder = new AlertDialog.Builder(ConsultarActividades.this);
        builder.setMessage("No se pudo Registrar")
                .setPositiveButton("Aceptar", new DialogInterface.OnClickListener() {
                    @Override
                    public void onClick(DialogInterface dialog, int wich) {
                        dialog.dismiss();
                    }
                });
        builder.show();


    }
}