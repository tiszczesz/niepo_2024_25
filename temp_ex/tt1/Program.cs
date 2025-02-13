// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine(fun1().Name);
dynamic fun1(){
    return new{
        Name = "John",
        Age = 25
    };
}
