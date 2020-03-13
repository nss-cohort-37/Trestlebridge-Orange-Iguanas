using System;
using System.Collections.Generic;
using System.Linq;
using Trestlebridge.Actions;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Animals;

namespace Trestlebridge {
  class Program {
    // this function writes the display banner 
    static void DisplayBanner () {
      // Utils.Clear();
      Console.WriteLine ();
      Console.WriteLine (@"
        +-++-++-++-++-++-++-++-++-++-++-++-++-+
        |T||r||e||s||t||l||e||b||r||i||d||g||e|
        +-++-++-++-++-++-++-++-++-++-++-++-++-+
                    |F||a||r||m||s|
                    +-++-++-++-++-+");
      Console.WriteLine ();
    }

    static void Main (string[] args) {
      Console.ForegroundColor = ConsoleColor.White;
      Console.BackgroundColor = ConsoleColor.DarkMagenta;
      // makes a new instance of the Farm class called Trestlebridge
      Farm
      Trestlebridge = new Farm ();

      while (true) {
        DisplayBanner ();
        Console.WriteLine ("1. Create Facility");
        Console.WriteLine ("2. Purchase Animals");
        Console.WriteLine ("3. Purchase Seeds");
        Console.WriteLine ("4. Display Farm Status");
        Console.WriteLine ("5. Exit");
        Console.WriteLine ();

        Console.WriteLine ("Choose a FARMS option");
        Console.Write ("> ");
        string option = Console.ReadLine ();

        if (option == "1") {
          DisplayBanner ();
          CreateFacility.CollectInput (Trestlebridge);

        } else if (option == "2") {
          DisplayBanner ();
          PurchaseStock.CollectInput (Trestlebridge);
        } else if (option == "3") {
          DisplayBanner ();
          PurchaseSeed.CollectInput (Trestlebridge);
        } else if (option == "4") {
          DisplayBanner ();
          Console.WriteLine (Trestlebridge);
          //  calls the toString method on Trestlebridge

          Console.WriteLine ("Press return key to go back to main menu.");
          Console.ReadLine ();
        } else if (option == "5") {
          Console.WriteLine ("Today is a great day for farming");
          break;
        } else {
          Console.WriteLine ($"Invalid option: {option}");
        }
      }
    }
  }
}