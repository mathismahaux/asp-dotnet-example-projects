using System;

namespace MoneyMaker
{
  class MainClass
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Welcome to Money Maker!");
      Console.WriteLine("Enter an amount to convert to coins:");
      double amount = Convert.ToDouble(Console.ReadLine());
      Console.WriteLine($"{amount} cents is equal to...");
      
      int goldCoin = 10;
      int silverCoin = 5;

      double goldCoins = Math.Floor(amount/goldCoin);

      double remainder = amount % goldCoin;

      double silverCoins = Math.Floor(remainder/silverCoin);

      remainder = remainder % silverCoin;

      Console.WriteLine($"{goldCoins} gold coins");
      Console.WriteLine($"{silverCoins} silver coins");
      Console.WriteLine($"{remainder} bronze coins");
    }
  }
}
