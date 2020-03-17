using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Trestlebridge.Actions;
using Trestlebridge.Interfaces;
using Trestlebridge.Models.Facilities;

namespace Trestlebridge.Models.Facilities
{
    public class GrazingField : IFacility<IResource>
    {

        private int _capacity = 2;
        private Guid _id = Guid.NewGuid();

        public List<IResource> _animals = new List<IResource>();


        public double Capacity
        {
            get
            {
                return _capacity;
            }
        }

        public int ResourceCount // Have Adam explain why we could not access _animals.
        {
            get
            {
                return _animals.Count;
            }
        }

        public void AddResource(IResource animal)
        {
            // maybe use a while loop
            while (true)
            {
                if (_animals.Count < Capacity)
                {
                    _animals.Add(animal);
                    Console.WriteLine("You added your animal!");
                    break;
                }
                else
                {
                    Console.WriteLine("Select another facility");
                    break;
                    // ChooseGrazingField.CollectInput (animal);
                }

            }

        }

        public void AddResource(List<IResource> animals)
        {

            animals = _animals;

        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            // appends before converting to string to make it run faster
            string shortId = $"{this._id.ToString().Substring(this._id.ToString().Length - 6)}";

            var zoo = this._animals.GroupBy(animal => animal.Type);
            output.Append($"Grazing field {shortId} {(this._animals.Count == 0 ? "is empty" : "has")} ");

            foreach (var group in zoo)
            {
                output.Append($"{group.Count()} {group.Key} ");
            }


            this._animals.ForEach(a => output.Append($" \n{a}\n"));

            return output.ToString();
        }
    }
}