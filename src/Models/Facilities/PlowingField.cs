// using System;
// using System.Collections.Generic;
// using System.Text;
// using Trestlebridge.Interfaces;

// namespace Trestlebridge.Models.Facilities
// {
//   // public class PlowingField : IFacility<IPlowing>
//   {

//     private int _capacity = 50;
//     private Guid _id = Guid.NewGuid();

//     private List<IGrazing> _animals = new List<IGrazing>();

//     public double Capacity
//     {
//       get
//       {
//         return _capacity;
//       }
//     }

//     public void AddResource(IGrazing animal)
//     {
//       // TODO: implement this...
//       // still in development 
//       throw new NotImplementedException();
//     }

//     public void AddResource(List<IGrazing> animals)
//     {
//       // TODO: implement this...
//       // still in development
//       throw new NotImplementedException();
//     }

//     public override string ToString()
//     {
//       StringBuilder output = new StringBuilder();
//       string shortId = $"{this._id.ToString().Substring(this._id.ToString().Length - 6)}";

//       output.Append($"Grazing field {shortId} has {this._animals.Count} animals\n");
//       this._animals.ForEach(a => output.Append($"   {a}\n"));

//       return output.ToString();
//     }
//   }
// }