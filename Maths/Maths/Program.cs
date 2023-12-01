using Maths;
using Maths.Shapes;
using Maths.Interface;

public class Program
{
    //List that stores objects associated with IShape interface
    static List<IShape> shapesList = new List<IShape>();

    public static void Main(string[] args)
    {
        //Object of shapes
        Circle circle = new Circle(5);
        Square square = new Square(5);

        //adding objects to the list
        shapesList.Add(circle);
        shapesList.Add(square);


        //writing the values 
        foreach(var shape in shapesList)
        {
            Console.WriteLine($"Area of {shape.ShapeName}: {shape.Area}");
            Console.WriteLine($"Perimeter of {shape.ShapeName}: {shape.Perimeter}");

            Console.WriteLine(); //leave a line for better formatting
        }
    }
}