// See https://aka.ms/new-console-template for more information
using c12generics;

var ic = new IntContainer(4);
Console.WriteLine(ic);
var fc = new Container<float>(4.4f);
Console.WriteLine(fc);
var dc = new Container<double>(6.6);
Console.WriteLine(dc);