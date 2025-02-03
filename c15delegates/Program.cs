// See https://aka.ms/new-console-template for more information
/*
List<string> list = new List<string>();
list.Add("Hello, World!");
list.Add("Hello, .NET!");
list.Add("Hello, C#!");
list.Add("Welcome, Visual Studio!");
list.Add("Welcome, .NET Core!");
foreach (string item in list)
{
    Console.WriteLine(item);
}
foreach (string item in list
    .Where(x => x.StartsWith("H"))
    .OrderBy(x => x)
    ) // Lambda function
{
    Console.WriteLine(item);
}
*/
// --------------------------------

Console.WriteLine(CallMathOp(4,5,Addition));
Console.WriteLine(CallMathOp(4, 5, (i,j) => { return (i + j); })); // lambda funkce, arrow funkce
float CallMathOp(float l, float m, BinaryMathOp op)
{
    return op(l, m);
}

float CallOp(float l,float m, Func<float, float, float> op) // návratová hodnota, parametry
{
    return (float)op(l, m);
}

float Addition(float x, float y)  { return x + y; } // : delegate?

delegate float BinaryMathOp(float a, float b);

// ------
/*
() => {...} 
x => return x * 2
x => (x * 2)
(int x, int y) => {return x * y}
(x,y) => {return x * y}
(x,y) => (x * y)
*/ 
// -------
/*
Func<T1, T2, ..., TR> = TR func(T1, T2)
Action<T1, T2> = func(T1, T2)
Predicate<T1, T2> = bool func(T1, T2)
*/