package com.example.appmovil.model;

import androidx.appcompat.app.AlertDialog;
import androidx.appcompat.app.AppCompatActivity;

import android.content.DialogInterface;
import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.TextView;
import android.widget.Toast;

import com.example.appmovil.Login;
import com.example.appmovil.R;
import com.example.appmovil.io.AppApiAdapter;

import java.util.List;

import retrofit2.Call;
import retrofit2.Callback;
import retrofit2.Response;

public class CambioContrasenia extends AppCompatActivity {

EditText txtUser;
Button btnvolver;
EditText txtContraActual;
EditText txtContraNueva;
Button btnCmabiar;
TextView errorACtual;
TextView errorConfirmar;
EditText txtConfirmarContra;
String []empleado;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_cambio_contrasenia);
        empleado=getIntent().getStringArrayExtra("usuarioMenu");
        txtUser=findViewById(R.id.txtUser);
        txtUser.setEnabled(false);
        txtUser.setText(empleado[0].toString());
        btnvolver=findViewById(R.id.btnCancelarCambio);
        btnvolver.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                CambioContrasenia.this.finish();
            }
        });

        txtContraActual=findViewById(R.id.txtContraActual);
        txtContraNueva=findViewById(R.id.txtContraNueva);
        txtConfirmarContra=findViewById(R.id.txtConfirmar);
        errorACtual=findViewById(R.id.txtContraIncorrecta);
       errorConfirmar=findViewById(R.id.txtErrorConfirmar);
       cambiarContra();
    }

    public void cambiarContra(){

        btnCmabiar=findViewById(R.id.btnCambio);
        btnCmabiar.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                  comprobar();

            }
        });
    }
    String contra;
    public void comprobar(){
        LoadingDialog loadingDialog=new LoadingDialog(CambioContrasenia.this);
         if(txtContraActual.getText().toString().equals("")||txtContraNueva.getText().toString().equals("")
                 ||txtConfirmarContra.getText().toString().equals("")){
              alertaVacio();
         }else{
             txtContraActual.setBackgroundResource(R.drawable.borde_negro);
             errorACtual.setText("");
             txtConfirmarContra.setBackgroundResource(R.drawable.borde_negro);
             errorConfirmar.setText("");

             if(txtContraActual.getText().toString().equals(empleado[1].toString())){

                 if(txtContraNueva.getText().toString().equals(txtConfirmarContra.getText().toString())){
                     loadingDialog.iniciarDialogo();
                     Call<Boolean> call = AppApiAdapter.getApiService().putContrasenia(
                             String.valueOf(empleado[0]),String.valueOf(txtContraNueva.getText().toString()));
                     call.enqueue(new Callback<Boolean>() {
                         @Override
                         public void onResponse(Call<Boolean> call, Response<Boolean> response) {
                             Boolean si=true;
                             if(si=response.body()){

                                 loadingDialog.cancelarDialogo();
                                 exito();
                                 empleado[1]=txtContraNueva.getText().toString();
                             }else{
                                 fallo();
                             }

                         }

                         @Override
                         public void onFailure(Call<Boolean> call, Throwable t) {
                               fallo();
                         }
                     });
                 }else{
                     txtConfirmarContra.setBackgroundResource(R.drawable.borde_rojo);
                     errorConfirmar.setText("Las contraseñas no coinciden");
                 }
             }else{
                 txtContraActual.setBackgroundResource(R.drawable.borde_rojo);
                 txtContraActual.setFocusable(true);
                 errorACtual.setText("Contraseña Incorrecta");
             }
         }
    }

    public void alertaVacio(){
        AlertDialog.Builder builder=new AlertDialog.Builder(CambioContrasenia.this);
        builder.setMessage("Debe llenar los parametros")
                .setPositiveButton("Aceptar", new DialogInterface.OnClickListener() {
                    @Override
                    public void onClick(DialogInterface dialog, int wich) {
                        dialog.dismiss();
                    }
                });
        builder.show();
    }
    public void exito(){
        AlertDialog.Builder builder=new AlertDialog.Builder(CambioContrasenia.this);
        builder.setMessage("Contraseña actualizada con exito")
                .setPositiveButton("Aceptar", new DialogInterface.OnClickListener() {
                    @Override
                    public void onClick(DialogInterface dialog, int wich) {
                        dialog.dismiss();
                    }
                });
        builder.show();
    }

    public void fallo(){
        AlertDialog.Builder builder=new AlertDialog.Builder(CambioContrasenia.this);
        builder.setMessage("No se puedo Actualizar")
                .setPositiveButton("Aceptar", new DialogInterface.OnClickListener() {
                    @Override
                    public void onClick(DialogInterface dialog, int wich) {
                        dialog.dismiss();
                    }
                });
        builder.show();
    }


}