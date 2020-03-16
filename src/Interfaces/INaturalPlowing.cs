using System.Collections.Generic;
using Trestlebridge.Models.Animals;

namespace Trestlebridge.Interfaces
{
  public interface INaturalPlowing : IComposting, ISeedProducing
  {
    double Capacity { get; }

    // void AddResource(T resource);
    // void AddResource(List<T> resources);
  }
}