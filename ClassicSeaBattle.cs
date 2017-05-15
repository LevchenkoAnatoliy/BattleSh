using System;
using System.Collections.Generic;

namespace BattleShip
{
    class ClassicSeaBattle
    {
        List<Ship> listOfShips = new List<Ship>();
        public List<Ship> ListOfShips
        {
            get { return listOfShips; }
            private set { listOfShips = value; }
        }
        public int Count
        {
            get { return listOfShips.Count; }
            private set { }
        }
        public void AddShip(Ship ship)
        {
            listOfShips.Add(ship);
        }
        public void DeleteShip(Ship ship)
        {
            listOfShips.Remove(ship);
        }
        public string ShowList()
        {
            string msg = "На поле боя следующие корабли :\n";
            foreach(Ship sh in listOfShips)
            {
                msg += sh + "c "+sh.Hp+"\n";
            }
            return msg;
        }
    }
}
