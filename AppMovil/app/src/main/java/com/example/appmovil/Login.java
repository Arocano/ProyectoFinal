package com.example.appmovil;



import androidx.annotation.ColorLong;
import androidx.appcompat.app.AlertDialog;
import androidx.appcompat.app.AppCompatActivity;

import android.content.DialogInterface;
import android.content.Intent;
import android.graphics.Color;
import android.os.Bundle;
import android.util.Log;
import android.view.KeyEvent;
import android.view.View;
import android.widget.ArrayAdapter;
import android.widget.Button;
import android.widget.EditText;
import android.widget.TextView;
import android.widget.Toast;

import com.android.volley.Request;
import com.android.volley.VolleyError;
import com.android.volley.toolbox.StringRequest;
import com.android.volley.toolbox.Volley;
import com.example.appmovil.io.AppApiAdapter;
import com.example.appmovil.io.AppApiService;
import com.example.appmovil.model.EmpleadoTI;
import com.example.appmovil.model.Menu;
import com.example.appmovil.model.RegistroReporte;
import com.example.appmovil.model.TipoDeActividad;

import org.json.JSONException;
import org.json.JSONObject;

import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import java.util.Map;

import retrofit2.Call;
import retrofit2.Callback;
import retrofit2.Response;

public class Login extends AppCompatActivity {
    EditText txtusuario,txtpass;
    Button btnenviar;
    TextView txtErrorUsuario,txtErrorContra;



    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        txtusuario=findViewById(R.id.txtUsuario);
        txtpass=findViewById(R.id.pwdContraseña);
        txtErrorUsuario=findViewById(R.id.txtErrorUsuario);
        txtErrorContra=findViewById(R.id.txtErroContra);
        btnenviar=findViewById(R.id.login);
        btnenviar.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                inicioSesion();
            }
        });

    }
    @Override
    public boolean onKeyDown(int keyCode, KeyEvent event) {
        if (keyCode==event.KEYCODE_BACK){
            AlertDialog.Builder builder=new AlertDialog.Builder(Login.this);
            builder.setMessage("¿Salir?")
                    .setPositiveButton("Si", new DialogInterface.OnClickListener() {
                        @Override
                        public void onClick(DialogInterface dialog, int wich) {
                            Intent intent=new Intent(Intent.ACTION_MAIN) ;
                            intent.addCategory(Intent.CATEGORY_HOME);
                            intent.setFlags(Intent.FLAG_ACTIVITY_NEW_TASK );
                            startActivity(intent);
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
        return super.onKeyDown(keyCode, event);
    }
    public void inicioSesion(){
        if(txtusuario.getText().toString().equals("")||txtpass.getText().toString().equals("")){
            alertaVacio();
        }
        else {
            txtusuario.setBackgroundResource(R.drawable.borde_negro);
            txtpass.setBackgroundResource(R.drawable.borde_negro);
            txtErrorUsuario.setText("");
            txtErrorContra.setText("");


            Call<List<EmpleadoTI>> call = AppApiAdapter.getApiService().getEmpleadoTI();
            call.enqueue(new Callback<List<EmpleadoTI>>() {
                @Override
                public void onResponse(Call<List<EmpleadoTI>> call, Response<List<EmpleadoTI>> response) {

                    for(EmpleadoTI e :response.body()){
                        if(e.equals(null)){
                            Toast.makeText(Login.this,"Fuera de Servicio1",Toast.LENGTH_SHORT).show();
                        }else{
                            if (e.getUser().toString().equals(txtusuario.getText().toString())) {
                                txtusuario.setBackgroundResource(R.drawable.borde_redondo);
                                txtErrorUsuario.setText("");
                                String user = e.getUser().toString();
                                String contrasenia = e.getContrasenia().toString();
                                if (e.getContrasenia().equals(txtpass.getText().toString())) {
                                    txtpass.setBackgroundResource(R.drawable.borde_redondo);
                                    String[] aux={user,contrasenia};
                                    Intent i = new Intent(Login.this, Menu.class);
                                    i.putExtra("Empleado",aux);
                                    i.putExtra("user", user);
                                    startActivity(i);
                                } else {
                                    txtpass.setFocusable(true);
                                    txtpass.setBackgroundResource(R.drawable.borde_rojo);
                                    txtErrorContra.setText("Contraseña Incorrecta!");
                                }
                                break;

                            } else {
                                txtusuario.setFocusable(true);
                                txtusuario.setBackgroundResource(R.drawable.borde_rojo);
                                txtErrorUsuario.setText("No existe este usuario!");
                            }
                        }

                    }
                }
                @Override
                public void onFailure(Call<List<EmpleadoTI>> call, Throwable t) {
                    AlertDialog.Builder builder=new AlertDialog.Builder(Login.this);
                    builder.setMessage("El servicio no es encuentra disponible en estos momentos vuelva mas tarde")
                            .setPositiveButton("Aceptar", new DialogInterface.OnClickListener() {
                                @Override
                                public void onClick(DialogInterface dialog, int wich) {
                                    dialog.dismiss();
                                }
                            });
                    builder.show();
                }

            });


        }


    }


  public void alertaVacio(){
        AlertDialog.Builder builder=new AlertDialog.Builder(Login.this);
        builder.setMessage("Debe llenar los parametros")
                .setPositiveButton("Aceptar", new DialogInterface.OnClickListener() {
                    @Override
                    public void onClick(DialogInterface dialog, int wich) {
                        dialog.dismiss();
                    }
                });
        builder.show();
    }


}


