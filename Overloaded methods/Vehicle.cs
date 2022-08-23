/*
//Overloaded Contructores is basically when we have many arguments with different types: (int x,string y, double z) etc...

using System.Text;
using System.Threading;

namespace Acourse
{

  public enum VehicleColor
  {
    white,
    black,
    red,
    gray
  }
  public class Vehicle
  {
    public string Model { get; set; }
    public int Weight { get; set; }
    public double Speed { get; set; }
    public int Doors { get; set; } = 4;
    public VehicleColor Color { get; set; }
    public int Row { get; set; } = 1;

    public Vehicle(string model)
    {
      this.Model = model;
      this.Speed = 0;
    }

    public Vehicle(string model, VehicleColor cor) : this(model)
    {
      this.Color = cor;
    }

    public Vehicle(string model, VehicleColor cor, int doors) : this(model, cor)
    {
      this.Doors = doors;
    }
    //<Summary>
    //Method for showing the vehicle info
    //<Summary>
    public string ShowVehiclesDetails()
    {
      StringBuilder sb = new StringBuilder();
      sb.Append(String.Format($"Vehicle Info\n"));
      sb.Append(String.Format($"Model: {this.Model}\n"));
      sb.Append(String.Format($"Color: {this.Color}\n"));
      sb.Append(String.Format($"Doors: {this.Doors}\n"));

      return sb.ToString();
    }

    public string ShowVehiclesDetails(int row)
    {
      StringBuilder sb = new StringBuilder();
      sb.Append(String.Format($"{row} - Vehicle :: {this.Model} - Color:: {this.Color} - Doors :: {this.Doors} :: Speed: {this.Speed}\n"));

      return sb.ToString();
    }

    //<Summary>
    // Method to get the speed up of the vehicle.
    //<Summary>
   
    public void SpeedUp()
    {
      this.Speed += 10;
    }
    //<Summary>
    // Method to get the speed up of the vehicle.
    //<Summary>
    //<param name="addition">
    public void SpeedUp(int addition)
    {
      this.Speed += addition;
    }
    //<Summary>
    // Method to get the speed up of the vehicle based on the time passed
    //<Summary>
    // <param name="addition">
    public void SpeedUp(int acresPerSecond, double timeInSeconds)

    {
      DateTime start = DateTime.Now;
      DateTime end = start.AddSeconds(timeInSeconds);

      while (start < end)
      {
        this.Speed += acresPerSecond;
        Thread.Sleep(1000);
        Console.WriteLine($"Current Speed: {this.Speed:F2}");

        start = start.AddSeconds(1.0);
      }

    }
  }
}
*/