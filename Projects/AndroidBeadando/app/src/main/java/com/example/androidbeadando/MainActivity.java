package com.example.androidbeadando;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.TextView;

public class MainActivity extends AppCompatActivity {

    private EditText Name;
    private EditText Password;
    private TextView Info;
    private Button Login;
    private int counter = 5;
    private Button ColorButton;
    private Button CalculatorButton;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        Name = (EditText)findViewById(R.id.editTextName);
        Password = (EditText)findViewById(R.id.editTextPassword);
        Info = (TextView)findViewById(R.id.textViewInfo);
        Login = (Button)findViewById(R.id.buttonLogin);

        Info.setText("Hátralévő próbálkozások száma: 5");

        Login.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                validacio(Name.getText().toString(), Password.getText().toString());
            }
        });

        ColorButton = findViewById(R.id.buttonColor);
        ColorButton.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                openColorActivity();
            }


        });

        CalculatorButton = findViewById(R.id.buttonCalculator);
        CalculatorButton.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                openActivity();
            }


        });




    }

    private void openActivity() {
        Intent intent = new Intent(this, Main3act.class);
        startActivity(intent);
    }

    private void validacio(String userName, String userPassword){
        if ((userName.equals("admin")) && (userPassword.equals("admin"))){
            Intent intent = new Intent(MainActivity.this, SecondActivity.class);
            startActivity(intent);
        } else {
            counter--;

            Info.setText("Hátralévő próbálkozások száma: " + String.valueOf(counter));

            if(counter == 0){
                Login.setEnabled(false);
            }
        }
    }

    private void openColorActivity() {
        Intent intent = new Intent(this, ColorActivity.class);
        startActivity(intent);
    }


}
