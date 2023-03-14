using System;
using System.Collections.Generic;
using System.Text;

namespace obiektowo
{
    class Human : Homo
    {

        public Human(int newheight, int newweight) : base(newheight, newweight)
        {
        }
        public override void PaintWall()
        {
            Console.WriteLine("Maluję ściany");
        }
        public void WriteALetter()
        {
            Console.WriteLine("Piszę list");
        }

    }
}
