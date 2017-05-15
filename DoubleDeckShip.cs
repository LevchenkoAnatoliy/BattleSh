using System;
using System.Collections.Generic;

namespace BattleShip
{
    class DoubleDeckShip:Ship
    {
        public DoubleDeckShip()
        {
            hp = 2;
        }
        public override bool SetLocation(string location)
        {
            //Находи начальную точку
            string[] pos = location.Split(new char[] { ',' });
            int posX = int.Parse(pos[0]);
            int posY = int.Parse(pos[1]);
            //Проверяем, не занята ли начальная точка
            if (Ship.field[posX, posY] != 1 && Ship.field[posX, posY] != 2)
            {
                if (posX == 0 && posY == 0)
                {
                    if (Ship.field[posX, posY + 1] != 2)
                    {
                        int ax = posX;
                        int ay = posY + 1;
                        Ship.field[ax, ay + 1] = 2;
                        Ship.field[ax + 1, ay + 1] = 2;
                        Ship.field[ax + 1, ay] = 2;
                        Ship.field[posX + 1, posY] = 2;
                        Ship.field[posX, posY] = 1;
                        Ship.field[ax, ay] = 1;
                        this.location = new string[] { (posX + "," + posY), (ax + "," + ay) };
                        return true;
                    }
                    else if (Ship.field[posX + 1, posY] != 2)
                    {
                        int ax = posX + 1;
                        int ay = posY;
                        Ship.field[ax, ay + 1] = 2;
                        Ship.field[ax + 1, ay + 1] = 2;
                        Ship.field[ax + 1, ay] = 2;
                        Ship.field[posX + 1, posY] = 2;
                        Ship.field[posX, posY] = 1;
                        Ship.field[ax, ay] = 1;
                        this.location = new string[] { (posX + "," + posY), (ax + "," + ay) };
                        return true;
                    }
                }
                else if (posX == 9 && posY == 0)
                {
                    if (Ship.field[posX, posY + 1] != 2)
                    {
                        int ax = posX;
                        int ay = posY + 1;
                        Ship.field[ax, ay + 1] = 2;
                        Ship.field[ax + 1, ay + 1] = 2;
                        Ship.field[ax - 1, ay] = 2;
                        Ship.field[posX - 1, posY] = 2;
                        Ship.field[posX, posY] = 1;
                        Ship.field[ax, ay] = 1;
                        this.location = new string[] { (posX + "," + posY), (ax + "," + ay) };
                        return true;
                    }
                    else if (Ship.field[posX - 1, posY] != 2)
                    {
                        int ax = posX - 1;
                        int ay = posY;
                        Ship.field[ax - 1, ay] = 2;
                        Ship.field[ax - 1, ay + 1] = 2;
                        Ship.field[ax, ay + 1] = 2;
                        Ship.field[posX, posY + 1] = 2;
                        Ship.field[posX, posY] = 1;
                        Ship.field[ax, ay] = 1;
                        this.location = new string[] { (posX + "," + posY), (ax + "," + ay) };
                        return true;
                    }
                }
                else if (posX == 9 && posY == 9)
                {
                    if (Ship.field[posX, posY - 1] != 2)
                    {
                        int ax = posX;
                        int ay = posY - 1;
                        Ship.field[ax, ay - 1] = 2;
                        Ship.field[ax - 1, ay - 1] = 2;
                        Ship.field[ax - 1, ay] = 2;
                        Ship.field[posX - 1, posY] = 2;
                        Ship.field[posX, posY] = 1;
                        Ship.field[ax, ay] = 1;
                        this.location = new string[] { (posX + "," + posY), (ax + "," + ay) };
                        return true;
                    }
                    else if (Ship.field[posX - 1, posY] != 2)
                    {
                        int ax = posX - 1;
                        int ay = posY;
                        Ship.field[ax - 1, ay] = 2;
                        Ship.field[ax - 1, ay - 1] = 2;
                        Ship.field[ax, ay - 1] = 2;
                        Ship.field[posX, posY - 1] = 2;
                        Ship.field[posX, posY] = 1;
                        Ship.field[ax, ay] = 1;
                        this.location = new string[] { (posX + "," + posY), (ax + "," + ay) };
                        return true;
                    }
                }
                else if (posX == 0 && posY == 9)
                {
                    if (Ship.field[posX, posY - 1] != 2)
                    {
                        int ax = posX;
                        int ay = posY - 1;
                        Ship.field[ax, ay - 1] = 2;
                        Ship.field[ax + 1, ay - 1] = 2;
                        Ship.field[ax + 1, ay] = 2;
                        Ship.field[posX + 1, posY] = 2;
                        Ship.field[posX, posY] = 1;
                        Ship.field[ax, ay] = 1;
                        this.location = new string[] { (posX + "," + posY), (ax + "," + ay) };
                        return true;
                    }
                    else if (Ship.field[posX + 1, posY] != 2)
                    {
                        int ax = posX + 1;
                        int ay = posY;
                        Ship.field[ax + 1, ay] = 2;
                        Ship.field[ax + 1, ay - 1] = 2;
                        Ship.field[ax, ay - 1] = 2;
                        Ship.field[posX, posY - 1] = 2;
                        Ship.field[posX, posY] = 1;
                        Ship.field[ax, ay] = 1;
                        this.location = new string[] { (posX + "," + posY), (ax + "," + ay) };
                        return true;
                    }
                }
                else if (posY == 0)
                {
                    if (posX-1 >= 1 && Ship.field[posX - 1, posY] != 2)
                    {
                        int ax = posX - 1;
                        int ay = posY;
                        Ship.field[ax - 1, ay] = 2;
                        Ship.field[ax - 1, ay + 1] = 2;
                        Ship.field[ax, ay + 1] = 2;
                        Ship.field[ax + 1, ay + 1] = 2;
                        Ship.field[posX + 1, posY + 1] = 2;
                        Ship.field[posX + 1, posY] = 2;
                        Ship.field[posX, posY] = 1;
                        Ship.field[posX - 1, posY] = 1;
                        this.location = new string[] { (posX + "," + posY), (ax + "," + ay) };
                        return true;
                    }
                    else if (posX+1<=8 && Ship.field[posX + 1, posY] != 2)
                    {
                        int ax = posX + 1;
                        int ay = posY;
                        Ship.field[ax + 1, ay] = 2;
                        Ship.field[ax + 1, ay + 1] = 2;
                        Ship.field[ax, ay + 1] = 2;
                        Ship.field[ax - 1, ay + 1] = 2;
                        Ship.field[posX - 1, posY + 1] = 2;
                        Ship.field[posX - 1, posY] = 2;
                        Ship.field[posX, posY] = 1;
                        Ship.field[posX + 1, posY] = 1;
                        this.location = new string[] { (posX + "," + posY), (ax + "," + ay) };
                        return true;
                    }
                }
                else if (posY == 9)
                {
                    if (posX-1 >= 1 && Ship.field[posX - 1, posY] != 2)
                    {
                        int ax = posX - 1;
                        int ay = posY;
                        Ship.field[ax - 1, ay] = 2;
                        Ship.field[ax - 1, ay - 1] = 2;
                        Ship.field[ax, ay - 1] = 2;
                        Ship.field[ax + 1, ay - 1] = 2;
                        Ship.field[posX + 1, posY - 1] = 2;
                        Ship.field[posX + 1, posY] = 2;
                        Ship.field[posX, posY] = 1;
                        Ship.field[posX - 1, posY] = 1;
                        this.location = new string[] { (posX + "," + posY), (ax + "," + ay) };
                        return true;
                    }
                    else if (posX+1<=8 && Ship.field[posX + 1, posY] != 2)
                    {
                        int ax = posX + 1;
                        int ay = posY;
                        Ship.field[ax + 1, ay] = 2;
                        Ship.field[ax + 1, ay - 1] = 2;
                        Ship.field[ax, ay - 1] = 2;
                        Ship.field[ax - 1, ay - 1] = 2;
                        Ship.field[posX - 1, posY - 1] = 2;
                        Ship.field[posX - 1, posY] = 2;
                        Ship.field[posX, posY] = 1;
                        Ship.field[posX + 1, posY] = 1;
                        this.location = new string[] { (posX + "," + posY), (ax + "," + ay) };
                        return true;
                    }
                }
                else if (posX == 0)
                {
                    if (posY-1>=1 && Ship.field[posX, posY - 1] != 2)
                    {
                        int ax = posX;
                        int ay = posY - 1;
                        Ship.field[ax, ay - 1] = 2;
                        Ship.field[ax + 1, ay - 1] = 2;
                        Ship.field[ax + 1, ay] = 2;
                        Ship.field[ax + 1, posY] = 2;
                        Ship.field[posX + 1, posY + 1] = 2;
                        Ship.field[posX, posY + 1] = 2;
                        Ship.field[posX, posY] = 1;
                        Ship.field[posX, posY - 1] = 1;
                        this.location = new string[] { (posX + "," + posY), (ax + "," + ay) };
                        return true;
                    }
                    else if (posY+1<=8 && Ship.field[posX, posY + 1] != 2)
                    {
                        int ax = posX;
                        int ay = posY + 1;
                        Ship.field[ax, ay + 1] = 2;
                        Ship.field[ax + 1, ay + 1] = 2;
                        Ship.field[ax + 1, ay] = 2;
                        Ship.field[posX + 1, posY] = 2;
                        Ship.field[posX + 1, posY - 1] = 2;
                        Ship.field[posX, posY - 1] = 2;
                        Ship.field[posX, posY] = 1;
                        Ship.field[posX, posY + 1] = 1;
                        this.location = new string[] { (posX + "," + posY), (ax + "," + ay) };
                        return true;
                    }
                }
                else if (posX == 9)
                {
                    if (posY-1 >=1 && Ship.field[posX, posY - 1] != 2)
                    {
                        int ax = posX;
                        int ay = posY - 1;
                        Ship.field[ax, ay - 1] = 2;
                        Ship.field[ax - 1, ay - 1] = 2;
                        Ship.field[ax - 1, ay] = 2;
                        Ship.field[ax - 1, posY] = 2;
                        Ship.field[posX - 1, posY - 1] = 2;
                        Ship.field[posX, posY + 1] = 2;
                        Ship.field[posX, posY] = 1;
                        Ship.field[posX, posY - 1] = 1;
                        this.location = new string[] { (posX + "," + posY), (ax + "," + ay) };
                        return true;
                    }
                    else if (posY+1 <=8 && Ship.field[posX, posY - 1] != 2)
                    {
                        int ax = posX;
                        int ay = posY - 1;
                        Ship.field[ax, ay - 1] = 2;
                        Ship.field[ax - 1, ay + 1] = 2;
                        Ship.field[ax - 1, ay] = 2;
                        Ship.field[posX - 1, posY] = 2;
                        Ship.field[posX - 1, posY - 1] = 2;
                        Ship.field[posX, posY - 1] = 2;
                        Ship.field[posX, posY] = 1;
                        Ship.field[posX, posY - 1] = 1;
                        this.location = new string[] { (posX + "," + posY), (ax + "," + ay) };
                        return true;
                    }
                }
                else
                {
                    if (Ship.field[posX - 1, posY] != 2 && (posX-2>=0))
                    {
                        int ax = posX - 1;
                        int ay = posY;
                        Ship.field[posX, posY - 1] = 2;
                        Ship.field[posX + 1, posY - 1] = 2;
                        Ship.field[posX + 1, posY] = 2;
                        Ship.field[posX + 1, posY + 1] = 2;
                        Ship.field[posX, posY + 1] = 2;
                        Ship.field[ax, posY + 1] = 2;
                        Ship.field[ax - 1, posY + 1] = 2;
                        Ship.field[ax - 1, posY] = 2;
                        Ship.field[ax - 1, posY - 1] = 2;
                        Ship.field[ax, posY - 1] = 2;

                        Ship.field[posX, posY] = 1;
                        Ship.field[ax, ay] = 1;
                        this.location = new string[] { (posX + "," + posY), (ax + "," + ay) };
                        return true;
                    }
                    else if (Ship.field[posX + 1, posY] != 2 && posX+2<=9)
                    {
                        int ax = posX + 1;
                        int ay = posY;
                        Ship.field[posX, posY - 1] = 2;
                        Ship.field[posX - 1, posY - 1] = 2;
                        Ship.field[posX - 1, posY] = 2;
                        Ship.field[posX - 1, posY + 1] = 2;
                        Ship.field[ax - 1, ay + 1] = 2;
                        Ship.field[ax, ay + 1] = 2;
                        Ship.field[ax + 1, ay + 1] = 2;
                        Ship.field[ax + 1, ay] = 2;
                        Ship.field[posX + 2, posY -1] = 2;
                        Ship.field[posX + 1, posY - 1] = 2;
                        Ship.field[posX, posY] = 1;
                        Ship.field[ax, ay] = 1;
                        this.location = new string[] { (posX + "," + posY), (ax + "," + ay) };
                        return true;
                    }
                    else if (Ship.field[posX, posY + 1] != 2&&posY+2<=9)
                    {
                        int ax = posX;
                        int ay = posY + 1;
                        Ship.field[posX, posY - 1] = 2;
                        Ship.field[posX - 1, posY - 1] = 2;
                        Ship.field[posX - 1, posY] = 2;
                        Ship.field[posX - 1, posY + 1] = 2;
                        Ship.field[ax - 1, ay + 1] = 2;
                        Ship.field[ax, ay + 1] = 2;
                        Ship.field[ax + 1, ay + 1] = 2;
                        Ship.field[ax + 1, ay] = 2;
                        Ship.field[posX + 1, posY] = 2;
                        Ship.field[posX + 1, posY - 1] = 2;
                        Ship.field[posX, posY] = 1;
                        Ship.field[ax, ay] = 1;
                        this.location = new string[] { (posX + "," + posY), (ax + "," + ay) };
                        return true;
                    }
                    else if (Ship.field[posX, posY - 1] != 2&&posY-2>=0)
                    {
                        int ax = posX;
                        int ay = posY - 1;
                        Ship.field[posX, posY - 1] = 2;
                        Ship.field[posX - 1, posY - 1] = 2;
                        Ship.field[posX - 1, posY] = 2;
                        Ship.field[posX - 1, posY + 1] = 2;
                        Ship.field[ax - 1, ay + 1] = 2;
                        Ship.field[ax, ay + 1] = 2;
                        Ship.field[ax + 1, ay + 1] = 2;
                        Ship.field[ax + 1, ay] = 2;
                        Ship.field[posX + 1, posY] = 2;
                        Ship.field[posX + 1, posY - 1] = 2;
                        Ship.field[posX, posY] = 1;
                        Ship.field[ax, ay] = 1;
                        this.location = new string[] { (posX + "," + posY), (ax + "," + ay) };
                        return true;
                    }
                }
                return false;
            }
            else return false;
        }

        public override string ToString()
        {
            return "Двопалубный корабль";
        }
    }
}
