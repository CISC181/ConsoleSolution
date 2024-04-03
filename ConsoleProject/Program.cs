// See https://aka.ms/new-console-template for more information
using ConsoleProject.Code;

Console.WriteLine("Hello, World!");


//  Create a rectangle, show the area
Rectangle rec1 = new Rectangle(0, 0, 10, 30);
Console.WriteLine(rec1.area());

//  Create a shape, show the area
Shape s1 = new Rectangle(0, 0, 20, 40);
Console.WriteLine(s1.area());
 

//  Create a list of shapes, add four shapes, then sum up the area
List<Shape> shapes = new List<Shape>();
shapes.Add(new Circle(0, 0, 10));
shapes.Add(new Circle(0, 0, 15));
shapes.Add(new Circle(0, 0, 22));
shapes.Add(new Circle(0, 0, 30));

double totArea = 0;
foreach (var c in shapes)
{
    totArea += c.area();
}
Console.WriteLine($"Total area of all circles: {totArea.ToString()}");





