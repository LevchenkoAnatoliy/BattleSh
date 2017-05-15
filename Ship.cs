using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.IO;

namespace BattleShip
{
    abstract class Ship : IDisposable
    {
        public Ship()
        {
            FileStream file = new FileStream("LogFile.txt", FileMode.Append);
            StreamWriter writer = new StreamWriter(file);
            writer.WriteLine("Создан объект " + this.GetType().Name);
            writer.Close();
            file.Close();
        }
        public static int[,] field = new int[10, 10];
        protected int hp = 0;
        protected string[] location;
        public abstract bool SetLocation(string location);
        public int Hp
        {
            get { return hp; }
            protected set { hp = value; }
        }
        public bool Hit(string position)
        {
            if (location.Contains(position))
            {
                for (int i = 0; i < location.Length; i++)
                {
                    if (location[i] == position)
                    {
                        location[i] = "-1";
                    }
                }
                return true;
            }
            else return false;           
        }

        void Kill(ClassicSeaBattle collection)
        {
            collection.DeleteShip(this);
            this.Dispose();
        }

        public bool Injury(ClassicSeaBattle collection)
        {
            hp--;
            if (hp == 0) { Kill(collection); return true; }
            return false;
        }

        public override string ToString()
        {
            return "Абстрактный класс для всех кораблей!";
        }

        public void Dispose()
        {
            FileStream file = new FileStream("LogFile.txt", FileMode.Append);
            StreamWriter writer = new StreamWriter(file);
            writer.WriteLine("Уничтожен объект " + this.GetType().Name);
            writer.Close();
            file.Close();
        }
    }
}
