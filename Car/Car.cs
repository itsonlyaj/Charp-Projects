using System.Linq.Expressions;

namespace Car;

public class Car
{
    public string YearModel { get; set; }
    public string Make { get; set; }
    public int Speed { get; set; }

    /// <summary>
    /// Creates an instance of the car class.
    /// </summary>
    /// <param name="yearModel"></param>
    /// <param name="make"></param>
    /// <param name="speed"></param>
    public Car(string yearModel, string make, int speed)
    {
        YearModel = yearModel;
        Make = make;
        Speed = speed;
    }

    /// <summary>
    /// Accelerate the car by 10 MPH.
    /// </summary>
    public void Accelerate()
    {
        Speed += 5;
    }

    /// <summary>
    /// Decreases the speed until the car comes to a complete stop.
    /// </summary>
    public void Brake()
    {
        if (Speed >= 5)
        {
            Speed -= 5;
        }
        else
        {
            Speed = 0;
        }
    }
}