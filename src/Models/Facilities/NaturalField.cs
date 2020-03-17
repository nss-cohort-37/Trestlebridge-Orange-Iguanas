using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Trestlebridge.Actions;
using Trestlebridge.Interfaces;
using Trestlebridge.Models.Facilities;

namespace Trestlebridge.Models.Facilities
{
    public class NaturalField : IFacility<IResource>
    {

        private int _capacity = 4;
        private Guid _id = Guid.NewGuid();
        public string Type { get; set; } = "Natural";

        public List<IResource> _plants = new List<IResource>();

        public double Capacity
        {
            get
            {
                return _capacity;
            }
        }

        public int ResourceCount
        {
            get
            {
                return _plants.Count;
            }
        }

        public void AddResource(IResource plant)
        {
            // maybe use a while loop
            while (true)
            {
                if (_plants.Count < Capacity)
                {
                    _plants.Add(plant);
                    Console.WriteLine("You added your plant!");
                    break;
                }
                else
                {
                    Console.WriteLine("Select another facility");
                    break;
                    // ChooseGrazingField.CollectInput (plants);
                }

            }

        }

        public void AddResource(List<IResource> plants)
        {

            plants = _plants;

        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            // appends before converting to string to make it run faster
            string shortId = $"{this._id.ToString().Substring(this._id.ToString().Length - 6)}";

            var greenhouse = this._plants.GroupBy(plants => plants.Type);
            output.Append($"Natural Field {shortId} has ");

            foreach (var group in greenhouse)
            {
                output.Append($"{group.Count()} {group.Key} ");
            }
            this._plants.ForEach(a => output.Append($" \n{a}\n"));

            return output.ToString();
        }

    }
}