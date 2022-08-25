namespace Acourse
{
  public class Bus : Vehicle
  {
    private int capacity;
    public override int Capacity
    {
      get { return capacity; }
      set
      {
        if (value >= 18 && value <= 60)
          capacity = value;
        else
          throw new Exception("The bus can only have between 18 and 60 people");
      }

    }

    public override void ToFuel(double quantity)
    {
      GasQuantity += quantity;
      Console.WriteLine($"Bus fueld with {quantity} liters");

    }

    //new keyword disconsidered the stop method from Car classe.
    public new void Stop()
    {
      Console.WriteLine($"brakes activated...Bus stop.");
    }

    public override void Move(double distanceInKm)
    {
      if (GasQuantity < distanceInKm / 5)
      {
        GasQuantity -= distanceInKm / 5;
        Console.WriteLine($"Car moved {distanceInKm} km");

      }
      else
      {
        this.ToFuel(100);

      }
    }

    public Bus(int weight, DateTime madeOfDate, int capacity = 44) : base(weight, madeOfDate)
    {
      this.Capacity = capacity;
    }

  }
}