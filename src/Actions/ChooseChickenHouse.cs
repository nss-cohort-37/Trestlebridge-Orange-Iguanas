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
            var AvailableFarms = farm.ChickenHouses.Where(house => house.Capacity > house.ResourceCount).ToList();

            if (AvailableFarms.Count == 0)
            {
                Console.WriteLine("Please add a Facility");

            }
            else
            {

                foreach (var house in farm.ChickenHouses)
                {

                    if (house.ResourceCount < house.Capacity)
                    {
                        Console.WriteLine($"{farm.ChickenHouses.IndexOf(house) + 1}. {house}");
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

                farm.ChickenHouses[(choice - 1)].AddResource(animal);
            }


            /*
                Couldn't get this to work. Can you?
                Stretch goal. Only if the app is fully functional.
             */
            // farm.PurchaseResource<IGrazing>(animal, choice);

        }
    }
}