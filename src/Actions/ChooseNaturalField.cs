using System;
using System.Linq;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Animals;
using Trestlebridge.Models.Facilities;

namespace Trestlebridge.Actions
{
  public class ChooseNaturalField
  {
    public static void CollectInput(Farm farm, IComposting plant)
    {
      // Utils.Clear ();

      for (int i = 0; i < farm.NaturalFields.Count; i++)
      {
        //Ternary / if else
        Console.WriteLine($"{i + 1}. natural Field has the following seeds:");
        foreach (var field in farm.NaturalFields)
        {
          var groups = field._plants.GroupBy(animal => animal.Type);
          foreach (var individualAnimal in groups)
          {
            Console.WriteLine($"{individualAnimal.Count()} {individualAnimal.Key} ");
          }
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