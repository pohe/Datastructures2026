using System;
using System.Collections.Generic;
using System.Text;

namespace Datastructures2026
{
    public class HouseRepository
    {
        private List<House> _houses; 

        public HouseRepository()
        {
            _houses = new List<House>();
        }

        public void Add(House aHouse)
        {
            _houses.Add(aHouse);
        }

        public House? SearchHouse(int id)
        {
            foreach(House h in _houses)
            {
                if (h.Id==id)
                {
                    return h;
                }
            }
            return null; 
        }

        public void DeleteHouse(int id)
        {
            House? houseToBeRemoved = SearchHouse(id);
            if (houseToBeRemoved != null)
                _houses.Remove(houseToBeRemoved);
        }


        public void PrintAllHouses()
        {
            foreach(House h in _houses)
            {
                h.PrintAll();
            }
        }
    }
}
