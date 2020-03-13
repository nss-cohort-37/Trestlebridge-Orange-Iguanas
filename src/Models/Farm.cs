using System;
using System.Collections.Generic;
using System.Text;
using Trestlebridge.Interfaces;
using Trestlebridge.Models.Facilities;

namespace Trestlebridge.Models {
  public class Farm {
    // has property of a List of type grazing field called GrazingFields 
    public List<GrazingField> GrazingFields { get; } = new List<GrazingField> ();
    // public List<PlowedField> PlowedFields { get; } = new List<PlowedField>();
    // public List<NaturalField> NaturalFields { get; } = new List<NaturalField>();
    public List<ChickenHouse> ChickenHouses { get; } = new List<ChickenHouse> ();
    // public List<DuckHouse> DuckHouses { get; } = new List<DuckHouse>();

    /*
        This method must specify the correct product interface of the
        resource being purchased.
     */
    public void PurchaseResource<T> (IResource resource, int index) {
      Console.WriteLine (typeof (T).ToString ());
      switch (typeof (T).ToString ()) {
        case "Cow":
          GrazingFields[index].AddResource ((IGrazing) resource);
          break;
        default:
          break;
      }
    }

    public void AddGrazingField (GrazingField field) {
      GrazingFields.Add (field);
      Console.WriteLine ("You have added a grazing field!");
    }
    public void AddChickenHouse (ChickenHouse house) {
      ChickenHouses.Add (house);
      Console.WriteLine ("You have added a chicken house!");
    }

    public override string ToString () {
      StringBuilder report = new StringBuilder ();

      GrazingFields.ForEach (gf => report.Append (gf));
      ChickenHouses.ForEach (ch => report.Append (ch));

      return report.ToString ();
    }

  }
}