// See https://aka.ms/new-console-template for more information
using c16extMethods;

List<int> numbers = new List<int> { 1, 2,3,7,8,5,9,6,1,4,8,4};
// ListDerivate nums = new ListDerivate();
Console.WriteLine(numbers.CountOdd()); // extension method

// 
List<int> res = numbers.Where(x => (x % 2 == 1)).ToList();
foreach (int x in res)
{
    Console.WriteLine(x);
}
// Where, OrderBy, OrderByDescending, Select, GroupBy, ...