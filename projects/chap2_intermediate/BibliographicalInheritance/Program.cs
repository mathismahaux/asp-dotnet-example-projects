using System;

namespace BiblioInheritance
{
  class Program
  {
    static void Main(string[] args)
    {
      Resource testResource = new Resource("TestTitle", "TestCategory");
      testResource.GetInfo();
      testResource.UpdateStatus();
      testResource.GetInfo();

      Console.WriteLine();

      string[] authors = { "Charles Petzold", "Another Author" };
      Book myBook = new Book("Code: The Hidden Language of Computer Hardware and Software", "Non-Fiction", authors, 396);
      myBook.GetInfo();
      Console.WriteLine($"Authors: {myBook.GetAuthors()}");

      Console.WriteLine();

      Periodical p = new Periodical("Wired", "Monthly", "Technology");
      p.UpdateStatus();
      Console.WriteLine(p.Status);

      Console.WriteLine();

      Video v = new Video("Ex Machina", "Sci-Fi", "Alex Garland", 108, "On-Demand");
      v.GetInfo();
    }
  }
}