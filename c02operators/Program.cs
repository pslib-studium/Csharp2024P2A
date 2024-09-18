int a = 10;
int b = 3;
//b = b + a;
//b += a;

//int c = --a + b; a = 9; c = 9 + 3 = 12 // predecrement
int c = a-- + b; // a = 9; c = 13 // postdecrement
// preincrement, postincrement
for (int ii = 0; ii < 10; ii++)
{
    Console.WriteLine(ii);
}
var d = a | b; // 11 // bitwise OR
var e = (a == 1) || (b != c); // true // logical OR
// boolenovské operátory
bool f = true;
bool g = !f; // false
int h = -1;
var i = a + b; // 13 
// asociativní - zleva doprava
// komutativita - pořadí nezáleží
var j = a > 10 ? 1 : 2;
// ternární operátor
var k = (a > 10 ? 1 : a++ < 5 ? 2 : --a < 0 ? 3 : 0) == 1 ? 7 : 8;
Console.WriteLine(k);
string? trida = null;
//trida = "P2A";
Console.WriteLine(trida ?? "i have no clue"); // null-coalescing operator
// trida is not null ? trida : "something" 
int m = default; // 0
int? n = default; // null
