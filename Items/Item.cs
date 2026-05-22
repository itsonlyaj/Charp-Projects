namespace Items;

public abstract class Item
{
    public string Name {get; set;}
    public string Description {get; set;}
    public double Price {get; set;}

    /// <summary>
    /// Creates an instance of the item class.
    /// </summary>
    /// <param name="name"></param>
    /// <param name="description"></param>
    /// <param name="price"></param>
    public Item(string name, string description, double price)
    {
        Name = name;
        Description = description;
        Price = price;
    }
    public void DisplayItem()
    {
        Console.WriteLine($"Name: {Name}\n Description: {Description}\n Price: {Price}");
    }
}