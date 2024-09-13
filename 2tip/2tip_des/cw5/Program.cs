int[] t1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
string[] t2 = { "ahh", "b", "c", "d", "hhhhe", "f", "g", "h", "i", "j" };
Console.WriteLine(t1[3]);
Console.WriteLine(t1.LongLength);
Console.WriteLine(t1.Length);
for (int i = 0; i < t1.Length; i++){
    Console.Write(t1[i]+" ");
}
Console.WriteLine();
foreach (var i in t2){
    Console.Write(i+" ");
}
//funkcja generujaca tablice o podanymn rozmiarze liczb losowych
int[] numbers(int size){
    int[] result = new int[size];
    Random r = new Random();
    for (int i = 0; i < size; i++){
        result[i] = r.Next(0, 100);
    }
    return result;
}
Console.WriteLine("==========================================");
var t3 = numbers(55);
foreach (var i in t3){
    Console.Write(i+" ");
}
var ile = search(t3,5);
Console.WriteLine($"\nile = {ile}"); 
int search(int[] data, int find)
{
   int counter = 0;
   foreach (var i in data){
       if (i == find){
           counter++;
       }
   }
   return counter;
}