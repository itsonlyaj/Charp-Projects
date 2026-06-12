namespace MathQuiz;

class Program
{
    static void Main(string[] args)
    {
        int num1;
        int num2;
        double num3;
        int questionsCorrect = 0;
        int questionsIncorrect = 0;
        int attempts = 0;
        bool questionOne = true;
        bool questionTwo = true;
        bool questionThree = true;

        while (questionOne)
        {
            Console.Write("What is 2 + 2 = ");
            num1 = Convert.ToInt32(Console.ReadLine());

            if (num1 == 4)
            {
                Console.WriteLine("You got it correct!");
                questionsCorrect++;
                questionOne = false; 
                break;   
            }
            else
            {
                Console.WriteLine("You're wrong, try again!");
                attempts++;
            }

            if (attempts == 3)
            {
                Console.WriteLine("The correct answer was 4!");
                questionsIncorrect++;
                attempts = 0;
                questionOne = false;
                break;  
            }      
        }

        while (questionTwo)
        {
            Console.Write("What is 6 + 2 - 4 * 12 = ");
            num2 = Convert.ToInt32(Console.ReadLine());

            if (num2 == -40)
            {
                Console.WriteLine("You got it correct!");
                questionsCorrect++;
                questionOne = false; 
                break;   
            }
            else
            {
                Console.WriteLine("You're wrong, try again!");
                attempts++;
            }

            if (attempts == 3)
            {
                Console.WriteLine("The correct answer was -40!");
                questionsIncorrect++;
                attempts = 0;
                questionOne = false;
                break;  
            }           
        }

        while (questionThree)
        {
            Console.Write("What is 20 * 23 / 10 + 2^3 = ");
            num3 = Convert.ToDouble(Console.ReadLine());

            if (num3 == 50)
            {
                Console.WriteLine("You got it correct!");
                questionsCorrect++;
                questionOne = false; 
                break;   
            }
            else
            {
                Console.WriteLine("You're wrong, try again!");
                attempts++;
            }

            if (attempts == 3)
            {
                Console.WriteLine("The correct answer was 50!");
                questionsIncorrect++;
                attempts = 0;
                questionOne = false;
                break;  
            }           
        }

        Console.WriteLine($"You got {questionsCorrect} questions correct!"); 
        Console.WriteLine($"You got {questionsIncorrect} questions incorrect!");     
    }
}
