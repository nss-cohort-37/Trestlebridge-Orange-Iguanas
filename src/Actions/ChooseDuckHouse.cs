using System;
using System.Linq;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Animals;
using Trestlebridge.Models.Facilities;

namespace Trestlebridge.Actions
{
  public class ChooseDuckHouse
  {
    public static void CollectInput(Farm farm, Duck animal)
    {
      // Utils.Clear ();

      for (int i = 0; i < farm.DuckHouses.Count; i++)
      {
        foreach (var house in farm.DuckHouses)
        {
          Console.WriteLine($"{i + 1}. Duck House currently has {house._animals.Count} ducks, ducking around ");
        }
      }

      Console.WriteLine();

      // How can I output the type of animal chosen here?
      Console.WriteLine($"Place the animal where?");

      Console.Write("> ");
      int choice = Int32.Parse(Console.ReadLine());

      farm.DuckHouses[(choice - 1)].AddResource(animal);

      /*
          Couldn't get this to work. Can you?
          Stretch goal. Only if the app is fully functional.
       */
      // farm.PurchaseResource<IGrazing>(animal, choice);

    }
  }
}