using Ships;

namespace Ships;

public class CruiseShip : Ship
{
    public int MaxPassengers {get; set;}

    /// <summary>
    /// Creates an instance for a cruise ship.
    /// </summary>
    /// <param name="decommissoned"></param>
    /// <param name="yearBuilt"></param>
    /// <param name="name"></param>
    /// <param name="maxPassengers"></param>
    public CruiseShip(string yearBuilt, string name, int maxPassengers) : base(yearBuilt, name)
    {
        MaxPassengers = maxPassengers;
    }

    /// <summary>
    /// General information of a cruise ship.
    /// </summary>
    /// <param name="name"></param>
    /// <param name="yearBuilt"></param>
    /// <param name="maxPassengers"></param>
    /// <param name="decommissoned"></param>
    /// <returns>Returns the ships name, year built, the maximum number of passengers, and if the ship is
    /// decommissoned.</returns>
    public string CruiseShipInforMation(string name, string yearBuilt , int maxPassengers, int decommissoned)
    {
        string result;

        result = $"Cruise Ship Name: {name}\nYear Built: {yearBuilt}\n Max Passengers: {maxPassengers}\n";

        if (decommissoned > 0)
        {
            result += $"Decommissoined: {decommissoned}";
            Console.WriteLine(result);
        }
        else
        {
            result += "Active.";
            Console.WriteLine(result);
        }

        return result;
    }
}