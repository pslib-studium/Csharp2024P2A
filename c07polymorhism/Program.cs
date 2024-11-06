// See https://aka.ms/new-console-template for more information
using c07polymorhism;

var x = new Dato(10);
x.Add(5);
Console.WriteLine(x.Value);
var y = new ExtendedDato(10);
y.Multiplier = 2;
y.Add(5);
Console.WriteLine(y.Value);
Dato z = new ExtendedDato(10); // <--- polymorphism 2.type = overriding
z.Add(5);
Console.WriteLine(z.Value);
Console.WriteLine(z);

Console.WriteLine("Polymorphism ---------");
Dato[] data = new Dato[] { new Dato(10), new ExtendedDato(10) };
foreach (var item in data)
{
    item.Add(5);
    Console.WriteLine(item.Value);
}