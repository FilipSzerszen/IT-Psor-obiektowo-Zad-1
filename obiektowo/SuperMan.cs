using System;
using System.Collections.Generic;
using System.Text;

namespace obiektowo
{
    class SuperMan:Human
    {

        public SuperMan(int newheight, int newweight) : base(newheight,  newweight)
        {
            this.SetHeight(newheight);
            this.SetWeight(newweight);

        }

        public void LaserEye()
        {
            Console.WriteLine("Używam laserowych oczu!");
        }
        public void FlyHigh()
        {
            Console.WriteLine("Latam wysoko!");
        }

        public override void PaintWall()
        {
            Console.WriteLine("Ściana maluje się sama jak supperman spojrzy na farbę");
        }
    }
}
