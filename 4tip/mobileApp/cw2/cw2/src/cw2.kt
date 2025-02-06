import kotlin.random.Random

fun main(){
    //println("suma elementow tablicy: ${c21()}")
    c22()
}
fun c21():Int{
    val numbers = arrayOf<Int>(4,12, 56, 77, 32,11,43)
    //numbers[12] = 34 za zakresem
    numbers[4]=999
    println("elementy tablicy: ${numbers.joinToString()}")
    println("element o indeksie 2: ${numbers[2]}")
    println("ostatni parzysty: ${numbers.lastOrNull { it -> it % 2 == 0 }}")
    println("ostatni nieparzysty: ${numbers.lastOrNull { it -> it % 2 != 0 }}")
    return numbers.sum()
}
fun c22(){
    val numbers = Array<Int>(3){ Random.nextInt(0,100)}
    println(numbers.joinToString())
    println("\n --------------------------------- ")
//    for (index in numbers){
//        print("$index ")
//    }
    for (index in 0..numbers.size-1){
        print("${numbers[index]} ")
    }
    println("\n --------------------------------- ")
    fun getOddSum(data:Array<Int>):Int{
        var sum = 0
        for (index in data){
            if (index % 2 != 0){
                sum += index
            }
        }
        return sum
    }
    println("suma nieparzystych: ${getOddSum(numbers)}")
}
fun generTab():Array<Int>{
    print("Podaj rozmiar tablicy: ")
    val input = readLine()
    val size = input?.toIntOrNull() ?: 0
    val tab = Array<Int>(size){ Random.nextInt(0,100)}
    return tab;
}
fun c23(){
    val numbers = generTab()
    //todo funkcje -> srednia i srednia parzystych lub nieparzystych true lub false
    println("srednia tablicy ${numbers.joinToString()} ${numbers.average()}")

}
