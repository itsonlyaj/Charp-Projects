using System.ComponentModel;

// If you want to relate something to another class, you must change the name for the namespace.
namespace Ships;

public class Ship
{
    public int Decommissoned {get; private set;}
    public string YearBuilt {get;  private set;}
    public string Name {get; private set;}

    /// <summary>
    /// Instance of a ship.
    /// </summary>
    /// <param name="yearBuilt"></param>
    /// <param name="decommissoned"></param>
    /// <param name="name"></param>
    public Ship(string yearBuilt, string name)
    {
        YearBuilt = yearBuilt;
        Name = name;
        Decommissoned = 0;
    }

    public void Decommissoined(int year)
    {
        Decommissoned = year;
    }

    /// <summary>
    /// The general information of a ship.
    /// </summary>
    /// <param name="yearBuilt"></param>
    /// <param name="name"></param>
    /// <param name="decommissoned"></param>
    /// <returns>Will return the ships name, year, and if it's been decommissoned.</returns>
    public string ShipInformation(string yearBuilt, string name, int decommissoned)
    {
        string result;

        result = $"Ship name: {name}\nYear Built: {yearBuilt}\n";
        Console.WriteLine(result);

        if (decommissoned > 0)
        {
            result += $"Decommissoned: {decommissoned}";
            Console.WriteLine(result);
        }
        else
        {
            result += "Active";
            Console.WriteLine(result);
        }

        return result;
    }
}