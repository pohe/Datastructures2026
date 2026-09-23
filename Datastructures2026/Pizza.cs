using System;
using System.Collections.Generic;
using System.Text;

namespace Datastructures2026
{
    public class Pizza
    {
        private int _no;
        private string _name;
        private double _price;

        public Pizza(int no, string name, string description, double price)
        {
            _no = no;
            _name = name;
            Description = description;
            _price = price; 
        }

        public int No { get { return _no; } }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public double Price
        {
            get { return _price; }
            set
            {   _price = value; }
        }

        public string Description { get; set; }

        public override string ToString()
        {
            return $"No {_no} Name {_name} Description {Description} price {_price}"; 
        }

    }
}
