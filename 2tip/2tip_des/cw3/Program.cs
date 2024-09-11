// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Person p1 = new Person();
p1.firstname = "Jan";
p1.lastname = "Nowak";
p1.age = 33;
Console.WriteLine(p1);
Console.WriteLine(p1.ToString());
Console.WriteLine(p1.lastname + " " + p1.firstname + " ma " + p1.age + " lat");
p1.Hello();
