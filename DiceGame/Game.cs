using System.Data;

namespace DiceGame;

public class Game
{
    public Dice Dice {get; set;}
    public int Result {get; private set;}
    public List<int> RollHistory {get; private set;}
    public int TotalRolls {get; private set;}
    public int PreviousRolls {get; private set;}

    /// <summary>
    /// Creates an instance of the game class.
    /// </summary>
    /// <param name="dice"></param>
    /// <param name="result"></param>
    /// <param name="rollHistory"></param>
    /// <param name="totalRolls"></param>
    /// <param name="previousRolls"></param>
    public Game(Dice dice)
    {
        Dice = dice;
        RollHistory = new List<int>();
    }

    /// <summary>
    /// Method that will be called when the round is played.
    /// </summary>
    public void PlayRound()
    {
        Result = Dice.Roll();

        RollHistory.Add(Result);

        TotalRolls++;
        PreviousRolls++;

        Console.WriteLine($"You rolled a {Result}");
    }

    /// <summary>
    /// Method that will shows the statistics for when the user rolled the dice.
    /// </summary>
    public void ShowStats()
    {
        Console.WriteLine("==================================");
        Console.WriteLine($"You rolled the dice {TotalRolls} times.");
        Console.WriteLine($"The hightst number you rolled was {RollHistory.Max()}.");
        Console.WriteLine($"The lowest number you rolled was {RollHistory.Min()}.");
        Console.WriteLine("==================================");
    }
}