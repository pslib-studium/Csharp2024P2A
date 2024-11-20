// See https://aka.ms/new-console-template for more information

using c10interfaces;

Car bourák = new Car { SPZ = "L 44 44", Capacity=4, Color="Red", Power=100, Speed=200};
Horse kůň = new Horse { Name = "Blesk", Age = 5, Color = "Black", Power = 10 };
Human petr = new Human { Name = "Petr", Age = 25, Power = 1 };
Human jana = new Human { Name = "Jana", Age = 30, Power = 2 };
// Vehicle x = new Vehicle();
Vehicle[] Garage = { bourák, kůň};
IMeasurablePower[] PowerThingies = { bourák, kůň, petr };
var totalPower = 0;
foreach (var item in PowerThingies)
{
    totalPower += item.Power;
}
Console.WriteLine($"Total power of all vehicles in the garage is {totalPower} hp.");
Console.WriteLine($"Petr is {(petr.CompareTo(jana) > 0 ? "older" : "younger")} than Jana.");
