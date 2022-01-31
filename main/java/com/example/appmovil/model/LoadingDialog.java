package com.example.appmovil.model;

import android.app.Activity;
import android.app.AlertDialog;
import android.view.LayoutInflater;

import com.example.appmovil.R;

public class LoadingDialog {

    private Activity activity;
    private AlertDialog dialog ;
    LoadingDialog(Activity mActivity){
        activity=mActivity;
    }
    void iniciarDialogo(){
        AlertDialog.Builder buiulder=new AlertDialog.Builder(activity);
        LayoutInflater inflater=activity.getLayoutInflater();
        buiulder.setView(inflater.inflate(R.layout.custom_dialog,null));
        buiulder.setCancelable(false);
        dialog= buiulder.create();
        dialog.show();
    }
    void cancelarDialogo(){
        dialog.dismiss();
    }
}
