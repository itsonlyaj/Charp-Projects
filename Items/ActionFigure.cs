namespace Items;

public class ActionFigure : Item
{
    private string Material {get; set;}
    private string Brand {get; set;}

    /// <summary>
    /// Creates an instance of the action figure, and relates to the item class.
    /// </summary>
    /// <param name="name"></param>
    /// <param name="description"></param>
    /// <param name="price"></param>
    /// <param name="material"></param>
    /// <param name="brand"></param>
    public ActionFigure(string name, string description, double price, string material, string brand) : base(name, description, price)
    {
        Material = material;
        Brand = brand;
    }

    /// <summary>
    /// Method to display the figure for the main method.
    /// </summary>
    public void DisplayFigures()
    {
        DisplayItem();
        Console.WriteLine($"Figure Material: {Material}\nBrand: {Brand}\n");
    }
}