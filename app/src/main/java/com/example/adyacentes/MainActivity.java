package com.example.adyacentes;

import androidx.appcompat.app.AppCompatActivity;

import android.graphics.Color;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;

public class MainActivity extends AppCompatActivity {

    private int estadobtn1 =0;
    private int estadobtn2 =0;
    private int estadobtn3 =0;
    private int estadobtn4 =0;

    private Button button1;
    private Button button2;
    private Button button3;
    private Button button4;


    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        button1.findViewById(R.id.button1);
        button2.findViewById(R.id.button2);
        button3.findViewById(R.id.button3);
        button4.findViewById(R.id.button4);


        button1.setBackgroundColor(Color.BLUE);
        button2.setBackgroundColor(Color.BLUE);
        button3.setBackgroundColor(Color.BLUE);
        button4.setBackgroundColor(Color.BLUE);

    }


    public void btn1(View view){
        cambiarColor(estadobtn1);
    }

    public void cambiarColor(int estado){

        if (estado == 0){
            estado += 1;
            button1.setBackgroundColor(Color.RED);
            button2.setBackgroundColor(Color.RED);
            button3.setBackgroundColor(Color.RED);
            button4.setBackgroundColor(Color.RED);
        }
        else{
            estado = 0;
            button1.setBackgroundColor(Color.BLUE);
            button2.setBackgroundColor(Color.BLUE);
            button3.setBackgroundColor(Color.BLUE);
            button4.setBackgroundColor(Color.BLUE);


        }

    }



}