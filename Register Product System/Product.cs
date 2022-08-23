/*

using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class Product
{
  private string name;
  private double price;

  public int Stock { get; private set; }
  public string Id { get; set; }
  public double Price
  {
    get { return price; }
    set
    {
      if (value > 0)
      {
        price = value;
      }
      else
      {
        throw new Exception("Price must be greater than zero!");
      }
    }
  }
  public string Name
  {
    get { return name; }
    set
    {
      if (value.Length > 1)
      {
        name = value;
      }
      else
      {
        throw new Exception("Product name cannot be empty or at leats 2 caracteres... ");
      }
    }
  }

  public Product(string name, double price,string Id)
  {
    this.Name = name;
    this.Id = Id;
    this.Price = price;
    this.Stock = 0;
  }

  public int Sell(int quantity)
  {
    if (this.Stock - quantity >= 0)
    {
      this.Stock -= quantity;
      return this.Stock;
    }
    else
    {
      throw new Exception("Stock does not have this quantity available");
    }
  }

  public int Buy(int quantity)
  {
    this.Stock += quantity;
    return this.Stock;
  }


  public string getProductDetails()
  {
    StringBuilder sb = new StringBuilder();
    sb.Append($"\n Name: {this.Name}");
    sb.Append($"\n Id: {this.Id}");
    sb.Append($"\n Price: {this.Price}");
    sb.Append($"\n Stock: {this.Stock}");

    return sb.ToString();
  }

}

*/