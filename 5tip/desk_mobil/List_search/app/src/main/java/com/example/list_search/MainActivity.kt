package com.example.list_search

import android.os.Build
import android.os.Bundle
import android.widget.ArrayAdapter
import android.widget.Button
import android.widget.EditText
import android.widget.ListView
import androidx.activity.enableEdgeToEdge
import androidx.annotation.RequiresApi
import androidx.appcompat.app.AppCompatActivity
import androidx.core.view.ViewCompat
import androidx.core.view.WindowInsetsCompat

class MainActivity : AppCompatActivity() {
    @RequiresApi(Build.VERSION_CODES.HONEYCOMB)
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        enableEdgeToEdge()
        setContentView(R.layout.activity_main)
        ViewCompat.setOnApplyWindowInsetsListener(findViewById(R.id.main)) { v, insets ->
            val systemBars = insets.getInsets(WindowInsetsCompat.Type.systemBars())
            v.setPadding(systemBars.left, systemBars.top, systemBars.right, systemBars.bottom)
            insets
        }
        val buttonSearch = findViewById<Button>(R.id.searchButton)
        val textSearch = findViewById<EditText>(R.id.searchText)
        val list = findViewById<ListView>(R.id.listView)
        var entryWords = arrayListOf<String>(
            "Apple", "Banana", "Cherry", "Date",
            "Fig", "Grape", "Kiwi", "Lemon", "Mango",
            "Orange", "Papaya", "Peach", "Pear", "Plum",
            "Raspberry", "Strawberry", "Watermelon"
        )
        var words = ArrayList(entryWords)
        val listAdapter = ArrayAdapter(this, android.R.layout.simple_list_item_1, entryWords)
        list.adapter = listAdapter

        buttonSearch.setOnClickListener {
                val search = textSearch.text.toString()
                if (search.isNotEmpty()) {
                    val searchWords = words.filter { it.contains(search, ignoreCase = true) }
                    listAdapter.clear()
                    listAdapter.addAll(searchWords)
                } else {
                    listAdapter.clear()
                    listAdapter.addAll(words)
                }
                listAdapter.notifyDataSetChanged()
        }

    }
}