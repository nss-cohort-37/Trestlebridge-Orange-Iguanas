using System;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Animals;
using Trestlebridge.Models.Facilities;

namespace Trestlebridge.Actions
{
  public class PurchaseSeed
  {
    public static void CollectInput(Farm farm)
    {
      Console.WriteLine("1. Sesame");
      Console.WriteLine("2. Wildflower");
      Console.WriteLine("3. Sunflower");

      Console.WriteLine();
      Console.WriteLine("What are you buying today?");

      Console.Write("> ");
      string choice = Console.ReadLine();

      switch (Int32.Parse(choice))
      {
        case 1:
          // make an action ChooseNaturalField or ChoosePlowField
          // ChooseGrazingField.CollectInput(farm, new Sesame());
          break;
        default:
          break;
      }
    }
  }
}