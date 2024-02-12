using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("How much did you receive money ($)? ");
        int totalMoney = int.Parse(Console.ReadLine());

        // Calculate three quarters of the total money for books and supplies
        int booksAndSupplies = totalMoney * 3 / 4;

        // Calculate the remaining quarter
        int remainingMoney = totalMoney - booksAndSupplies;

        //Divide the remaining money in  equal parts
        int moneyForEachItem = remainingMoney / 3;

        // Calculate the cost of each item
        int coffeeCost = 2;
        int flashComputerCost = 4;
        int subwayTicketCost = 3;

        // Calculate the quantity of each item
        int coffees = moneyForEachItem / coffeeCost;
        int flashComputers = moneyForEachItem / flashComputerCost;
        int subwayTickets = moneyForEachItem / subwayTicketCost;

        // Calculate the total spent on coffees, flash computers, and subway tickets
        int totalSpent = coffees * coffeeCost + flashComputers * flashComputerCost + subwayTickets * subwayTicketCost;

        // Calculate the remaining money for white roses
        int remainingForRoses = remainingMoney - totalSpent;

        Console.WriteLine($"Book and Supplies: {booksAndSupplies} $");
        Console.WriteLine("You can then buy:");
        Console.WriteLine($"{coffees} coffees");
        Console.WriteLine($"{flashComputers} Flash Computer Numbers");
        Console.WriteLine($"{subwayTickets} subway Tickets");
        Console.WriteLine($"and you will have {remainingForRoses} dollars for the white roses.");
    }
}
