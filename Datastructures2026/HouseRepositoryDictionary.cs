using System;
using System.Collections.Generic;
using System.Text;

namespace Datastructures2026
{
    public  class HouseRepositoryDictionary
    {
        private Dictionary<int, House> _houses;

        public HouseRepositoryDictionary()
        {
            _houses = new Dictionary<int, House>();
        }

        public void Add(House aHouse)
        {
            if ( !_houses.ContainsKey(aHouse.Id))
            {
                _houses.Add(aHouse.Id, aHouse);
            }
            
        }

        public House? SearchHouse(int id)
        {
            if (_houses.ContainsKey(id))
            {
                return _houses[id];
            }
            //foreach(House item in _houses.Values)
            //{
            //    if (item.Id == id)
            //    {
            //        return _houses[id];
            //    }
            //}
            return null;
        }

        public void DeleteHouse(int id)
        {
            _houses.Remove(id);
        }

        public void UpdateHouse(int id, House aUpdatedHouse)
        {
            if (_houses.ContainsKey(id))
            {
                _houses[id].Htype = aUpdatedHouse.Htype;
                _houses[id].Sqr = aUpdatedHouse.Sqr;
                _houses[id].Address = aUpdatedHouse.Address;
            }
        }

        public void PrintAllHouses()
        {
            foreach(House item in _houses.Values)
            {
                item.PrintAll();
            }
        }




    }
}
