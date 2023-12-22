// Example file for Advanced C#: Object Oriented Programming by Joe Marini
// Defining and instantiating classes

// TODO: Create some new Rectangle objects with dimensions
Rectangle rect1 = new Rectangle(10, 20);
Rectangle rect2 = new Rectangle(30);

System.Console.WriteLine(rect1.GetArea());
System.Console.WriteLine(rect2.GetArea());

// TODO: Change the values of width and height
rect2.width = 5;
rect2.height = 7;
System.Console.WriteLine(rect2.GetArea());