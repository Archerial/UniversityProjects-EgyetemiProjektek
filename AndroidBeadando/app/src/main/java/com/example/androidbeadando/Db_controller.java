package com.example.androidbeadando;

import android.content.ContentValues;
import android.content.Context;
import android.database.Cursor;
import android.database.sqlite.SQLiteDatabase;
import android.database.sqlite.SQLiteOpenHelper;
import android.widget.TextView;

import androidx.annotation.Nullable;

public class Db_controller extends SQLiteOpenHelper {
    public Db_controller(@Nullable Context context, @Nullable String name, @Nullable SQLiteDatabase.CursorFactory factory, int version) {
        super(context, "DbName.db", factory, version);
    }

    @Override
    public void onCreate(SQLiteDatabase db) {
        db.execSQL("CREATE TABLE STUDENTS( ID INTEGER PRIMARY KEY AUTOINCREMENT, FIRSTNAME TEXT UNIQUE, LASTNAME TEXT);");
    }

    @Override
    public void onUpgrade(SQLiteDatabase db, int oldVersion, int newVersion) {
        db.execSQL("DROP TABLE IF EXISTS STUDENTS");
        onCreate(db);
    }

    public void insert_students(String firstName, String lastNane){
        ContentValues contentValues = new ContentValues();
        contentValues.put("FIRSTNAME",firstName);
        contentValues.put("LASTNAME",lastNane);
        this.getWritableDatabase().insertOrThrow("STUDENTS","",contentValues);
    }

    public void delete_student(String firstname){
        this.getWritableDatabase().delete("STUDENTS", "FIRSTNAME='" +firstname+"'",null);
    }

    public void update_student(String old_firtsname, String new_firstname){
        this.getWritableDatabase().execSQL("UPDATE STUDENTS SET FIRSTNAME='" + new_firstname + "' WHERE FIRSTNAME='" + old_firtsname+"'");
    }

    public void list_all_students(TextView textView){
        Cursor cursor = this.getReadableDatabase().rawQuery("SELECT * FROM STUDENTS", null);
        textView.setText("");
        while (cursor.moveToNext()){
            textView.append(cursor.getString(1)+ " " +cursor.getString(2)+"\n");
        }
    }
}
