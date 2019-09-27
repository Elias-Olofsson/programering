using System;

namespace metod_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double radie = 2.4;
            Console.WriteLine(Omkrets(radie));
            Console.WriteLine(Area(radie));
        }

        static double Omkrets(double radie)
        {
            double omkrets = radie * 2 * Math.PI;
            return omkrets;
        }

        static double Area(double radie)
        {
            double area = radie * radie * Math.PI;
            return area;
        }
    }
}
