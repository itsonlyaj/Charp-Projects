using Ships;

namespace Ships;

public class CargoShip : Ship
{
    public int CargoCapacity {get; set;}

    /// <summary>
    /// Creates an instance for a cargo ship.
    /// </summary>
    /// <param name="yearBuilt"></param>
    /// <param name="name"></param>
    /// <param name="cargoCap"></param>
    public CargoShip(string yearBuilt, string name, int cargoCap) : base(yearBuilt, name)
    {
        CargoCapacity = cargoCap;
    }

    /// <summary>
    /// General information for a cargo ship.
    /// </summary>
    /// <param name="name"></param>
    /// <param name="yearBuilt"></param>
    /// <param name="decommissoned"></param>
    /// <param name="cargoCap"></param>
    /// <returns>Returns the name of the ship, the year it was built, the cargo capacity, and if it's decommissoned.</returns>
    public string CargoShipInformation(string name, string yearBuilt, int decommissoned, int cargoCap)
    {
        string result;

        result = $"Cruise Ship Name: {name}\nYear Built: {yearBuilt}\n Max Passengers: {cargoCap}\n";

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