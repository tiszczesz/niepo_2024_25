package com.example.cw1

import android.os.Bundle
import android.widget.Button
import android.widget.EditText
import android.widget.ImageView
import android.widget.TextView
import android.widget.Toast

import androidx.activity.enableEdgeToEdge
import androidx.appcompat.app.AppCompatActivity
import androidx.core.view.ViewCompat
import androidx.core.view.WindowInsetsCompat

class MainActivity : AppCompatActivity() {
    private var counter = 0;
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        enableEdgeToEdge()
        setContentView(R.layout.activity_main)
        ViewCompat.setOnApplyWindowInsetsListener(findViewById(R.id.main)) { v, insets ->
            val systemBars = insets.getInsets(WindowInsetsCompat.Type.systemBars())
            v.setPadding(systemBars.left, systemBars.top, systemBars.right, systemBars.bottom)
            insets
        }
        val btn1 = findViewById<Button>(R.id.btn1)
        val image = findViewById<ImageView>(R.id.iv1)
        val etDivider = findViewById<EditText>(R.id.etDivider)
        val btnCounter = findViewById<Button>(R.id.btnCounter)
        val tvCounter = findViewById<TextView>(R.id.tvCounter)
        tvCounter.text = counter.toString() //zero na poczatek
        btnCounter.setOnClickListener {
            counter++;
            tvCounter.text = counter.toString()
            val div = etDivider.text.toString().toInt()
            changeVisibility(image, div)
        }
        btn1.setOnClickListener {
            Toast.makeText(this, "Przycisk zadziałał", Toast.LENGTH_LONG).show()
        }
    }

    private fun changeVisibility(image: ImageView, div: Int = 2) {

        if (counter % div == 0) {
            image.visibility = ImageView.VISIBLE
        } else {
            image.visibility = ImageView.INVISIBLE
        }
    }
}