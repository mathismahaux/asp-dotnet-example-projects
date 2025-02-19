using System;

namespace CaesarCipher
{
  class Program
  {
    static void Main(string[] args)
    {
      char[] alphabet = new char[] {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};

      Console.WriteLine("Enter a secret message:");
      string message = Console.ReadLine();
      message = message.ToLower(); 

      char[] secretMessage = message.ToCharArray();

      char[] encryptedMessageArray = new char[secretMessage.Length];

      for(int i = 0; i < secretMessage.Length; i++)
      {
        char character = secretMessage[i];
        int charIndex = Array.IndexOf(alphabet, character);
        if(charIndex == -1) {
          continue;
        }
        int encryptedCharIndex = (charIndex + 3) % alphabet.Length;
        char encryptedChar = alphabet[encryptedCharIndex];
        encryptedMessageArray[i] = encryptedChar;
      }

      string encryptedMessageString = String.Join("", encryptedMessageArray);
      Console.WriteLine(encryptedMessageString);
    }
  }
}