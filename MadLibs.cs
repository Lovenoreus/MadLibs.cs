using System;

namespace MadLibs
{
  class Program
  {
    static void Main(string[] args)
    {
      /*
      This program is MadLibs
      */


      // Let the user know that the program is starting:
      Console.WriteLine("The program has now started!");

      // Give the Mad Lib a title:
      string title = "Madlibs";

      Console.WriteLine(title);
      // Define user input and variables:
      Console.Write("Enter a name: ");
      string name = Console.ReadLine();
      Console.Write("Enter a color: ");
      string color = Console.ReadLine();
      Console.Write("Enter a feeling: ");
      string feeling = Console.ReadLine();
      Console.Write("Enter a texture: ");
      string texture = Console.ReadLine();
      Console.Write("Enter a verb: ");
      string verb = Console.ReadLine();
      Console.Write("Enter an instrument: ");
      string instrument = Console.ReadLine();
      Console.Write("Enter a thing: ");
      string thing = Console.ReadLine();
      Console.Write("Enter an animal: ");
      string animal = Console.ReadLine();
      Console.Write("Enter a food: ");
      string food = Console.ReadLine();
      Console.Write("Enter a fruit: ");
      string fruit = Console.ReadLine();
      Console.Write("Enter a superhero: ");
      string superhero = Console.ReadLine();
      Console.Write("Enter a country: ");
      string country = Console.ReadLine();
      Console.Write("Enter a dessert: ");
      string dessert = Console.ReadLine();
      Console.Write("Enter a year: ");
      string year = Console.ReadLine();

      // The template for the story:


      string story = $"This morning {name} woke up feeling {color}. 'It is going to be a {feeling} day!' Outside, a bunch of {animal}s were protesting to keep {food} in stores. They began to {verb} to the rhythm of the {instrument}, which made all the {fruit}s very {texture}. Concerned, {name} texted {superhero}, who flew  to {country} and dropped {name} in a puddle of frozen {dessert}. {name} woke up in the year {year}, in a world where {thing}s ruled the world.";


      // Print the story:
      Console.WriteLine(story);

    }
  }
}
