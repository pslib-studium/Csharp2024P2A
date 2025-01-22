// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Student x = new Student { Firstname = "Jim", Lastname = "Brown" };
List<Student> students = new List<Student>
{
    new Student { Firstname = "John", Lastname = "Doe" },
    new Student { Firstname = "Jane", Lastname = "Doe" }
};
//students.Sort();
foreach (var student in students)
{
    Console.WriteLine($"{student.Firstname} {student.Lastname}");
}
students.Add(new Student { Firstname = "David", Lastname = "Dumb"});
students.Add(x);
students.Remove(x);

Dictionary<string, Student> studentDictionary = new Dictionary<string, Student>
{
    { "John", new Student { Firstname = "John", Lastname = "Doe" } },
    { "Jane", new Student { Firstname = "Jane", Lastname = "Doe" } }
};
studentDictionary.Add("David", new Student { Firstname = "David", Lastname = "Dumb" });
foreach (var item in studentDictionary)
{
    var key = item.Key;
    var value = item.Value;
    Console.WriteLine($"{key}: {value.Firstname} {value.Lastname}");
}
if (studentDictionary.ContainsKey("David"))
    Console.WriteLine("David is in the dictionary");
if (studentDictionary.ContainsValue(x))
    Console.WriteLine("Jim Brown is in the dictionary");
else Console.WriteLine("Jim Brown is not in the dictionary");
//FIFO
Queue<Student> messhall = new Queue<Student>();
messhall.Enqueue(new Student { Firstname = "John", Lastname = "Doe" });
messhall.Enqueue(new Student { Firstname = "Jane", Lastname = "Doe" });
messhall.Enqueue(new Student { Firstname = "David", Lastname = "Dumb" });
Console.WriteLine(messhall.Dequeue().Firstname);
Console.WriteLine(messhall.Dequeue().Firstname);
Student res;
var s = messhall.TryPeek(out res);
if (s) Console.WriteLine(res.Firstname);
else Console.WriteLine("Queue is empty");
//LIFO
Stack<Student> stack = new Stack<Student>();
stack.Push(new Student { Firstname = "John", Lastname = "Doe" });
stack.Push(new Student { Firstname = "Jane", Lastname = "Doe" });
Console.WriteLine(stack.Pop().Firstname);
var s2 = stack.TryPeek(out res);
if (s2) Console.WriteLine(res.Firstname);
else Console.WriteLine("Stack is empty");

HashSet<Student> set = new HashSet<Student>();
set.Add(new Student { Firstname = "John", Lastname = "Doe" });
set.Add(new Student { Firstname = "Jane", Lastname = "Doe" });
set.Add(x);
set.Add(x);
foreach (var student in set)
{
    Console.WriteLine($"{student.Firstname} {student.Lastname}");
}

class Student
{
    public required string Firstname { get; set; }
    public required string Lastname { get; set; }
}