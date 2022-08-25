/*

namespace Acourse
{
  class MainClass
  {
    static List<Vehicle> vehicles = new List<Vehicle>();
    static Random random = new Random();
    public static void Main(string[] args)
    {
      //Its not possible to instancied the Vehicle class, cuz is abstract 
      //  Vehicle v1 = new Vehicle(1000,DateTime(23,11,2000));


      //both car and bus are vehicle, cuz of that v2 and v3 can be types of vehicle
      Vehicle v2 = new Car(1000, DateTime.Now.Date.AddDays(-500));
      Vehicle v3 = new Bus(5000, DateTime.Now.Date.AddDays(-5400));

      // v2.ToFuel(34);
      // v3.ToFuel(56);

      // v2.Move(56);
      // v3.Move(40);

      // v2.Stop();
      // v3.Stop();

      CreateRandomVehicle();

      foreach (var v in vehicles)
      {
        Console.WriteLine($"\n-------------------------");
        Console.WriteLine($"{v.Type}");
        v.ToFuel(random.Next(10, 40));
        v.Move(random.Next(10, 200));
        v.Stop();
        Console.WriteLine($"-------------------------");

      }


    }
    static void CreateRandomVehicle()
    {
      for (int i = 0; i <= 10; i++)
      {
        if (random.Next() % 2 == 0)
          vehicles.Add(new Car(random.Next(200, 400), DateTime.Now.Date.AddDays(-random.Next(30, 4000))));
        else  
          vehicles.Add(new Bus(random.Next(4000, 6400), DateTime.Now.Date.AddDays(-random.Next(30, 400))));
      }

    }



  }


}


*/