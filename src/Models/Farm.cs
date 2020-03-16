using System;
using System.Collections.Generic;
using System.Text;
using Trestlebridge.Interfaces;
using Trestlebridge.Models.Facilities;

namespace Trestlebridge.Models
{
  public class Farm
  {
    // has property of a List of type grazing field called GrazingFields 
    public List<IFacility<IResource>> GrazingFields { get; } = new List<IFacility<IResource>>();
    public List<IFacility<IResource>> PlowingFields { get; } = new List<IFacility<IResource>>();
    public List<IFacility<IResource>> NaturalFields { get; } = new List<IFacility<IResource>>();
    public List<IFacility<IResource>> ChickenHouses { get; } = new List<IFacility<IResource>>();
    public List<IFacility<IResource>> DuckHouses { get; } = new List<IFacility<IResource>>();

    /*
        This method must specify the correct product interface of the
        resource being purchased.
     */
    public void PurchaseResource<T>(IResource resource, int index)
    {
      Console.WriteLine(typeof(T).ToString());
      switch (typeof(T).ToString())
      {
        case "Cow":
          GrazingFields[index].AddResource((IResource)resource);
          break;
        default:
          break;
      }
    }

    public void AddGrazingField(GrazingField field)
    {
      GrazingFields.Add(field);
      Console.WriteLine("You have added a grazing field!");
    }
    public void AddNaturalField(NaturalField field)
    {
      NaturalFields.Add(field);
      Console.WriteLine("You have added a Natural field!");
    }
    public void AddPlowingField(PlowingField field)
    {
      PlowingFields.Add(field);
      Console.WriteLine("You have added a Plowing field!");
    }
    public void AddChickenHouse(ChickenHouse house)
    {
      ChickenHouses.Add(house);
      Console.WriteLine("You have added a chicken house!");
    }
    public void AddDuckHouse(DuckHouse house)
    {
      DuckHouses.Add(house);
      Console.WriteLine("You have added a Duck house!");
    }

    public override string ToString()
    {
      StringBuilder report = new StringBuilder();

      GrazingFields.ForEach(gf => report.Append(gf));
      ChickenHouses.ForEach(ch => report.Append(ch));
      DuckHouses.ForEach(ch => report.Append(ch));
      NaturalFields.ForEach(ch => report.Append(ch));
      PlowingFields.ForEach(ch => report.Append(ch));

      return report.ToString();
    }

  }
}