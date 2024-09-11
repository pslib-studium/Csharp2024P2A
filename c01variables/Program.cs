int a;
int b = 3;
string činčila = "činčila";
Console.WriteLine(činčila);
// a, b, c = matematika
// i, j, k = iterace
// x, y, z = souřadnice
// temp, str
// jmenoStudenta - proměnná
// jmeno_studenta - nic
// JmenoStudenta - třída
// JMENO_STUDENTA - konstanta
int v1 = 1;
long v2 = 1;
//v2 = v1; // implicitní konverze
v1 = (int)v2; // explicitní konverze
v1 = int.MaxValue;
try {     
    v1 = checked(v1 + 1);
} catch (OverflowException) {
    Console.WriteLine("Přetečení");
}
//v1 = checked(v1 + 1); // OverflowException

// int, long, float, double, decimal - hodnotové
int x = 1;
int y = 2;
//int z = Test1(x, y);
int z = Test1(ref x, ref y);
Console.WriteLine(z);
Console.WriteLine(x);
// string, object, pole - referenční

Barva barva = Barva.Cervena;
Console.WriteLine(barva);
Console.WriteLine((int)barva);

int? q = 1; // nullable
q = null;
if (q == null) Console.WriteLine("null");
else Console.WriteLine(q);
if (q is null) Console.WriteLine("null");
else Console.WriteLine(q);
// null je hodnota i typ zároveň

int Test(int par1, int par2)
{
    par1 = 10;
    return par1 + par2;
}

int Test1(ref int par1, ref int par2) // reference
{
    par1 = 10;
    return par1 + par2;
}

enum Barva { Cervena = 10, Modra, Zelena };