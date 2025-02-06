fun main(){
 //cc1()
    println(cc2("ala ma kota"))
    println("ostatni znak: ${cc3("ala ma kota malego1")}")
    println("pierwszy znak: ${"ala ma kota malego1".first()}")
    println("ostatni znak: ${"ala ma kota malego1".lastOrNull { it-> it=='l' }}")
    println("index l znak: ${"ala ma kota malego1".lastIndexOf('l')}")
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
fun cc2(message:String):String {
    val firstname = "Jan"
    val elem = 'a'
    println(firstname.uppercase()+elem+"\n =========== \n")
    var result = firstname+' '+elem+' '+message
    return result
}
fun cc3(text:String):Char{
    return text.last()
}