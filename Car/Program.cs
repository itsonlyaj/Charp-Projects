namespace Car;

class Program
{
    static void Main(string[] args)
    {
        // Creates a car object.
        Car car1 = new Car("2004", "Impala", 0);

        // Will run the accelerate method ten times until the speed is equal to 50.
        for (int i = 0; i < 10; i++)
        {
            car1.Accelerate();
            Console.WriteLine($"{car1.Make} is going {car1.Speed} MPH");
        }

        // Will run the brake method ten times until the car comes to a complete stop.
        for (int i = 0; i < 10; i++)
        {
            car1.Brake();
            Console.WriteLine($"{car1.Make} is going {car1.Speed} MPH");

            if (car1.Speed == 0)
            {
                Console.WriteLine("The car has came to a stop!");
            }
        }
    }
}
