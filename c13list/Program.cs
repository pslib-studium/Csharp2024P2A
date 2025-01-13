// See https://aka.ms/new-console-template for more information
using System.Collections;

ArrayList  al = new ArrayList();
al.Add(4);
al.Add(5);
al.Add(6.4);
al.Add("Alois");
al.Add(new Dato { Value = 4 });
foreach(var x in al)
{
    if (x is Dato)
    {
        Console.WriteLine((x as Dato).ToString());
    }
    else
    {
        Console.WriteLine(x);
    }
    
}

List<int> ints = new List<int>();
ints.Add(100);
ints.Add(2);
ints.Add(3);
ints.Add(4);
ints.Add(5);
ints.Remove(2);
ints.RemoveAt(3);
ints[2] = 10;
try
{
    ints[30] = 20;
}
catch (Exception ex)
{
    Console.WriteLine(ex.ToString());
}
ints.Sort();
foreach(var x in ints)
{
    Console.WriteLine(x);
}
for (int i = 0; i < ints.Count; i++)
{
    Console.WriteLine(i + ": " + ints[i]);
}

class Dato
{
    public int Value { get; set; } = 0;
    public int Value2 { get; set; } = 0;

    public override string ToString()
    {
        return Value.ToString() + " " + Value2.ToString();
    }
}