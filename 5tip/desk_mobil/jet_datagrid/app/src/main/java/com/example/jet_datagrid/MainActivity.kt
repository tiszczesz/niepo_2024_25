package com.example.jet_datagrid

import android.os.Bundle
import androidx.activity.ComponentActivity
import androidx.activity.compose.setContent
import androidx.activity.enableEdgeToEdge
import androidx.compose.foundation.background
import androidx.compose.foundation.border

import androidx.compose.foundation.layout.Column
import androidx.compose.foundation.layout.fillMaxSize
import androidx.compose.foundation.layout.fillMaxWidth
import androidx.compose.foundation.layout.height
import androidx.compose.foundation.layout.padding
import androidx.compose.material3.AlertDialog
import androidx.compose.material3.Button
import androidx.compose.material3.ExperimentalMaterial3Api
import androidx.compose.material3.Scaffold
import androidx.compose.material3.Text
import androidx.compose.runtime.Composable
import androidx.compose.runtime.mutableStateOf
import androidx.compose.runtime.remember
import androidx.compose.ui.Modifier
import androidx.compose.ui.graphics.Color
import androidx.compose.ui.graphics.Shape
import androidx.compose.ui.unit.dp
import com.example.jet_datagrid.ui.theme.Jet_datagridTheme

class MainActivity : ComponentActivity() {
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        enableEdgeToEdge()
        setContent {
            Jet_datagridTheme {
                Scaffold(modifier = Modifier.fillMaxSize()) { innerPadding ->
                    MyWindow(modifier = Modifier.padding(innerPadding))
                }
               // DataGrid()
            }
        }
    }
}
//@OptIn(ExperimentalMaterial3Api::class)
@Composable
fun MyWindow(modifier: Modifier) {
    val showAlertDialog = remember { mutableStateOf(false) }
    Column(modifier = Modifier.padding(50.dp)) {
        Button(modifier = Modifier.fillMaxWidth(), onClick = { showAlertDialog.value = true }) {
            Text("Show Dialog")
        }
    }
    if(showAlertDialog.value) {
       AlertDialog(onDismissRequest = {showAlertDialog.value=false}, confirmButton = {},
           title = {Text("sddssdssfs")})
    }

}


@Composable
fun Greeting(name: String, modifier: Modifier = Modifier) {
    Text(
        text = "Hello $name!",
        modifier = modifier
    )
}

//@Preview(showBackground = true)
//@Composable
//fun GreetingPreview() {
//    Jet_datagridTheme {
//        Greeting("Android")
//    }
//}
//@Preview
//@Composable
//fun DataGrid() {
//    val items = (0..20).toList()
//    LazyVerticalGrid(
//        columns = GridCells.Fixed(2),
//        modifier = Modifier.fillMaxSize()
//    ) {
//        items(items.size){index->
//            Box(contentAlignment = Alignment.Center,
//
//                modifier = Modifier.padding(8.dp).aspectRatio(1f)
//                    .border(2.dp, Color.Black)
//                    .background(Color.Green)) {
//                Text(text = "Item $index")
//            }
//        }
//    }
//}