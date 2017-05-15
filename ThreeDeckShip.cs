using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BattleShip
{
    class ThreeDeckShip : Ship
    {
        public ThreeDeckShip()
        {
            hp = 3;
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
                    if (Ship.field[posX, posY + 1] != 2 && Ship.field[posX, posY + 2] != 2)
                    {
                        int ax = posX;
                        int ay = posY + 2;
                        Ship.field[ax, ay + 1] = 2;
                        Ship.field[ax + 1, ay + 1] = 2;
                        Ship.field[ax + 1, ay] = 2;
                        Ship.field[posX + 1, ay-1] = 2;
                        Ship.field[posX + 1, posY] = 2;
                        Ship.field[posX, posY] = 1;
                        Ship.field[ax, ay - 1] = 1;
                        Ship.field[ax, ay] = 1;
                        this.location = new string[] { (posX + "," + posY), (ax + "," + ay), (ax + "," + (ay-1)) };
                        return true;
                    }
                    else if (Ship.field[posX + 1, posY] != 2 && Ship.field[posX + 2, posY] != 2)
                    {
                        int ax = posX + 2;
                        int ay = posY;
                        Ship.field[ax+1, ay] = 2;
                        Ship.field[ax + 1, ay + 1] = 2;
                        Ship.field[ax , ay+1] = 2;
                        Ship.field[posX + 1, posY+1] = 2;
                        Ship.field[posX, posY+1] = 2;
                        Ship.field[posX, posY] = 1;
                        Ship.field[ax-1, ay] = 1;
                        Ship.field[ax, ay] = 1;
                        this.location = new string[] { (posX + "," + posY), (ax + "," + ay), ((ax-1) + "," + ay ) };
                        return true;
                    }
                }
                else if (posX == 9 && posY == 0)
                {
                    if (Ship.field[posX, posY + 1] != 2 && Ship.field[posX, posY + 2] != 2)
                    {
                        int ax = posX;
                        int ay = posY + 2;
                        Ship.field[ax, ay + 1] = 2;
                        Ship.field[ax -1, ay + 1] = 2;
                        Ship.field[ax - 1, ay] = 2;
                        Ship.field[posX - 1, posY+1] = 2;
                        Ship.field[posX - 1, posY] = 2;
                        Ship.field[posX, posY] = 1;
                        Ship.field[posX, posY + 1] = 1;
                        Ship.field[ax, ay] = 1;
                        this.location = new string[] { (posX + "," + posY), (ax + "," + ay), (ax + "," + (ay - 1)) };
                        return true;
                    }
                    else if (Ship.field[posX - 1, posY] != 2 && Ship.field[posX - 2, posY] != 2)
                    {
                        int ax = posX - 2;
                        int ay = posY;
                        Ship.field[ax - 1, ay] = 2;
                        Ship.field[ax - 1, ay + 1] = 2;
                        Ship.field[ax, ay + 1] = 2;
                        Ship.field[posX - 1, posY + 1] = 2;
                        Ship.field[posX, posY + 1] = 2;
                        Ship.field[posX, posY] = 1;
                        Ship.field[posX - 1, posY] = 1;
                        Ship.field[ax, ay] = 1;
                        this.location = new string[] { (posX + "," + posY), (ax + "," + ay), ((ax+1) + "," + ay) };
                        return true;
                    }
                }
                else if (posX == 9 && posY == 9)
                {
                    if (Ship.field[posX, posY - 1] != 2 && Ship.field[posX, posY - 2] != 2)
                    {
                        int ax = posX;
                        int ay = posY - 2;
                        Ship.field[ax, ay - 1] = 2;
                        Ship.field[ax - 1, ay - 1] = 2;
                        Ship.field[ax - 1, ay] = 2;
                        Ship.field[posX - 1, posY - 1] = 2;
                        Ship.field[posX - 1, posY] = 2;
                        Ship.field[posX, posY] = 1;
                        Ship.field[posX , posY - 1] = 1;
                        Ship.field[ax, ay] = 1;
                        this.location = new string[] { (posX + "," + posY), (ax + "," + ay), (ax + "," + (ay + 1)) };
                        return true;
                    }
                    else if (Ship.field[posX - 1, posY] != 2 && Ship.field[posX - 2, posY] != 2)
                    {
                        int ax = posX - 2;
                        int ay = posY;
                        Ship.field[ax - 1, ay] = 2;
                        Ship.field[ax - 1, ay - 1] = 2;
                        Ship.field[ax, ay - 1] = 2;
                        Ship.field[posX - 1, posY - 1] = 2;
                        Ship.field[posX, posY - 1] = 2;
                        Ship.field[posX, posY] = 1;
                        Ship.field[posX - 1, posY] = 1;
                        Ship.field[ax, ay] = 1;
                        this.location = new string[] { (posX + "," + posY), (ax + "," + ay), ((ax+1) + "," + ay ) };
                        return true;
                    }
                }
                else if (posX == 0 && posY == 9)
                {
                    if (Ship.field[posX, posY - 1] != 2 && Ship.field[posX, posY - 2] != 2)
                    {
                        int ax = posX;
                        int ay = posY - 2;
                        Ship.field[ax, ay - 1] = 2;
                        Ship.field[ax + 1, ay - 1] = 2;
                        Ship.field[ax + 1, ay] = 2;
                        Ship.field[posX + 1, posY - 1] = 2;
                        Ship.field[posX + 1, posY] = 2;
                        Ship.field[posX, posY] = 1;
                        Ship.field[posX, posY - 1] = 1;
                        Ship.field[ax, ay] = 1;
                        this.location = new string[] { (posX + "," + posY), (ax + "," + ay), (ax + "," + (ay + 1)) };
                        return true;
                    }
                    else if (Ship.field[posX + 1, posY] != 2 && Ship.field[posX + 2, posY] != 2)
                    {
                        int ax = posX + 2;
                        int ay = posY;
                        Ship.field[ax + 1, ay] = 2;
                        Ship.field[ax + 1, ay - 1] = 2;
                        Ship.field[ax, ay - 1] = 2;
                        Ship.field[posX+1, posY - 1] = 2;
                        Ship.field[posX , posY - 1] = 2;
                        Ship.field[posX, posY] = 1;
                        Ship.field[posX+1, posY] = 1;
                        Ship.field[ax, ay] = 1;
                        this.location = new string[] { (posX + "," + posY), (ax + "," + ay), ((ax-1) + "," + ay) };
                        return true;
                    }
                }
                else if (posY == 0)
                {
                    if (posX==2 && Ship.field[posX - 1, posY] != 2 && Ship.field[posX - 2, posY] != 2)
                    {
                        int ax = posX - 2;
                        int ay = posY;
                        Ship.field[ax, ay+1] = 2;
                        Ship.field[ax + 1, ay + 1] = 2;
                        Ship.field[posX, ay + 1] = 2;
                        Ship.field[posX+1, posY + 1] = 2;
                        Ship.field[posX+1, posY] = 2;
                        Ship.field[posX,posY] = 1;
                        Ship.field[posX - 1, ay] = 1;
                        Ship.field[ax, ay] = 1;
                        this.location = new string[] { (posX + "," + posY), (ax + "," + ay), ((ax+1) + "," + ay) };
                        return true;
                    }
                    else if (posX==7 && Ship.field[posX + 1, posY] != 2 && Ship.field[posX + 2, posY] != 2)
                    {
                        int ax = posX + 2;
                        int ay = posY;
                        Ship.field[ax, ay+1] = 2;
                        Ship.field[ax - 1, ay + 1] = 2;
                        Ship.field[posX, ay + 1] = 2;
                        Ship.field[posX - 1, posY + 1] = 2;
                        Ship.field[posX - 1, posY] = 2;
                        Ship.field[posX, posY] = 1;
                        Ship.field[posX + 1, posY] = 1;
                        Ship.field[ax, ay] = 1;
                        this.location = new string[] { (posX + "," + posY), (ax + "," + ay), ((ax-1) + "," + ay) };
                        return true;
                    }
                    else if (posX<=7 && Ship.field[posX + 1, posY] != 2 && Ship.field[posX + 2, posY] != 2)
                    {
                        int ax = posX+2;
                        int ay = posY;
                        Ship.field[ax+1, posY] = 2;
                        Ship.field[ax + 1, ay+1] = 2;
                        Ship.field[ax , ay + 1] = 2;
                        Ship.field[ax-1, ay + 1] = 2;
                        Ship.field[posX, ay + 1] = 2;
                        Ship.field[posX-1, ay + 1] = 2;
                        Ship.field[posX - 1, posY] = 2;
                        Ship.field[posX, posY] = 1;
                        Ship.field[posX+1, posY] = 1;
                        Ship.field[ax, posY] = 1;
                        this.location = new string[] { (posX + "," + posY), (ax + "," + ay), ((ax-1) + "," + ay) };
                        return true;
                    }
                    else if (posX>=2&& Ship.field[posX - 1, posY] != 2 && Ship.field[posX - 2, posY] != 2)
                    {
                        int ax = posX - 2;
                        int ay = posY;
                        Ship.field[ax - 1, posY] = 2;
                        Ship.field[ax - 1, ay + 1] = 2;
                        Ship.field[ax, ay + 1] = 2;
                        Ship.field[ax + 1, ay + 1] = 2;
                        Ship.field[posX, ay + 1] = 2;
                        Ship.field[posX + 1, ay + 1] = 2;
                        Ship.field[posX + 1, posY] = 2;
                        Ship.field[posX, posY] = 1;
                        Ship.field[posX - 1, posY] = 1;
                        Ship.field[ax, posY] = 1;
                        this.location = new string[] { (posX + "," + posY), (ax + "," + ay), ((ax+1) + "," + ay ) };
                        return true;
                    }
                }
                else if (posY == 9)
                {
                    if (posX == 2 && Ship.field[posX - 1, posY] != 2 && Ship.field[posX - 2, posY] != 2)
                    {
                        int ax = posX - 2;
                        int ay = posY;
                        Ship.field[ax, ay - 1] = 2;
                        Ship.field[ax + 1, ay - 1] = 2;
                        Ship.field[posX, ay - 1] = 2;
                        Ship.field[posX + 1, posY - 1] = 2;
                        Ship.field[posX + 1, posY] = 2;
                        Ship.field[posX, posY] = 1;
                        Ship.field[ax + 1, ay] = 1;
                        Ship.field[ax, ay] = 1;
                        this.location = new string[] { (posX + "," + posY), (ax + "," + ay), ((ax+1) + "," + ay) };
                        return true;
                    }
                    else if (posX == 7 && Ship.field[posX + 1, posY] != 2 && Ship.field[posX + 2, posY] != 2)
                    {
                        int ax = posX + 2;
                        int ay = posY;
                        Ship.field[ax, ay - 1] = 2;
                        Ship.field[ax - 1, ay - 1] = 2;
                        Ship.field[posX, ay - 1] = 2;
                        Ship.field[posX - 1, posY - 1] = 2;
                        Ship.field[posX - 1, posY] = 2;
                        Ship.field[posX, posY] = 1;
                        Ship.field[posX + 1, posY] = 1;
                        Ship.field[ax, ay] = 1;
                        this.location = new string[] { (posX + "," + posY), (ax + "," + ay), ((ax-1) + "," + ay ) };
                        return true;
                    }
                    else if (posX+2<=8 && Ship.field[posX + 1, posY] != 2 && Ship.field[posX + 2, posY] != 2)
                    {
                        int ax = posX + 2;
                        int ay = posY;
                        Ship.field[ax + 1, posY] = 2;
                        Ship.field[ax + 1, ay - 1] = 2;
                        Ship.field[ax, ay - 1] = 2;
                        Ship.field[ax - 1, ay - 1] = 2;
                        Ship.field[posX, ay - 1] = 2;
                        Ship.field[posX - 1, ay - 1] = 2;
                        Ship.field[posX - 1, posY] = 2;
                        Ship.field[posX, posY] = 1;
                        Ship.field[posX + 1, posY] = 1;
                        Ship.field[ax, posY] = 1;
                        this.location = new string[] { (posX + "," + posY), (ax + "," + ay), ((ax-1) + "," + ay) };
                        return true;
                    }
                    else if (posX>=3 && Ship.field[posX - 1, posY] != 2 && Ship.field[posX - 2, posY] != 2)
                    {
                        int ax = posX - 2;
                        int ay = posY;
                        Ship.field[ax - 1, posY] = 2;
                        Ship.field[ax - 1, ay - 1] = 2;
                        Ship.field[ax, ay - 1] = 2;
                        Ship.field[ax + 1, ay - 1] = 2;
                        Ship.field[posX, ay - 1] = 2;
                        Ship.field[posX + 1, ay - 1] = 2;
                        Ship.field[posX + 1, posY] = 2;
                        Ship.field[posX, posY] = 1;
                        Ship.field[posX - 1, posY] = 1;
                        Ship.field[ax, posY] = 1;
                        this.location = new string[] { (posX + "," + posY), (ax + "," + ay), ((ax+1) + "," + ay) };
                        return true;
                    }
                }
                else if (posX == 0)
                {
                    if (posY==2 && Ship.field[posX, posY - 1] != 2 && Ship.field[posX, posY - 2] != 2)
                    {
                        int ax = posX;
                        int ay = posY - 2;
                        Ship.field[ax +1 , ay] = 2;
                        Ship.field[ax + 1, ay+1] = 2;
                        Ship.field[ax + 1, posY] = 2;
                        Ship.field[ax + 1, posY+1] = 2;
                        Ship.field[posX, posY + 1] = 2;
                        Ship.field[ax, ay] = 1;
                        Ship.field[posX, posY] = 1;
                        Ship.field[posX, posY - 1] = 1;
                        this.location = new string[] { (posX + "," + posY), (ax + "," + ay), (ax + "," + (ay + 1)) };
                        return true;
                    }
                    else if (posY == 7 && Ship.field[posX, posY + 1] != 2 && Ship.field[posX, posY + 2] != 2)
                    {
                        int ax = posX;
                        int ay = posY + 2;
                        Ship.field[ax , posY - 1] = 2;
                        Ship.field[ax + 1, posY -1] = 2;
                        Ship.field[ax + 1, posY] = 2;
                        Ship.field[posX + 1, posY+1] = 2;
                        Ship.field[posX + 1, ay] = 2;
                        Ship.field[ax, ay] = 2;
                        Ship.field[posX, posY] = 1;
                        Ship.field[posX, posY + 1] = 1;
                        Ship.field[posX, ay] = 1;
                        this.location = new string[] { (posX + "," + posY), (ax + "," + ay), (ax + "," + (ay - 1)) };
                        return true;
                    }
                    else if (posY<=6&& Ship.field[posX, posY + 1] != 2 && Ship.field[posX, posY + 2] != 2)
                    {
                        int ax = posX;
                        int ay = posY + 2;
                        Ship.field[ax, posY - 1] = 2;
                        Ship.field[ax + 1, posY - 1] = 2;
                        Ship.field[ax + 1, posY] = 2;
                        Ship.field[posX + 1, posY + 1] = 2;
                        Ship.field[posX + 1, ay] = 2;
                        Ship.field[posX + 1, ay+1] = 2;
                        Ship.field[posX, ay+ 1] = 2;
                        Ship.field[posX, posY] = 1;
                        Ship.field[posX, posY + 1] = 1;
                        Ship.field[posX, ay] = 1;
                        this.location = new string[] { (posX + "," + posY), (ax + "," + ay), (ax + "," + (ay - 1)) };
                        return true;
                    }
                    if (posY>=3 && Ship.field[posX, posY - 1] != 2 && Ship.field[posX, posY - 2] != 2)
                    {
                        int ax = posX;
                        int ay = posY - 2;
                        Ship.field[ax , ay - 1] = 2;
                        Ship.field[ax + 1, ay -1] = 2;
                        Ship.field[ax + 1, ay] = 2;
                        Ship.field[ax + 1, ay + 1] = 2;
                        Ship.field[ax + 1, posY] = 2;
                        Ship.field[ax + 1, posY + 1] = 2;
                        Ship.field[posX, posY + 1] = 2;
                        Ship.field[ax, ay] = 1;
                        Ship.field[posX, posY] = 1;
                        Ship.field[posX, posY - 1] = 1;
                        this.location = new string[] { (posX + "," + posY), (ax + "," + ay), (ax + "," + (ay + 1)) };
                        return true;
                    }
                }
                else if (posX == 9)
                {
                    if (posY == 2 && Ship.field[posX, posY - 1] != 2 && Ship.field[posX, posY - 2] != 2)
                    {
                        int ax = posX;
                        int ay = posY - 2;
                        Ship.field[ax - 1, ay] = 2;
                        Ship.field[ax - 1, ay + 1] = 2;
                        Ship.field[ax - 1, posY] = 2;
                        Ship.field[ax - 1, posY + 1] = 2;
                        Ship.field[posX, posY + 1] = 2;
                        Ship.field[ax, ay] = 1;
                        Ship.field[posX, posY] = 1;
                        Ship.field[posX, posY - 1] = 1;
                        this.location = new string[] { (posX + "," + posY), (ax + "," + ay), (ax + "," + (ay + 1)) };
                        return true;
                    }
                    else if (posY == 7 && Ship.field[posX, posY + 1] != 2 && Ship.field[posX, posY + 2] != 2)
                    {
                        int ax = posX;
                        int ay = posY + 2;
                        Ship.field[ax, posY - 1] = 2;
                        Ship.field[ax - 1, posY - 1] = 2;
                        Ship.field[ax - 1, posY] = 2;
                        Ship.field[posX - 1, posY + 1] = 2;
                        Ship.field[posX - 1, ay] = 2;
                        Ship.field[ax, ay] = 2;
                        Ship.field[posX, posY] = 1;
                        Ship.field[posX, posY + 1] = 1;
                        Ship.field[posX, ay] = 1;
                        this.location = new string[] { (posX + "," + posY), (ax + "," + ay), (ax + "," + (ay - 1)) };
                        return true;
                    }
                    else if (posY<=6&&Ship.field[posX, posY + 1] != 2 && Ship.field[posX, posY + 2] != 2)
                    {
                        int ax = posX;
                        int ay = posY + 2;
                        Ship.field[ax, posY - 1] = 2;
                        Ship.field[ax - 1, posY - 1] = 2;
                        Ship.field[ax - 1, posY] = 2;
                        Ship.field[posX - 1, posY + 1] = 2;
                        Ship.field[posX - 1, ay] = 2;
                        Ship.field[posX - 1, ay] = 2;
                        Ship.field[posX, ay + 1] = 2;
                        Ship.field[ax, ay] = 2;
                        Ship.field[posX, posY] = 1;
                        Ship.field[posX, posY + 1] = 1;
                        Ship.field[posX, ay] = 1;
                        this.location = new string[] { (posX + "," + posY), (ax + "," + ay), (ax + "," + (ay - 1)) };
                        return true;
                    }
                    if (posY>=3&&Ship.field[posX, posY - 1] != 2 && Ship.field[posX, posY - 2] != 2)
                    {
                        int ax = posX;
                        int ay = posY - 2;
                        Ship.field[ax, ay - 1] = 2;
                        Ship.field[ax - 1, ay - 1] = 2;
                        Ship.field[ax - 1, ay] = 2;
                        Ship.field[ax - 1, ay + 1] = 2;
                        Ship.field[ax - 1, posY] = 2;
                        Ship.field[ax - 1, posY + 1] = 2;
                        Ship.field[posX, posY + 1] = 2;

                        Ship.field[ax, ay] = 1;
                        Ship.field[posX, posY] = 1;
                        Ship.field[posX, posY - 1] = 1;
                        this.location = new string[] { (posX + "," + posY), (ax + "," + ay), (ax + "," + (ay + 1)) };
                        return true;
                    }
                }
                else
                {
                    if ((posX - 2 >= 1) && (posY + 1 <= 9) && (posY - 1 >= 0) && posX + 1 <= 9&&Ship.field[posX - 1, posY] != 2 && Ship.field[posX - 2, posY] != 2 )
                    {
                        int ax = posX - 2;
                        int ay = posY;
                        Ship.field[posX + 1, ay] = 2;
                        Ship.field[posX + 1, ay+1] = 2;
                        Ship.field[posX , ay + 1] = 2;
                        Ship.field[posX - 1, ay + 1] = 2;
                        Ship.field[ax, ay + 1] = 2;
                        Ship.field[ax- 1, ay + 1] = 2;
                        Ship.field[ax- 1, ay] = 2;
                        Ship.field[ax - 1, ay - 1] = 2;
                        Ship.field[ax, ay - 1] = 2;
                        Ship.field[posX - 1, ay - 1] = 2;
                        Ship.field[posX , ay - 1] = 2;
                        Ship.field[posX + 1, ay - 1] = 2;
                        Ship.field[ax, ay] = 1;
                        Ship.field[posX - 1, posY] = 1;
                        Ship.field[posX, posY] = 1;
                        this.location = new string[] { (posX + "," + posY), (ax + "," + ay), ((ax+1) + "," + ay) };
                        return true;
                    }
                    else if ((posX - 1 >= 0) && (posY + 1 <= 9) && posX + 2 <= 8&& (posY - 1 >= 0) && Ship.field[posX + 1, posY] != 2 && Ship.field[posX + 2, posY] != 2)
                    {
                        int ax = posX + 2;
                        int ay = posY;
                        Ship.field[ax + 1, ay] = 2;
                        Ship.field[ax + 1, ay + 1] = 2;
                        Ship.field[ax, ay + 1] = 2;
                        Ship.field[ax - 1, ay + 1] = 2;
                        Ship.field[posX, ay + 1] = 2;
                        Ship.field[posX - 1, ay + 1] = 2;
                        Ship.field[posX - 1, ay] = 2;
                        Ship.field[posX - 1, ay - 1] = 2;
                        Ship.field[posX, ay - 1] = 2;
                        Ship.field[ax - 1, ay - 1] = 2;
                        Ship.field[ax, ay - 1] = 2;
                        Ship.field[ax + 1, ay - 1] = 2;
                        Ship.field[ax, ay] = 1;
                        Ship.field[posX + 1, posY] = 1;
                        Ship.field[posX, posY] = 1;
                        this.location = new string[] { (posX + "," + posY), (ax + "," + ay), ((ax - 1) + "," + ay) };
                        return true;
                    }
                    else if((posX - 1 >= 0) && (posX + 1 <= 9)&& posY + 2 <= 8 && Ship.field[posX, posY+1] != 2 && Ship.field[posX, posY+2] != 2)
                    {
                        int ax = posX;
                        int ay = posY+2;
                        Ship.field[posX, posY - 1] = 2;
                        Ship.field[posX - 1, posY - 1] = 2;
                        Ship.field[posX - 1, posY] = 2;
                        Ship.field[posX - 1, posY + 1] = 2;
                        Ship.field[posX - 1, ay] = 2;
                        Ship.field[posX - 1, ay + 1] = 2;
                        Ship.field[posX, ay+1] = 2;
                        Ship.field[posX + 1, ay+ 1] = 2;
                        Ship.field[posX + 1,ay] = 2;
                        Ship.field[posX + 1, ay - 1] = 2;
                        Ship.field[posX + 1, posY] = 2;
                        Ship.field[posX + 1, posY - 1] = 2;
                        Ship.field[posX, posY] = 1;
                        Ship.field[posX, posY+1] = 1;
                        Ship.field[ax, ay] = 1;
                        this.location = new string[] { (posX + "," + posY), (ax + "," + ay), (ax + "," + (ay - 1)) };
                        return true;
                    }
                    else if ((posX + 1 <= 9) && (posX - 1>=0) && (posY - 2 >= 1) && Ship.field[posX, posY - 1] != 2 && Ship.field[posX, posY - 2] != 2)
                    {
                        int ax = posX;
                        int ay = posY - 2;
                        Ship.field[posX, ay - 1] = 2;
                        Ship.field[posX - 1, ay - 1] = 2;
                        Ship.field[posX - 1, ay] = 2;
                        Ship.field[posX - 1, ay + 1] = 2;
                        Ship.field[posX - 1, posY] = 2;
                        Ship.field[posX - 1, posY + 1] = 2;
                        Ship.field[posX, posY + 1] = 2;
                        Ship.field[posX + 1, posY + 1] = 2;
                        Ship.field[posX + 1, posY] = 2;
                        Ship.field[posX + 1, posY - 1] = 2;
                        Ship.field[posX + 1, ay] = 2;
                        Ship.field[posX + 1, ay - 1] = 2;
                        Ship.field[posX, posY] = 1;
                        Ship.field[posX, posY - 1] = 1;
                        Ship.field[ax, ay] = 1;
                        this.location = new string[] { (posX + "," + posY), (ax + "," + ay), (ax + "," + (ay + 1)) };
                        return true;
                    }
                }
                return false;
            }
            return false;
        }
        public override string ToString()
        {
            return "Трехпалубный корабль";
        }
    }
}
