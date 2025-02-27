import java.io.File
import kotlin.random.Random

fun main() {
   // c41()
   // c42()
    c43()
}

fun c41() {
    //lista niemutowalna
    val list = listOf<Int>(1, 2, 3, 4, 5)
    println(list)
    //list.add(7)
    //list.remove(3)
    val newList = list.subList(1, 3)
    println(newList)
    val list2 = List<Int>(20) { it -> Random.nextInt(1, 50) }
    println(list2)
    val list3 = list2.filter { it -> it % 2 == 0 }
    println(list2.last { it -> it % 2 == 0 })
    println(list3)
    println("suma: ${list2.sum()}")
    println("suma nieparzystych: ${ list2.filter { it -> it % 2 != 0 }.sum() }")
    println("suma parzystych: ${ list2.filter { it -> it % 2 == 0 }.sum() }")
}
fun c42(){
    //listy mutowalne mozna modyfikowac dodawac usuwac elementy
    val list = mutableListOf<Int>(1, 2, 3, 4, 5)
    println(list)
    list.add(7)
    println(list)
    list.remove(3)
    println(list)
    list.removeAt(2)
    println(list)
}
fun c43(){
    val names = mutableListOf<String>("Ala", "Ola", "Ela")
    println(names)
    names.add("Ula")
    names.add(1, "Iza")
    //zapis do pliku dane.txt listy names
    File("dane.txt").writeText(names.joinToString("\n"))
    //odczyt z pliku dane.txt do listy names2
    val names2 = File("dane.txt").readLines().toMutableList()
    println(" odzytane z pliku dane.txt: ")
    println(names2)
}