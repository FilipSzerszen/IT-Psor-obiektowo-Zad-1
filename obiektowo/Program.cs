using System;

namespace obiektowo
{
    class Program
    {
        static void Main(string[] args)
        {
            int AdamWeight = GetIntFromConsole("Podaj wagę Adama: ");
            int AdamHeight = GetIntFromConsole("Podaj wzrost Adama: ");

            Human Adam = new Human(AdamHeight, AdamWeight);
            Human Anna = new Human(165, 50);

            SuperMan SuperMan = new SuperMan(125, 40);

            Homo.SetHomeothermic(false);

            Console.WriteLine("\n\r--Adam--");
            Adam.PrintState();
            Adam.PaintWall();

            Console.WriteLine("\n\r--Anna--");
            Anna.PrintState();
            Anna.PaintWall();

            Console.WriteLine("\n\r--Homo Erectus--");
            var HomoErectus = new HomoErectus(150, 50);
            HomoErectus.PrintState();
            HomoErectus.PaintWall();

            Console.WriteLine("\n\r--Superman--");
            SuperMan.PrintState();
            SuperMan.LaserEye();
            SuperMan.FlyHigh();

        }

        static int GetIntFromConsole(String Message)
        {
            bool isParsed = false;
            int result=0;
            while (!isParsed)
            {
                try
                {
                    Console.WriteLine(Message);
                    result = int.Parse(Console.ReadLine());
                    isParsed = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Podaj liczbe!");
                }
            }
            return result;
        }


    }
}
