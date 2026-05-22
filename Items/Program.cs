using System.Diagnostics;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;

namespace Items;

class Program
{
    static void Main(string[] args)
    {
        // Objects for the three classes that relate to the item class.
        ActionFigure batmanPop = new ActionFigure("Batman", "A pop figure of everyone's favorite DC hero!", 12.49, "Vinyl", "Funko");
        ActionFigure omniMan = new ActionFigure("Omni-Man", "Are you sure?", 15.99, "Vinyl", "YouTooz");

        Dictionary<string, Food> foods = new()
        {
            {"Apple", new Food("Apple", "A sweet juicy apple with a lot of fiber", 2.49, "Fruit", "Yes")},
            {"Bananna", new Food("Bananna", "A snack filled with potassium", 2.45, "Fruit", "Yes")},
            {"Hamburger", new Food("Hamburger", "A juicy hamburger!", 5.21, "Sandwich", "No")},
            {"Cheese Pizza", new Food("Cheese Pizza", "A classic Italian dish!", 18.34, "Pizza", "No")}
        };

        Dictionary<string, Controller> controllers = new()
        {
            {"Xbox 360 Controller", new Controller("Xbox 360 Controller", "A controller that your brother had!", 26.45, "Game Controller", "Microsoft")},
            {"Samsung TV Remote", new Controller("Samsung TV Remote", "A TV Remote for switching channel's.", 14.22, "TV Remote", "Samsung")},
            {"Joycons", new Controller("Joycons", "Seperate Joycon controller's for your Nintendo Switch", 42.99, "Game Controller", "Nintendo")},
            {"Fire TV Remote", new Controller("Fire TV Remote", "Jeff", 17.99, "TV Remote", "Amazon")}
        };

        // Displays the action figures.
        batmanPop.DisplayFigures();
        omniMan.DisplayFigures();

        // Will loop through and display all of the foods in the dictionary.
        // The loop will also check to see if the food is healthy, if they are set to yes or no, it call the IsFoodHealthy method
        // From the Food class.
        foreach (var foodList in foods)
        {
            {foodList.Value.DisplayFood();}
            
            if (foodList.Value.Healthy == "Yes")
            {
                {foodList.Value.IsFoodHealthy("Yes");}
            }
            else
            {
                {foodList.Value.IsFoodHealthy("No");}
            }
        }

        // Basic foreach loop which displays the controllers in the dictionary.
        foreach (var controllerList in controllers)
        {
            {controllerList.Value.DisplayController();}
        }
    }
}