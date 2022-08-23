 
public class Car : Vehicle
{
  public int Doors { get; set; }
  public double Price { get; set; }
  public string Model { get; set; }

  public Car()
  {
    Console.WriteLine("A new car has been created");
  }


  //Here we call the constructor from the parent class.
  public Car(int weigthKg) : base(weigthKg)
  {
    Console.WriteLine("A weight for car has been added");

  }

  public Car(string model) : this()
  {
    this.Model = model;
  }

  public Car(string model, int doors, double price) : this(model)
  {
    this.Doors = doors;
    this.Price = price;
  }

  ~Car()
  {
    Console.WriteLine("An object of type car has been destroyed");
  }
}
