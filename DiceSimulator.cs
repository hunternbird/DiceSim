namespace RollDice;

public class DiceSimulator
{
    public int[] SimulateRolls(int NumOfRolls)
    {
        int[] rollResults = new int[13];
        
        Random random = new Random();
        
        for (int i = 0; i < NumOfRolls; i++)
        {
            int die1 = random.Next(1, 7); 
            int die2 = random.Next(1, 7); 
            int sum = die1 + die2;        
            rollResults[sum]++;          
        }
        
        return rollResults;
        
    }
}