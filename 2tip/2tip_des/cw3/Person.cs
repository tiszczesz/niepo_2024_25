public class Person
{
    //pola zmienne opisujace dany obiekt
    private string? firstname;
    public string? Firstname
    {
        get { return firstname.ToUpper(); }
        set
        {
            if (value.Length < 3) firstname = "noname";
            else firstname = value;
        }
    }
    private string? lastname;
    public string? Lastname
    {
        get { return lastname.ToUpper(); }
        set
        {
            if (value.Length < 3) lastname = "noname";
            else lastname = value;
        }
    }
    private int age;
    public int Age
    {
        get { return age; }
        set { age = value > 0 ? value : -value; }
    }

    //metody funkcje definiujace zachowanie obiektu
    public void Hello()
    {
        Console.WriteLine("Hello jestem " + Firstname + " " + Lastname);
    }

    public override string ToString()
    {
        return Firstname + " " + Lastname + " wiek " + Age;
    }
}