// See https://aka.ms/new-console-template for more information
using c06inheritance;

Human adam = new Human("Adam", "Freeman", "Mr", 42, 170);
Human bruce = new Human("Bruce", "Smith", null, 38, 210);
Student charlie = new Student("Charlie", "Brown", null, "P3A");
Student diana = new Student("Diana", "White", "Ms");
Teacher erwin = new Teacher("Erwin", "Black", "Dr", "IT");
Console.WriteLine(adam.Name);
Console.WriteLine(bruce.Name);
Console.WriteLine(charlie.Name);
Console.WriteLine(diana.Name);
Console.WriteLine(erwin.Name);