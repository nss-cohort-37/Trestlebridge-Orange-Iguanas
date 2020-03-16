using System;
using System.Collections.Generic;
using System.Text;
using Trestlebridge.Actions;
using Trestlebridge.Interfaces;
using Trestlebridge.Models.Facilities;

namespace Trestlebridge.Models.Facilities
{
  public class PlowingField : IFacility<ISeedProducing>
  {

    private int _capacity = 4;
    private Guid _id = Guid.NewGuid();

    public List<ISeedProducing> _plants = new List<ISeedProducing>();

    public double Capacity
    {
      get
      {
        return _capacity;
      }
    }

    public void AddResource(ISeedProducing plant)
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
          // ChooseGrazingField.CollectInput (animal);
        }

      }

    }

    public void AddResource(List<ISeedProducing> plants)
    {

      plants = _plants;

    }

    public override string ToString()
    {
      StringBuilder output = new StringBuilder();
      // appends before converting to string to make it run faster
      string shortId = $"{this._id.ToString().Substring(this._id.ToString().Length - 6)}";

      output.Append($"Plowing field {shortId} has {this._plants.Count} plants\n");
      this._plants.ForEach(a => output.Append($"   {a}\n"));

      return output.ToString();
    }
  }
}