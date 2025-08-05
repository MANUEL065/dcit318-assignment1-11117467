using System;

class TriangleTypeIdentifier
{
    static void Main()
    {
        Console.Write("Enter length of side A: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Enter length of side B: ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Enter length of side C: ");
        double c = double.Parse(Console.ReadLine());

        if (a == b && b == c)
        {
            Console.WriteLine("Triangle Type: Equilateral");
        }
        else if (a == b || b == c || a == c)
        {
            Console.WriteLine("Triangle Type: Isosceles");
        }
        else
        {
            Console.WriteLine("Triangle Type: Scalene");
        }
    }
}
