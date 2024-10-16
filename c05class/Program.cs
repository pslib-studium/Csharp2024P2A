// See https://aka.ms/new-console-template for more information
using c05class;

Student alf = new Student("Petr","Petrov");
//Console.WriteLine(alf.firstName);
Console.WriteLine(alf.GetFirstName());
//alf.firstName = "Alfa";
alf.SetFirstName("Elon");
Console.WriteLine(alf.GetFirstName());
alf.SetFirstName("Alfa");
Console.WriteLine(alf.GetFullName());
Student bruce = new Student();
Console.WriteLine(bruce.FirstName);