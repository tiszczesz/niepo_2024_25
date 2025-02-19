fun main() {
    //c31();
    // c32();
    // c33()
    //c34()
    c35()
}

fun c32() {
    try {
        print("Podaj ilosc liczb: ")
        val howMany = readln().toInt()
        print("przez ile dzilone: ")
        val divided = readln().toInt()
        val result = generateNumbers(howMany, divided)
        for (i in result) {
            print("$i ")
        }
    } catch (e: NumberFormatException) {
        println("Wystapil blad: ${e.message}")
    } catch (e: Exception) {
        println("Wystapil blad ogolny: ${e.message}")
    }
}

fun generateNumbers(howMany: Int, i: Int): Array<Int> {
    // TODO("Not yet implemented")
    val result = Array<Int>(howMany) { it -> 0 }
    // val result = IntArray(howMany)//utworzenie tablicy o rozmiarze howMany
    for (index in 0..result.size - 1) {
        result[index] = index * i
    }
    return result//.toTypedArray()
}

fun c31() {
    for (i in 1..10) { //1..10
        println("i = $i")
    }
}

fun c33() {
    print("Podaj swoj wiek: ")
    val age = readln().toInt()
    //cout << (age >= 18 ? "Jestes pelnoletni" : "Nie jestes pelnoletni") << endl;
    println(if (age >= 18) "Jestes pelnoletni" else "Nie jestes pelnoletni")
    if (age >= 18) {
        println("Jestes pelnoletni")
    } else {
        println("Nie jestes pelnoletni")
    }
}

fun c34() {
    do {
        print("Podaj liczbe: ")
        val number = readln().toInt()
        if (number != 0) {
            println("liczba wynosi: $number")
        }
    } while (number != 0)
}



//napisz funkcje ktora przyjmuje argument limit do ktorego szukamy liczb pierwszych
// i wyswietla je na ekranie
fun getPrimes(limit: Int):Unit {
   for (i in 2..limit){
       if (isPrime(i)){
           print("$i ")
       }
   }
}
//napisz funkcje ktora sprwdza czy liczba jest pierwsza
//fun isPrime(number: Int): Boolean {}
fun isPrime(number: Int): Boolean {
    if (number < 2) {
        return false
    }
    var i = 2
    while (i * i <= number) {
        if (number % i == 0) {
            return false
        }
        i++
    }
    return true
}
fun c35(){
    print("Podaj limit: ")
    val limit = readln().toInt()
    getPrimes(limit)
}
//napisz funkcje ktora przyjmuje 2 argumenty ilosc
// liczb podzielnych przez daną liczbę arg2
// fun generateNumbers(howMany: Int, arg2: Int): Array<Int> {}