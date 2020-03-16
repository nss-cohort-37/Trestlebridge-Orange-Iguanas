using System;
using System.Linq;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Animals;
using Trestlebridge.Models.Facilities;

namespace Trestlebridge.Actions
{
  public class ChoosePlowingOrNatural
  {
    public static void CollectInput(Farm farm, IComposting plant)
    {
      // Utils.Clear ();
      for (int i = 0; i < farm.PlowingAndNaturalFields.Count; i++)
      {
        foreach (var field in farm.PlowingAndNaturalFields)
        {
          Console.WriteLine($"{i+1}. {field}");
        }
      }
      Console.WriteLine();

      // How can I output the type of animal chosen here?
      Console.WriteLine($"Place the plant where?");

      Console.Write("> ");
      int choice = Int32.Parse(Console.ReadLine());

      farm.NaturalFields[(choice - 1)].AddResource(plant);

      /*
          Couldn't get this to work. Can you?
          Stretch goal. Only if the app is fully functional.
       */
      // farm.PurchaseResource<IGrazing>(animal, choice);

    }
  }
}