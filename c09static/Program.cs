// See https://aka.ms/new-console-template for more information
Human h = new Human("Pepa", 16); // instance třídy Human
h.SayHello();
Human h2 = new Human("Jirka", 18); // instance třídy Human
h2.SayHello();
Human.SayHelloStatic();

Console.WriteLine(MathOps.Divide(2,3));
class Human
{
    public string Name { get; set; }
    public int Age { get; set; }
    static int Counter { get; set; } = 0;
    public Human(string name, int age)
    {
        Name = name;
        Age = age;
        Counter++;
    }
    public void SayHello()
    {
        Console.WriteLine($"Ahoj, jsem {Name} a je mi {Age} let.");
        Console.WriteLine($"Je tu {Counter} lidí.");
    }

    public static void SayHelloStatic()
    {
        Console.WriteLine($"Ahoj, je tu {Counter} lidí.");
    }
}

static class MathOps
{
    public static float Divide(float a, float b)
    {
        if (b == 0)
        {
            throw new DivideByZeroException("Seš idiot, dělíš nulou.");
        }
        return a / b;
    }
}