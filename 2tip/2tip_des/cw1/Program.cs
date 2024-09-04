// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.Write("Hello, World!");
Console.Write("Hello, World!");
//typ nazwa
int? liczba=null;
ulong a = 12122344454455545455;
Console.WriteLine(liczba);
Console.WriteLine(4/3);
try{
    liczba = Convert.ToInt32("10.0"); //proba wykonania
    Console.WriteLine(liczba);
}catch(FormatException ex){
    Console.WriteLine(ex.Message); //przechwycenie wyjatku
}
