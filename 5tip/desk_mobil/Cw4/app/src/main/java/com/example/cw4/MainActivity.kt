package com.example.cw4

import android.os.Bundle
import android.widget.Button
import android.widget.EditText
import android.widget.TextView
import android.widget.Toast
import androidx.activity.enableEdgeToEdge
import androidx.appcompat.app.AppCompatActivity
import androidx.core.view.ViewCompat
import androidx.core.view.WindowInsetsCompat

class MainActivity : AppCompatActivity() {
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        enableEdgeToEdge()
        setContentView(R.layout.activity_main)
        val btnRun = findViewById<Button>(R.id.btnRun)
        val aEdit = findViewById<EditText>(R.id.a)
        val bEdit = findViewById<EditText>(R.id.b)
        val resultEdit = findViewById<TextView>(R.id.result)
        ViewCompat.setOnApplyWindowInsetsListener(findViewById(R.id.main)) { v, insets ->
            val systemBars = insets.getInsets(WindowInsetsCompat.Type.systemBars())
            v.setPadding(systemBars.left, systemBars.top, systemBars.right, systemBars.bottom)
            insets
        }
        btnRun.setOnClickListener {
            try {
                val a = aEdit.text.toString().toInt()
                val b = bEdit.text.toString().toInt()
                val nwdResult = Nwd().nwdIter(a, b)
                resultEdit.text = "NWD($a, $b) = $nwdResult"
                //Toast.makeText(this, "$a + $b = ${a + b}", Toast.LENGTH_SHORT).show()
            }catch (e: Exception) {
                Toast.makeText(this, "Błędne Dane!!!", Toast.LENGTH_SHORT).show()
            }

        }
    }
}