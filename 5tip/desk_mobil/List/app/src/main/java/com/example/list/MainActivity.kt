package com.example.list

import android.os.Bundle
import android.widget.ArrayAdapter
import android.widget.Button
import android.widget.EditText
import android.widget.ListView
import android.widget.SeekBar
import android.widget.Spinner
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
        ViewCompat.setOnApplyWindowInsetsListener(findViewById(R.id.main)) { v, insets ->
            val systemBars = insets.getInsets(WindowInsetsCompat.Type.systemBars())
            v.setPadding(systemBars.left, systemBars.top, systemBars.right, systemBars.bottom)
            insets
        }
        val list = findViewById<ListView>(R.id.list)
        val addNew = findViewById<Button>(R.id.add)
        val task = findViewById<EditText>(R.id.task)
        val spinner = findViewById<Spinner>(R.id.spinner)
        val seekBar = findViewById<SeekBar>(R.id.seekBar)
        val progresValue = findViewById<TextView>(R.id.progress)
        //zadania wstępne
        val todos = arrayListOf<Todo>(
            Todo("Zrobić zakupy", MyPriority.ALERT),
            Todo("Obejrzeć film", MyPriority.MEDIUM),
            Todo("Zrobić prezentację", MyPriority.HIGH),
            Todo("Posprzątać pokój", MyPriority.LOW)
        )
        val priority = arrayListOf<MyPriority>(
            MyPriority.ALERT,
            MyPriority.HIGH,
            MyPriority.MEDIUM,
            MyPriority.LOW
        )
        //jak datasource dla spinnera
        val adapterSpinner = ArrayAdapter<MyPriority>(
            this,
            android.R.layout.simple_spinner_item, priority
        )
        spinner.adapter = adapterSpinner //podpięcie adaptera do spinnera

        //dla listview
        val adapterTodo = ArrayAdapter<Todo>(
            this,
            android.R.layout.simple_list_item_1, todos
        )
        list.adapter = adapterTodo //podpięcie adaptera do listview
        //dodawanie do listy
        addNew.setOnClickListener {
            //pobranie wartości z pól
            val newTask = task.text.toString().trim()
            if (newTask.isEmpty()) {
                Toast.makeText(this, "Wpisz treść zadania", Toast.LENGTH_SHORT).show()
                return@setOnClickListener
            }
            val newPriority = spinner.selectedItem as MyPriority
            //dodanie do listy
            todos.add(Todo(newTask, newPriority))
            //wyczyszczenie pola
            task.text.clear()
            //odświeżenie adaptera
            adapterTodo.notifyDataSetChanged()
        }
        //dla seekbara
        seekBar.setOnSeekBarChangeListener(object : SeekBar.OnSeekBarChangeListener {
            override fun onProgressChanged(seekBar: SeekBar?, progress: Int, fromUser: Boolean) {
                progresValue.text = progress.toString()
            }

            override fun onStartTrackingTouch(seekBar: SeekBar?) {
                // TODO("Not yet implemented")
            }

            override fun onStopTrackingTouch(seekBar: SeekBar?) {
                //  TODO("Not yet implemented")
            }
        }
        )
    }
}