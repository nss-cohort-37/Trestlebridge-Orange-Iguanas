using System;
using System.Linq;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Animals;
using Trestlebridge.Models.Facilities;

namespace Trestlebridge.Actions
{
  public class ChooseChickenHouse
  {
    public static void CollectInput(Farm farm, Chicken animal)
    {
      // Utils.Clear ();

      for (int i = 0; i < farm.ChickenHouses.Count; i++)
      {
        foreach (var house in farm.ChickenHouses)
        {
          Console.WriteLine($"{i + 1}. Chicken House has {house._animals.Count} {(house._animals.Count == 1 ? "chicken" : "chickens") }  squawkin about!");

        }
      }

      Console.WriteLine();

      // How can I output the type of animal chosen here?
      Console.WriteLine($"Place the animal where?");

      Console.Write("> ");
      int choice = Int32.Parse(Console.ReadLine());

      farm.ChickenHouses[(choice - 1)].AddResource(animal);

      /*
          Couldn't get this to work. Can you?
          Stretch goal. Only if the app is fully functional.
       */
      // farm.PurchaseResource<IGrazing>(animal, choice);

    }
  }
}