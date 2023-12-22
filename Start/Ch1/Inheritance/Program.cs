// Example file for Advanced C#: Object Oriented Programming by Joe Marini
// Using inheritance to define a class hierarchy

// Instantiate some objects
Circle c = new Circle(10);
Rectangle r = new Rectangle(10, 20);
Square s = new Square(10);

// TODO: Exercise the ToString() method
System.Console.WriteLine($"{c}");
System.Console.WriteLine($"{r}");

// TODO: Use the "is" operator to test an object type
System.Console.WriteLine($"{c is Shape2D}");
System.Console.WriteLine($"{c is Rectangle}");

// TODO: Call the GetArea() function on each one
System.Console.WriteLine(c.GetArea());
System.Console.WriteLine(r.GetArea());
System.Console.WriteLine(s.GetArea());

// TODO: Print the area of each shape
void PrintArea(Shape2D shape)
{
    System.Console.WriteLine($"Area of {shape} is {shape.GetArea()}");
}

// TODO: All of the classes derive from Shape2D, so we can treat each one
// as an instance of the base class. 
PrintArea(c);
PrintArea(r);
PrintArea(s);
