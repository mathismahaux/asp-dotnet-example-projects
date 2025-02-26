using System;

namespace DatingProfile
{
  class Program
  {
    static void Main(string[] args)
    {
      Profile sam = new Profile("Sam Drakkila", 30, "New York", "USA", "he/him");
      string[] hobbies = ["listening to audiobooks and podcasts", "playing rec sports like bowling and kickball", "writing a speculative fiction novel", "reading advice columns"];
      sam.SetHobbies(hobbies);
      Console.WriteLine(sam.ViewProfile());

      Profile mathis = new Profile("Mathis Mahaux", 24);
      Console.WriteLine(mathis.ViewProfile());

      Profile timmy = new Profile("Timmy Thechild", 12, "New York", "USA", "he/him");
      Console.WriteLine(timmy.ViewProfile());
    }
  }
}
