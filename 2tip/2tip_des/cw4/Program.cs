// See https://aka.ms/new-console-template for more information

//podajemy text i jest wyswietlamy w konsoli gdy podamy stop to koniec programu
void cw1()
{
    string? text;
    do
    {
        Console.Write("Podaj tekst(stop konczy): ");
        text = Console.ReadLine();

    } while (text?.Trim().ToLower() != "stop");
    int i = 0;
    while (i < 10)
    {
        Console.WriteLine(++i);
    }
}
//cw1();
void cw2(){
    for (int i = 0; i < 10; i++){
        for (int j = 0; j < 10; j++){
            Console.WriteLine($"\ti = {i}\tj = {j}");
        }
    }
}
//cw2();

void cw3(){
    for (int i = 0; i < 10; i++){
        Console.WriteLine($"i = {i} przed ifem");
        if(i>4){
            continue;//przerwanie akualnego cyklu petli
        }
        Console.WriteLine($"i = {i} po ifie");
    }
}
//cw3();
void cw4(){
    for (int i = 0; i < 10; i++){
        Console.WriteLine($"i = {i} przed ifem");
        if(i>4){
            break;//przerwanie akualnego cyklu petli
        }
        Console.WriteLine($"i = {i} po ifie");
    }
}
cw4();