// See https://aka.ms/new-console-template for more information
int[] pole =  new int[2];
pole[0] = 0;
pole[1] = 100;
//Console.WriteLine(pole[0]);
//Console.WriteLine(pole[6]);
int[] pole2 = [];
int[] pole3 = new []{ 1, 2 };
int[] pole4  = { 3, 4 };
pole4 = new int[10];
//Console.WriteLine(pole4[8]);
pole4[0] = 5;
for(int i = 0; i < pole4.Length; i++)
{
    Console.WriteLine(pole4[i]);
}
foreach(var x in pole4)
{
    Console.WriteLine(x);
}
Console.WriteLine(pole4);

// 

