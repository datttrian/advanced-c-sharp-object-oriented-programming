// Example file for Advanced C#: Object Oriented Programming by Joe Marini
// Using object and collection initializers

// TODO: Use the initializer syntax to create new objects
Dog dog = new Dog { Name = "Fido", Age = 4, IsTrained = true };
Cat cat = new Cat { Name = "Mr. Meowington", Age = 7, IsDeclawed = true };
System.Console.WriteLine($"{dog.Name} is {dog.Age} years old");
System.Console.WriteLine($"{cat.Name} is {cat.Age} years old");

// TODO: Initializers can be used on anonymous types
var pet = new { Name = "Charlie", Age = 5 };
System.Console.WriteLine($"{pet.Name} is {pet.Age} years old");

// TODO: Collections can also be initialized this way
int[] numbers = new int[] { 1, 2, 3, 4, 5, 6 };
System.Console.WriteLine($"{numbers.Length} numbers in the array");

// TODO: Initialize a collection with a set of objects
PetOwner owner = new PetOwner
{
    Name = "Joe Marini",
    Pets = new List<Pet> {
        new Dog { Name = "Junebug", Age = 4},
        new Cat { Name = "Whiskers", Age = 3},
        new Dog { Name = "Max", Age = 10},
    }
};
System.Console.WriteLine($"{owner.Name}'s Pets");
foreach (Pet p in owner.Pets)
{
    System.Console.WriteLine($"  {p.Name} is a {p.GetType().Name.ToLower()}");
};
