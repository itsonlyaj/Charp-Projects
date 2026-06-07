namespace DiceGame;

class Program
{
    /// <summary>
    /// Method that runs the entire program.
    /// </summary>
    /// <param name="args"></param>
    static void Main(string[] args)
    {
        Dice dice = new Dice(6);    // Dice object that displays how many sides it should have.
        Game game = new Game(dice); // The game object that holds the dice.

        bool gameRunning = true;
        int userInput;

        Console.WriteLine("Welcome to a game of dice!");
        Console.WriteLine("Instructions:");
        Console.WriteLine("You will be asked to roll a dice, then the program will return the number you rolled.");
        Console.WriteLine("It's very simple! It's very basic to understand!");
        Console.WriteLine("You also choose to display your stats for how many times you rolled, and the highest and lowest numbers\n" + 
        "you rolled.");
        Console.WriteLine("So, what would you like to do?");
        Console.WriteLine();

        while (gameRunning)
        {
            Console.WriteLine("1. Roll the dice.");
            Console.WriteLine("2. Display statistics.");
            Console.WriteLine("3. Exit.");

            userInput = Convert.ToInt32(Console.ReadLine());

            switch (userInput)
            {
                case 1:
                    game.PlayRound();
                    break;
                case 2:
                    game.ShowStats();
                    break;
                case 3:
                    gameRunning = false;
                    break;
                default:
                    Console.WriteLine("Invalid input!");
                    break;
            }
        }
    }
}
