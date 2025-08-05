using System;

public class TriangleTypeIdentifier
{
    public static void Run()
    {
        Console.Write("Enter side 1: ");
        double side1 = double.Parse(Console.ReadLine() ?? "0");

        Console.Write("Enter side 2: ");
        double side2 = double.Parse(Console.ReadLine() ?? "0");

        Console.Write("Enter side 3: ");
        double side3 = double.Parse(Console.ReadLine() ?? "0");

        if (side1 == side2 && side2 == side3)
        {
            Console.WriteLine("The triangle is equilateral.");
        }
        else if (side1 == side2 || side1 == side3 || side2 == side3)
        {
            Console.WriteLine("The triangle is isosceles.");
        }
        else
        {
            Console.WriteLine("The triangle is scalene.");
        }
    }
}
