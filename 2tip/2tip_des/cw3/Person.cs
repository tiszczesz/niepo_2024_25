public class Person{
    //pola zmienne opisujace dany obiekt
    public string firstname;
    public string lastname;
    public int age;

    //metody funkcje definiujace zachowanie obiektu
    public void Hello(){
        Console.WriteLine("Hello jestem " + firstname + " " + lastname);
    }
}