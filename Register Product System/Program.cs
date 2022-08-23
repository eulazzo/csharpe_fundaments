/*

class MainClass
{
  private static List<Product> products = new List<Product>();
  public static void Main(string[] args)
  {
    // Product product1 = new Product("Apple", 3434.3, "_344535");
    string? commandChoosen = "";

    do
    {
      Console.Clear();
      Console.WriteLine("Choose an option: ");
      Console.WriteLine("1 - Register a product");
      Console.WriteLine("2 - List all products");
      Console.WriteLine("0 - Exit");

      Console.Write("Option choosed: ");
      commandChoosen = Console.ReadLine();
      switch (commandChoosen)
      {

        case "1":
          Console.Write($"\nProduct Name: ");
          string? name = Console.ReadLine();
          Console.Write($"\nProduct Price: ");
          string? price = Console.ReadLine();
          string id = Guid.NewGuid().ToString("N");
          Product newProduct = new Product(name, Convert.ToDouble(price), id);
          products.Add(newProduct);
          Console.WriteLine($"\nProduct Added successfully");
          break;
        case "2":
          if (products.Count > 0)
          {
            Console.WriteLine($"\nAll Products");
            foreach (Product product in products)
            {
              Console.WriteLine(product.getProductDetails());
            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
          }
          else
          {
            Console.WriteLine("There are no products ");
          }
          break;
        case "0":
          Console.WriteLine("Your Choose to exit our program!");
          Console.WriteLine("Thanks for using our service");
          commandChoosen = "0";
          break;
        default:
          Console.WriteLine($"\nInvalid Command!");
          break;
      }
    } while (commandChoosen != "0");
  }

  public string generateID()
  {
    return Guid.NewGuid().ToString("N");
  }


}

*/