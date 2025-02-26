using System;

namespace DatingProfile
{ 
  public class Profile {
    private string name;
    private string Name
    { get; set; }

    private int age;
    private int Age
    { get; set; }

    private string city;
    private string City
    { get; set; }

    private string country;
    private string Country
    { get; set; }

    private string pronouns;
    private string Pronouns
    { get; set; }

    private string[] hobbies = [];

    public Profile(string name, int age, string city, string country, string pronouns = "they/them") {
        this.name = name;
        if(age >= 18) {
          this.age = age;
        } else {
          throw new ArgumentException("Age must be at least 18.");
        }
        
        this.city = city;
        this.country = country;
        this.pronouns = pronouns;
    }

    public Profile(string name, int age) : this(name, age, "Unknown", "Unknown", "they/them") { }

    public string ViewProfile() {
      string profile = $"Name: {this.name}\nAge: {this.age}\nCity: {this.city}\nCountry: {this.country}\nPronouns: {this.pronouns}\nHobbies:";
      if(hobbies.Length > 0) {
        foreach(string hobby in hobbies) {
          profile += $"\n{hobby}";
        }
      } else {
        profile += $"\nnone.";
      }
      
      return profile;
    }

    public void SetHobbies(string[] hobbies) {
      this.hobbies = hobbies;
    }
  }
}
