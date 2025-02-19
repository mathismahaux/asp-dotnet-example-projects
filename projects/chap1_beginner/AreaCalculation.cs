using System;

namespace ArchitectArithmetic
{
  class Program
  {
    public static void Main(string[] args)
    {
      double totalArea = 0;
      totalArea += Rectangle(2500, 1500);
      totalArea += Triangle(750, 500);
      totalArea += (Circle(375) / 2);
      Console.WriteLine($"Total area: {totalArea} m²");

      double totalPrice = Math.Round(totalArea * 180, 2);
      Console.WriteLine($"Total price: {totalPrice} Mexican pesos");

    }

    static double Rectangle(double length, double width)
    {
      return length * width;
    }

    static double Circle(double radius)
    {
      return Math.PI * (Math.Pow(radius, 2));
    }

    static double Triangle(double bottom, double height)
    {
      return 0.5 * bottom * height;
    }
  }
}
