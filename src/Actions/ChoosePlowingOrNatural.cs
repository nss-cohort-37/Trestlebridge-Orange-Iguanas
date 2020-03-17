using System;
using System.Collections.Generic;
using System.Linq;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Animals;
using Trestlebridge.Models.Facilities;

namespace Trestlebridge.Actions
{
    public class ChoosePlowingOrNatural
    {
        public static void CollectInput(Farm farm, IResource plant)
        {
            // Utils.Clear ();
            var PlowedAndNaturalFields = new List<IFacility<IResource>>();

            PlowedAndNaturalFields.AddRange(farm.PlowingFields);
            PlowedAndNaturalFields.AddRange(farm.NaturalFields);
            foreach (var field in PlowedAndNaturalFields)
            {

                if (field.ResourceCount < field.Capacity)
                {
                    Console.WriteLine($"{PlowedAndNaturalFields.IndexOf(field) + 1}. {field}");
                }
                else
                {

                }
            }
            Console.WriteLine();


            Console.WriteLine($"Place the plant where?");

            Console.Write("> ");
            int choice = Int32.Parse(Console.ReadLine());

            PlowedAndNaturalFields[(choice - 1)].AddResource(plant);

            /*
                Couldn't get this to work. Can you?
                Stretch goal. Only if the app is fully functional.
             */
            // farm.PurchaseResource<IGrazing>(animal, choice);

        }
    }
}