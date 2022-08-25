/*


namespace Acourse
{
  public abstract class Vehicle
  {
    public int WeightInKg { get; set; }
    public DateTime MadeOfDate { get; set; }
    public double GasQuantity { get; set; }
    public string Type { get { return this.GetType().Name; } }
    public abstract int Capacity { get; set; }
    public abstract void ToFuel(double quantity);
    public abstract void Move(double distanceInKm);

    //virtual keyword can have implementation, abstract cannot.
    public virtual void Stop()
    {
      Console.WriteLine("Vehicle stop method.");
    }

    public Vehicle(int weight, DateTime madeofDate)
    {

      this.WeightInKg = weight;
      this.MadeOfDate = madeofDate;
    }

  }
}

*/