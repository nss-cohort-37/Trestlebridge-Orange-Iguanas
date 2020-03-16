using System;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Plants
{
  public class Wildflower : IResource, IComposting
  {
    private double _compostProduced = 30.3;
    public string Type { get; } = "Wildflower";

    public double Shoveler()
    {
      return _compostProduced;
    }

    public override string ToString()
    {
      return $"Wildflower. How wild!";
    }
  }
}