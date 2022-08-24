namespace Acourse
{
  static public class Extensions
  {
    public static bool HasOnlyNumbers(this string cpf)
    {

      const string digits = "0123456789";
      foreach (var digit in digits)
      {
        if (!digits.Contains(digit))
        {
          return false;
        }
      }
      return true;
    }
  }
}