using System;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Facilities;
using Trestlebridge.Models.Plants;

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
          ChoosePlowingField.CollectInput(farm, new Sesame());
          break;
        case 2:
          ChooseNaturalField.CollectInput(farm, new Wildflower());
          break;
        case 3:
          //create new method. ChoosePlowedOrNatural
          ChoosePlowingOrNatural.CollectInput(farm, new Sunflower());
          break;
        default:
          break;
      }
    }
  }
}