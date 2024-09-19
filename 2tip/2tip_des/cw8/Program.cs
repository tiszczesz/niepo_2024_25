string text = File.ReadAllText("dane.txt");
Console.WriteLine(text);
Console.WriteLine(text.Length);
Console.WriteLine($"Ilość liter: {HowManyLetters(text)}");
Console.WriteLine($"Ilość samoglosek: {HowManyVowels(text)}");

int HowManyLetters(string text){
    int count = 0;
    foreach(char c in text){
        if(Char.IsLetter(c)){
            count++;
            
        }
    }
    return count;
}
int HowManyVowels(string text){
    int count = 0;
    string vowels = "aeiouyęóą";
    foreach(char c in text){
        if(vowels.Contains(Char.ToLower(c))){
            count++;
        }
    }
    return count;
}
int HowManyConsonant(string text){
    return HowManyLetters(text) - HowManyVowels(text);
}
