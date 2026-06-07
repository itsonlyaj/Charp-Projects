namespace DiceGame;

public class Dice
{
    public int Sides {get; set;}

    /// <summary>
    /// Create's an instance of a dice.
    /// </summary>
    /// <param name="sides"></param>
    public Dice(int sides)
    {
        Sides = sides;
    }

    /// <summary>
    /// Method to roll the dice itself.
    /// </summary>
    /// <returns>A number between 1 - 6.</returns>
    public int Roll()
    {
        int amount;
        Random random = new Random();

        amount = random.Next(1, 6); // Will randomize a number between 1 - 6.

        Console.WriteLine(amount);

        return amount;
    }
}
