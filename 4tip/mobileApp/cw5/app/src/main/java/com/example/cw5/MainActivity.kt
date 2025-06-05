package com.example.cw5

import android.os.Bundle
import android.util.Log
import androidx.activity.enableEdgeToEdge
import androidx.appcompat.app.AppCompatActivity
import androidx.core.view.ViewCompat
import androidx.core.view.WindowInsetsCompat

class MainActivity : AppCompatActivity() {
    private val My_TAG = "LifeCycle"
    override fun onCreate(savedInstanceState: Bundle?) {
        println("$My_TAG: onCreate")
        Log.d(My_TAG, "onCreate called")
         // Log.d is used to log debug messages
        super.onCreate(savedInstanceState)
        enableEdgeToEdge()
        setContentView(R.layout.activity_main)
        ViewCompat.setOnApplyWindowInsetsListener(findViewById(R.id.main)) { v, insets ->
            val systemBars = insets.getInsets(WindowInsetsCompat.Type.systemBars())
            v.setPadding(systemBars.left, systemBars.top, systemBars.right, systemBars.bottom)
            insets
        }
    }

    override fun onStart() {
        super.onStart()
        println("$My_TAG: onStart")
    }
    override fun onResume() {
        super.onResume()
        println("$My_TAG: onResume")
    }
    override fun onPause() {
        super.onPause()
       // println("$My_TAG: onPause")
    }
    override fun onStop() {
        super.onStop()
       // println("$My_TAG: onStop")
    }
    override fun onDestroy() {
       // println("$My_TAG: onDestroy")
        super.onDestroy()

    }
}