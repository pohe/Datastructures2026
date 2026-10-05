using System;
using System.Collections.Generic;
using System.Text;

namespace Datastructures2026
{
    public class House
    {
		private string _address;
        private HouseType _htype;

        private static int counter=0; //static - tilhører klassen

        public int Id { get; }  //unikt nummer tildeles hvert objekt

        public  HouseType Htype
        {
            get { return _htype; }
            set { _htype = value;  }
        }

		public string Address
		{
			get { return _address; }
			set { _address = value; }
		}

        public int Sqr { get; set; }
        public House(string addres, int sqr, HouseType htype)
        {
            Id = ++counter;
            _address = addres;
            Sqr = sqr;
            _htype = htype; 
        }

        public void PrintAll()
        {
            Console.WriteLine($"ID {Id} Address {_address} kvadratmeter {Sqr} m2 type {_htype}");
        }


    }
}
