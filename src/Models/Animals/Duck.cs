using System;
using System.Collections.Generic;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Animals
{
  public class Duck : IResource, IFeeding, IEggProducing
  {

    private Guid _id = Guid.NewGuid();
    private double _eggProduced = 6;
    private double _feathersProduced = .75;

    private string _shortId
    {
      get
      {
        return this._id.ToString().Substring(this._id.ToString().Length - 6);
      }
    }

    public double FeedPerDay { get; set; } = .8;
    public string Type { get; } = "Duck";

    // Methods
    public void Feed()
    {
      Console.WriteLine($"Duck {this._shortId} just ate {this.FeedPerDay}kg of feed");
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
      return $"Duck {this._shortId}. quack quack!";
    }
  }
}