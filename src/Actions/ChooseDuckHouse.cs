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
            var AvailableFarms = farm.DuckHouses.Where(houses => houses.Capacity > houses.ResourceCount).ToList();

            if (AvailableFarms.Count == 0)
            {
                Console.WriteLine("Please add a Facility");

            }
            else
            {


                foreach (var house in farm.DuckHouses)
                {
                    if (house.ResourceCount < house.Capacity)
                    {
                        Console.WriteLine($"{farm.DuckHouses.IndexOf(house) + 1}. {house}");
                    }
                    else
                    {

                    }

                }
                Console.WriteLine();

                // How can I output the type of animal chosen here?
                Console.WriteLine($"Place the animal where?");

                Console.Write("> ");
                int choice = Int32.Parse(Console.ReadLine());

                farm.DuckHouses[(choice - 1)].AddResource(animal);
            }


            /*
                Couldn't get this to work. Can you?
                Stretch goal. Only if the app is fully functional.
             */
            // farm.PurchaseResource<IGrazing>(animal, choice);

        }
    }
}