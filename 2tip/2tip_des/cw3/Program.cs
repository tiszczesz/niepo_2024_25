// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Person p1 = new Person();
p1.Firstname = "Jan";
p1.Lastname = "Nowak";
p1.Age = -33;
Console.WriteLine(p1);
Console.WriteLine(p1.ToString());

p1.Hello();
