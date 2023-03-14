using System;
using System.Collections.Generic;
using System.Text;

namespace obiektowo
{
    class HomoErectus : Homo
    {
        public HomoErectus(int newheight, int newweight) : base( newheight,  newweight)
        {
        }
        public override void PaintWall()
        {
            Console.WriteLine("Maluję po ścianach");
        }

    }
}
