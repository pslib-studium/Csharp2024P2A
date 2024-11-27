// See https://aka.ms/new-console-template for more information
using c11sysInterfaces;

Student adam = new("Adam", "Smith", "123456", 4.5);
Student clonedAdam = new("Adam", "Smith", "123456", 4.5);
Student eve = new("Eve", "Smith", "123457", 2.0);

if (adam == clonedAdam) Console.WriteLine("Adam and clonedAdam are the same");
else Console.WriteLine("Adam and clonedAdam are not the same");
if (adam.Equals(clonedAdam)) Console.WriteLine("Adam and clonedAdam are the same");
else Console.WriteLine("Adam and clonedAdam are not the same");
if (adam.AverageMark > eve.AverageMark) Console.WriteLine("Adam is dumber than Eve");
else Console.WriteLine("Eve is dumber than Adam");
if (adam.CompareTo(eve) > 0) Console.WriteLine("Adam is dumber than Eve");
else Console.WriteLine("Eve is dumber than Adam");
if (adam > eve) Console.WriteLine("Adam is dumber than Eve");
else Console.WriteLine("Eve is dumber than Adam");


Classroom p2a = new("Programming 2A", new Student[] { adam, clonedAdam, eve });
/*foreach (Student student in p2a.Students)
{
    Console.WriteLine($"{student.FirstName} {student.LastName} has an average mark of {student.AverageMark}");
}
*/
foreach (Student student in p2a)
{
    Console.WriteLine($"{student.FirstName} {student.LastName} has an average mark of {student.AverageMark}");
}