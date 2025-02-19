using System;

namespace PasswordChecker
{
  class Program
  {
    public static void Main(string[] args)
    {
      int minLength = 8;
      string upperCase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
      string lowerCase = "abcdefghijklmnopqrstuvwxyz";
      string digits = "0123456789";
      string specialChars = "#?!";

      Console.Write("Enter a password: ");
      string password = Console.ReadLine();

      int score = 0;

      if(password.Length >= minLength)
      {
        score++;
      }

      if(Tools.Contains(password, upperCase)) 
      {
        score++;
      }

      if(Tools.Contains(password, lowerCase)) 
      {
        score++;
      }

      if(Tools.Contains(password, digits)) 
      {
        score++;
      }

      if(Tools.Contains(password, specialChars)) 
      {
        score++;
      }

      switch(score)
      {
        case 5:
        case 4:
          Console.WriteLine("Extremely strong");
          break;
        case 3:
          Console.WriteLine("Strong");
          break;
        case 2:
          Console.WriteLine("Medium");
          break;
        case 1:
          Console.WriteLine("Weak");
          break;
        default:
          Console.WriteLine("None of the standards were met...");
          break;
      }
    }
  }
}
