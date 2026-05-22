namespace PaintJob;

class Program
{
    static void Main(string[] args)
    {
        double squareFeet = 101.00;
        double laborHours = 10.00;
        double ratePerHour = 17.50;
        double wallSpace = 0;

        int numOfRooms;
        double pricePerGallon;
        double gallonsRequired;
        double _LaborHours;
        double painCost;
        double charges;
        double total;

        Console.Write("How many rooms do you want to paint: ");
        numOfRooms = Convert.ToInt32(Console.ReadLine());

        Console.Write("What's the price per gallon: ");
        pricePerGallon = Convert.ToDouble(Console.ReadLine());

        // Will ask the user to enter the square feet of the room based on the number of rooms the user entered.
        for (int i = 0; i <= numOfRooms; i++)
        {
            Console.Write("Enter the square feet of wall space in each room: ");
            wallSpace += Convert.ToDouble(Console.ReadLine());
        }

        gallonsRequired = CalculateGallons(wallSpace, squareFeet);
        _LaborHours = CalculateLaborHours(gallonsRequired, laborHours);
        painCost = CalculatePaintCost(gallonsRequired, pricePerGallon);
        charges = CalculateCharges(laborHours, ratePerHour);
        total = painCost + charges;

        Console.WriteLine($"Gallons of paint required: {gallonsRequired}");
        Console.WriteLine($"Labor hours required: {_LaborHours}");
        Console.WriteLine($"Cost of paint: {painCost}");
        Console.WriteLine($"Labor charges: {charges}");
        Console.WriteLine($"Total cost of the paint job: {total}");

    }

    /// <summary>
    /// Calculates the how many gallons of paint are required,
    /// </summary>
    /// <param name="wallSpace"></param>
    /// <param name="sqaureFeetPerGallon"></param>
    /// <returns>The required gallons of paint.</returns>
    public static double CalculateGallons(double wallSpace, double sqaureFeetPerGallon)
    {
        return wallSpace / sqaureFeetPerGallon;
    }

    /// <summary>
    /// Calculates the labor hours.
    /// </summary>
    /// <param name="gallonsRequired"></param>
    /// <param name="laborHoursPerGallon"></param>
    /// <returns>The labor hours that are required.</returns>
    public static double CalculateLaborHours(double gallonsRequired, double laborHoursPerGallon)
    {
        return gallonsRequired * laborHoursPerGallon;
    }

    /// <summary>
    /// Calcualtes the paint cost.
    /// </summary>
    /// <param name="gallonsRequired"></param>
    /// <param name="pricePerGallon"></param>
    /// <returns>The calculated amount of paint.</returns>
    public static double CalculatePaintCost(double gallonsRequired, double pricePerGallon)
    {
        return gallonsRequired * pricePerGallon;
    }

    /// <summary>
    /// Calculates the total charges.
    /// </summary>
    /// <param name="laborHours"></param>
    /// <param name="ratePerHour"></param>
    /// <returns>Total amount of charges for the paint job.</returns>
    public static double CalculateCharges(double laborHours, double ratePerHour)
    {
        return laborHours * ratePerHour;
    }
}
