fun main(){
 //cc1()
    cc2()
}
fun cc1(){
    val a = 12 //niemutowalna
    var c:Int
    var b:Int = 16 //mutowalna
    println("a = $a, b = $b")
  //  a = 34 //nie można zmienić wartości
    b = 45 //można zmienić wartość
    c = 23
    println("a = $a, b = $b, c = $c")
}
fun cc2(){
    val firstname = "Jan"
    val elem = 'a'
    print(firstname.uppercase())
}