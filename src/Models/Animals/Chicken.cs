using System;
using System.Collections.Generic;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Animals
{
  public class Chicken : IResource, IFeeding, IMeatProducing, IEggProducing
  {

    private Guid _id = Guid.NewGuid();
    private double _meatProduced = 1.7;
    private double _eggProduced = 7;
    private double _feathersProduced = .5;

    private string _shortId
    {
      get
      {
        return this._id.ToString().Substring(this._id.ToString().Length - 6);
      }
    }

    public double FeedPerDay { get; set; } = .9;
    public string Type { get; set; } = "Chicken";

    // Methods
    public void Feed()
    {
      Console.WriteLine($"Chicken {this._shortId} just ate {this.FeedPerDay}kg of feed");
    }

    public double Butcher()
    {
      return _meatProduced;
    }

    public double EggCollector()
    {
      return _eggProduced;
    }
    public double FeatherCollector()
    {
      return _feathersProduced;
    }

    public override string ToString()
    {
      return $"Chicken {this._shortId}. Bwkkka Bwkaa!";
    }
  }
}