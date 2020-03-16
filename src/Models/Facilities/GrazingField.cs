using System;
using System.Collections.Generic;
using System.Text;
using Trestlebridge.Actions;
using Trestlebridge.Interfaces;
using Trestlebridge.Models.Facilities;

namespace Trestlebridge.Models.Facilities
{
    public class GrazingField : IFacility<IGrazing>
    {

        private int _capacity = 4;
        private Guid _id = Guid.NewGuid();

        public List<IGrazing> _animals = new List<IGrazing>();

        public double Capacity
        {
            get
            {
                return _capacity;
            }
        }

        public void AddResource(IGrazing animal)
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

        public void AddResource(List<IGrazing> animals)
        {

            animals = _animals;

        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            // appends before converting to string to make it run faster
            string shortId = $"{this._id.ToString().Substring(this._id.ToString().Length - 6)}";

            output.Append($"Grazing field {shortId} has {this._animals.Count} animals\n");
            this._animals.ForEach(a => output.Append($"   {a}\n"));

            return output.ToString();
        }
    }
}