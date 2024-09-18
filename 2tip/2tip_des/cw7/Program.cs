List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
//var numbers = new List<int> { 1, 2, 3, 4, 5 };
numbers.Add(6);
numbers.Insert(3, 44);
foreach (int number in numbers)
{
    Console.WriteLine(number);
}
//utworzenie listy z elementami string pustą 
List<string> names = new List<string>();
//w petli do while dodanie elementów do listy az uzytkownik napisze stop
//wyswietlenie elementów listy