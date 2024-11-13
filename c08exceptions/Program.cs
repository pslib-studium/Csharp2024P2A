// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

float a = 7;
float b = 0;
try 
{
    float c = Divide(a, b); // <--- tady to může hodit výjimku
    Console.WriteLine($"a/b = {c}");
}
catch (DivideByZeroException e)
{
    Console.WriteLine("CHYBA dělení: " + e.Message);
}
catch (Exception e)
{
    Console.WriteLine("Divná chyba: " + e.Message);
}
finally {
    Console.WriteLine("Konec programu.");
}

float Divide(float a, float b)
{
    if (a == 7)
    {
        throw new MySpecialException("Nesmíš dělit sedmičku.");
    }
    if (b == 0)     {
        throw new DivideByZeroException("Seš idiot, dělíš nulou.");
    }
    return a / b;
}

class MySpecialException : Exception
{
    public MySpecialException(string message) : base(message)
    {
    }
}