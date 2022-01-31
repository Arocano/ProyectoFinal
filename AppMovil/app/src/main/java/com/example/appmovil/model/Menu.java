package com.example.appmovil.model;

import androidx.annotation.ColorInt;
import androidx.appcompat.app.AlertDialog;
import androidx.appcompat.app.AppCompatActivity;

import android.content.DialogInterface;
import android.content.Intent;
import android.graphics.Color;
import android.graphics.drawable.Drawable;
import android.os.Bundle;
import android.view.KeyEvent;
import android.view.View;
import android.widget.Button;
import android.widget.TextView;
import android.widget.Toast;

import com.example.appmovil.Login;
import com.example.appmovil.R;
import com.example.appmovil.io.AppApiAdapter;

import java.util.List;

import retrofit2.Call;
import retrofit2.Callback;
import retrofit2.Response;

public class Menu extends AppCompatActivity {
    Button btnRegistroActividades;
    Button btnCerrar;
    TextView txtBienvenida;
    private String user;
    Button cambioContrasenia;
    Button consultarActividades;

    private String[] empleado;
    @Override
    protected void onCreate(Bundle savedInstanceState) {

        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_menu);
        txtBienvenida=findViewById(R.id.txtBienvenida);

        user = getIntent().getStringExtra("user");
        empleado=getIntent().getStringArrayExtra("Empleado");
        txtBienvenida.setText("BIENVENIDO "+user.toUpperCase());
        btnRegistroActividades=findViewById(R.id.btnRegistroActividades);

        btnRegistroActividades.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent i = new Intent(Menu.this, RegistroReporte.class) ;
                i.putExtra("user", user);
                startActivity(i);
            }
        });
        btnCerrar=findViewById(R.id.btnCerrar);
        btnCerrar.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                cerrarSesion();
            }
        });
        cambioContrasenia=findViewById(R.id.btnCambioContraseña);
        cambioContrasenia.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                cambioContrasenia.setEnabled(false);
                Intent i = new Intent(Menu.this,CambioContrasenia.class);
                i.putExtra("usuarioMenu",empleado);
                startActivity(i);
            }
        });
        consultarActividades=findViewById(R.id.btnConsultarActividades);
        consultarActividades.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent i = new Intent(Menu.this,ConsultarActividades.class) ;
                i.putExtra("userConsultar",user );
                startActivity(i);
            }
        });
    }
    @Override
    public boolean onKeyDown(int keyCode, KeyEvent event) {
        if (keyCode==event.KEYCODE_BACK){
           cerrarSesion();
        }
        return super.onKeyDown(keyCode, event);
    }
    public void cerrarSesion(){
        AlertDialog.Builder builder=new AlertDialog.Builder(Menu.this);
        builder.setMessage("¿Cerrar Sesión?")
                .setPositiveButton("Si", new DialogInterface.OnClickListener() {
                    @Override
                    public void onClick(DialogInterface dialog, int wich) {
                        Intent i = new Intent(Menu.this, Login.class) ;
                        startActivity(i);
                    }
                })
                .setNegativeButton("Cancelar", new DialogInterface.OnClickListener() {
                    @Override
                    public void onClick(DialogInterface dialog, int wich) {
                        dialog.dismiss();
                    }
                });
        builder.show();
    }


}