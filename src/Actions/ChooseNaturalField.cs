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
        public static void CollectInput(Farm farm, IResource plant)
        {
            // Utils.Clear ();

            var AvailableFarms = farm.NaturalFields.Where(field => field.Capacity > field.ResourceCount).ToList();

            if (AvailableFarms.Count == 0)
            {
                Console.WriteLine("Please add a Facility");

            }
            else
            {

                foreach (var field in farm.NaturalFields)
                {
                    if (field.ResourceCount < field.Capacity)
                    {

                        Console.WriteLine($"{farm.NaturalFields.IndexOf(field) + 1}. {field}");
                    }
                    else
                    {

                    }

                }
                Console.WriteLine();

                // How can I output the type of animal chosen here?
                Console.WriteLine($"Place the plant where?");

                Console.Write("> ");
                int choice = Int32.Parse(Console.ReadLine());

                farm.NaturalFields[(choice - 1)].AddResource(plant);
            }


            /*
                Couldn't get this to work. Can you?
                Stretch goal. Only if the app is fully functional.
             */
            // farm.PurchaseResource<IGrazing>(animal, choice);

        }
    }
}