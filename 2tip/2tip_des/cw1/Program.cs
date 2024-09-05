// See https://aka.ms/new-console-template for more information
using System.Text;

void cw1()
{
    Console.WriteLine("Hello, World!");
    Console.Write("Hello, World!");
    Console.Write("Hello, World!");
    //typ nazwa
    int? liczba = null;
    ulong a = 12122344454455545455;
    Console.WriteLine(liczba);
    Console.WriteLine(4 / 3);
    try
    {
        liczba = Convert.ToInt32("10.0"); //proba wykonania
        Console.WriteLine(liczba);
    }
    catch (FormatException ex)
    {
        Console.WriteLine(ex.Message); //przechwycenie wyjatku
    }
}
void cw2()
{
    string firstname = "Adam";
    Console.WriteLine($"Hello, {firstname}!"); //wyswietlenie zmiennej (firstname);
    firstname = firstname + "34";
    // StringBuilder sb = new StringBuilder();
    // sb.Append(firstname);
    // sb.Append("34");
    // firstname = sb.ToString();
    Console.WriteLine($"Hello, {firstname}!"); //wyswietlenie zmiennej (firstname);
}
void cw3()
{
    Console.Write("Podaj swoje imie: ");
    string? firstname = Console.ReadLine();
    Console.Write("Podaj swoje nazwisko: ");
    string? lastname = Console.ReadLine();
    Console.WriteLine($"Hello, {firstname} {lastname}! Dzisiaj mamy {DateTime.Now.ToShortDateString()}");
}
//cw1();
//cw2();
cw3();