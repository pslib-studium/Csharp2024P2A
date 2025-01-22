// See https://aka.ms/new-console-template for more information
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