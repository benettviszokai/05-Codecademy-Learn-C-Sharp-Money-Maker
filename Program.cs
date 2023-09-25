using System;

namespace MoneyMaker
{
  class MainClass
  {
    public static void Main(string[] args)
    {
      // Greeting the user
      Console.WriteLine("Welcome to Money Maker!");

      // Storing the coins
      double goldCoin = 10;
      double silverCoin = 5;
      
      // Amount to convert
      Console.WriteLine("Please enter the amount to convert to coins: ");
      double amountToConvert = Convert.ToDouble(Console.ReadLine());

      // What the program is going to do...
      Console.WriteLine($"{amountToConvert} coins is equal to...");

      // Converting
      double goldCoins = Math.Floor((amountToConvert / goldCoin));
      double remaining = amountToConvert % goldCoin;

      double silverCoins = Math.Floor((remaining / silverCoin));
      double remainder = remaining % silverCoin;

      // Printing out the coins
      Console.WriteLine($"{goldCoins} gold coins");
      Console.WriteLine($"{silverCoins} silver coins");
      Console.WriteLine($"{remainder} bronze coins");
    }
  }
}
