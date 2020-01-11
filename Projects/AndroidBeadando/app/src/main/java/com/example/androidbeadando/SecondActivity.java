package com.example.androidbeadando;

import androidx.appcompat.app.AlertDialog;
import androidx.appcompat.app.AppCompatActivity;

import android.content.DialogInterface;
import android.database.sqlite.SQLiteException;
import android.os.Bundle;
import android.view.View;
import android.widget.EditText;
import android.widget.TextView;
import android.widget.Toast;

public class SecondActivity extends AppCompatActivity {

    EditText firstname, lastname;
    TextView textView;
    Db_controller controller;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_second);

        firstname = (EditText)findViewById(R.id.editTextKnev);
        lastname = (EditText)findViewById(R.id.editTextVnev);
        textView = (TextView)findViewById(R.id.textViewLarge);

        controller = new Db_controller(this,"",null,1);

    }

    public void btn_click(View view){
        switch (view.getId()){
            case R.id.buttonAdd:
                try{
                    controller.insert_students(firstname.getText().toString(), lastname.getText().toString());
                }catch (SQLiteException e){
                    Toast.makeText(SecondActivity.this, "MÁR LÉTEZIK", Toast.LENGTH_SHORT).show();
                }
                break;
            case R.id.buttonDelete:
                controller.delete_student(firstname.getText().toString());
                break;
            case R.id.buttonUpdate:
                AlertDialog.Builder dialog = new AlertDialog.Builder(SecondActivity.this);
                dialog.setTitle("Adja meg az új keresztnevet");

                final EditText new_firstname = new EditText(this);
                dialog.setView(new_firstname);

                dialog.setPositiveButton("OK", new DialogInterface.OnClickListener() {
                    @Override
                    public void onClick(DialogInterface dialog, int which) {
                        controller.update_student(firstname.getText().toString(), new_firstname.getText().toString());
                    }
                });

                dialog.show();
                break;
            case R.id.buttonList:
                controller.list_all_students(textView);
                break;

        }
    }

}
