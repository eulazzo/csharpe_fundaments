/*


namespace Acourse
{
  public class Person
  {
    private string cpf;
    public string Cpf
    {
      get { return cpf; }
      set
      {
        if ((value.Length == 11) && value.HasOnlyNumbers())
          cpf = value;
        else
          throw new Exception("Cpf invalid");
      }
    }
    public string Name { get; set; }
    public string LastName { get; set; }
    public DateTime BirthDate { get; set; }
    public double Weight { get; set; }
    public double Height { get; set; }

    public double Imc { get { return Math.Truncate(this.Weight / (this.Height * this.Height)); } }

    public Person(string name, string lastName, DateTime birthDate, string cpf)
    {
      this.Name = name;
      this.LastName = lastName;
      this.BirthDate = birthDate;
      this.Cpf = cpf;
    }

    public Person(string name, string lastName, DateTime birthDate,
    string cpf, double weight, double height) : this(name, lastName, birthDate, cpf)
    {
      this.Height = height;
      this.Weight = weight;
    }

    public void Eat(double weightKg)
    {
      this.Weight += weightKg / 10;
      Console.WriteLine($"{this.Name} {this.LastName} eat {weightKg} kg of food");
    }
    public void Eat(int calories)
    {
      this.Weight += (calories / 30000);
      Console.WriteLine($"{this.Name} {this.LastName} eat {calories} calories");
    }

    public void ShowPersonInfo()
    {
      Console.WriteLine($"***** Person Info *****");
      Console.WriteLine($"\nFull Name: {this.Name} {this.LastName}");
      Console.WriteLine($"Age: {Math.Truncate((DateTime.Now - this.BirthDate).TotalDays / 365.25)}");
      Console.WriteLine($"Imc: {this.Imc}");
      Console.WriteLine($"Imc: {this.Cpf}");

    }
  }
}

*/