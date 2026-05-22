namespace Ships;

class Program
{
    static void Main(string[] args)
    {
        // The total amount of ships that will be in the array.
        int totalShips = 6;


        Ship[] ships = new Ship[totalShips];

        // Stores each ship object into an array.
        ships[0] = new Ship("1960", "Explore");
        ships[0].Decommissoined(1980);
        ships[1] = new Ship("2002", "Royal of The Seas");

        ships[2] = new CruiseShip("1911", "Titanic", 2400);
        ships[2].Decommissoined(1912);
        ships[3] = new CruiseShip("1998", "Disney Magic", 2713);

        ships[4] = new CargoShip("2018", "Ever Given", 220000);
        ships[5] = new CargoShip("2013", "Maersk Mc-Kinney Moller", 194000);

        // Outputs the ship information into the console.
        // NOTE: The first two ships will display twice, I will fix that in the future.
        foreach (Ship ship in ships)
        {
            if (ship is CruiseShip cruiseShip)
            {
                cruiseShip.CruiseShipInforMation(cruiseShip.Name, cruiseShip.YearBuilt, cruiseShip.MaxPassengers, cruiseShip.Decommissoned);
            }
            else if (ship is CargoShip cargoShip)
            {
                cargoShip.CargoShipInformation(cargoShip.Name, cargoShip.YearBuilt, cargoShip.Decommissoned, cargoShip.CargoCapacity);
            }
            else
            {
                ship.ShipInformation(ship.YearBuilt, ship.Name, ship.Decommissoned);
            }
        }
    }
}
