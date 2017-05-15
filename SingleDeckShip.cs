using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BattleShip
{
    class SingleDeckShip:Ship
    {
        public SingleDeckShip()
        {
            hp = 1;
        }
        public override bool SetLocation(string location)
        {            
            string[] pos = location.Split(new char[] { ',' });
            int posX = int.Parse(pos[0]);
            int posY = int.Parse(pos[1]);
            if (Ship.field[posX, posY] != 1 && Ship.field[posX, posY] != 2)
            {
                Ship.field[posX, posY] = 1;
                this.location = new string[]{ (posX + "," + posY) };
                if (posX == 0 && posY == 0)
                {
                    Ship.field[posX + 1, posY] = 2;
                    Ship.field[posX + 1, posY + 1] = 2;
                    Ship.field[posX, posY + 1] = 2;
                }
                else if (posX == 9 && posY == 0)
                {
                    Ship.field[posX - 1, posY] = 2;
                    Ship.field[posX - 1, posY + 1] = 2;
                    Ship.field[posX, posY + 1] = 2;
                }
                else if (posX == 9 && posY == 9)
                {
                    Ship.field[posX, posY - 1] = 2;
                    Ship.field[posX - 1, posY - 1] = 2;
                    Ship.field[posX - 1, posY] = 2;
                }
                else if (posX == 0 && posY == 9)
                {
                    Ship.field[posX, posY - 1] = 2;
                    Ship.field[posX + 1, posY - 1] = 2;
                    Ship.field[posX + 1, posY] = 2;
                }
                else if (posY == 0)
                {
                    Ship.field[posX + 1, posY] = 2;
                    Ship.field[posX - 1, posY] = 2;
                    Ship.field[posX, posY + 1] = 2;
                    Ship.field[posX + 1, posY + 1] = 2;
                    Ship.field[posX - 1, posY + 1] = 2;
                }
                else if (posY == 9)
                {
                    Ship.field[posX + 1, posY] = 2;
                    Ship.field[posX - 1, posY] = 2;
                    Ship.field[posX, posY - 1] = 2;
                    Ship.field[posX - 1, posY - 1] = 2;
                    Ship.field[posX + 1, posY - 1] = 2;
                }
                else if (posX == 0)
                {
                    Ship.field[posX + 1, posY] = 2;
                    Ship.field[posX, posY + 1] = 2;
                    Ship.field[posX, posY - 1] = 2;
                    Ship.field[posX + 1, posY + 1] = 2;
                    Ship.field[posX + 1, posY - 1] = 2;
                }
                else if (posX == 9)
                {                    
                    Ship.field[posX - 1, posY] = 2;
                    Ship.field[posX, posY + 1] = 2;
                    Ship.field[posX, posY - 1] = 2;
                    Ship.field[posX - 1, posY - 1] = 2;
                    Ship.field[posX - 1, posY + 1] = 2;
                }
                else
                {
                    Ship.field[posX + 1, posY] = 2;
                    Ship.field[posX - 1, posY] = 2;
                    Ship.field[posX, posY + 1] = 2;
                    Ship.field[posX, posY - 1] = 2;
                    Ship.field[posX - 1, posY - 1] = 2;
                    Ship.field[posX + 1, posY + 1] = 2;
                     Ship.field[posX + 1, posY - 1] = 2;
                    Ship.field[posX - 1, posY + 1] = 2;
                }
                return true;
            }
            else return false;
        }       
        public override string ToString()
        {
            return "Однопалубный корабль";
        }
    }   
}
