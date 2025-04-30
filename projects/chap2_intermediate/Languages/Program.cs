using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ProgrammingLanguages
{
  class Program
  {
    public static void PrettyPrintAll(IEnumerable<Language> languages) 
    {
      foreach(Language l in languages)
      {
        Console.WriteLine(l.Prettify());
      }
    }

    public static void PrintAll(IEnumerable<Object> sequence)
    {
      foreach(Object o in sequence)
      {
        Console.WriteLine(o);
      }
    }

    static void Main()
    {
      List<Language> languages = File.ReadAllLines("./languages.tsv")
        .Skip(1)
        .Select(line => Language.FromTsv(line))
        .ToList();

      foreach(Language l in languages)
      {
        Console.WriteLine(l.Prettify());
      }

      Console.WriteLine("----------------");

      var yearNameChiefDev = languages.Select(l => l.Year + " - " + l.Name + " - " + l.ChiefDeveloper);

      PrintAll(yearNameChiefDev);

      Console.WriteLine("----------------");

      var csharpLanguages = languages.Where(l => l.Name == "C#");

      foreach(Language csl in csharpLanguages)
      {
        Console.WriteLine(csl.Prettify());
      }

      Console.WriteLine("----------------");

      var microsoftLanguages = languages.Where(l => l.ChiefDeveloper == "Microsoft");

      foreach(Language msl in microsoftLanguages)
      {
        Console.WriteLine(msl.Prettify());
      }

      Console.WriteLine("----------------");

      var lispDescendants = languages.Where(l => l.Predecessors.Contains("Lisp"));

      foreach(Language ld in lispDescendants)
      {
        Console.WriteLine(ld.Prettify());
      }

      Console.WriteLine("----------------");

      var scriptLanguages = languages.Where(l => l.Name.Contains("Script"));

      foreach(Language sl in scriptLanguages)
      {
        Console.WriteLine(sl.Prettify());
      }

      Console.WriteLine("----------------");

      Console.WriteLine($"There are {languages.Count} languages in the list.");

      Console.WriteLine("----------------");

      var languagesBetween1995And2005 = languages.Where(l => l.Year > 1995 && l.Year < 2005);

      foreach(Language l in languagesBetween1995And2005)
      {
        Console.WriteLine(l.Prettify());
      }

      Console.WriteLine("----------------");

      var languagesBetween1995And20052 = languages
        .Where(l => l.Year > 1995 && l.Year < 2005)
        .Select(l => $"{l.Name} was invented in {l.Year}");

      foreach(string l in languagesBetween1995And20052)
      {
        Console.WriteLine(l);
      }

      Console.WriteLine("----------------");

      PrettyPrintAll(languages);
    }
  }
}
