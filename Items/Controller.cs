namespace Items;

public class Controller : Item
{
    private string ControllerType {get; set;}
    private string ControllerBrand {get; set;}

    /// <summary>
    /// Creates an instance of the controller class, that relates to the item class.
    /// </summary>
    /// <param name="name"></param>
    /// <param name="description"></param>
    /// <param name="price"></param>
    /// <param name="controllerType"></param>
    /// <param name="controllerBrand"></param>
    public Controller(string name, string description, double price, string controllerType, string controllerBrand) : base(name, description, price)
    {
        ControllerType = controllerType;
        ControllerBrand = controllerBrand;
    }

    /// <summary>
    /// Displays the information of the controller.
    /// </summary>
    public void DisplayController()
    {
        DisplayItem();
        Console.WriteLine($"Controller Type: {ControllerType}\nController Brand: {ControllerBrand}\n");
    }
}