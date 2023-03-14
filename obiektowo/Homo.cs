using System;
using System.Collections.Generic;
using System.Text;

namespace obiektowo
{
    abstract class Homo
    {
        static bool Homeothermic = true;

        private int Height;
        private int Weight;

        public Homo(int newheight, int newweight)
        {
            Height = newheight;
            Weight = newweight;

        }
        abstract public void PaintWall();
        public void PrintState()
        {
            Console.WriteLine("Waga: " + Weight);
            Console.WriteLine("Wzrost: " + Height);
            Console.WriteLine("Stałocieplność: " + Homeothermic);
        }

        public static bool IsHomeothermic()
        {
            return Homeothermic;
        }

        public static void SetHomeothermic(bool NewHomeothermic)
        {
            Homeothermic = NewHomeothermic;
        }
        public int GetWeight()
        {
            return Weight;
        }
        public int GetHeightInCm()
        {
            return Height;
        }
        public int GetHeightInCal()
        {
            return (int)(Height/2.54);
        }

        public void SetWeight(int NewWeight)
        {
            Weight = NewWeight;
        }
        public void SetHeight(int NewHeight)
        {
            Height = NewHeight;
        }

    }
}
