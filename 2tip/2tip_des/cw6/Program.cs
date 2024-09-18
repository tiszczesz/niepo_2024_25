using cw6.Models;

Game g1 = new Game();//implementacja obiektu klasy Game
g1.Title = "Wiedźmin 3";
g1.Genre = "RPG";
Game g2 = new Game();
g2.Title = "ee";
g2.Genre = "RPG";
Console.WriteLine(g1.ToString());
Console.WriteLine(g2);
// Console.WriteLine(g1.GetHashCode());
// Console.WriteLine(g2.GetHashCode());

//zdefiniowac klase Person w nowym pliku Models/Person.cs
//zdefiniowac pola publiczne: FirstName, LastName, Age
//zdefiniowac metode ToString zwracajaca FirstName, LastName, Age
//w Program.cs utworzyc obiekt klasy Person i wypisac go na ekran