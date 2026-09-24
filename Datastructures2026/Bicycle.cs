using System;
using System.Collections.Generic;
using System.Text;

namespace Datastructures2026
{
    public class Bicycle
    {
        //Instancefields
        private string _sno;

        //properties
        public string SNO
        {
            get { return _sno; }
        }

        public string Model  //Autoproperty - har et skjult instance field
        {
            get;
            set;
        }

        public int Gears
        {
            get;
            set; 
        }

        //konstruktor - bruges til at initialisere objektet
        public Bicycle(string sno, string model, int gears)
        {
            _sno = sno;
            Model = model;
            Gears = gears; 
        }

        public override string ToString()  //returnerer en streng der beskriver tilstanden af objektet
        {
            return $"SNO {_sno} Model {Model} Gears {Gears}";
        }
    }
}
