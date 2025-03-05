import java.io.File

fun main(){
    //cw1()
    cw2()
}
//proste klasy w kotlinie data class
fun cw1(){
    data class Book(var title: String, val author: String, val year: Int)
    val book = Book("W pustyni i w puszczy", "Henryk Sienkiewicz", 1911)
    println(book)
    val book2 = book.copy(year = 2012)
    val book3 = book2
    println(book2)
    println(book)
    println(book3)
    book3.title = "Krzyżacy"
    println(book3)
    println(book2)
}
data class Person(val name: String, val surname: String, val age: Int,val salary: Int)
//napisac funkcje wczytujaca z pliku data.txt dane osobowe i zapisujaca je
// do listy obiektow klasy Person
//napisac funkcje wyswietlajaca liste obiektow klasy Person jako argument
fun personsFromFile(filename: String): List<Person> {
    val persons = mutableListOf<Person>()
    val lines = File(filename).readLines()
    //val data = lines.map { it.split(" ") }
    for (line in lines){
        val d = line.split(" ")
        val name = d[0]
        val surname = d[1]
        val age = d[2].toInt()
        val salary = d[3].toInt()
        persons.add(Person(name,surname,age,salary))
    }
    return persons
}
fun printPersons(persons: List<Person>){
    for(person in persons){
        println(person)
    }
}
fun cw2(){
    val persons = personsFromFile("data.txt")
    printPersons(persons)
}