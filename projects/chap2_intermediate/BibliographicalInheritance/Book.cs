using System;

namespace BiblioInheritance
{
  public class Book : Resource
  {
    public string[] Authors { get; set; }
    public int PageCount { get; set; }

    public Book(string title, string category, string[] authors, int pageCount) : base(title, category)
    {
      Authors = authors;
      PageCount = pageCount;
    }

    public string GetAuthors()
    {
      return string.Join(", ", Authors);
    }
  }
}