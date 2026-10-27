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
            if (SearchHouse(aHouse.Id) == null) // sikrer at der ikke er dubletter - to House objekter med samme ID
            {
                _houses.Add(aHouse);
            }
            
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

        public void UpdateHouse(int id, House aUpdatedHouse )
        {
            for(int i = 0; i<_houses.Count; i++)
            {
                if (_houses[i].Id == id )
                {
                    _houses[i].Htype = aUpdatedHouse.Htype;
                    _houses[i].Address = aUpdatedHouse.Address;
                    _houses[i].Sqr = aUpdatedHouse.Sqr;
                    return;
                }
            }
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
