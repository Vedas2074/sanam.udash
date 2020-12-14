using System;

public class Country
{
  public string Name {get; set;}  

  public string Capitol {get; set;}

  public string Continent {get; set;}

  public long Population {get; set;}

  public DateTime IndependenceDay {get; set;} 

  public Country(string name, string Capitol,long population,string continent , DateTime IndependenceDay= default)
  {
      this.Name=name;
      this.Capitol=Capitol;
      this.Continent=continent;
      this.IndependenceDay=IndependenceDay;
      this.Population=Population;

  }

}