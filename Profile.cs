using System;

namespace DatingProfile
{ 
  class Profile
  {
    //Fields
    private int age;


    //Properties
    private string Name {get; set; }
    private int Age 
    { 
      get{ return age;} 
    set
      {
      if(value>18)
        {age=value;}
      else
        {
          throw new ArgumentOutOfRangeException("Age", "Users must be at least 18 years of age.");
        }
      } 
    }
    private string City { get; set; }
    private string Country { get; set; }
    private string Pronouns { get; set; }
    private string[] Hobbies { get; set; }

    //Constructor

    public Profile(string name, int age, string city, string country, string pronouns = "they/them")
    {
      this.Name = name;
      this.Age = age;
      this.City = city;
      this.Country = country;
      this.Pronouns = pronouns;
      this.Hobbies = new string[0];
    }
    public Profile(string name, int age) 
    {
      this.Name = name;
      this.Age = age;
      this.City = "Unknown";
      this.Country = "Unknown";
      this.Pronouns = "Unknown";
      this.Hobbies = new string[0];
    }

     //Methods

     public string ViewProfile()
      {
        if(this.Hobbies.Length > 0)
        {
          string info = $"Name = {this.Name}\nAge = {this.Age}\nCity = {this.City}\nCountry = {this.Country}\nPronouns = {this.Pronouns}\nHobbies: \n* {string.Join("\n* ",this.Hobbies)}";
        return info;
        }
        return $"Name = {this.Name}\nAge = {this.Age}\nCity = {this.City}\nCountry = {this.Country}\nPronouns = {this.Pronouns}";  
      }

      public void SetHobbies(string[] hobbies)
      {
        this.Hobbies = hobbies;
      }      
  }
  
}
