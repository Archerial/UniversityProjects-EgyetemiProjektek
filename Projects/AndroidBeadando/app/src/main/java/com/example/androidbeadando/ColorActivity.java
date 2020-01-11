package com.example.androidbeadando;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.view.View;

public class ColorActivity extends AppCompatActivity {
    View view;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_color);

        view= this.getWindow().getDecorView();

    }
    public void goRed(View v){
        view.setBackgroundResource(R.color.red);
        v.setBackgroundResource(R.color.red);
    }

    public void goGreen(View v){
        view.setBackgroundResource(R.color.green);
        v.setBackgroundResource(R.color.green);
    }

    public void goBlue(View v) {
        view.setBackgroundResource(R.color.blue);
        v.setBackgroundResource(R.color.blue);
    }

    public void goYellow(View v) {
        view.setBackgroundResource(R.color.yellow);
        v.setBackgroundResource(R.color.yellow);
    }

    public void goReset(View v) {
        view.setBackgroundResource(R.color.white);
        v.setBackgroundResource(R.color.white);
    }
}
