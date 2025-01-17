namespace RollDice;

public class DiceSimulator
{
    public int[] SimulateRolls(int NumOfRolls)
    {
        int[] rollResults = new int[13];
        
        Random random = new Random();
        
        for (int i = 0; i < NumOfRolls; i++)
        {
            int die1 = random.Next(1, 7); // Roll the first die (1-6)
            int die2 = random.Next(1, 7); // Roll the second die (1-6)
            int sum = die1 + die2;        // Sum of the two dice
            rollResults[sum]++;          // Increment the count for this sum
        }
        
        return rollResults;
        
    }
}