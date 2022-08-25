/*


using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Acourse
{
  public class Car : Vehicle
  {

    public int capacity;
    public override int Capacity
    {
      get { return capacity; }
      set
      {
        if (value >= 2 && value <= 7)
        {
          capacity = value;
        }
        else
        {
          throw new Exception("Car only can have only between 2 to 7 people.");
        }
      }
    }

    public int CvPotency { get; set; }
    public override void Move(double distanceInKm)
    {
      if (GasQuantity < distanceInKm / 10)
      {
        GasQuantity -= distanceInKm / 10;
        Console.WriteLine($"Car moved {distanceInKm} km");

      }
      else
      {
        this.ToFuel(100);

      }
    }

    public override void ToFuel(double quantity)
    {
      GasQuantity += quantity;
      Console.WriteLine($"Car fueld with {quantity} liters of gas ");

    }

    public override void Stop()
    {
      Console.WriteLine($"ABS brakes activated...Car stop.");

    }

    public Car(int weightInKg, DateTime madeOfDate, int capacity = 5) : base(weightInKg, madeOfDate)
    {
      this.Capacity = capacity;
    }
  }
}

*/