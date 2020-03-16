using System;
using System.Linq;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Animals;
using Trestlebridge.Models.Facilities;

namespace Trestlebridge.Actions
{
    public class ChooseGrazingField
    {
        public static void CollectInput(Farm farm, IGrazing animal)
        {
            // Utils.Clear ();

            for (int i = 0; i < farm.GrazingFields.Count; i++)
            {
                //Ternary / if else
                Console.WriteLine($"{i + 1}. Grazing Field has the following animals:");
                foreach (var field in farm.GrazingFields)
                {
                    var groups = field._animals.GroupBy(animal => animal.Type);
                    foreach (var individualAnimal in groups)
                    {

                        Console.WriteLine($"{individualAnimal.Count()} {individualAnimal.Key} ");
                    }
                }
            }

            Console.WriteLine();

            // How can I output the type of animal chosen here?
            Console.WriteLine($"Place the animal where?");

            Console.Write("> ");
            int choice = Int32.Parse(Console.ReadLine());

            farm.GrazingFields[(choice - 1)].AddResource(animal);

            /*
                Couldn't get this to work. Can you?
                Stretch goal. Only if the app is fully functional.
             */
            // farm.PurchaseResource<IGrazing>(animal, choice);

        }
    }
}