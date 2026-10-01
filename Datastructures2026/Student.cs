using System;
using System.Collections.Generic;
using System.Text;

namespace Datastructures2026
{
    public class Student
    {
        private static int _counter=0; //Denne counter hører til klassen
        //Full property
		private int _id;//Instance field

		public int Id  //Property til at tilgå instance field
		{
			get { return _id; }
		}

        public string Name { get; set; } //Autoproperty

        public string Mobile { get; set; } //Auto property


        public Student( string name, string mobile) //Konstruktor  -laver og  initialiserer et objekt
        {

            Name = name;
            _id = ++_counter;
            Mobile = mobile;
        }


        public override string ToString()  //returnerer en streng med objektets værdier /tilstand
        {
            return $"Id {_id} Name {Name} Mobile {Mobile}";
        }
    }
}
