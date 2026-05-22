namespace Items;

public class Food : Item
{
    public string FoodType {get; set;}
    public string Healthy {get; set;}

    /// <summary>
    /// Creates an instance of the food class, and relates to the item class.
    /// </summary>
    /// <param name="name"></param>
    /// <param name="description"></param>
    /// <param name="price"></param>
    /// <param name="foodType"></param>
    /// <param name="healthy"></param>
    public Food(string name, string description, double price, string foodType, string healthy) : base(name, description, price)
    {
        FoodType = foodType;
        Healthy = healthy;
    }

    /// <summary>
    /// Displays the food information for the main method.
    /// </summary>
    public void DisplayFood()
    {
        DisplayItem();
        Console.WriteLine($"Food Type: {FoodType}\n Healthy: {Healthy}");
    }

    /// <summary>
    /// Will try to see if a certain food is healthy for the user.
    /// </summary>
    /// <param name="healthy"></param>
    /// <returns>Will return a string to see of the food is healthy or not.</returns>
    public string IsFoodHealthy(string healthy)
    {
        string result;

        if (healthy == "Yes")
        {
            result = $"This food healthy!\n";
            Console.WriteLine(result);
        }
        else
        {
            result = $"This food isn't healthy\n";
            Console.WriteLine(result);
        }

        return result;
    }
}