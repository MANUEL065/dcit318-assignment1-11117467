using System;

class TicketPriceCalculator
{
    static void Main()
    {
        Console.Write("Enter your age: ");
        int age = int.Parse(Console.ReadLine());

        int basePrice = 10;
        int discount = 3;
        int ticketPrice;

        if (age <= 12 || age >= 65)
            ticketPrice = basePrice - discount;
        else
            ticketPrice = basePrice;

        Console.WriteLine($"Your ticket price is: GHC{ticketPrice}");
    }
}
