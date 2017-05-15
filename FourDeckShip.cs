using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace BattleShip
{
    class FourDeckShip : Ship
    {
        public FourDeckShip()
        {
            hp = 4;
        }
        public override bool SetLocation(string location)
        {
            string[] pos = location.Split(new char[] { ',' });
            int posX = int.Parse(pos[0]);
            int posY = int.Parse(pos[1]);
            if (Ship.field[posX, posY] != 1 && Ship.field[posX, posY] != 2)
            {
                if (posX == 0 && posY == 0)
                {
                    if (Ship.field[posX, posY + 1] != 2 && Ship.field[posX, posY + 2] != 2 && Ship.field[posX, posY + 3] != 2)
                    {
                        int ax = posX;
                        int ay = posY + 3;                        
                        Ship.field[posX, posY] = 1;
                        Ship.field[ax, ay - 1] = 1;
                        Ship.field[ax, ay - 2] = 1;
                        Ship.field[ax, ay] = 1;
                        this.location = new string[] { (posX + "," + posY), (ax + "," + ay), (ax + "," + (ay - 1)), (ax + "," + (ay - 2)) };
                        return true;
                    }
                    else if (Ship.field[posX + 1, posY] != 2 && Ship.field[posX + 2, posY] != 2 && Ship.field[posX + 3, posY] != 2)
                    {
                        int ax = posX + 3;
                        int ay = posY;                        
                        Ship.field[posX, posY] = 1;
                        Ship.field[ax - 1, ay] = 1;
                        Ship.field[ax - 2, ay] = 1;
                        Ship.field[ax, ay] = 1;
                        this.location = new string[] { (posX + "," + posY), (ax + "," + ay), ((ax-1) + "," + ay), ((ax-2) + "," + ay) };
                        return true;
                    }
                }
                else if (posX == 9 && posY == 0)
                {
                    if (Ship.field[posX, posY + 1] != 2 && Ship.field[posX, posY + 2] != 2 && Ship.field[posX, posY + 3] != 2)
                    {
                        int ax = posX;
                        int ay = posY + 3;                       
                        Ship.field[posX, posY] = 1;
                        Ship.field[posX, posY + 1] = 1;
                        Ship.field[posX, posY + 2] = 1;
                        Ship.field[ax, ay] = 1;
                        this.location = new string[] { (posX + "," + posY), (ax + "," + ay), (ax + "," + (ay - 1)), (ax + "," + (ay - 2)) };
                        return true;
                    }
                    else if (Ship.field[posX - 1, posY] != 2 && Ship.field[posX - 2, posY] != 2 && Ship.field[posX - 3, posY] != 2)
                    {
                        int ax = posX - 3;
                        int ay = posY;
                        Ship.field[posX, posY] = 1;
                        Ship.field[posX - 1, posY] = 1;
                        Ship.field[posX - 2, posY] = 1;
                        Ship.field[ax, ay] = 1;
                        this.location = new string[] { (posX + "," + posY), (ax + "," + ay), ((ax + 1) + "," + ay), ((ax + 2) + "," + ay) };
                        return true;
                    }
                }
                else if (posX == 9 && posY == 9)
                {
                    if (Ship.field[posX, posY - 1] != 2 && Ship.field[posX, posY - 2] != 2 && Ship.field[posX, posY - 3] != 2)
                    {
                        int ax = posX;
                        int ay = posY - 3;                        
                        Ship.field[posX, posY] = 1;
                        Ship.field[posX, posY - 1] = 1;
                        Ship.field[posX, posY - 2] = 1;
                        Ship.field[ax, ay] = 1;
                        this.location = new string[] { (posX + "," + posY), (ax + "," + ay), (ax + "," + (ay + 1)), (ax + "," + (ay + 2)) };
                        return true;
                    }
                    else if (Ship.field[posX - 1, posY] != 2 && Ship.field[posX - 2, posY] != 2 && Ship.field[posX - 3, posY] != 2)
                    {
                        int ax = posX - 3;
                        int ay = posY;                       
                        Ship.field[posX, posY] = 1;
                        Ship.field[posX - 2, posY] = 1;
                        Ship.field[posX - 1, posY] = 1;
                        Ship.field[ax, ay] = 1;
                        this.location = new string[] { (posX + "," + posY), (ax + "," + ay), ((ax + 1) + "," + ay), ((ax + 2) + "," + ay) };
                        return true;
                    }
                }
                else if (posX == 0 && posY == 9)
                {
                    if (Ship.field[posX, posY - 1] != 2 && Ship.field[posX, posY - 2] != 2 && Ship.field[posX, posY - 3] != 2)
                    {
                        int ax = posX;
                        int ay = posY - 3;                       
                        Ship.field[posX, posY] = 1;
                        Ship.field[posX, posY - 1] = 1;
                        Ship.field[posX, posY - 2] = 1;
                        Ship.field[ax, ay] = 1;
                        this.location = new string[] { (posX + "," + posY), (ax + "," + ay), (ax + "," + (ay + 1)), (ax + "," + (ay + 2)) };
                        return true;
                    }
                    else if (Ship.field[posX + 1, posY] != 2 && Ship.field[posX + 2, posY] != 2 && Ship.field[posX + 3, posY] != 2)
                    {
                        int ax = posX + 3;
                        int ay = posY;
                        Ship.field[posX, posY] = 1;
                        Ship.field[posX + 1, posY] = 1;
                        Ship.field[posX + 2, posY] = 1;
                        Ship.field[ax, ay] = 1;
                        this.location = new string[] { (posX + "," + posY), (ax + "," + ay), ((ax - 1) + "," + ay), ((ax - 2) + "," + ay) };
                        return true;
                    }
                }
                else if (posY == 0)
                {
                    if (posX - 3 >=0 && Ship.field[posX - 1, posY] != 2 && Ship.field[posX - 2, posY] != 2 && Ship.field[posX - 3, posY] != 2)
                    {
                        int ax = posX - 3;
                        int ay = posY;
                        Ship.field[posX, posY] = 1;
                        Ship.field[posX - 1, ay] = 1;
                        Ship.field[posX - 2, ay] = 1;
                        Ship.field[ax, ay] = 1;
                        this.location = new string[] { (posX + "," + posY), (ax + "," + ay), ((ax + 1) + "," + ay), ((ax + 2) + "," + ay) };
                        return true;
                    }
                    else if (posX +3<= 9 && Ship.field[posX + 1, posY] != 2 && Ship.field[posX + 2, posY] != 2 && Ship.field[posX + 3, posY] != 2)
                    {
                        int ax = posX + 3;
                        int ay = posY;
                        Ship.field[posX, posY] = 1;
                        Ship.field[posX + 1, posY] = 1;
                        Ship.field[posX + 2, posY] = 1;
                        Ship.field[ax, ay] = 1;
                        this.location = new string[] { (posX + "," + posY), (ax + "," + ay), ((ax - 1) + "," + ay), ((ax - 2) + "," + ay) };
                        return true;
                    }                    
                }
                else if (posY == 9)
                {
                    if (posX - 3>=0 && Ship.field[posX - 1, posY] != 2 && Ship.field[posX - 2, posY] != 2 && Ship.field[posX - 3, posY] != 2)
                    {
                        int ax = posX - 3;
                        int ay = posY;
                        Ship.field[posX, posY] = 1;
                        Ship.field[ax - 1, ay] = 1;
                        Ship.field[ax - 2, ay] = 1;
                        Ship.field[ax, ay] = 1;
                        this.location = new string[] { (posX + "," + posY), (ax + "," + ay), ((ax + 1) + "," + ay), ((ax + 2) + "," + ay) };
                        return true;
                    }
                    else if (posX+3<=9 && Ship.field[posX + 1, posY] != 2 && Ship.field[posX + 2, posY] != 2 && Ship.field[posX + 3, posY] != 2)
                    {
                        int ax = posX + 3;
                        int ay = posY;                        
                        Ship.field[posX, posY] = 1;
                        Ship.field[posX + 1, posY] = 1;
                        Ship.field[posX + 2, posY] = 1;
                        Ship.field[ax, ay] = 1;
                        this.location = new string[] { (posX + "," + posY), (ax + "," + ay), ((ax - 1) + "," + ay), ((ax - 2) + "," + ay) };
                        return true;
                    }  
                }
                else if (posX == 0)
                {
                    if (posY-3>=0 && Ship.field[posX, posY - 1] != 2 && Ship.field[posX, posY - 2] != 2 && Ship.field[posX, posY - 3] != 2)
                    {
                        int ax = posX;
                        int ay = posY - 3;
                        Ship.field[ax, ay] = 1;
                        Ship.field[posX, posY] = 1;
                        Ship.field[posX, posY - 1] = 1;
                        Ship.field[posX, posY - 2] = 1;
                        this.location = new string[] { (posX + "," + posY), (ax + "," + ay), (ax + "," + (ay + 1)), (ax + "," + (ay + 2)) };
                        return true;
                    }
                    else if (posY +3<=9 && Ship.field[posX, posY + 1] != 2 && Ship.field[posX, posY + 2] != 2 && Ship.field[posX, posY + 3] != 2)
                    {
                        int ax = posX;
                        int ay = posY + 3;
                        Ship.field[posX, posY] = 1;
                        Ship.field[posX, posY + 1] = 1;
                        Ship.field[posX, posY + 2] = 1;
                        Ship.field[posX, ay] = 1;
                        this.location = new string[] { (posX + "," + posY), (ax + "," + ay), (ax + "," + (ay - 1)), (ax + "," + (ay - 2)) };
                        return true;
                    }
                }
                else if (posX == 9)
                {
                    if (posY -3 >=0 && Ship.field[posX, posY - 1] != 2 && Ship.field[posX, posY - 2] != 2 && Ship.field[posX, posY - 3] != 2)
                    {
                        int ax = posX;
                        int ay = posY - 3;
                        Ship.field[ax, ay] = 1;
                        Ship.field[posX, posY] = 1;
                        Ship.field[posX, posY - 1] = 1;
                        Ship.field[posX, posY - 2] = 1;
                        this.location = new string[] { (posX + "," + posY), (ax + "," + ay), (ax + "," + (ay + 1)), (ax + "," + (ay + 2)) };
                        return true;
                    }
                    else if (posY + 3<=9 && Ship.field[posX, posY + 1] != 2 && Ship.field[posX, posY + 2] != 2 && Ship.field[posX, posY + 3] != 2)
                    {
                        int ax = posX;
                        int ay = posY + 3;
                        Ship.field[posX, posY] = 1;
                        Ship.field[posX, posY + 1] = 1;
                        Ship.field[posX, posY + 2] = 1;
                        Ship.field[posX, ay] = 1;
                        this.location = new string[] { (posX + "," + posY), (ax + "," + ay), (ax + "," + (ay - 1)), (ax + "," + (ay - 2)) };
                        return true;
                    }
                }
                else
                {
                    if (posX - 3 >=0 && Ship.field[posX - 1, posY] != 2 && Ship.field[posX - 2, posY] != 2 && Ship.field[posX - 3, posY] != 2)
                    {
                        int ax = posX - 3;
                        int ay = posY;
                        Ship.field[ax, ay] = 1;
                        Ship.field[posX - 1, posY] = 1;
                        Ship.field[posX - 2, posY] = 1;
                        Ship.field[posX, posY] = 1;
                        this.location = new string[] { (posX + "," + posY), (ax + "," + ay), ((ax + 1) + "," + ay), ((ax + 2) + "," + ay) };
                        return true;
                    }
                    else if ((posX + 3 <= 9) && Ship.field[posX + 1, posY] != 2 && Ship.field[posX + 2, posY] != 2 && Ship.field[posX + 3, posY] != 2)
                    {
                        int ax = posX + 3;
                        int ay = posY;                        
                        Ship.field[ax, ay] = 1;
                        Ship.field[posX + 1, posY] = 1;
                        Ship.field[posX + 2, posY] = 1;
                        Ship.field[posX, posY] = 1;
                        this.location = new string[] { (posX + "," + posY), (ax + "," + ay), ((ax - 1) + "," + ay), ((ax - 2) + "," + ay) };
                        return true;
                    }
                    else if (posY + 3 <= 9 && Ship.field[posX, posY + 1] != 2 && Ship.field[posX, posY + 2] != 2 && Ship.field[posX, posY + 3] != 2)
                    {
                        int ax = posX;
                        int ay = posY + 3;
                        Ship.field[posX, posY] = 1;
                        Ship.field[posX, posY + 1] = 1;
                        Ship.field[posX, posY + 2] = 1;
                        Ship.field[ax, ay] = 1;
                        this.location = new string[] { (posX + "," + posY), (ax + "," + ay), ((ax - 1) + "," + ay), ((ax - 2) + "," + ay) };
                        return true;
                    }
                    else if ((posY - 3 >= 0) && Ship.field[posX, posY - 1] != 2 && Ship.field[posX, posY - 2] != 2 && Ship.field[posX, posY - 3] != 2)
                    {
                        int ax = posX;
                        int ay = posY - 3;
                        Ship.field[posX, posY] = 1;
                        Ship.field[posX, posY - 1] = 1;
                        Ship.field[posX, posY - 2] = 1;
                        Ship.field[ax, ay] = 1;
                        this.location = new string[] { (posX + "," + posY), (ax + "," + ay), (ax + "," + (ay + 1)), (ax + "," + (ay + 2)) };
                        return true;
                    }
                }
                return false;
            }
            return false;
        }
        public override string ToString()
        {
            return "Четырехпалубный корабль";
        }
    }
}
    
