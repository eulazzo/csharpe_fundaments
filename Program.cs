class MainClass
{
  static void CreateCar()
  {
    Car car = new Car();
    Car car2 = new Car("Vectra", 4, 3143.3);
    Car car3 = new Car(10);
    Console.WriteLine(car3.WeigthKg);
    
  }
  public static void Main(string[] args)
  {

    CreateCar();

    GC.Collect();
  }


}