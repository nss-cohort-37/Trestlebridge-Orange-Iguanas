using System;
using System.Collections.Generic;
using System.Text;
using Trestlebridge.Actions;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Facilities {
    public class GrazingField : IFacility<IGrazing> {

        private int _capacity = 2;
        private Guid _id = Guid.NewGuid ();

        private List<IGrazing> _animals = new List<IGrazing> ();

        public double Capacity {
            get {
                return _capacity;
            }
        }

        public void AddResource (IGrazing animal) {
            // maybe use a while loop
            if (_animals.Count < Capacity) {
                _animals.Add (animal);
                Console.WriteLine ("You added your animal!");

            } else {
                Console.WriteLine ("Select another facility");
                // ChooseGrazingField.CollectInput (animal);
            }
            // adding cow to a grazing field 
            // throw new NotImplementedException ();
        }

        public void AddResource (List<IGrazing> animals) {

            throw new NotImplementedException ();
        }

        public override string ToString () {
            StringBuilder output = new StringBuilder ();
            string shortId = $"{this._id.ToString().Substring(this._id.ToString().Length - 6)}";

            output.Append ($"Grazing field {shortId} has {this._animals.Count} animals\n");
            this._animals.ForEach (a => output.Append ($"   {a}\n"));

            return output.ToString ();
        }
    }
}