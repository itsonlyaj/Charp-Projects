using System.ComponentModel;

namespace Ships;

public abstract class Ship
{
    private int Decommissoned {get; set;}
    private string YearBuilt {get; set;}
    private string Name {get; set;}

    /// <summary>
    /// Instance of a ship.
    /// </summary>
    /// <param name="yearBuilt"></param>
    /// <param name="decommissoned"></param>
    /// <param name="name"></param>
    public Ship(int decommissoned, string yearBuilt, string name)
    {
        Decommissoned = decommissoned;
        YearBuilt = yearBuilt;
        Name = name;
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