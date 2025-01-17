// See https://aka.ms/new-console-template for more information

namespace RollDice;

internal class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("How many dice rolls do you want to simulate?");
        int NumOfRolls = int.Parse(Console.ReadLine());


        DiceSimulator simulator = new DiceSimulator();
        
        int[] rollResults = simulator.SimulateRolls(NumOfRolls);
        
        Console.WriteLine("\nDICE ROLLING SIMULATION RESULTS");
        Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
        Console.WriteLine($"Total number of rolls = {NumOfRolls}.\n");

        for (int i = 2; i <= 12; i++) // Only display results for sums 2-12
        {
            double percentage = (rollResults[i] / (double)NumOfRolls) * 100;
            int stars = (int)Math.Round(percentage); // Each star represents 1%
            
            Console.WriteLine($"{i}: {new string('*', stars)}");
        }
        
        Console.WriteLine("\nThank you for using the dice throwing simulator. Goodbye!");
        
    }
}