namespace RoverControlCenter
{
  class Probe
  {
    public string Alias { get; private set; }
    public int Year { get; private set; }

    public Probe(string alias, int year)
    {
      Alias = alias;
      Year = year;
    }

    public virtual string GetInfo()
    {
      return $"Alias: {Alias}, Year: {Year}";
    }

    public virtual string Explore()
    {
      return "Probe is exploring!";
    }

    public virtual string Collect()
    {
      return "Probe is collecting data!";
    }
  }
}
