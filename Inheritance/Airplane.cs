/*

namespace Acourse
{
  public class Airplane : Vehicle
  {
    public int Passengers { get; set; }
    public double Altitud { get; set; }

    public Airplane(double weigth, double height, double width, double Length, int passengers) : base(weigth, height, width, Length)
    {
      this.Passengers = passengers;
      this.Altitud = 0;
      Console.WriteLine("An airplane of type Airplane was created!");
    }

    ~Airplane()
    {
      Console.WriteLine("An airplane of type Airplane was destroyed!");
    }

    public void Fly(int distance)
    {
      //Decolar
      this.TakeOff(distance);
      double distanceTraveled = 0;
      while (distanceTraveled < distance)
      {
        Console.WriteLine($"Our Airplane are {(distance - distanceTraveled):F2} meters from our destination.");

        distanceTraveled += 220;
        Thread.Sleep(1000);
      }
      //Pousar
      this.Land();

    }

    private void Land()
    {
      while (this.Altitud < 0)
      {
        Console.WriteLine($"Our Airplane are {this.Altitud:F2} meters of altitud.");

        this.Altitud -= 60;
        this.Altitud = this.Altitud < 0 ? 0 : this.Altitud;
        Thread.Sleep(1000);
      }
      Console.WriteLine($"We have arived! Airplane is landed.");
      Thread.Sleep(500);

    }

    private void TakeOff(int altitud)
    {
      while (this.Altitud < altitud)
      {
        Console.WriteLine($"Our Airplane are {this.Altitud:F2} meters of altitud.");

        this.Altitud += 60;
        Thread.Sleep(1000);
      }
      Console.WriteLine($"Take off successfully");

    }
  }
}
*/