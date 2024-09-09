void cw1()
{
    try
    {
        Console.Write("Podaj pierwsza liczbe: ");
        double liczba1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Podaj druga liczbe: ");
        double liczba2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"{liczba1} + {liczba2} = {liczba1 + liczba2}");
        Console.WriteLine($"{liczba1} - {liczba2} = {liczba1 - liczba2}");
        Console.WriteLine($"{liczba1} * {liczba2} = {liczba1 * liczba2}");
        // if (liczba2 != 0)
        // {
        //     Console.WriteLine($"{liczba1} / {liczba2} = {liczba1 / liczba2}");
        // }
        // else
        // {
        //     Console.WriteLine($"{liczba1} / {liczba2} = BRAK WYNIKU");
        // }
        Console.WriteLine($"{liczba1} / {liczba2} = " 
                + (liczba2 != 0 ? liczba1 / liczba2 : "BRAK WYNIKU"));
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
        Console.WriteLine("Błędny format danych");
    }

}

cw1();